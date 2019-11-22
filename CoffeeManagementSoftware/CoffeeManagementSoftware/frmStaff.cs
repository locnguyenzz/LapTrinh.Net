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
   
    public partial class frmStaff : DevExpress.XtraEditors.XtraForm
    {
        Staff_CL dll = new Staff_CL();
        TimeKeeping_CL dt = new TimeKeeping_CL();
        public frmStaff()
        {
            InitializeComponent();
        }
        public void LoadStaff()
        {
            cbo_Staff.DataSource = dll.Getdata();
            cbo_Staff.DisplayMember = "NAME_STAFF";
            cbo_Staff.ValueMember = "NAME_STAFF";
        }
        public void LoadTime()
        {
            cbo_Time.DataSource = dt.LoadShift();
            cbo_Time.DisplayMember = "SHIFT";
            cbo_Time.ValueMember = "ID";
        }
        public void LoadData()
        {
            dgv_Staff.DataSource = dll.LoadStaff();
        }
        private void frmStaff_Load(object sender, EventArgs e)
        {
            LoadStaff();
            LoadTime();
            LoadData();
            txt_ID.Text = dgv_Staff.CurrentRow.Cells["ID"].Value.ToString();
            cbo_Time.Text = dgv_Staff.CurrentRow.Cells["SHIFT"].Value.ToString();
            cbo_Staff.Text = dgv_Staff.CurrentRow.Cells["NAME_STAFF"].Value.ToString();
            if (dgv_Staff.CurrentRow.Cells["STATUS"].Value.Equals(1))
            {
                chk_Status.Checked = true;
            }
            else
            {
                chk_Status.Checked = false;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if(dll.AddNewStaff(cbo_Staff.SelectedValue.ToString(),Int32.Parse(cbo_Time.SelectedValue.ToString())))
            {
                XtraMessageBox.Show("Them thanh cong", "Thong Bao");
                LoadData();
            }
            else
            {
                XtraMessageBox.Show("Them that bai!", "Thong bao");
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (dll.DeleteStaff(Int32.Parse(txt_ID.Text)))
            {
                XtraMessageBox.Show("Xoa thanh cong", "Thong Bao");
                LoadData();
            }
            else
            {
                XtraMessageBox.Show("Xoa that bai!", "Thong bao");
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            int chk = 0;
            if(chk_Status.Checked)
            {
                chk = 1;
            }
            else
            {
                chk = 0;
            }
            if (dll.EditStaff(Int32.Parse(txt_ID.Text),cbo_Staff.SelectedValue.ToString(), cbo_Time.SelectedValue.ToString(),chk))
            {
                XtraMessageBox.Show("Sua thanh cong", "Thong Bao");
                LoadData();
            }
            else
            {
                XtraMessageBox.Show("Sua that bai!", "Thong bao");
            }
        }

        private void dgv_Staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = dgv_Staff.CurrentRow.Cells["ID"].Value.ToString();
            cbo_Time.Text = dgv_Staff.CurrentRow.Cells["SHIFT"].Value.ToString();
            cbo_Staff.Text = dgv_Staff.CurrentRow.Cells["NAME_STAFF"].Value.ToString();
            if(dgv_Staff.CurrentRow.Cells["STATUS"].Value.Equals(1))
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