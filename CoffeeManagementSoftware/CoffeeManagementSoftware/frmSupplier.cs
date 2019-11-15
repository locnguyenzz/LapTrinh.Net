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
    public partial class frmSupplier : DevExpress.XtraEditors.XtraForm
    {
        Supplier_CL dll = new Supplier_CL();
        public frmSupplier()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            dgv_Supplier.DataSource = dll.LoadSupplier();
        }
        private void frmSupplier_Load(object sender, EventArgs e)
        {
            LoadData();
            chk_Status.Enabled = true;
        }

        private void tsb_Add_Click(object sender, EventArgs e)
        {
            if(dll.AddNewSupp(txt_Name.Text,mtx_Phone.Text,txt_Address.Text,txt_Email.Text))
            {
                XtraMessageBox.Show("Them thanh cong", "Thong Bao");
                LoadData();
            }
            else
            {
                XtraMessageBox.Show("Them that bai!", "Thong Bao");
            }
        }

        private void dgv_Supplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = dgv_Supplier.CurrentRow.Cells[0].Value.ToString();
            txt_Name.Text = dgv_Supplier.CurrentRow.Cells[1].Value.ToString();
            txt_Address.Text = dgv_Supplier.CurrentRow.Cells[2].Value.ToString();
            mtx_Phone.Text = dgv_Supplier.CurrentRow.Cells[3].Value.ToString();
            txt_Email.Text = dgv_Supplier.CurrentRow.Cells[4].Value.ToString();
            if(dgv_Supplier.CurrentRow.Cells[5].Value.Equals(1))
            {
                chk_Status.Checked = true;
            }
            else
            {
                chk_Status.Checked = false;
            }
        }

        private void tsb_Delete_Click(object sender, EventArgs e)
        {
            if (dll.DeleteSupp(Int32.Parse(txt_ID.Text)))
            {
                XtraMessageBox.Show("Xoa thanh cong", "Thong Bao");
                LoadData();
            }
            else
            {
                XtraMessageBox.Show("Xoa that bai", "Thong Bao");
            }
        }

        private void tsb_Edit_Click(object sender, EventArgs e)
        {
            
            int check = 1;
            if(chk_Status.Checked == true)
            {
                check = 1;
            }
            else
            {
                check = 0;
            }
            if(dll.EditSupp(Int32.Parse(txt_ID.Text),txt_Name.Text,mtx_Phone.Text,txt_Address.Text,txt_Email.Text,check))
            {
                XtraMessageBox.Show("Sua thanh cong", "Thong Bao");
                
                LoadData();
            }
            else
            {
                XtraMessageBox.Show("Sua that bai!", "Thong Bao");
            }

        }

        private void tsb_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}