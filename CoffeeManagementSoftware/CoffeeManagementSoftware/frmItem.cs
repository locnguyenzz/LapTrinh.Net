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
    public partial class frmItem : DevExpress.XtraEditors.XtraForm
    {
        Item_CL dll = new Item_CL();
        TypeItem_CL dti = new TypeItem_CL();
        Price_CL dp = new Price_CL();
        public frmItem()
        {
            InitializeComponent();
        }

        public void LoadItem()
        {

            cbo_NameType.DataSource = dti.LoadTypeItem();
            cbo_NameType.ValueMember = "ID";
            cbo_NameType.DisplayMember = "NAME_TYPE";
        }
        public void LoadPrice()
        {

            cbo_Price.DataSource = dp.LoadPrice();
            cbo_Price.ValueMember = "ID";
            cbo_Price.DisplayMember = "PRICE";
        }

        public void LoadData()
        {

            dgv_Item.DataSource = dll.LoadItem();
        }

        
        private void tSBThemmoi_Click(object sender, EventArgs e)
        {
            int _price = Int32.Parse(cbo_Price.SelectedValue.ToString());
            int _type = Int32.Parse(cbo_NameType.SelectedValue.ToString());
            if (dll.AddNewItem(txt_Name.Text,txt_Unit.Text,_price,_type))
            {
                XtraMessageBox.Show("Them thanh cong!", "Thong Bao");
                LoadData();
            }
            else
            {
                XtraMessageBox.Show("Them tThat bai!", "Thong Bao");
            }

        }

        private void frmItem_Load(object sender, EventArgs e)
        {
            LoadItem();
            LoadPrice();
            LoadData();
            txt_ID.Text = dgv_Item.CurrentRow.Cells[0].Value.ToString();
            txt_Name.Text = dgv_Item.CurrentRow.Cells["NAME_ITEM"].Value.ToString();
            txt_Unit.Text = dgv_Item.CurrentRow.Cells["UNIT"].Value.ToString();
            //cbo_Price.Text = dgv_Item.CurrentRow.Cells["BUY"].Value.ToString();
            cbo_NameType.Text = dgv_Item.CurrentRow.Cells["NAME_TYPE"].Value.ToString();
            if (dgv_Item.CurrentRow.Cells["STATUS"].Value.Equals(1))
            {
                chk_Status.Checked = true;
            }
            else
            {
                chk_Status.Checked = false;
            }
        }

        private void tSBChinhsua_Click(object sender, EventArgs e)
        {
            int _price = Int32.Parse(cbo_Price.SelectedValue.ToString());
            int _type = Int32.Parse(cbo_NameType.SelectedValue.ToString());
            int check = 1;
            if (chk_Status.Checked == true)
            {
                check = 1;
            }
            else
            {
                check = 0;
            }
            if (dll.EditItem(Int32.Parse(txt_ID.Text), txt_Name.Text, txt_Unit.Text, _price, _type, check))
            {
                XtraMessageBox.Show("Sua thanh cong", "Thong Bao");

                LoadData();
            }
            else
            {
                XtraMessageBox.Show("Sua that bai!", "Thong Bao");
            }
        }

        private void tSBXoa_Click(object sender, EventArgs e)
        {
            if (dll.DeleteItem(Int32.Parse(txt_ID.Text)))
            {
                XtraMessageBox.Show("Xoa thanh cong", "Thong Bao");
                LoadData();
            }
            else
            {
                XtraMessageBox.Show("Xoa that bai", "Thong Bao");
            }
        }

        private void dgv_Item_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = dgv_Item.CurrentRow.Cells[0].Value.ToString();
            txt_Name.Text = dgv_Item.CurrentRow.Cells["NAME_ITEM"].Value.ToString();
            txt_Unit.Text = dgv_Item.CurrentRow.Cells["UNIT"].Value.ToString();
            //cbo_Price.Text = dgv_Item.CurrentRow.Cells["BUY"].Value.ToString();
            cbo_NameType.Text = dgv_Item.CurrentRow.Cells["NAME_TYPE"].Value.ToString();
            if (dgv_Item.CurrentRow.Cells["STATUS"].Value.Equals(1))
            {
                chk_Status.Checked = true;
            }
            else
            {
                chk_Status.Checked = false;
            }
        }



    }
}