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

namespace CoffeeManagementSoftware
{
    public partial class frmRole : DevExpress.XtraEditors.XtraForm
    {
        public frmRole()
        {
            InitializeComponent();
        }

        private void group_userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.group_userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_Grand);

        }

        private void frmRole_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_Grand.grant_right' table. You can move, or remove it, as needed.
            this.grant_rightTableAdapter.Fill(this.dS_Grand.grant_right);
            // TODO: This line of code loads data into the 'dS_Grand.group_user' table. You can move, or remove it, as needed.
            this.group_userTableAdapter.Fill(this.dS_Grand.group_user);

        }

      

        private void btn_SaveRole_Click(object sender, EventArgs e)
        {
            int _IdGroup = Int32.Parse(group_userDataGridView.CurrentRow.Cells[0].Value.ToString());
            try { 
                for(int i = 0 ; i < grant_rightDkDataGridView.Rows.Count ; i++)
                {
                    string tmp = grant_rightDkDataGridView.Rows[i].Cells[2].Value.ToString();// Lay ra gia tri quyen T/F
                    string _IdScreen = grant_rightDkDataGridView.Rows[i].Cells[0].Value.ToString();
                    if(tmp != string.Empty)
                    {
                        // Kiem tra TH quyen da duoc cap ma khong hien
                        if(this.grant_rightTableAdapter.F_IsGrantRightScalarQuery(_IdGroup,_IdScreen) > 0)
                        {//F_IsGrantRightScalarQuery : Dung de kiem tra xem quyen do co ton tai hay khong
                            if(this.grant_rightTableAdapter.F_GetRoleScalarQuery(_IdGroup,_IdScreen) !=  Boolean.Parse(tmp))
                            {//F_GetRoleScalarQuery: Kiem tra quyen do la T/F , Trong CSDL la T thi cap lai quyen
                                this.grant_rightTableAdapter.Update(Boolean.Parse(tmp), _IdGroup, _IdScreen, this.grant_rightTableAdapter.F_GetRoleScalarQuery(_IdGroup, _IdScreen));
                                //Cap lai quyen
                            }
                        }
                        else
                        {
                            if(tmp.Equals("True"))
                            {
                                this.grant_rightTableAdapter.Insert(_IdGroup, _IdScreen, true); // Them quyen
                            }
                            else
                            {
                                this.grant_rightTableAdapter.Insert(_IdGroup, _IdScreen, false); // Xoa quyen
                            }
                        }
                    }
                }
                XtraMessageBox.Show("Lưu quyền thành công!");
            }
            catch
            {
                XtraMessageBox.Show("Lưu quyền thất bại!!");
            }
            
        }

        private void btn_ExitRole_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = XtraMessageBox.Show("Bạn có chắc muốn thoát !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (r == DialogResult.Yes)
                this.Close();
        }

        private void group_userDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try {
                int tmp = Int32.Parse(group_userDataGridView.CurrentRow.Cells[0].Value.ToString());
                this.grant_rightDKTableAdapter.Fill(this.dS_Grand.grant_rightDk, tmp);
            }
            catch
            {
                return;
            }
        }

    }
}