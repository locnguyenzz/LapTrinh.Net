namespace CoffeeManagementSoftware
{
    partial class frmCustumer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustumer));
            this.tLP_Customer = new System.Windows.Forms.TableLayoutPanel();
            this.tCtr_Member = new System.Windows.Forms.TabControl();
            this.tP_Member = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tV_Member = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.tCtr_Customer = new System.Windows.Forms.TabControl();
            this.tP_Customer = new System.Windows.Forms.TabPage();
            this.tLP_DetailCus = new System.Windows.Forms.TableLayoutPanel();
            this.tS_Customer = new System.Windows.Forms.ToolStrip();
            this.tSB_Add = new System.Windows.Forms.ToolStripButton();
            this.tSP_Edit = new System.Windows.Forms.ToolStripButton();
            this.tSB_Delete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.dGV_Customer = new System.Windows.Forms.DataGridView();
            this.ID_PROFILE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_USER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDENFITICATION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LAST_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIRST_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SCORE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMS_GroupCus = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmNhómToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaNhómToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiTênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tLP_Customer.SuspendLayout();
            this.tCtr_Member.SuspendLayout();
            this.tP_Member.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tCtr_Customer.SuspendLayout();
            this.tP_Customer.SuspendLayout();
            this.tLP_DetailCus.SuspendLayout();
            this.tS_Customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Customer)).BeginInit();
            this.cMS_GroupCus.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLP_Customer
            // 
            this.tLP_Customer.ColumnCount = 2;
            this.tLP_Customer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.tLP_Customer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74F));
            this.tLP_Customer.Controls.Add(this.tCtr_Member, 0, 0);
            this.tLP_Customer.Controls.Add(this.tCtr_Customer, 1, 0);
            this.tLP_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_Customer.Location = new System.Drawing.Point(0, 0);
            this.tLP_Customer.Name = "tLP_Customer";
            this.tLP_Customer.RowCount = 1;
            this.tLP_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_Customer.Size = new System.Drawing.Size(1119, 534);
            this.tLP_Customer.TabIndex = 0;
            // 
            // tCtr_Member
            // 
            this.tCtr_Member.Controls.Add(this.tP_Member);
            this.tCtr_Member.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tCtr_Member.Location = new System.Drawing.Point(3, 3);
            this.tCtr_Member.Name = "tCtr_Member";
            this.tCtr_Member.SelectedIndex = 0;
            this.tCtr_Member.Size = new System.Drawing.Size(284, 528);
            this.tCtr_Member.TabIndex = 0;
            // 
            // tP_Member
            // 
            this.tP_Member.Controls.Add(this.tableLayoutPanel1);
            this.tP_Member.Location = new System.Drawing.Point(4, 22);
            this.tP_Member.Name = "tP_Member";
            this.tP_Member.Padding = new System.Windows.Forms.Padding(3);
            this.tP_Member.Size = new System.Drawing.Size(276, 502);
            this.tP_Member.TabIndex = 0;
            this.tP_Member.Text = "Thành Viên";
            this.tP_Member.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tV_Member, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.125678F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.87432F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(270, 496);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tV_Member
            // 
            this.tV_Member.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tV_Member.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tV_Member.Location = new System.Drawing.Point(3, 28);
            this.tV_Member.Name = "tV_Member";
            this.tV_Member.Size = new System.Drawing.Size(264, 465);
            this.tV_Member.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator2,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(270, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::CoffeeManagementSoftware.Properties.Resources.Add_32x32;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::CoffeeManagementSoftware.Properties.Resources.PenColor_32x32;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::CoffeeManagementSoftware.Properties.Resources.Article_32x32;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::CoffeeManagementSoftware.Properties.Resources.Report_32x32;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::CoffeeManagementSoftware.Properties.Resources.Refresh_32x32;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // tCtr_Customer
            // 
            this.tCtr_Customer.Controls.Add(this.tP_Customer);
            this.tCtr_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tCtr_Customer.Location = new System.Drawing.Point(293, 3);
            this.tCtr_Customer.Name = "tCtr_Customer";
            this.tCtr_Customer.SelectedIndex = 0;
            this.tCtr_Customer.Size = new System.Drawing.Size(823, 528);
            this.tCtr_Customer.TabIndex = 1;
            // 
            // tP_Customer
            // 
            this.tP_Customer.Controls.Add(this.tLP_DetailCus);
            this.tP_Customer.Location = new System.Drawing.Point(4, 22);
            this.tP_Customer.Name = "tP_Customer";
            this.tP_Customer.Padding = new System.Windows.Forms.Padding(3);
            this.tP_Customer.Size = new System.Drawing.Size(815, 502);
            this.tP_Customer.TabIndex = 0;
            this.tP_Customer.Text = "Khách Hàng";
            this.tP_Customer.UseVisualStyleBackColor = true;
            // 
            // tLP_DetailCus
            // 
            this.tLP_DetailCus.ColumnCount = 1;
            this.tLP_DetailCus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_DetailCus.Controls.Add(this.tS_Customer, 0, 0);
            this.tLP_DetailCus.Controls.Add(this.dGV_Customer, 0, 1);
            this.tLP_DetailCus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_DetailCus.Location = new System.Drawing.Point(3, 3);
            this.tLP_DetailCus.Name = "tLP_DetailCus";
            this.tLP_DetailCus.RowCount = 2;
            this.tLP_DetailCus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tLP_DetailCus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tLP_DetailCus.Size = new System.Drawing.Size(809, 496);
            this.tLP_DetailCus.TabIndex = 0;
            // 
            // tS_Customer
            // 
            this.tS_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tS_Customer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSB_Add,
            this.tSP_Edit,
            this.tSB_Delete,
            this.toolStripSeparator3,
            this.toolStripButton6,
            this.toolStripButton7});
            this.tS_Customer.Location = new System.Drawing.Point(0, 0);
            this.tS_Customer.Name = "tS_Customer";
            this.tS_Customer.Size = new System.Drawing.Size(809, 24);
            this.tS_Customer.TabIndex = 0;
            this.tS_Customer.Text = "toolStrip1";
            // 
            // tSB_Add
            // 
            this.tSB_Add.Image = global::CoffeeManagementSoftware.Properties.Resources.Add_16x16;
            this.tSB_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_Add.Name = "tSB_Add";
            this.tSB_Add.Size = new System.Drawing.Size(81, 21);
            this.tSB_Add.Text = "Thêm Mới";
            this.tSB_Add.Click += new System.EventHandler(this.tSB_Add_Click);
            // 
            // tSP_Edit
            // 
            this.tSP_Edit.Image = global::CoffeeManagementSoftware.Properties.Resources.EditTask_16x16;
            this.tSP_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSP_Edit.Name = "tSP_Edit";
            this.tSP_Edit.Size = new System.Drawing.Size(81, 21);
            this.tSP_Edit.Text = "Chỉnh Sửa";
            this.tSP_Edit.Click += new System.EventHandler(this.tSP_Edit_Click);
            // 
            // tSB_Delete
            // 
            this.tSB_Delete.Image = global::CoffeeManagementSoftware.Properties.Resources.Delete_16x16;
            this.tSB_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_Delete.Name = "tSB_Delete";
            this.tSB_Delete.Size = new System.Drawing.Size(47, 21);
            this.tSB_Delete.Text = "Xóa";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 24);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(37, 21);
            this.toolStripButton6.Text = "In";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Image = global::CoffeeManagementSoftware.Properties.Resources.Lookup_Reference_32x32;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(46, 21);
            this.toolStripButton7.Text = "Lọc";
            // 
            // dGV_Customer
            // 
            this.dGV_Customer.AllowUserToAddRows = false;
            this.dGV_Customer.AllowUserToDeleteRows = false;
            this.dGV_Customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_Customer.BackgroundColor = System.Drawing.Color.White;
            this.dGV_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PROFILE,
            this.ID_USER,
            this.IDENFITICATION,
            this.LAST_NAME,
            this.FIRST_NAME,
            this.SEX,
            this.PHONE,
            this.ADDRESS,
            this.SCORE,
            this.NAME_TYPE,
            this.STATUS});
            this.dGV_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV_Customer.Location = new System.Drawing.Point(3, 27);
            this.dGV_Customer.MultiSelect = false;
            this.dGV_Customer.Name = "dGV_Customer";
            this.dGV_Customer.ReadOnly = true;
            this.dGV_Customer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Customer.Size = new System.Drawing.Size(803, 466);
            this.dGV_Customer.TabIndex = 1;
            // 
            // ID_PROFILE
            // 
            this.ID_PROFILE.DataPropertyName = "ID_PROFILE";
            this.ID_PROFILE.HeaderText = "Mã Hồ Sơ";
            this.ID_PROFILE.Name = "ID_PROFILE";
            this.ID_PROFILE.ReadOnly = true;
            // 
            // ID_USER
            // 
            this.ID_USER.DataPropertyName = "ID_USER";
            this.ID_USER.HeaderText = "Mã Người Dùng";
            this.ID_USER.Name = "ID_USER";
            this.ID_USER.ReadOnly = true;
            // 
            // IDENFITICATION
            // 
            this.IDENFITICATION.DataPropertyName = "IDENFITICATION";
            this.IDENFITICATION.HeaderText = "SỐ CMND";
            this.IDENFITICATION.Name = "IDENFITICATION";
            this.IDENFITICATION.ReadOnly = true;
            // 
            // LAST_NAME
            // 
            this.LAST_NAME.DataPropertyName = "LAST_NAME";
            this.LAST_NAME.HeaderText = "Họ";
            this.LAST_NAME.Name = "LAST_NAME";
            this.LAST_NAME.ReadOnly = true;
            // 
            // FIRST_NAME
            // 
            this.FIRST_NAME.DataPropertyName = "FIRST_NAME";
            this.FIRST_NAME.HeaderText = "Tên";
            this.FIRST_NAME.Name = "FIRST_NAME";
            this.FIRST_NAME.ReadOnly = true;
            // 
            // SEX
            // 
            this.SEX.DataPropertyName = "SEX";
            this.SEX.HeaderText = "Giới Tính";
            this.SEX.Name = "SEX";
            this.SEX.ReadOnly = true;
            // 
            // PHONE
            // 
            this.PHONE.DataPropertyName = "PHONE";
            this.PHONE.HeaderText = "SDT";
            this.PHONE.Name = "PHONE";
            this.PHONE.ReadOnly = true;
            // 
            // ADDRESS
            // 
            this.ADDRESS.DataPropertyName = "ADDRESS";
            this.ADDRESS.HeaderText = "Địa Chỉ";
            this.ADDRESS.Name = "ADDRESS";
            this.ADDRESS.ReadOnly = true;
            // 
            // SCORE
            // 
            this.SCORE.DataPropertyName = "SCORE";
            this.SCORE.HeaderText = "Điểm TL";
            this.SCORE.Name = "SCORE";
            this.SCORE.ReadOnly = true;
            // 
            // NAME_TYPE
            // 
            this.NAME_TYPE.DataPropertyName = "NAME_TYPE";
            this.NAME_TYPE.HeaderText = "Tên Loại";
            this.NAME_TYPE.Name = "NAME_TYPE";
            this.NAME_TYPE.ReadOnly = true;
            this.NAME_TYPE.Visible = false;
            // 
            // STATUS
            // 
            this.STATUS.DataPropertyName = "STATUS";
            this.STATUS.HeaderText = "Trạng Thái";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            // 
            // cMS_GroupCus
            // 
            this.cMS_GroupCus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmNhómToolStripMenuItem,
            this.xóaNhómToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.đổiTênToolStripMenuItem});
            this.cMS_GroupCus.Name = "cMS_GroupCus";
            this.cMS_GroupCus.Size = new System.Drawing.Size(142, 92);
            // 
            // thêmNhómToolStripMenuItem
            // 
            this.thêmNhómToolStripMenuItem.Name = "thêmNhómToolStripMenuItem";
            this.thêmNhómToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.thêmNhómToolStripMenuItem.Text = "Thêm Nhóm";
            // 
            // xóaNhómToolStripMenuItem
            // 
            this.xóaNhómToolStripMenuItem.Image = global::CoffeeManagementSoftware.Properties.Resources.Delete_16x16;
            this.xóaNhómToolStripMenuItem.Name = "xóaNhómToolStripMenuItem";
            this.xóaNhómToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.xóaNhómToolStripMenuItem.Text = "Xóa Nhóm";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::CoffeeManagementSoftware.Properties.Resources.Refresh_16x16;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // đổiTênToolStripMenuItem
            // 
            this.đổiTênToolStripMenuItem.Image = global::CoffeeManagementSoftware.Properties.Resources.EditTask_16x16;
            this.đổiTênToolStripMenuItem.Name = "đổiTênToolStripMenuItem";
            this.đổiTênToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.đổiTênToolStripMenuItem.Text = "Đổi tên";
            // 
            // frmCustumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 534);
            this.Controls.Add(this.tLP_Customer);
            this.Name = "frmCustumer";
            this.Text = "Khách Hàng";
            this.tLP_Customer.ResumeLayout(false);
            this.tCtr_Member.ResumeLayout(false);
            this.tP_Member.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tCtr_Customer.ResumeLayout(false);
            this.tP_Customer.ResumeLayout(false);
            this.tLP_DetailCus.ResumeLayout(false);
            this.tLP_DetailCus.PerformLayout();
            this.tS_Customer.ResumeLayout(false);
            this.tS_Customer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Customer)).EndInit();
            this.cMS_GroupCus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLP_Customer;
        private System.Windows.Forms.TabControl tCtr_Member;
        private System.Windows.Forms.TabPage tP_Member;
        private System.Windows.Forms.TreeView tV_Member;
        private System.Windows.Forms.TabControl tCtr_Customer;
        private System.Windows.Forms.TabPage tP_Customer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip cMS_GroupCus;
        private System.Windows.Forms.ToolStripMenuItem thêmNhómToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaNhómToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiTênToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tLP_DetailCus;
        private System.Windows.Forms.ToolStrip tS_Customer;
        private System.Windows.Forms.ToolStripButton tSB_Add;
        private System.Windows.Forms.ToolStripButton tSP_Edit;
        private System.Windows.Forms.ToolStripButton tSB_Delete;
        private System.Windows.Forms.DataGridView dGV_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PROFILE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_USER;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDENFITICATION;
        private System.Windows.Forms.DataGridViewTextBoxColumn LAST_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIRST_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEX;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn SCORE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
    }
}