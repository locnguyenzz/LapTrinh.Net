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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dGV_Customer = new System.Windows.Forms.DataGridView();
            this.ID_PROFILE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_USER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDENFITICATION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LAST_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIRST_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_LName = new System.Windows.Forms.TextBox();
            this.txt_FName = new System.Windows.Forms.TextBox();
            this.msk_Phone = new System.Windows.Forms.MaskedTextBox();
            this.cbo_TypeCus = new System.Windows.Forms.ComboBox();
            this.chk_Status = new System.Windows.Forms.CheckBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Email = new CoffeeLibrary.MailTextBox(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
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
            this.tLP_DetailCus.ColumnCount = 4;
            this.tLP_DetailCus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.48578F));
            this.tLP_DetailCus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.10383F));
            this.tLP_DetailCus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.93449F));
            this.tLP_DetailCus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.72311F));
            this.tLP_DetailCus.Controls.Add(this.tS_Customer, 0, 0);
            this.tLP_DetailCus.Controls.Add(this.label2, 0, 2);
            this.tLP_DetailCus.Controls.Add(this.label3, 0, 3);
            this.tLP_DetailCus.Controls.Add(this.label6, 2, 3);
            this.tLP_DetailCus.Controls.Add(this.dGV_Customer, 0, 5);
            this.tLP_DetailCus.Controls.Add(this.label1, 0, 4);
            this.tLP_DetailCus.Controls.Add(this.label4, 2, 4);
            this.tLP_DetailCus.Controls.Add(this.txt_LName, 1, 2);
            this.tLP_DetailCus.Controls.Add(this.txt_FName, 1, 3);
            this.tLP_DetailCus.Controls.Add(this.msk_Phone, 1, 4);
            this.tLP_DetailCus.Controls.Add(this.cbo_TypeCus, 3, 3);
            this.tLP_DetailCus.Controls.Add(this.chk_Status, 3, 4);
            this.tLP_DetailCus.Controls.Add(this.txt_Address, 3, 1);
            this.tLP_DetailCus.Controls.Add(this.label5, 2, 1);
            this.tLP_DetailCus.Controls.Add(this.label7, 2, 2);
            this.tLP_DetailCus.Controls.Add(this.txt_Email, 3, 2);
            this.tLP_DetailCus.Controls.Add(this.label8, 0, 1);
            this.tLP_DetailCus.Controls.Add(this.txt_ID, 1, 1);
            this.tLP_DetailCus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_DetailCus.Location = new System.Drawing.Point(3, 3);
            this.tLP_DetailCus.Name = "tLP_DetailCus";
            this.tLP_DetailCus.RowCount = 6;
            this.tLP_DetailCus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.056452F));
            this.tLP_DetailCus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.443548F));
            this.tLP_DetailCus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.451613F));
            this.tLP_DetailCus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tLP_DetailCus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.040323F));
            this.tLP_DetailCus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.35484F));
            this.tLP_DetailCus.Size = new System.Drawing.Size(809, 496);
            this.tLP_DetailCus.TabIndex = 0;
            // 
            // tS_Customer
            // 
            this.tLP_DetailCus.SetColumnSpan(this.tS_Customer, 4);
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
            this.tS_Customer.Size = new System.Drawing.Size(809, 35);
            this.tS_Customer.TabIndex = 0;
            this.tS_Customer.Text = "toolStrip1";
            // 
            // tSB_Add
            // 
            this.tSB_Add.Image = global::CoffeeManagementSoftware.Properties.Resources.Add_16x16;
            this.tSB_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_Add.Name = "tSB_Add";
            this.tSB_Add.Size = new System.Drawing.Size(81, 32);
            this.tSB_Add.Text = "Thêm Mới";
            this.tSB_Add.Click += new System.EventHandler(this.tSB_Add_Click);
            // 
            // tSP_Edit
            // 
            this.tSP_Edit.Image = global::CoffeeManagementSoftware.Properties.Resources.EditTask_16x16;
            this.tSP_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSP_Edit.Name = "tSP_Edit";
            this.tSP_Edit.Size = new System.Drawing.Size(81, 32);
            this.tSP_Edit.Text = "Chỉnh Sửa";
            this.tSP_Edit.Click += new System.EventHandler(this.tSP_Edit_Click);
            // 
            // tSB_Delete
            // 
            this.tSB_Delete.Image = global::CoffeeManagementSoftware.Properties.Resources.Delete_16x16;
            this.tSB_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_Delete.Name = "tSB_Delete";
            this.tSB_Delete.Size = new System.Drawing.Size(47, 32);
            this.tSB_Delete.Text = "Xóa";
            this.tSB_Delete.Click += new System.EventHandler(this.tSB_Delete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(37, 32);
            this.toolStripButton6.Text = "In";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Image = global::CoffeeManagementSoftware.Properties.Resources.Lookup_Reference_32x32;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(46, 32);
            this.toolStripButton7.Text = "Lọc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Họ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(386, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "Thành Viên";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dGV_Customer
            // 
            this.dGV_Customer.AllowUserToAddRows = false;
            this.dGV_Customer.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow;
            this.dGV_Customer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            this.NAME_TYPE,
            this.Email,
            this.STATUS,
            this.Column1,
            this.Column2,
            this.Column3});
            this.tLP_DetailCus.SetColumnSpan(this.dGV_Customer, 4);
            this.dGV_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV_Customer.Location = new System.Drawing.Point(3, 153);
            this.dGV_Customer.MultiSelect = false;
            this.dGV_Customer.Name = "dGV_Customer";
            this.dGV_Customer.ReadOnly = true;
            this.dGV_Customer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Customer.Size = new System.Drawing.Size(803, 340);
            this.dGV_Customer.TabIndex = 10;
            this.dGV_Customer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Customer_CellClick);
            // 
            // ID_PROFILE
            // 
            this.ID_PROFILE.DataPropertyName = "ID";
            this.ID_PROFILE.HeaderText = "Mã Khách";
            this.ID_PROFILE.Name = "ID_PROFILE";
            this.ID_PROFILE.ReadOnly = true;
            // 
            // ID_USER
            // 
            this.ID_USER.DataPropertyName = "ID_ACCOUNT";
            this.ID_USER.HeaderText = "Mã Người Dùng";
            this.ID_USER.Name = "ID_USER";
            this.ID_USER.ReadOnly = true;
            this.ID_USER.Visible = false;
            // 
            // IDENFITICATION
            // 
            this.IDENFITICATION.DataPropertyName = "IDENTIFICATION";
            this.IDENFITICATION.HeaderText = "SỐ CMND";
            this.IDENFITICATION.Name = "IDENFITICATION";
            this.IDENFITICATION.ReadOnly = true;
            this.IDENFITICATION.Visible = false;
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
            this.SEX.Visible = false;
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
            // NAME_TYPE
            // 
            this.NAME_TYPE.DataPropertyName = "NAME_TYPE";
            this.NAME_TYPE.HeaderText = "Thành Viên";
            this.NAME_TYPE.Name = "NAME_TYPE";
            this.NAME_TYPE.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "EMAIL";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // STATUS
            // 
            this.STATUS.DataPropertyName = "STATUS";
            this.STATUS.HeaderText = "Trạng Thái";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID_TYPE_CUSTOMER";
            this.Column1.HeaderText = "ID_TYPE_CUSTUMMER";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "account";
            this.Column2.HeaderText = "ACCOUNT";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "type_customer";
            this.Column3.HeaderText = "type_customer";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Điện thoại";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(386, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Trạng Thái";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_LName
            // 
            this.txt_LName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_LName.Location = new System.Drawing.Point(192, 65);
            this.txt_LName.Name = "txt_LName";
            this.txt_LName.Size = new System.Drawing.Size(188, 21);
            this.txt_LName.TabIndex = 11;
            // 
            // txt_FName
            // 
            this.txt_FName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_FName.Location = new System.Drawing.Point(192, 97);
            this.txt_FName.Name = "txt_FName";
            this.txt_FName.Size = new System.Drawing.Size(188, 21);
            this.txt_FName.TabIndex = 12;
            // 
            // msk_Phone
            // 
            this.msk_Phone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msk_Phone.Location = new System.Drawing.Point(192, 128);
            this.msk_Phone.Mask = "0000000000";
            this.msk_Phone.Name = "msk_Phone";
            this.msk_Phone.Size = new System.Drawing.Size(188, 21);
            this.msk_Phone.TabIndex = 13;
            // 
            // cbo_TypeCus
            // 
            this.cbo_TypeCus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_TypeCus.FormattingEnabled = true;
            this.cbo_TypeCus.Location = new System.Drawing.Point(522, 97);
            this.cbo_TypeCus.Name = "cbo_TypeCus";
            this.cbo_TypeCus.Size = new System.Drawing.Size(284, 21);
            this.cbo_TypeCus.TabIndex = 15;
            // 
            // chk_Status
            // 
            this.chk_Status.AutoSize = true;
            this.chk_Status.Location = new System.Drawing.Point(522, 128);
            this.chk_Status.Name = "chk_Status";
            this.chk_Status.Size = new System.Drawing.Size(76, 17);
            this.chk_Status.TabIndex = 16;
            this.chk_Status.Text = "Hoạt động";
            this.chk_Status.UseVisualStyleBackColor = true;
            // 
            // txt_Address
            // 
            this.txt_Address.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Address.Location = new System.Drawing.Point(522, 38);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(284, 21);
            this.txt_Address.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(386, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Địa chỉ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(386, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 32);
            this.label7.TabIndex = 17;
            this.label7.Text = "Email";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_Email
            // 
            this.txt_Email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Email.Location = new System.Drawing.Point(522, 65);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(284, 21);
            this.txt_Email.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 27);
            this.label8.TabIndex = 19;
            this.label8.Text = "Mã khách";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_ID
            // 
            this.txt_ID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ID.Location = new System.Drawing.Point(192, 38);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(188, 21);
            this.txt_ID.TabIndex = 20;
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
            this.Load += new System.EventHandler(this.frmCustumer_Load);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip cMS_GroupCus;
        private System.Windows.Forms.ToolStripMenuItem thêmNhómToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaNhómToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiTênToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.TabControl tCtr_Customer;
        private System.Windows.Forms.TabPage tP_Customer;
        private System.Windows.Forms.TableLayoutPanel tLP_DetailCus;
        private System.Windows.Forms.ToolStrip tS_Customer;
        private System.Windows.Forms.ToolStripButton tSB_Add;
        private System.Windows.Forms.ToolStripButton tSP_Edit;
        private System.Windows.Forms.ToolStripButton tSB_Delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dGV_Customer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_LName;
        private System.Windows.Forms.TextBox txt_FName;
        private System.Windows.Forms.MaskedTextBox msk_Phone;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.ComboBox cbo_TypeCus;
        private System.Windows.Forms.CheckBox chk_Status;
        private System.Windows.Forms.Label label7;
        private CoffeeLibrary.MailTextBox txt_Email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PROFILE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_USER;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDENFITICATION;
        private System.Windows.Forms.DataGridViewTextBoxColumn LAST_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIRST_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEX;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}