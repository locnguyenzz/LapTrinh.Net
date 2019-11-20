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
        WareHousing_CL dll = new WareHousing_CL();
        Item_CL dli = new Item_CL();
        public frmWarehousing()
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
            dgv_Right.DataSource = dll.LoadsWare();
            dgv_Left.DataSource = dll.LoadsWare();
        }
        private void frmWarehousing_Load(object sender, EventArgs e)
        {
            txt_ID.Enabled = false;
            LoadItem();
            LoadData();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //double sum = Double.Parse(dgv_Right.CurrentRow.Cells["NUMBER"].Value.ToString()) * Double.Parse(dgv_Right.CurrentRow.Cells["PRICE_PURCHASE"].Value.ToString());
            int _id = Int32.Parse(cbo_Item.SelectedValue.ToString());
            int num = Int32.Parse(txt_Number.Text);
            if (dll.AddNewImport(_id, msk_Create.Text, num))
            {
                //dgv_Right.CurrentRow.Cells["MONEY"].Value = sum.ToString();
                //dgv_Left.CurrentRow.Cells["SUM_MONEY"].Value = sum.ToString();
                XtraMessageBox.Show("Them thanh cong!", "Thong bao");
                LoadData();
            }
            else
            {
                XtraMessageBox.Show("Them that bai!", "Thong Bao");
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (dll.DeleteImport(Int32.Parse(txt_ID.Text)))
            {
                XtraMessageBox.Show("Xoa thanh cong!", "Thong bao");
                LoadData();
            }
            else
            {
                XtraMessageBox.Show("Xoa that bai!", "Thong Bao");
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //double sum = Double.Parse(dgv_Right.CurrentRow.Cells["NUMBER"].Value.ToString()) * Double.Parse(dgv_Right.CurrentRow.Cells["PRICE_PURCHASE"].Value.ToString());
            int _id = Int32.Parse(cbo_Item.SelectedValue.ToString());
            int num = Int32.Parse(txt_Number.Text);
            if (dll.EditImport(Int32.Parse(txt_ID.Text), _id, msk_Create.Text, num))
            {
                //dgv_Right.CurrentRow.Cells["MONEY"].Value = sum.ToString();
                //dgv_Left.CurrentRow.Cells["SUM_MONEY"].Value = sum.ToString();
                XtraMessageBox.Show("Sua thanh cong!", "Thong bao");
                LoadData();
            }
            else
            {
                XtraMessageBox.Show("Sua that bai!", "Thong Bao");
            }
        }

        private void dgv_Right_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            double sum = Double.Parse(dgv_Right.CurrentRow.Cells["NUMBER"].Value.ToString()) * Double.Parse(dgv_Right.CurrentRow.Cells["PRICE_PURCHASE"].Value.ToString());
            txt_ID.Text = dgv_Left.CurrentRow.Cells["ID"].Value.ToString();
            cbo_Item.Text = dgv_Right.CurrentRow.Cells["NAME_ITEM"].Value.ToString();
            msk_Create.Text = dgv_Left.CurrentRow.Cells["CREATE_AT"].Value.ToString();
            txt_Number.Text = dgv_Right.CurrentRow.Cells["NUMBER"].Value.ToString();
            dgv_Right.CurrentRow.Cells["MONEY"].Value = sum.ToString();
        }

        private void dgv_Left_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            double sum = Double.Parse(dgv_Right.CurrentRow.Cells["NUMBER"].Value.ToString()) * Double.Parse(dgv_Right.CurrentRow.Cells["PRICE_PURCHASE"].Value.ToString());
            txt_ID.Text = dgv_Left.CurrentRow.Cells["ID"].Value.ToString();
            cbo_Item.Text = dgv_Right.CurrentRow.Cells["NAME_ITEM"].Value.ToString();
            msk_Create.Text = dgv_Left.CurrentRow.Cells["CREATE_AT"].Value.ToString();
            txt_Number.Text = dgv_Right.CurrentRow.Cells["NUMBER"].Value.ToString();
            dgv_Left.CurrentRow.Cells["SUM_MONEY"].Value = sum.ToString();
        }

    }
}