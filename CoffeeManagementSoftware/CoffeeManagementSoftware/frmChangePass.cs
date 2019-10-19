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
    public partial class frmChangePass : DevExpress.XtraEditors.XtraForm
    {
        C_Account acc = new C_Account();
        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public frmChangePass()
        {
            InitializeComponent();
        }
        
        private void btn_Argee_Click(object sender, EventArgs e)
        {
            if (txt_PassOld.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("Chưa nhập mật khẩu cũ !");
                txt_PassOld.Focus();
                return;
            }
            if (txt_PassNew.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("Chưa nhập mật khẩu mới !");
                txt_PassNew.Focus();
                return;
            }
            if (txt_ConfirmPassNew.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("Chưa xác nhận mật khẩu !");
                txt_ConfirmPassNew.Focus();
                return;
            }
            if (string.Equals(txt_PassNew.Text,txt_ConfirmPassNew.Text))
            {
                //Thực hiện cho cập nhật mật khẩu
                if (acc.ChangePass(this.UserName, txt_PassNew.Text, txt_PassOld.Text))
                {
                    XtraMessageBox.Show("Đổi mật khẩu thành công !");
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("Không thành công");
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}