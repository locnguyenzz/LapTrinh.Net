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

    public partial class frmSell : DevExpress.XtraEditors.XtraForm
    {
        Item_CL _sp = new Item_CL();
        Table_CL _table = new Table_CL();
        Receipt_CL _px = new Receipt_CL();
        Detai_Receipt_CL _ctpx = new Detai_Receipt_CL();

        public frmSell()
        {
            InitializeComponent();
        }
        public void LoadTable()
        {
            cbo_Ban.DataSource = _table.LoadTable();
            cbo_Ban.DisplayMember = "NAME_TABLE";
            cbo_Ban.ValueMember = "ID";
        }
        public void LoadSP()
        {
            cbbMaSanPham.DataSource = _sp.GetData();
            cbbMaSanPham.DisplayMember = "NAME_ITEM";
            cbbMaSanPham.ValueMember = "ID";
        }

        public void LoadPX()
        {
            cbo_MaPhieuBan.DataSource = _px.LoadReceipt();
            cbo_MaPhieuBan.DisplayMember = "ID";
            cbo_MaPhieuBan.ValueMember = "ID";
        }

        public void LoadCTPX(int pID)
        {
            dgvCTPN.DataSource = _ctpx.LoadDetail(pID);
        }

        public void LoadData()
        {
            LoadTable();
            LoadPX();
            LoadSP();
            txtMaPhieuBan.Focus();
            
        }
        private void frmSell_Load(object sender, EventArgs e)
        {
            LoadData();
            
            txtThanhTien.Enabled = false;
        }

        private void btnTaoPN_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaPhieuBan.Text))
            {
                MessageBox.Show("Ma phieu nhap khong duoc de trong!");
                txtMaPhieuBan.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtNgayBan.Text))
            {
                MessageBox.Show("Ngay nhap khong duoc de trong!");
                txtNgayBan.Focus();
                return;
            }
            bool flag = _px.TaoPhieuXuat(Int32.Parse(txtMaPhieuBan.Text),  txtNgayBan.Text);
            if (flag)
            {
                MessageBox.Show("Tao phieu nhap thanh cong !");
                LoadPX();
                return;
            }
            else
            {
                MessageBox.Show("Tao phieu nhap that bai !");
            }
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
        private void btnThemSP_Click(object sender, EventArgs e)
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
                            bool capnhatsoluong = _ctpx.CapNhatCTPX(Int32.Parse(cbo_MaPhieuBan.SelectedValue.ToString()),int.Parse(cbbMaSanPham.SelectedValue.ToString()), Int32.Parse(dgvCTPN.Rows[i].Cells["SoLuong"].Value.ToString()));
                            //Ở đây cần tạo thêm hàm cập nhật số lượng trong kho(table: SanPham)
                            _sp.DeleteNumber(int.Parse(cbbMaSanPham.SelectedValue.ToString()), int.Parse(txtSoLuong.Text));
                        }
                    }
                    txtThanhTien.Text = TinhThanhTien().ToString();
                    //Goi ham cap nhat thanh tien
                    bool capnhatthanhtien = _px.CapNhatThanhTien(int.Parse(cbo_MaPhieuBan.Text), double.Parse(txtThanhTien.Text));
                    if (capnhatthanhtien)
                    {
                        MessageBox.Show("Cap nhat thanh cong !");
                        dgvCTPN.CurrentRow.Cells["DonGia"].Value = double.Parse(txtDonGia.Text);
                        LoadData();
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
                    bool themmoi = _ctpx.ThemMoiCTPX(Int32.Parse(cbo_MaPhieuBan.SelectedValue.ToString()),int.Parse(cbo_Ban.SelectedValue.ToString()), Int32.Parse(cbbMaSanPham.SelectedValue.ToString()), Double.Parse(txtDonGia.Text), Int32.Parse(txtSoLuong.Text));
                    //goi ham them moi , sau do load lai dgvCTPN
                    if (themmoi)
                    {
                        LoadData();
                        txtThanhTien.Text = TinhThanhTien().ToString();
                        bool capnhatthanhtien = _px.CapNhatThanhTien(Int32.Parse(cbo_MaPhieuBan.SelectedValue.ToString()), Double.Parse(txtThanhTien.Text));
                        MessageBox.Show("Them CTPX thanh cong");
                        dgvCTPN.CurrentRow.Cells["DonGia"].Value = double.Parse(txtDonGia.Text);
                        _sp.DeleteNumber(int.Parse(cbbMaSanPham.SelectedValue.ToString()), int.Parse(txtSoLuong.Text));                        
                        LoadCTPX(Int32.Parse(cbo_MaPhieuBan.SelectedValue.ToString()));
                        LoadData();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Them CTPX that bai");
                        return;
                    }
                }
            }
        }

        private void dgvCTPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCTPN.CurrentRow != null)
            {
                cbo_MaPhieuBan.Text = dgvCTPN.CurrentRow.Cells["MaPhieuBan"].Value.ToString();
                cbbMaSanPham.Text = dgvCTPN.CurrentRow.Cells["MaSanPham"].Value.ToString();
                //txtDonGia.Text = dgvCTPN.CurrentRow.Cells["DonGia"].Value.ToString();
                txtSoLuong.Text = dgvCTPN.CurrentRow.Cells["SoLuong"].Value.ToString();
            }
        }

        private void cbo_MaPhieuBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                receipt pn = _px.LoadTTPX(Int32.Parse(cbo_MaPhieuBan.SelectedValue.ToString()));

                if (pn != null)
                {
                    txtMaPhieuBan.Text = pn.ID.ToString();
                    
                    txtNgayBan.Text = Convert.ToDateTime(pn.CREATE_AT).ToString("dd/MM/yyyy");
                    txtThanhTien.Text = pn.SUM_MONEY.ToString();
                    //Load them thong tin chi tiet phieu nhap o day
                    LoadCTPX(pn.ID);
                    txtThanhTien.Text = TinhThanhTien().ToString();
                }
            }
            catch
            {
                return;
            }
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvCTPN.CurrentRow != null)
            {
                //MessageBox.Show("Bạn đang sửa sản phẩm có Mã: "+dgvCTPN.CurrentRow.Cells["MaSanPham"].Value.ToString()+" bạn có thể sửa trực tiếp tại lưới danh sách hoặc trong các ô đơn giá, số lượng phía trên !");
                bool sua = _ctpx.SuaCTNP(int.Parse(cbo_MaPhieuBan.Text), int.Parse(cbbMaSanPham.Text), double.Parse(txtDonGia.Text), int.Parse(txtSoLuong.Text));
                if (sua)
                {

                    txtThanhTien.Text = TinhThanhTien().ToString();
                    bool capnhat = _px.CapNhatThanhTien(int.Parse(cbo_MaPhieuBan.Text), double.Parse(txtThanhTien.Text));
                    MessageBox.Show("Sửa thành công sản phẩm Mã: " + dgvCTPN.CurrentRow.Cells["MaSanPham"].Value.ToString());
                    LoadCTPX(int.Parse(cbo_MaPhieuBan.Text));
                }
            }
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvCTPN.CurrentRow != null)
            {
                DialogResult r;
                r = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm có Mã: " + dgvCTPN.CurrentRow.Cells["MaSanPham"].Value.ToString(), "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (r == DialogResult.Yes)
                {
                    bool xoa = _ctpx.XoaCTNP(int.Parse(cbo_MaPhieuBan.Text),int.Parse(cbbMaSanPham.Text));
                    if (xoa)
                    {

                        txtThanhTien.Text = TinhThanhTien().ToString();
                        bool capnhat = _px.CapNhatThanhTien(int.Parse(cbo_MaPhieuBan.Text), double.Parse(txtThanhTien.Text));
                        MessageBox.Show("Xoa CTPN thanh cong !");
                        LoadCTPX(int.Parse(cbo_MaPhieuBan.Text));
                    }
                    else
                    {
                        MessageBox.Show("Xoa CTPN that bai !");
                    }
                }
            }
        }
    }
}