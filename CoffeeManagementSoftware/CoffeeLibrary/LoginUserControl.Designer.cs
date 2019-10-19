namespace CoffeeLibrary
{
    partial class LoginUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUserControl));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_Banner = new System.Windows.Forms.Panel();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.chk_RememberPass = new System.Windows.Forms.CheckBox();
            this.btn_Login = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_NameDataBase = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.36449F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.62617F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.03738F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.140187F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.46316F));
            this.tableLayoutPanel1.Controls.Add(this.pnl_Banner, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_UserName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Password, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_Username, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_Password, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.chk_RememberPass, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_Login, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_Cancel, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_NameDataBase, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.92553F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.21609F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.29032F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.274194F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.75806F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(428, 248);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnl_Banner
            // 
            this.pnl_Banner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Banner.BackgroundImage")));
            this.pnl_Banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.SetColumnSpan(this.pnl_Banner, 5);
            this.pnl_Banner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Banner.Location = new System.Drawing.Point(3, 3);
            this.pnl_Banner.Name = "pnl_Banner";
            this.pnl_Banner.Size = new System.Drawing.Size(422, 107);
            this.pnl_Banner.TabIndex = 0;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(103, 113);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(78, 35);
            this.lbl_UserName.TabIndex = 1;
            this.lbl_UserName.Text = "Người dùng";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(103, 148);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(78, 27);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "Mật khẩu";
            // 
            // txt_Username
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_Username, 3);
            this.txt_Username.Location = new System.Drawing.Point(187, 116);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(238, 20);
            this.txt_Username.TabIndex = 3;
            // 
            // txt_Password
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_Password, 3);
            this.txt_Password.Location = new System.Drawing.Point(187, 151);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(238, 20);
            this.txt_Password.TabIndex = 4;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // chk_RememberPass
            // 
            this.chk_RememberPass.AutoSize = true;
            this.chk_RememberPass.Location = new System.Drawing.Point(187, 178);
            this.chk_RememberPass.Name = "chk_RememberPass";
            this.chk_RememberPass.Size = new System.Drawing.Size(110, 16);
            this.chk_RememberPass.TabIndex = 5;
            this.chk_RememberPass.Text = "Ghi nhớ mật khẩu";
            this.chk_RememberPass.UseVisualStyleBackColor = true;
            // 
            // btn_Login
            // 
            this.btn_Login.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Login.Location = new System.Drawing.Point(187, 200);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(114, 34);
            this.btn_Login.TabIndex = 6;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Cancel.Location = new System.Drawing.Point(329, 200);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(96, 34);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Hủy bỏ";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 116);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 3);
            this.panel1.Size = new System.Drawing.Size(94, 78);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 51);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cơ sở dữ liệu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_NameDataBase
            // 
            this.lbl_NameDataBase.AutoSize = true;
            this.lbl_NameDataBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_NameDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NameDataBase.ForeColor = System.Drawing.Color.Red;
            this.lbl_NameDataBase.Location = new System.Drawing.Point(103, 197);
            this.lbl_NameDataBase.Name = "lbl_NameDataBase";
            this.lbl_NameDataBase.Size = new System.Drawing.Size(78, 51);
            this.lbl_NameDataBase.TabIndex = 10;
            this.lbl_NameDataBase.Text = "label4";
            this.lbl_NameDataBase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoginUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LoginUserControl";
            this.Size = new System.Drawing.Size(428, 248);
            this.Load += new System.EventHandler(this.LoginUserControl_Load_1);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnl_Banner;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.CheckBox chk_RememberPass;
        private DevExpress.XtraEditors.SimpleButton btn_Login;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_NameDataBase;
    }
}
