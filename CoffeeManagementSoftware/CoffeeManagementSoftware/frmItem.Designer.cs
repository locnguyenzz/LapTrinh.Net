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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItem));
            this.dgv_Item = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE_SELL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE_PURCHASE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Unit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_NameType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_PricePur = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_PriceSell = new System.Windows.Forms.TextBox();
            this.txt_Purchase = new System.Windows.Forms.TextBox();
            this.txt_Number = new System.Windows.Forms.TextBox();
            this.btn_AddNewType = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Item)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Item
            // 
            this.dgv_Item.AllowUserToAddRows = false;
            this.dgv_Item.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow;
            this.dgv_Item.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Item.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Item.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Item.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NAME_ITEM,
            this.UNIT,
            this.PRICE_SELL,
            this.PRICE_PURCHASE,
            this.NUMBER,
            this.NAME_TYPE,
            this.STATUS,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.tableLayoutPanel1.SetColumnSpan(this.dgv_Item, 4);
            this.dgv_Item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Item.Location = new System.Drawing.Point(3, 155);
            this.dgv_Item.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Item.Name = "dgv_Item";
            this.dgv_Item.ReadOnly = true;
            this.dgv_Item.RowTemplate.Height = 24;
            this.dgv_Item.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Item.Size = new System.Drawing.Size(1267, 355);
            this.dgv_Item.TabIndex = 1;
            this.dgv_Item.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Item_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã hàng";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NAME_ITEM
            // 
            this.NAME_ITEM.DataPropertyName = "NAME_ITEM";
            this.NAME_ITEM.HeaderText = "Tên hàng";
            this.NAME_ITEM.Name = "NAME_ITEM";
            this.NAME_ITEM.ReadOnly = true;
            // 
            // UNIT
            // 
            this.UNIT.DataPropertyName = "UNIT";
            this.UNIT.HeaderText = "Đơn vị tính";
            this.UNIT.Name = "UNIT";
            this.UNIT.ReadOnly = true;
            // 
            // PRICE_SELL
            // 
            this.PRICE_SELL.DataPropertyName = "PRICE_SELL";
            this.PRICE_SELL.HeaderText = "Giá bán";
            this.PRICE_SELL.Name = "PRICE_SELL";
            this.PRICE_SELL.ReadOnly = true;
            // 
            // PRICE_PURCHASE
            // 
            this.PRICE_PURCHASE.DataPropertyName = "PRICE_PURCHASE";
            this.PRICE_PURCHASE.HeaderText = "Giá nhập";
            this.PRICE_PURCHASE.Name = "PRICE_PURCHASE";
            this.PRICE_PURCHASE.ReadOnly = true;
            // 
            // NUMBER
            // 
            this.NUMBER.DataPropertyName = "NUMBER";
            this.NUMBER.HeaderText = "Số Lượng";
            this.NUMBER.Name = "NUMBER";
            this.NUMBER.ReadOnly = true;
            // 
            // NAME_TYPE
            // 
            this.NAME_TYPE.DataPropertyName = "NAME_TYPE";
            this.NAME_TYPE.HeaderText = "Nhóm hàng";
            this.NAME_TYPE.Name = "NAME_TYPE";
            this.NAME_TYPE.ReadOnly = true;
            // 
            // STATUS
            // 
            this.STATUS.DataPropertyName = "STATUS";
            this.STATUS.HeaderText = "Trạng Thái";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            this.STATUS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ID_TYPE_ITEM";
            this.Column7.HeaderText = "ID_TYPE_NAME";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "ID_PRICE";
            this.Column8.HeaderText = "ID_PRICE";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "price";
            this.Column9.HeaderText = "price";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "type_item";
            this.Column10.HeaderText = "type_name";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1287, 544);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1279, 518);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mặt hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.58287F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.16732F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.29065F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.8806F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv_Item, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_ID, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_Name, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_Unit, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbo_NameType, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_PricePur, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_PriceSell, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_Purchase, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_Number, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_AddNewType, 2, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.470841F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.664063F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.92188F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1273, 512);
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
            this.toolStrip2.Size = new System.Drawing.Size(1273, 31);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tSBThemmoi
            // 
            this.tSBThemmoi.Image = global::CoffeeManagementSoftware.Properties.Resources.Add_32x32;
            this.tSBThemmoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBThemmoi.Name = "tSBThemmoi";
            this.tSBThemmoi.Size = new System.Drawing.Size(125, 28);
            this.tSBThemmoi.Text = "Thêm mới (Insert)";
            this.tSBThemmoi.Click += new System.EventHandler(this.tSBThemmoi_Click);
            // 
            // tSBChinhsua
            // 
            this.tSBChinhsua.Image = global::CoffeeManagementSoftware.Properties.Resources.Refresh_32x32;
            this.tSBChinhsua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBChinhsua.Name = "tSBChinhsua";
            this.tSBChinhsua.Size = new System.Drawing.Size(84, 28);
            this.tSBChinhsua.Text = "Chỉnh sửa";
            this.tSBChinhsua.Click += new System.EventHandler(this.tSBChinhsua_Click);
            // 
            // tSBXoa
            // 
            this.tSBXoa.Image = global::CoffeeManagementSoftware.Properties.Resources.Delete_16x16;
            this.tSBXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBXoa.Name = "tSBXoa";
            this.tSBXoa.Size = new System.Drawing.Size(79, 28);
            this.tSBXoa.Text = "Xóa (Del)";
            this.tSBXoa.Click += new System.EventHandler(this.tSBXoa_Click);
            // 
            // tSBIn
            // 
            this.tSBIn.Image = ((System.Drawing.Image)(resources.GetObject("tSBIn.Image")));
            this.tSBIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBIn.Name = "tSBIn";
            this.tSBIn.Size = new System.Drawing.Size(41, 28);
            this.tSBIn.Text = "In";
            // 
            // tSBLoc
            // 
            this.tSBLoc.Image = global::CoffeeManagementSoftware.Properties.Resources.Lookup_Reference_32x32;
            this.tSBLoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBLoc.Name = "tSBLoc";
            this.tSBLoc.Size = new System.Drawing.Size(50, 28);
            this.tSBLoc.Text = "Lọc";
            // 
            // tSBDInhluong
            // 
            this.tSBDInhluong.Image = ((System.Drawing.Image)(resources.GetObject("tSBDInhluong.Image")));
            this.tSBDInhluong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBDInhluong.Name = "tSBDInhluong";
            this.tSBDInhluong.Size = new System.Drawing.Size(128, 28);
            this.tSBDInhluong.Text = "Import định lượng";
            // 
            // tSBCapnhatgia
            // 
            this.tSBCapnhatgia.Image = ((System.Drawing.Image)(resources.GetObject("tSBCapnhatgia.Image")));
            this.tSBCapnhatgia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBCapnhatgia.Name = "tSBCapnhatgia";
            this.tSBCapnhatgia.Size = new System.Drawing.Size(142, 28);
            this.tSBCapnhatgia.Text = "Cập nhật giá từ excel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(587, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(587, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(587, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đơn vị tính";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_ID
            // 
            this.txt_ID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ID.Location = new System.Drawing.Point(596, 34);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(238, 21);
            this.txt_ID.TabIndex = 8;
            // 
            // txt_Name
            // 
            this.txt_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Name.Location = new System.Drawing.Point(596, 65);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(238, 21);
            this.txt_Name.TabIndex = 9;
            // 
            // txt_Unit
            // 
            this.txt_Unit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Unit.Location = new System.Drawing.Point(596, 97);
            this.txt_Unit.Name = "txt_Unit";
            this.txt_Unit.Size = new System.Drawing.Size(238, 21);
            this.txt_Unit.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(587, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nhóm hàng";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbo_NameType
            // 
            this.cbo_NameType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_NameType.FormattingEnabled = true;
            this.cbo_NameType.Location = new System.Drawing.Point(596, 125);
            this.cbo_NameType.Name = "cbo_NameType";
            this.cbo_NameType.Size = new System.Drawing.Size(238, 21);
            this.cbo_NameType.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(840, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Giá bán";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_PricePur
            // 
            this.txt_PricePur.AutoSize = true;
            this.txt_PricePur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_PricePur.Location = new System.Drawing.Point(840, 62);
            this.txt_PricePur.Name = "txt_PricePur";
            this.txt_PricePur.Size = new System.Drawing.Size(125, 32);
            this.txt_PricePur.TabIndex = 17;
            this.txt_PricePur.Text = "Giá nhập";
            this.txt_PricePur.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(840, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 28);
            this.label6.TabIndex = 18;
            this.label6.Text = "Số lượng";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_PriceSell
            // 
            this.txt_PriceSell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_PriceSell.Location = new System.Drawing.Point(971, 34);
            this.txt_PriceSell.Name = "txt_PriceSell";
            this.txt_PriceSell.Size = new System.Drawing.Size(299, 21);
            this.txt_PriceSell.TabIndex = 11;
            // 
            // txt_Purchase
            // 
            this.txt_Purchase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Purchase.Location = new System.Drawing.Point(971, 65);
            this.txt_Purchase.Name = "txt_Purchase";
            this.txt_Purchase.Size = new System.Drawing.Size(299, 21);
            this.txt_Purchase.TabIndex = 12;
            // 
            // txt_Number
            // 
            this.txt_Number.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Number.Location = new System.Drawing.Point(971, 97);
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(299, 21);
            this.txt_Number.TabIndex = 19;
            // 
            // btn_AddNewType
            // 
            this.btn_AddNewType.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_AddNewType.Location = new System.Drawing.Point(840, 125);
            this.btn_AddNewType.Name = "btn_AddNewType";
            this.btn_AddNewType.Size = new System.Drawing.Size(45, 25);
            this.btn_AddNewType.TabIndex = 20;
            this.btn_AddNewType.Text = "...";
            this.btn_AddNewType.Click += new System.EventHandler(this.btn_AddNewType_Click);
            // 
            // frmItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 544);
            this.Controls.Add(this.tabControl1);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE_SELL;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE_PURCHASE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private DevExpress.XtraEditors.SimpleButton btn_AddNewType;
    }
}