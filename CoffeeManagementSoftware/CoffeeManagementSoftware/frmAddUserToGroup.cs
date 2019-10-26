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
    public partial class frmAddUserToGroup : DevExpress.XtraEditors.XtraForm
    {

        public frmAddUserToGroup()
        {
            InitializeComponent();
        }

        private void accountBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accountBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_Grand1);

        }

        private void frmAddUserToGroup_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_Grand1.user_group_userDK' table. You can move, or remove it, as needed.
            this.user_group_userDKTableAdapter.Fill(this.dS_Grand1.user_group_userDK);
            // TODO: This line of code loads data into the 'dS_Grand1.user_group_user' table. You can move, or remove it, as needed.
            this.user_group_userTableAdapter.Fill(this.dS_Grand1.user_group_user);
            // TODO: This line of code loads data into the 'dS_Grand1.group_user' table. You can move, or remove it, as needed.
            this.group_userTableAdapter.Fill(this.dS_Grand1.group_user);
            // TODO: This line of code loads data into the 'dS_Grand1.account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.dS_Grand1.account);

        }
        public void LoadUserGroup()
        {
            try
            {
                this.user_group_userDKTableAdapter.Fill(this.dS_Grand1.user_group_userDK, Int32.Parse(group_userComboBox.SelectedValue.ToString()));
            }
            catch(Exception)
            {
                return;
            }
        }

        private void group_userComboBox_SelectedValueChanged_1(object sender, EventArgs e)
        {
            LoadUserGroup();
        }
        private void btn_AddGrant_Click(object sender, EventArgs e)
        {
            try {
                int? tmp = this.user_group_userTableAdapter.Insert(Int32.Parse(accountDataGridView.CurrentRow.Cells[0].Value.ToString()), Int32.Parse(group_userComboBox.SelectedValue.ToString()), 1);
                if(tmp == 1)
                {
                    XtraMessageBox.Show("Thêm người dùng vào nhóm thành công!");
                    LoadUserGroup();
                }
            }
            catch
            {
                XtraMessageBox.Show("Thêm người dùng vào nhóm thất bại!!");
            }
        }

        private void btn_DeleteGrant_Click(object sender, EventArgs e)
        {
            try {
                int? tmp = this.user_group_userTableAdapter.Delete(Int32.Parse(user_group_userDKDataGridView.CurrentRow.Cells[1].Value.ToString()), Int32.Parse(user_group_userDKDataGridView.CurrentRow.Cells[0].Value.ToString()), int.Parse(user_group_userDKDataGridView.CurrentRow.Cells[2].Value.ToString()));
                if (tmp == 1)
                {
                    XtraMessageBox.Show("Xóa người dùng vào nhóm thành công!");
                    LoadUserGroup();
                }
            }
            catch
            {
                XtraMessageBox.Show("Xóa người dùng vào nhóm thất bại!!");
            }
            
        }

    }
}