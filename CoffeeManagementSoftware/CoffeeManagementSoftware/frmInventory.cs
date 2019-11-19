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
    public partial class frmInventory : DevExpress.XtraEditors.XtraForm
    {
        Inventory_CL dll = new Inventory_CL();
        Item_CL dli = new Item_CL();
        public frmInventory()
        {
            InitializeComponent();
        }
        public void LoadItem()
        {
            cbo_Item.DataSource = dli.LoadItem();
            cbo_Item.DisplayMember = "NAME_ITEM";
            cbo_Item.ValueMember = "ID";
        }
        public void LoadData()
        {
            dgv_Inventory.DataSource = dll.LoadInventory();
        }
        private void frmInventory_Load(object sender, EventArgs e)
        {
            txt_ID.Enabled = false;
            LoadItem();
            LoadData();
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            int _Item = Int32.Parse(cbo_Item.SelectedValue.ToString());
            if (dll.AddNewInventory(_Item))
            {
                XtraMessageBox.Show("Them thanh cong", "Thong Bao");
                LoadData();
            }
            else
            {
                XtraMessageBox.Show("Them that bai!", "Thong Bao");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _Item = Int32.Parse(txt_ID.Text);
            if (dll.DeleteInventory(_Item))
            {
                XtraMessageBox.Show("Xoa thanh cong", "Thong Bao");
                LoadData();
            }
            else
            {
                XtraMessageBox.Show("Xoa that bai!", "Thong Bao");
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int _Id = Int32.Parse(txt_ID.Text);
            int _Item = Int32.Parse(cbo_Item.SelectedValue.ToString());
            if (dll.EditInventory(_Id,_Item))
            {
                XtraMessageBox.Show("Sua thanh cong", "Thong Bao");
                LoadData();
            }
            else
            {
                XtraMessageBox.Show("Sua that bai!", "Thong Bao");
            }
        }

        private void dgv_Inventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = dgv_Inventory.CurrentRow.Cells["ID"].Value.ToString();
            cbo_Item.Text = dgv_Inventory.CurrentRow.Cells["NAME_ITEM"].Value.ToString();
        }


    }
}