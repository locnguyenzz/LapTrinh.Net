namespace CoffeeLibrary
{
    partial class frmconfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmconfig));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ServerName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_ServerName = new System.Windows.Forms.ComboBox();
            this.cbo_Database = new System.Windows.Forms.ComboBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_SaveConfig = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.07018F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ServerName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbo_ServerName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbo_Database, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_UserName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_Password, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_SaveConfig, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btn_Cancel, 2, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.61702F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.48936F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.89362F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.3617F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.95745F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.80851F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(351, 188);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 4);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "CẤU HÌNH CƠ SỞ DỮ LIỆU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ServerName
            // 
            this.lbl_ServerName.AutoSize = true;
            this.lbl_ServerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_ServerName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ServerName.Location = new System.Drawing.Point(3, 34);
            this.lbl_ServerName.Name = "lbl_ServerName";
            this.lbl_ServerName.Size = new System.Drawing.Size(81, 30);
            this.lbl_ServerName.TabIndex = 1;
            this.lbl_ServerName.Text = "Server Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Database";
            // 
            // cbo_ServerName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cbo_ServerName, 3);
            this.cbo_ServerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_ServerName.FormattingEnabled = true;
            this.cbo_ServerName.Location = new System.Drawing.Point(90, 37);
            this.cbo_ServerName.Name = "cbo_ServerName";
            this.cbo_ServerName.Size = new System.Drawing.Size(258, 21);
            this.cbo_ServerName.TabIndex = 5;
            this.cbo_ServerName.DragDrop += new System.Windows.Forms.DragEventHandler(this.cbo_ServerName_DragDrop);
            // 
            // cbo_Database
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cbo_Database, 3);
            this.cbo_Database.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_Database.FormattingEnabled = true;
            this.cbo_Database.Location = new System.Drawing.Point(90, 120);
            this.cbo_Database.Name = "cbo_Database";
            this.cbo_Database.Size = new System.Drawing.Size(258, 21);
            this.cbo_Database.TabIndex = 6;
            this.cbo_Database.DragDrop += new System.Windows.Forms.DragEventHandler(this.cbo_Database_DragDrop);
            // 
            // txt_UserName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_UserName, 3);
            this.txt_UserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_UserName.Location = new System.Drawing.Point(90, 67);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(258, 21);
            this.txt_UserName.TabIndex = 7;
            this.txt_UserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_UserName_KeyPress);
            // 
            // txt_Password
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_Password, 3);
            this.txt_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Password.Location = new System.Drawing.Point(90, 94);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(258, 21);
            this.txt_Password.TabIndex = 8;
            this.txt_Password.UseSystemPasswordChar = true;
            this.txt_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Password_KeyPress);
            // 
            // btn_SaveConfig
            // 
            this.btn_SaveConfig.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_SaveConfig.ImageOptions.Image")));
            this.btn_SaveConfig.Location = new System.Drawing.Point(90, 149);
            this.btn_SaveConfig.Name = "btn_SaveConfig";
            this.btn_SaveConfig.Size = new System.Drawing.Size(89, 30);
            this.btn_SaveConfig.TabIndex = 9;
            this.btn_SaveConfig.Text = "Lưu lại";
            this.btn_SaveConfig.Click += new System.EventHandler(this.btn_SaveConfig_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.ImageOptions.Image")));
            this.btn_Cancel.Location = new System.Drawing.Point(188, 149);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(81, 30);
            this.btn_Cancel.TabIndex = 10;
            this.btn_Cancel.Text = "Hủy bỏ";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // frmconfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 188);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmconfig";
            this.Text = "CẤU HÌNH";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ServerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_ServerName;
        private System.Windows.Forms.ComboBox cbo_Database;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_Password;
        private DevExpress.XtraEditors.SimpleButton btn_SaveConfig;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
    }
}