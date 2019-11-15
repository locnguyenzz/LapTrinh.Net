namespace CoffeeManagementSoftware
{
    partial class frmLogin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lUC_Login = new CoffeeLibrary.LoginUserControl();
            this.SuspendLayout();
            // 
            // loginUserControl1
            // 
            this.lUC_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lUC_Login.Flag = false;
            this.lUC_Login.Location = new System.Drawing.Point(0, 0);
            this.lUC_Login.Name = "loginUserControl1";
            this.lUC_Login.NameAccount = null;
            this.lUC_Login.NameDatabase = "DB_Coffee";
            this.lUC_Login.NumberRole = 0;
            this.lUC_Login.Size = new System.Drawing.Size(434, 254);
            this.lUC_Login.TabIndex = 0;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 254);
            this.Controls.Add(this.lUC_Login);
            this.Name = "frmLogin";
            this.Text = "ĐĂNG NHẬP";
            this.BackColorChanged += new System.EventHandler(this.frmLogin_BackColorChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private CoffeeLibrary.LoginUserControl lUC_Login;
    }
}