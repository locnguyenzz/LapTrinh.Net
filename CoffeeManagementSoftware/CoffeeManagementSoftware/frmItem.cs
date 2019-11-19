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

        public void LoadData()
        {

            dgv_Item.DataSource = dll.LoadItem();
        }

        
        private void tSBThemmoi_Click(object sender, EventArgs e)
        {
            
            double _priceSell = Double.Parse(txt_PriceSell.Text);
            double _pricePur = Double.Parse(txt_Purchase.Text);
            int _type = Int32.Parse(cbo_NameType.SelectedValue.ToString());
            if (dll.AddNewItem(txt_Name.Text, txt_Unit.Text, _priceSell, _pricePur, _type))
            {
                XtraMessageBox.Show("Them thanh cong!", "Thong Bao");
                LoadData();
            }
            else
            {
                XtraMessageBox.Show("Them that bai!", "Thong Bao");
            }

        }

        private void frmItem_Load(object sender, EventArgs e)
        {
            LoadItem();
            LoadData();
            txt_ID.Enabled = false;
            dataGridView1.DataSource = dll.LoadItem();
            txt_ID.Text = dgv_Item.CurrentRow.Cells["ID"].Value.ToString();
            txt_Name.Text = dgv_Item.CurrentRow.Cells["NAME_ITEM"].Value.ToString();
            txt_Unit.Text = dgv_Item.CurrentRow.Cells["UNIT"].Value.ToString();
            txt_PriceSell.Text = dgv_Item.CurrentRow.Cells["PRICE_SELL"].Value.ToString();
            txt_Purchase.Text = dgv_Item.CurrentRow.Cells["PRICE_PURCHASE"].Value.ToString();
            cbo_NameType.Text = dgv_Item.CurrentRow.Cells["NAME_TYPE"].Value.ToString();   
        }

        private void tSBChinhsua_Click(object sender, EventArgs e)
        {
            int _type = Int32.Parse(cbo_NameType.SelectedValue.ToString());
            int check = Int32.Parse(dgv_Item.CurrentRow.Cells["STATUS"].Value.ToString());
            double _priceSell = Double.Parse(txt_PriceSell.Text);
            double _pricePur = Double.Parse(txt_Purchase.Text);
            if (check == 1)
            {
                check = 1;
            }
            else
            {
                check = 0;
            }
            if (dll.EditItem(Int32.Parse(txt_ID.Text), txt_Name.Text, txt_Unit.Text,_priceSell,_pricePur, _type, check))
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
            txt_ID.Text = dgv_Item.CurrentRow.Cells["ID"].Value.ToString();
            txt_Name.Text = dgv_Item.CurrentRow.Cells["NAME_ITEM"].Value.ToString();
            txt_Unit.Text = dgv_Item.CurrentRow.Cells["UNIT"].Value.ToString();
            txt_PriceSell.Text = dgv_Item.CurrentRow.Cells["PRICE_SELL"].Value.ToString();
            txt_Purchase.Text = dgv_Item.CurrentRow.Cells["PRICE_PURCHASE"].Value.ToString();
            cbo_NameType.Text = dgv_Item.CurrentRow.Cells["NAME_TYPE"].Value.ToString();          
        }
    }
}