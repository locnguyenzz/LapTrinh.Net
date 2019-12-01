using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CoffeeLibrary;
namespace CoffeeManagementSoftware
{
    public partial class frmWarehousing : DevExpress.XtraEditors.XtraForm
    {

        WareHousing_CL _pn = new WareHousing_CL();
        Supplier_CL _ncc = new Supplier_CL();
        Item_CL _sp = new Item_CL();
        Detail_Receip_Import_CL _ctpn = new Detail_Receip_Import_CL();
        public frmWarehousing()
        {
            InitializeComponent();
        }
        //Load cbbNhaCC
        //Load cbbMaPnn
        //Load cbbMasp
        public void LoadMaPN()
        {
            cbbMaPhieuNhap.DataSource = _pn.GetData();
            cbbMaPhieuNhap.DisplayMember = "ID";
            cbbMaPhieuNhap.ValueMember = "ID";
        }
        public void LoadNCC()
        {
            cbbNhaCC.DataSource = _ncc.LoadSupplier();//_ncc.GetData();
            cbbNhaCC.DisplayMember = "NAME";
            cbbNhaCC.ValueMember = "ID";
        }

        public void LoadSP()
        {
            cbbMaSanPham.DataSource = _sp.GetData();
            cbbMaSanPham.DisplayMember = "NAME_ITEM";
            cbbMaSanPham.ValueMember = "ID";
        }
        public void LoadData()
        {
            LoadMaPN();
            LoadNCC();
            LoadSP();
            txtMaPhieuNhap.Focus();

        }



        public void LoadCTPN(int pMaPn)
        {
            dgvCTPN.DataSource = _ctpn.LoadPN_MaPN(pMaPn);
        }


        public double TinhThanhTien()
        {
            double sum = 0;
            if (dgvCTPN.RowCount > 0)
            {
                for (int i = 0; i < dgvCTPN.Rows.Count; i++)
                {
                    int sl = Int32.Parse(dgvCTPN.Rows[i].Cells["SoLuong"].Value.ToString());
                    double dg = Double.Parse(txtDonGia.Text); //float.Parse(dgvCTPN.Rows[i].Cells["DonGia"].Value.ToString());
                    sum += (sl * dg);
                }
            }
            return sum;
        }


        public bool KiemTraSP_CTPN(string pMaSP)
        {
            for (int i = 0; i < dgvCTPN.Rows.Count; i++)
            {
                if (dgvCTPN.Rows[i].Cells["MaSanPham"].Value.ToString().Equals(pMaSP))
                {
                    return true;//Ton tai rai
                }
            }
            return false;
        }


        private void cbbMaSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (cbbMaSanPham.Text != null)
            //    {
            //        //SanPham load = _sp.KiemSP(cbbMaSanPham.Text);
            //        txtSoLuong.Text = load.SoLuong.ToString();
            //        txtDonGia.Text = load.DonGia.ToString();
            //    }
            //}
            //catch
            //{
            //    return;
            //}
        }

        private void btnTaoPN_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaPhieuNhap.Text))
            {
                MessageBox.Show("Ma phieu nhap khong duoc de trong!");
                txtMaPhieuNhap.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtNgayNhap.Text))
            {
                MessageBox.Show("Ngay nhap khong duoc de trong!");
                txtMaPhieuNhap.Focus();
                return;
            }
            bool flag = _pn.TaoPhieuNhap(Int32.Parse(txtMaPhieuNhap.Text), Int32.Parse(cbbNhaCC.SelectedValue.ToString()), txtNgayNhap.Text);
            if (flag)
            {
                MessageBox.Show("Tao phieu nhap thanh cong !");
                LoadMaPN();
                return;
            }
            else
            {
                MessageBox.Show("Tao phieu nhap that bai !");
            }
        }

        private void frmWarehousing_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvCTPN_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCTPN.CurrentRow != null)
            {
                cbbMaPhieuNhap.Text = dgvCTPN.CurrentRow.Cells["MaPhieuNhap"].Value.ToString();
                cbbMaSanPham.Text = dgvCTPN.CurrentRow.Cells["MaSanPham"].Value.ToString();
                //txtDonGia.Text = dgvCTPN.CurrentRow.Cells["DonGia"].Value.ToString();
                txtSoLuong.Text = dgvCTPN.CurrentRow.Cells["SoLuong"].Value.ToString();
            }
        }

        private void cbbMaPhieuNhap_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                receipt_import pn = _pn.LoadTTPN(Int32.Parse(cbbMaPhieuNhap.SelectedValue.ToString()));

                if (pn != null)
                {
                    txtMaPhieuNhap.Text = pn.ID.ToString();
                    cbbNhaCC.Text = pn.ID_SUPPLIER.ToString();
                    txtNgayNhap.Text = Convert.ToDateTime(pn.CREATE_AT).ToString("dd/MM/yyyy");
                    txtThanhTien.Text = pn.SUM_MONEY.ToString();
                    //Load them thong tin chi tiet phieu nhap o day
                    LoadCTPN(pn.ID);
                    txtThanhTien.Text = TinhThanhTien().ToString();
                }
            }
            catch
            {
                return;
            }
        }

        private void cbbMaSanPham_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //item it = _sp.LoadItemOne(Int32.Parse(cbbMaSanPham.SelectedValue.ToString()));
            //if(it != null)
            //{
            //    txtDonGia.Text = it.PRICE_PURCHASE.ToString();
            //}
        }

        private void btnThemSP_Click_1(object sender, EventArgs e)
        {
            if (cbbMaSanPham.SelectedValue.ToString() != null)
            {
                string masp = cbbMaSanPham.SelectedValue.ToString();
                if (KiemTraSP_CTPN(masp))
                {
                    //Cap nhat so luong, thanh tien
                    for (int i = 0; i < dgvCTPN.Rows.Count; i++)
                    {
                        if (dgvCTPN.Rows[i].Cells["MaSanPham"].Value.ToString().Equals(masp))
                        {
                            dgvCTPN.Rows[i].Cells["SoLuong"].Value = (int.Parse(dgvCTPN.Rows[i].Cells["SoLuong"].Value.ToString()) + Int32.Parse(txtSoLuong.Text)).ToString();
                            //Goi ham cap nhat so luong ctpn
                            bool capnhatsoluong = _ctpn.CapNhatCTPN(Int32.Parse(cbbMaPhieuNhap.SelectedValue.ToString()),int.Parse(cbbMaSanPham.SelectedValue.ToString()), Int32.Parse(dgvCTPN.Rows[i].Cells["SoLuong"].Value.ToString()));
                            //Ở đây cần tạo thêm hàm cập nhật số lượng trong kho(table: SanPham)
                            _sp.UpdateNumber(int.Parse(cbbMaSanPham.SelectedValue.ToString()), int.Parse(txtSoLuong.Text));
                        }
                    }
                    txtThanhTien.Text = TinhThanhTien().ToString();
                    //Goi ham cap nhat thanh tien
                    bool capnhatthanhtien = _pn.CapNhatThanhTien(int.Parse(cbbMaPhieuNhap.Text), double.Parse(txtThanhTien.Text));
                    if (capnhatthanhtien)
                    {
                        MessageBox.Show("Cap nhat thanh cong !");
                        dgvCTPN.CurrentRow.Cells["DonGia"].Value = double.Parse(txtDonGia.Text);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Cap nhat that bai !");
                        return;
                    }
                }
                else
                {
                    //them moi ctpn, cap nhat thanh tien
                    if (String.IsNullOrEmpty(txtSoLuong.Text))
                    {
                        MessageBox.Show("So luong khong de trong!");
                        txtSoLuong.Focus();
                        return;
                    }
                    if (String.IsNullOrEmpty(txtDonGia.Text))
                    {
                        MessageBox.Show("Don gia khong de trong!");
                        txtDonGia.Focus();
                        return;
                    }
                    bool themmoi = _ctpn.ThemMoiCTPN(Int32.Parse(cbbMaPhieuNhap.SelectedValue.ToString()), Int32.Parse(cbbMaSanPham.SelectedValue.ToString()), Double.Parse(txtDonGia.Text), Int32.Parse(txtSoLuong.Text));
                    //goi ham them moi , sau do load lai dgvCTPN
                    if (themmoi)
                    {
                        LoadData();
                        txtThanhTien.Text = TinhThanhTien().ToString();
                        bool capnhatthanhtien = _pn.CapNhatThanhTien(Int32.Parse(cbbMaPhieuNhap.SelectedValue.ToString()), Double.Parse(txtThanhTien.Text));
                        MessageBox.Show("Them CTPN thanh cong");
                        dgvCTPN.CurrentRow.Cells["DonGia"].Value = double.Parse(txtDonGia.Text);
                        _sp.UpdateNumber(int.Parse(cbbMaSanPham.SelectedValue.ToString()), int.Parse(txtSoLuong.Text));
                        LoadCTPN(Int32.Parse(cbbMaPhieuNhap.SelectedValue.ToString()));
                        LoadData();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Them CTPN that bai");
                        return;
                    }
                }
            }
        }

        private void xóaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (dgvCTPN.CurrentRow != null)
            {
                DialogResult r;
                r = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm có Mã: " + dgvCTPN.CurrentRow.Cells["MaSanPham"].Value.ToString(), "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (r == DialogResult.Yes)
                {
                    bool xoa = _ctpn.XoaCTNP(int.Parse(cbbMaPhieuNhap.Text),int.Parse(cbbMaSanPham.Text));
                    if (xoa)
                    {

                        txtThanhTien.Text = TinhThanhTien().ToString();
                        bool capnhat = _pn.CapNhatThanhTien(int.Parse(cbbMaPhieuNhap.Text), double.Parse(txtThanhTien.Text));
                        MessageBox.Show("Xoa CTPN thanh cong !");
                        LoadCTPN(int.Parse(cbbMaPhieuNhap.Text));
                    }
                    else
                    {
                        MessageBox.Show("Xoa CTPN that bai !");
                    }
                }
            }
        }

        private void sửaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvCTPN.CurrentRow != null)
                {
                    //MessageBox.Show("Bạn đang sửa sản phẩm có Mã: "+dgvCTPN.CurrentRow.Cells["MaSanPham"].Value.ToString()+" bạn có thể sửa trực tiếp tại lưới danh sách hoặc trong các ô đơn giá, số lượng phía trên !");
                    bool sua = _ctpn.SuaCTNP(int.Parse(cbbMaPhieuNhap.Text), int.Parse(cbbMaSanPham.Text), double.Parse(txtDonGia.Text), int.Parse(txtSoLuong.Text));
                    if (sua)
                    {
                        txtThanhTien.Text = TinhThanhTien().ToString();
                        bool capnhat = _pn.CapNhatThanhTien(int.Parse(cbbMaPhieuNhap.Text), double.Parse(txtThanhTien.Text));
                        MessageBox.Show("Sửa thành công sản phẩm Mã: " + dgvCTPN.CurrentRow.Cells["MaSanPham"].Value.ToString());

                        LoadCTPN(int.Parse(cbbMaPhieuNhap.Text));
                    }
                }
            }
            catch
            {
                XtraMessageBox.Show("Co loi");
                return;
            }

        }

    }
}