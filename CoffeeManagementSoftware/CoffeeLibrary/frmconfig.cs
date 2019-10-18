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

namespace CoffeeLibrary
{
    public partial class frmconfig : DevExpress.XtraEditors.XtraForm
    {
        UserManager Config = new UserManager();
        public frmconfig()
        {
            InitializeComponent();
        }

        private void cbo_ServerName_DragDrop(object sender, DragEventArgs e)
        {
            DataTable dt = Config.GetServerName();
            cbo_Database.Items.Clear();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                foreach (System.Data.DataColumn col in dt.Columns)
                {
                    cbo_ServerName.Items.Add(row[col]);
                }
            }
        }

        private bool CheckedBeforSearchNameDB()
        {
            if (cbo_ServerName.Text == string.Empty)
            {
                XtraMessageBox.Show("Server Name chưa được chọn hoặc nhập", "Thông Báo");
                return false;
            }
            if (txt_UserName.Text == string.Empty)
            {
                XtraMessageBox.Show("User Name chưa được nhập", "Thông Báo");
                return false;
            }
            if (txt_Password.Text == string.Empty)
            {
                XtraMessageBox.Show("Password chưa được nhập", "Thông Báo");
                return false;
            }
            return true;
        }
        private void cbo_Database_DragDrop(object sender, DragEventArgs e)
        {
            if (CheckedBeforSearchNameDB())
            {
                cbo_Database.Items.Clear();
                List<string> list = Config.GetDatabaseName(cbo_ServerName.Text, txt_UserName.Text, txt_Password.Text);
                if (list == null)
                {
                    XtraMessageBox.Show("Thông tin cấu hình chưa chính xác", "Thông báo");
                    return;
                }
                foreach (string item in list)
                {
                    cbo_Database.Items.Add(item);
                }
            }
        }

        private void btn_SaveConfig_Click(object sender, EventArgs e)
        {
            Config.ChangConnectionString(cbo_ServerName.Text, cbo_Database.Text, txt_UserName.Text, txt_Password.Text);
            LoginUserControl uc = new LoginUserControl();
            uc.NameDatabase = cbo_Database.Text;
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_UserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) || char.IsUpper(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}