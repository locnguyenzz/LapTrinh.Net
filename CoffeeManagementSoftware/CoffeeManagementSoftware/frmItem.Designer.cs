namespace CoffeeManagementSoftware
{
    partial class frmItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItem));
            this.dgv_Item = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tSBThemmoi = new System.Windows.Forms.ToolStripButton();
            this.tSBChinhsua = new System.Windows.Forms.ToolStripButton();
            this.tSBXoa = new System.Windows.Forms.ToolStripButton();
            this.tSBIn = new System.Windows.Forms.ToolStripButton();
            this.tSBLoc = new System.Windows.Forms.ToolStripButton();
            this.tSBDInhluong = new System.Windows.Forms.ToolStripButton();
            this.tSBCapnhatgia = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Unit = new System.Windows.Forms.TextBox();
            this.txt_PriceSell = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_NameType = new System.Windows.Forms.ComboBox();
            this.txt_PricePur = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlNhomhang = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.txt_Purchase = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE_SELL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE_PURCHASE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Item)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlNhomhang.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Item
            // 
            this.dgv_Item.AllowUserToAddRows = false;
            this.dgv_Item.AllowUserToDeleteRows = false;
            this.dgv_Item.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Item.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Item.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NAME_ITEM,
            this.UNIT,
            this.PRICE_SELL,
            this.PRICE_PURCHASE,
            this.NAME_TYPE,
            this.STATUS,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.tableLayoutPanel1.SetColumnSpan(this.dgv_Item, 4);
            this.dgv_Item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Item.Location = new System.Drawing.Point(3, 184);
            this.dgv_Item.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Item.Name = "dgv_Item";
            this.dgv_Item.ReadOnly = true;
            this.dgv_Item.RowTemplate.Height = 24;
            this.dgv_Item.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Item.Size = new System.Drawing.Size(944, 326);
            this.dgv_Item.TabIndex = 1;
            this.dgv_Item.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Item_CellClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl1.Location = new System.Drawing.Point(323, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(964, 544);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(956, 518);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mặt hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.89117F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.37372F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.68378F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.68378F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv_Item, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_ID, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_Name, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_Unit, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_PriceSell, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbo_NameType, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_PricePur, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_Purchase, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.761292F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.007286F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.470841F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.451272F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.216047F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.09326F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(950, 512);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // toolStrip2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.toolStrip2, 4);
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBThemmoi,
            this.tSBChinhsua,
            this.tSBXoa,
            this.tSBIn,
            this.tSBLoc,
            this.tSBDInhluong,
            this.tSBCapnhatgia});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(950, 39);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tSBThemmoi
            // 
            this.tSBThemmoi.Image = global::CoffeeManagementSoftware.Properties.Resources.Add_32x32;
            this.tSBThemmoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBThemmoi.Name = "tSBThemmoi";
            this.tSBThemmoi.Size = new System.Drawing.Size(125, 36);
            this.tSBThemmoi.Text = "Thêm mới (Insert)";
            this.tSBThemmoi.Click += new System.EventHandler(this.tSBThemmoi_Click);
            // 
            // tSBChinhsua
            // 
            this.tSBChinhsua.Image = global::CoffeeManagementSoftware.Properties.Resources.Refresh_32x32;
            this.tSBChinhsua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBChinhsua.Name = "tSBChinhsua";
            this.tSBChinhsua.Size = new System.Drawing.Size(84, 36);
            this.tSBChinhsua.Text = "Chỉnh sửa";
            this.tSBChinhsua.Click += new System.EventHandler(this.tSBChinhsua_Click);
            // 
            // tSBXoa
            // 
            this.tSBXoa.Image = global::CoffeeManagementSoftware.Properties.Resources.Delete_16x16;
            this.tSBXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBXoa.Name = "tSBXoa";
            this.tSBXoa.Size = new System.Drawing.Size(79, 36);
            this.tSBXoa.Text = "Xóa (Del)";
            this.tSBXoa.Click += new System.EventHandler(this.tSBXoa_Click);
            // 
            // tSBIn
            // 
            this.tSBIn.Image = ((System.Drawing.Image)(resources.GetObject("tSBIn.Image")));
            this.tSBIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBIn.Name = "tSBIn";
            this.tSBIn.Size = new System.Drawing.Size(41, 36);
            this.tSBIn.Text = "In";
            // 
            // tSBLoc
            // 
            this.tSBLoc.Image = global::CoffeeManagementSoftware.Properties.Resources.Lookup_Reference_32x32;
            this.tSBLoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBLoc.Name = "tSBLoc";
            this.tSBLoc.Size = new System.Drawing.Size(50, 36);
            this.tSBLoc.Text = "Lọc";
            // 
            // tSBDInhluong
            // 
            this.tSBDInhluong.Image = ((System.Drawing.Image)(resources.GetObject("tSBDInhluong.Image")));
            this.tSBDInhluong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBDInhluong.Name = "tSBDInhluong";
            this.tSBDInhluong.Size = new System.Drawing.Size(128, 36);
            this.tSBDInhluong.Text = "Import định lượng";
            // 
            // tSBCapnhatgia
            // 
            this.tSBCapnhatgia.Image = ((System.Drawing.Image)(resources.GetObject("tSBCapnhatgia.Image")));
            this.tSBCapnhatgia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBCapnhatgia.Name = "tSBCapnhatgia";
            this.tSBCapnhatgia.Size = new System.Drawing.Size(142, 36);
            this.tSBCapnhatgia.Text = "Cập nhật giá từ excel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 47);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đơn vị tính";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(476, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "Giá bán";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_ID
            // 
            this.txt_ID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ID.Location = new System.Drawing.Point(272, 67);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(198, 21);
            this.txt_ID.TabIndex = 8;
            // 
            // txt_Name
            // 
            this.txt_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Name.Location = new System.Drawing.Point(272, 100);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(198, 21);
            this.txt_Name.TabIndex = 9;
            // 
            // txt_Unit
            // 
            this.txt_Unit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Unit.Location = new System.Drawing.Point(272, 138);
            this.txt_Unit.Name = "txt_Unit";
            this.txt_Unit.Size = new System.Drawing.Size(198, 21);
            this.txt_Unit.TabIndex = 10;
            // 
            // txt_PriceSell
            // 
            this.txt_PriceSell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_PriceSell.Location = new System.Drawing.Point(713, 67);
            this.txt_PriceSell.Name = "txt_PriceSell";
            this.txt_PriceSell.Size = new System.Drawing.Size(234, 21);
            this.txt_PriceSell.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(476, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 47);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nhóm hàng";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbo_NameType
            // 
            this.cbo_NameType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_NameType.FormattingEnabled = true;
            this.cbo_NameType.Location = new System.Drawing.Point(713, 138);
            this.cbo_NameType.Name = "cbo_NameType";
            this.cbo_NameType.Size = new System.Drawing.Size(234, 21);
            this.cbo_NameType.TabIndex = 13;
            // 
            // txt_PricePur
            // 
            this.txt_PricePur.AutoSize = true;
            this.txt_PricePur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_PricePur.Location = new System.Drawing.Point(476, 97);
            this.txt_PricePur.Name = "txt_PricePur";
            this.txt_PricePur.Size = new System.Drawing.Size(231, 38);
            this.txt_PricePur.TabIndex = 17;
            this.txt_PricePur.Text = "Giá nhập";
            this.txt_PricePur.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(956, 518);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(950, 512);
            this.dataGridView1.TabIndex = 0;
            // 
            // pnlNhomhang
            // 
            this.pnlNhomhang.Controls.Add(this.treeView1);
            this.pnlNhomhang.Controls.Add(this.toolStrip1);
            this.pnlNhomhang.Location = new System.Drawing.Point(11, 11);
            this.pnlNhomhang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlNhomhang.Name = "pnlNhomhang";
            this.pnlNhomhang.Size = new System.Drawing.Size(286, 521);
            this.pnlNhomhang.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(3, 25);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(280, 494);
            this.treeView1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(286, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::CoffeeManagementSoftware.Properties.Resources.Add_32x32;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::CoffeeManagementSoftware.Properties.Resources.PenColor_32x32;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::CoffeeManagementSoftware.Properties.Resources.Article_32x32;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::CoffeeManagementSoftware.Properties.Resources.Report_32x32;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::CoffeeManagementSoftware.Properties.Resources.Refresh_32x32;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // txt_Purchase
            // 
            this.txt_Purchase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Purchase.Location = new System.Drawing.Point(713, 100);
            this.txt_Purchase.Name = "txt_Purchase";
            this.txt_Purchase.Size = new System.Drawing.Size(234, 21);
            this.txt_Purchase.TabIndex = 12;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã hàng";
            this.ID.Name = "ID";
            // 
            // NAME_ITEM
            // 
            this.NAME_ITEM.DataPropertyName = "NAME_ITEM";
            this.NAME_ITEM.HeaderText = "Tên hàng";
            this.NAME_ITEM.Name = "NAME_ITEM";
            // 
            // UNIT
            // 
            this.UNIT.DataPropertyName = "UNIT";
            this.UNIT.HeaderText = "Đơn vị tính";
            this.UNIT.Name = "UNIT";
            // 
            // PRICE_SELL
            // 
            this.PRICE_SELL.DataPropertyName = "PRICE_SELL";
            this.PRICE_SELL.HeaderText = "Giá bán";
            this.PRICE_SELL.Name = "PRICE_SELL";
            // 
            // PRICE_PURCHASE
            // 
            this.PRICE_PURCHASE.DataPropertyName = "PRICE_PURCHASE";
            this.PRICE_PURCHASE.HeaderText = "Giá nhập";
            this.PRICE_PURCHASE.Name = "PRICE_PURCHASE";
            // 
            // NAME_TYPE
            // 
            this.NAME_TYPE.DataPropertyName = "NAME_TYPE";
            this.NAME_TYPE.HeaderText = "Nhóm hàng";
            this.NAME_TYPE.Name = "NAME_TYPE";
            // 
            // STATUS
            // 
            this.STATUS.DataPropertyName = "STATUS";
            this.STATUS.HeaderText = "Trạng Thái";
            this.STATUS.Name = "STATUS";
            this.STATUS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ID_TYPE_ITEM";
            this.Column7.HeaderText = "ID_TYPE_NAME";
            this.Column7.Name = "Column7";
            this.Column7.Visible = false;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "ID_PRICE";
            this.Column8.HeaderText = "ID_PRICE";
            this.Column8.Name = "Column8";
            this.Column8.Visible = false;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "price";
            this.Column9.HeaderText = "price";
            this.Column9.Name = "Column9";
            this.Column9.Visible = false;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "type_item";
            this.Column10.HeaderText = "type_name";
            this.Column10.Name = "Column10";
            this.Column10.Visible = false;
            // 
            // frmItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 544);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnlNhomhang);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmItem";
            this.Text = "Danh mục mặt hàng";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Item)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlNhomhang.ResumeLayout(false);
            this.pnlNhomhang.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Item;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Unit;
        private System.Windows.Forms.ComboBox cbo_NameType;
        private System.Windows.Forms.Panel pnlNhomhang;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tSBThemmoi;
        private System.Windows.Forms.ToolStripButton tSBChinhsua;
        private System.Windows.Forms.ToolStripButton tSBXoa;
        private System.Windows.Forms.ToolStripButton tSBIn;
        private System.Windows.Forms.ToolStripButton tSBLoc;
        private System.Windows.Forms.ToolStripButton tSBDInhluong;
        private System.Windows.Forms.ToolStripButton tSBCapnhatgia;
        private System.Windows.Forms.TextBox txt_PriceSell;
        private System.Windows.Forms.Label txt_PricePur;
        private System.Windows.Forms.TextBox txt_Purchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE_SELL;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE_PURCHASE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}