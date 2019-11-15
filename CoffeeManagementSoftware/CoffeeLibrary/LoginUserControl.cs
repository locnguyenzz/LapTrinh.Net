using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace CoffeeLibrary
{
    public partial class LoginUserControl : System.Windows.Forms.UserControl
    {
        UserManager Config = new UserManager();
        private string nameAccount;//Giữ giá trị tên tài khoản gửi qua frmLogin
        private int numberRole;//Giữ giá trị quyền gửi qua frmLogin
        private string nameDatabase;//Giữ giá trị tên cơ sở dữ liệu gửi qua frmLogin
        private bool flag;
        public bool Flag
        {
            get { return flag; }
            set { flag = value; }
        }
        

        public string NameAccount
        {
            get { return nameAccount; }
            set { nameAccount = value; }
        }
        

        public int NumberRole
        {
            get { return numberRole; }
            set { numberRole = value; }
        }
        

        public string NameDatabase
        {
            get { return nameDatabase; }
            set { nameDatabase = value; }
        }
        public LoginUserControl()
        {
            InitializeComponent();
        }

        public void ProcessLogin()
        {
            int result = Config.Check_User(txt_Username.Text, txt_Password.Text);
            if (result == 1)
            {
                XtraMessageBox.Show("Sai Tên Người Dùng hoặc Mật Khẩu !", "Thông Báo");
                return;
            }
            else if (result == 2)
            {
                XtraMessageBox.Show("Tài Khoản Đã Bị Khóa !", "Thông Báo");
                return;
            }
            XtraMessageBox.Show("Đăng Nhập Thành Công !", "Thông Báo");
            //xử lý form parent để gọi formMain
            flag = true;//Đánh dấu lại là Người dùng đã đăng nhập thành công và cho phép sử dụng frmMain
            nameAccount = txt_Username.Text;
            ParentForm.BackColor = Color.White;
           
        }

        public void Check_RememberPass()
        {
            if (chk_RememberPass.Checked)
            {
                Properties.Settings.Default.UserName = txt_Username.Text;
                Properties.Settings.Default.Password = txt_Password.Text;
                Properties.Settings.Default.RemeberPass = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.RemeberPass = false;
                Properties.Settings.Default.Save();
            }
        }

        public void GetNameDatabase()
        {
            SqlConnection temp = new SqlConnection(Properties.Settings.Default.DB_CoffeeConnectionString);
            nameDatabase = temp.Database.ToString();
            lbl_NameDataBase.Text = temp.Database.ToString();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(txt_Username.Text.Trim()))
            {
                XtraMessageBox.Show("Không được bỏ trống " + lbl_UserName.Text.ToLower());
                this.txt_Username.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_Password.Text.Trim()))
            {
                XtraMessageBox.Show("Không được bỏ trống " + lbl_Password.Text.ToLower());
                this.txt_Password.Focus();
                return;
            }
            //Kiểm tra cấu hình trước khi đăng nhập
            int checkConn = Config.Check_Config();
            if (checkConn == 0)
            {
                ProcessLogin();//Cho phép đăng nhập
                Check_RememberPass();//Ghi nhớ mật khẩu
            }
            frmconfig config = new frmconfig();
            if (checkConn == 1)
            {
                XtraMessageBox.Show("Chuỗi cấu hình không tồn tại", "Thông báo");
                config.ShowDialog();
                GetNameDatabase();
            }
            if (checkConn == 2)
            {
                XtraMessageBox.Show("Chuỗi cấu hình không phù hợp", "Thông báo");
                //Xử lý cấu hình
                config.ShowDialog();
                GetNameDatabase();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = XtraMessageBox.Show("Bạn có chắc muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
                ParentForm.Close();
        }
        private void LoginUserControl_Load_1(object sender, EventArgs e)
        {
            ParentForm.Show();
            if (Properties.Settings.Default.RemeberPass)
            {
                txt_Username.Text = Properties.Settings.Default.UserName;
                txt_Password.Text = Properties.Settings.Default.Password;
                chk_RememberPass.Checked = true;
            }
            GetNameDatabase();
        }
       
    }
}
