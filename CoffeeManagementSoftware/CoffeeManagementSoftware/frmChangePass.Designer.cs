namespace CoffeeManagementSoftware
{
    partial class frmChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePass));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_PassOld = new System.Windows.Forms.TextBox();
            this.txt_PassNew = new System.Windows.Forms.TextBox();
            this.txt_ConfirmPassNew = new System.Windows.Forms.TextBox();
            this.btn_Argee = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.81818F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.26263F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.74747F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.17172F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_PassOld, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_PassNew, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_ConfirmPassNew, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_Argee, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_Cancel, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.99447F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.57458F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.23204F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.23204F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.62431F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(396, 181);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 4);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐỔI MẬT KHẨU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Xác nhận mật khâu mới";
            // 
            // txt_PassOld
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_PassOld, 3);
            this.txt_PassOld.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_PassOld.Location = new System.Drawing.Point(129, 40);
            this.txt_PassOld.Name = "txt_PassOld";
            this.txt_PassOld.Size = new System.Drawing.Size(264, 21);
            this.txt_PassOld.TabIndex = 4;
            this.txt_PassOld.UseSystemPasswordChar = true;
            // 
            // txt_PassNew
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_PassNew, 3);
            this.txt_PassNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_PassNew.Location = new System.Drawing.Point(129, 69);
            this.txt_PassNew.Name = "txt_PassNew";
            this.txt_PassNew.Size = new System.Drawing.Size(264, 21);
            this.txt_PassNew.TabIndex = 5;
            this.txt_PassNew.UseSystemPasswordChar = true;
            // 
            // txt_ConfirmPassNew
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_ConfirmPassNew, 3);
            this.txt_ConfirmPassNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ConfirmPassNew.Location = new System.Drawing.Point(129, 101);
            this.txt_ConfirmPassNew.Name = "txt_ConfirmPassNew";
            this.txt_ConfirmPassNew.Size = new System.Drawing.Size(264, 21);
            this.txt_ConfirmPassNew.TabIndex = 6;
            this.txt_ConfirmPassNew.UseSystemPasswordChar = true;
            // 
            // btn_Argee
            // 
            this.btn_Argee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Argee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btn_Argee.Location = new System.Drawing.Point(129, 133);
            this.btn_Argee.Name = "btn_Argee";
            this.btn_Argee.Size = new System.Drawing.Size(98, 37);
            this.btn_Argee.TabIndex = 7;
            this.btn_Argee.Text = "Đồng ý";
            this.btn_Argee.Click += new System.EventHandler(this.btn_Argee_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Cancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btn_Cancel.Location = new System.Drawing.Point(233, 133);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(91, 37);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "Hủy bỏ";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // frmChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 181);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐỔI MẬT KHẨU";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_PassOld;
        private System.Windows.Forms.TextBox txt_PassNew;
        private System.Windows.Forms.TextBox txt_ConfirmPassNew;
        private DevExpress.XtraEditors.SimpleButton btn_Argee;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
    }
}