namespace CoffeeManagementSoftware
{
    partial class frmSell
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaPhieuBan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTaoPN = new System.Windows.Forms.Button();
            this.cbo_Ban = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNgayBan = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.dgvCTPN = new System.Windows.Forms.DataGridView();
            this.ctm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbMaSanPham = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_MaPhieuBan = new System.Windows.Forms.ComboBox();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.MaPhieuBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receipt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_RECEIPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receipt_import = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_TABLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).BeginInit();
            this.ctm.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtThanhTien);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaPhieuBan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnTaoPN);
            this.groupBox1.Controls.Add(this.cbo_Ban);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNgayBan);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu Bán";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(380, 72);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(154, 21);
            this.txtThanhTien.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Thành Tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày Bán";
            // 
            // txtMaPhieuBan
            // 
            this.txtMaPhieuBan.Location = new System.Drawing.Point(87, 29);
            this.txtMaPhieuBan.Name = "txtMaPhieuBan";
            this.txtMaPhieuBan.Size = new System.Drawing.Size(164, 21);
            this.txtMaPhieuBan.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bàn";
            // 
            // btnTaoPN
            // 
            this.btnTaoPN.Image = global::CoffeeManagementSoftware.Properties.Resources.Add_32x32;
            this.btnTaoPN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoPN.Location = new System.Drawing.Point(7, 117);
            this.btnTaoPN.Name = "btnTaoPN";
            this.btnTaoPN.Size = new System.Drawing.Size(115, 36);
            this.btnTaoPN.TabIndex = 3;
            this.btnTaoPN.Text = "Tạo Phiếu Bán";
            this.btnTaoPN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaoPN.UseVisualStyleBackColor = true;
            this.btnTaoPN.Click += new System.EventHandler(this.btnTaoPN_Click);
            // 
            // cbo_Ban
            // 
            this.cbo_Ban.FormattingEnabled = true;
            this.cbo_Ban.Location = new System.Drawing.Point(380, 29);
            this.cbo_Ban.Name = "cbo_Ban";
            this.cbo_Ban.Size = new System.Drawing.Size(154, 21);
            this.cbo_Ban.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Phiếu Xuất";
            // 
            // txtNgayBan
            // 
            this.txtNgayBan.Location = new System.Drawing.Point(87, 76);
            this.txtNgayBan.Mask = "00/00/0000";
            this.txtNgayBan.Name = "txtNgayBan";
            this.txtNgayBan.Size = new System.Drawing.Size(164, 21);
            this.txtNgayBan.TabIndex = 0;
            this.txtNgayBan.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThemSP);
            this.groupBox2.Controls.Add(this.dgvCTPN);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtDonGia);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbbMaSanPham);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbo_MaPhieuBan);
            this.groupBox2.Location = new System.Drawing.Point(7, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(555, 264);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết phiếu bán";
            // 
            // btnThemSP
            // 
            this.btnThemSP.Image = global::CoffeeManagementSoftware.Properties.Resources.Add_32x32;
            this.btnThemSP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThemSP.Location = new System.Drawing.Point(6, 104);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(75, 67);
            this.btnThemSP.TabIndex = 16;
            this.btnThemSP.Text = "Thêm Sản Phẩm";
            this.btnThemSP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThemSP.UseVisualStyleBackColor = true;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // dgvCTPN
            // 
            this.dgvCTPN.AllowUserToAddRows = false;
            this.dgvCTPN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuBan,
            this.receipt,
            this.table,
            this.item,
            this.ID_RECEIPT,
            this.receipt_import,
            this.STATUS,
            this.MaSanPham,
            this.SoLuong,
            this.DonGia,
            this.ID_TABLE});
            this.dgvCTPN.ContextMenuStrip = this.ctm;
            this.dgvCTPN.Location = new System.Drawing.Point(86, 98);
            this.dgvCTPN.Name = "dgvCTPN";
            this.dgvCTPN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTPN.Size = new System.Drawing.Size(463, 160);
            this.dgvCTPN.TabIndex = 15;
            this.dgvCTPN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTPN_CellClick);
            // 
            // ctm
            // 
            this.ctm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sửaToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.ctm.Name = "ctm";
            this.ctm.Size = new System.Drawing.Size(95, 48);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.sửaToolStripMenuItem.Text = "Sửa";
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(378, 63);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(155, 21);
            this.txtSoLuong.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Số lượng";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(95, 60);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(155, 21);
            this.txtDonGia.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Đơn Giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mã Sản Phẩm";
            // 
            // cbbMaSanPham
            // 
            this.cbbMaSanPham.FormattingEnabled = true;
            this.cbbMaSanPham.Location = new System.Drawing.Point(379, 27);
            this.cbbMaSanPham.Name = "cbbMaSanPham";
            this.cbbMaSanPham.Size = new System.Drawing.Size(154, 21);
            this.cbbMaSanPham.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mã Phiếu Xuất";
            // 
            // cbo_MaPhieuBan
            // 
            this.cbo_MaPhieuBan.FormattingEnabled = true;
            this.cbo_MaPhieuBan.Location = new System.Drawing.Point(95, 23);
            this.cbo_MaPhieuBan.Name = "cbo_MaPhieuBan";
            this.cbo_MaPhieuBan.Size = new System.Drawing.Size(154, 21);
            this.cbo_MaPhieuBan.TabIndex = 17;
            this.cbo_MaPhieuBan.SelectedIndexChanged += new System.EventHandler(this.cbo_MaPhieuBan_SelectedIndexChanged);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // MaPhieuBan
            // 
            this.MaPhieuBan.DataPropertyName = "ID";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aqua;
            this.MaPhieuBan.DefaultCellStyle = dataGridViewCellStyle1;
            this.MaPhieuBan.HeaderText = "Mã Phiếu Xuất";
            this.MaPhieuBan.Name = "MaPhieuBan";
            this.MaPhieuBan.ReadOnly = true;
            // 
            // receipt
            // 
            this.receipt.DataPropertyName = "receipt";
            this.receipt.HeaderText = "Column1";
            this.receipt.Name = "receipt";
            this.receipt.Visible = false;
            // 
            // table
            // 
            this.table.DataPropertyName = "table";
            this.table.HeaderText = "Column1";
            this.table.Name = "table";
            this.table.Visible = false;
            // 
            // item
            // 
            this.item.DataPropertyName = "item";
            this.item.HeaderText = "Column1";
            this.item.Name = "item";
            this.item.Visible = false;
            // 
            // ID_RECEIPT
            // 
            this.ID_RECEIPT.DataPropertyName = "ID_RECEIPT";
            this.ID_RECEIPT.HeaderText = "Column1";
            this.ID_RECEIPT.Name = "ID_RECEIPT";
            this.ID_RECEIPT.Visible = false;
            // 
            // receipt_import
            // 
            this.receipt_import.DataPropertyName = "receipt_import";
            this.receipt_import.HeaderText = "Column1";
            this.receipt_import.Name = "receipt_import";
            this.receipt_import.Visible = false;
            // 
            // STATUS
            // 
            this.STATUS.DataPropertyName = "STATUS";
            this.STATUS.HeaderText = "Column1";
            this.STATUS.Name = "STATUS";
            this.STATUS.Visible = false;
            // 
            // MaSanPham
            // 
            this.MaSanPham.DataPropertyName = "ID_ITEM";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Aqua;
            this.MaSanPham.DefaultCellStyle = dataGridViewCellStyle2;
            this.MaSanPham.HeaderText = "Mã Sản Phẩm";
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "NUMBER";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Yellow;
            this.SoLuong.DefaultCellStyle = dataGridViewCellStyle3;
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "PRICE_SELL";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Yellow;
            this.DonGia.DefaultCellStyle = dataGridViewCellStyle4;
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            // 
            // ID_TABLE
            // 
            this.ID_TABLE.DataPropertyName = "ID_TABLE";
            this.ID_TABLE.HeaderText = "Column1";
            this.ID_TABLE.Name = "ID_TABLE";
            this.ID_TABLE.Visible = false;
            // 
            // frmSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 454);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHIẾU BÁN HÀNG";
            this.Load += new System.EventHandler(this.frmSell_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).EndInit();
            this.ctm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaPhieuBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTaoPN;
        private System.Windows.Forms.ComboBox cbo_Ban;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtNgayBan;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbMaSanPham;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_MaPhieuBan;
        private System.Windows.Forms.DataGridView dgvCTPN;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.ContextMenuStrip ctm;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn receipt;
        private System.Windows.Forms.DataGridViewTextBoxColumn table;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_RECEIPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn receipt_import;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TABLE;

        
    }
}