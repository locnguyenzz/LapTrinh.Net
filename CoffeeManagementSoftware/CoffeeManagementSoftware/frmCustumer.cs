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
    public partial class frmCustumer : DevExpress.XtraEditors.XtraForm
    {
        Custumer_CL dll = new Custumer_CL();
        TypeCus_CL dlt = new TypeCus_CL();
        public frmCustumer()
        {
            InitializeComponent();
        }

        public void LoadCus()
        {
            cbo_TypeCus.DataSource = dlt.LoadTypeCus();
            cbo_TypeCus.ValueMember = "ID";
            cbo_TypeCus.DisplayMember = "NAME_TYPE";
        }
        public void LoadData()
        {
            dGV_Customer.DataSource = dll.LoadCustumer();
        }

        private void tSB_Add_Click(object sender, EventArgs e)
        {
            if (dll.AddNewProfile(txt_LName.Text,txt_FName.Text,msk_Phone.Text,txt_Address.Text,txt_Email.Text,Int32.Parse(cbo_TypeCus.SelectedValue.ToString())))
            {
                XtraMessageBox.Show("Them thanh cong!", "Thong Bao");
                LoadData();
            }
            else
            {
                XtraMessageBox.Show("Them that bai!", "Thong Bao");
            }
        }

        private void tSP_Edit_Click(object sender, EventArgs e)
        {
            int check = 1;
            if (chk_Status.Checked == true)
            {
                check = 1;
            }
            else
            {
                check = 0;
            }
            if (dll.EditCus(Int32.Parse(txt_ID.Text), txt_LName.Text,txt_FName.Text, msk_Phone.Text, txt_Address.Text, txt_Email.Text,Int32.Parse(cbo_TypeCus.SelectedValue.ToString()), check))
            {
                XtraMessageBox.Show("Sua thanh cong", "Thong Bao");

                LoadData();
            }
            else
            {
                XtraMessageBox.Show("Sua that bai!", "Thong Bao");
            }
        }

        private void frmCustumer_Load(object sender, EventArgs e)
        {
            LoadCus();
            LoadData();
            txt_ID.Enabled = false;
            
            txt_ID.Text = dGV_Customer.CurrentRow.Cells[0].Value.ToString();
            txt_LName.Text = dGV_Customer.CurrentRow.Cells["LAST_NAME"].Value.ToString();
            txt_FName.Text = dGV_Customer.CurrentRow.Cells["FIRST_NAME"].Value.ToString();
            txt_Address.Text = dGV_Customer.CurrentRow.Cells["ADDRESS"].Value.ToString();
            msk_Phone.Text = dGV_Customer.CurrentRow.Cells["PHONE"].Value.ToString();
            txt_Email.Text = dGV_Customer.CurrentRow.Cells["Email"].Value.ToString();
            cbo_TypeCus.Text = dGV_Customer.CurrentRow.Cells["NAME_TYPE"].Value.ToString();
            if (dGV_Customer.CurrentRow.Cells["STATUS"].Value.Equals(1))
            {
                chk_Status.Checked = true;
            }
            else
            {
                chk_Status.Checked = false;
            }
        }

        private void tSB_Delete_Click(object sender, EventArgs e)
        {
            if (dll.DeleteCus(Int32.Parse(txt_ID.Text)))
            {
                XtraMessageBox.Show("Xoa thanh cong", "Thong Bao");
                LoadData();
            }
            else
            {
                XtraMessageBox.Show("Xoa that bai", "Thong Bao");
            }
        }

        private void dGV_Customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = dGV_Customer.CurrentRow.Cells[0].Value.ToString();
            txt_LName.Text = dGV_Customer.CurrentRow.Cells["LAST_NAME"].Value.ToString();
            txt_FName.Text = dGV_Customer.CurrentRow.Cells["FIRST_NAME"].Value.ToString();
            txt_Address.Text = dGV_Customer.CurrentRow.Cells["ADDRESS"].Value.ToString();
            msk_Phone.Text = dGV_Customer.CurrentRow.Cells["PHONE"].Value.ToString();
            txt_Email.Text = dGV_Customer.CurrentRow.Cells["Email"].Value.ToString();
            cbo_TypeCus.Text = dGV_Customer.CurrentRow.Cells["NAME_TYPE"].Value.ToString();
            if (dGV_Customer.CurrentRow.Cells["STATUS"].Value.Equals(1))
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