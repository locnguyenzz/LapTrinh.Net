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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Tất cả");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Chưa thiết lập");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Vàng");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Bạc");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Đồng");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("VIP");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Thùng rác");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustumer));
            this.pnlThanhvien = new System.Windows.Forms.Panel();
            this.trvThanhvien = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pnlKhachhang = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RankC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaxC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoteC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tSBThemmoiC = new System.Windows.Forms.ToolStripButton();
            this.tSBChinhsuaC = new System.Windows.Forms.ToolStripButton();
            this.tSBDelC = new System.Windows.Forms.ToolStripButton();
            this.tSBInC = new System.Windows.Forms.ToolStripButton();
            this.tSBLocC = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.pnlThanhvien.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pnlKhachhang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlThanhvien
            // 
            this.pnlThanhvien.Controls.Add(this.trvThanhvien);
            this.pnlThanhvien.Controls.Add(this.toolStrip1);
            this.pnlThanhvien.Location = new System.Drawing.Point(13, 13);
            this.pnlThanhvien.Name = "pnlThanhvien";
            this.pnlThanhvien.Size = new System.Drawing.Size(266, 601);
            this.pnlThanhvien.TabIndex = 0;
            // 
            // trvThanhvien
            // 
            this.trvThanhvien.ImageIndex = 0;
            this.trvThanhvien.ImageList = this.imageList1;
            this.trvThanhvien.Location = new System.Drawing.Point(4, 31);
            this.trvThanhvien.Name = "trvThanhvien";
            treeNode1.Name = " trvTatca";
            treeNode1.Text = "Tất cả";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "trvChuathietlap";
            treeNode2.Text = "Chưa thiết lập";
            treeNode3.ImageIndex = 2;
            treeNode3.Name = "trvVang";
            treeNode3.Text = "Vàng";
            treeNode4.ImageIndex = 2;
            treeNode4.Name = "trvBac";
            treeNode4.Text = "Bạc";
            treeNode5.ImageIndex = 2;
            treeNode5.Name = "trvDong";
            treeNode5.Text = "Đồng";
            treeNode6.ImageIndex = 2;
            treeNode6.Name = "trvVIP";
            treeNode6.Text = "VIP";
            treeNode7.ImageIndex = 3;
            treeNode7.Name = "trvTrash";
            treeNode7.Text = "Thùng rác";
            this.trvThanhvien.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            this.trvThanhvien.SelectedImageIndex = 0;
            this.trvThanhvien.Size = new System.Drawing.Size(259, 567);
            this.trvThanhvien.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Shape_32x32.png");
            this.imageList1.Images.SetKeyName(1, "None_32x32.png");
            this.imageList1.Images.SetKeyName(2, "BORole_16x16.png");
            this.imageList1.Images.SetKeyName(3, "Trash_32x32.png");
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
            this.toolStrip1.Size = new System.Drawing.Size(266, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pnlKhachhang
            // 
            this.pnlKhachhang.Controls.Add(this.dataGridView1);
            this.pnlKhachhang.Controls.Add(this.toolStrip2);
            this.pnlKhachhang.Location = new System.Drawing.Point(285, 13);
            this.pnlKhachhang.Name = "pnlKhachhang";
            this.pnlKhachhang.Size = new System.Drawing.Size(898, 601);
            this.pnlKhachhang.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NameC,
            this.AddressC,
            this.PhoneC,
            this.RankC,
            this.EmailC,
            this.FaxC,
            this.NoteC});
            this.dataGridView1.Location = new System.Drawing.Point(4, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(876, 570);
            this.dataGridView1.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "Mã";
            this.ID.Name = "ID";
            // 
            // NameC
            // 
            this.NameC.HeaderText = "Tên khách";
            this.NameC.Name = "NameC";
            // 
            // AddressC
            // 
            this.AddressC.HeaderText = "Địa chỉ";
            this.AddressC.Name = "AddressC";
            // 
            // PhoneC
            // 
            this.PhoneC.HeaderText = "Phone";
            this.PhoneC.Name = "PhoneC";
            // 
            // RankC
            // 
            this.RankC.HeaderText = "Thành viên";
            this.RankC.Name = "RankC";
            // 
            // EmailC
            // 
            this.EmailC.HeaderText = "Email";
            this.EmailC.Name = "EmailC";
            // 
            // FaxC
            // 
            this.FaxC.HeaderText = "Fax";
            this.FaxC.Name = "FaxC";
            // 
            // NoteC
            // 
            this.NoteC.HeaderText = "Ghi chú";
            this.NoteC.Name = "NoteC";
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBThemmoiC,
            this.tSBChinhsuaC,
            this.tSBDelC,
            this.tSBInC,
            this.tSBLocC});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(898, 27);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tSBThemmoiC
            // 
            this.tSBThemmoiC.Image = global::CoffeeManagementSoftware.Properties.Resources.Add_32x32;
            this.tSBThemmoiC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBThemmoiC.Name = "tSBThemmoiC";
            this.tSBThemmoiC.Size = new System.Drawing.Size(150, 24);
            this.tSBThemmoiC.Text = "Thêm mới (Insert)";
            this.tSBThemmoiC.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // tSBChinhsuaC
            // 
            this.tSBChinhsuaC.Image = global::CoffeeManagementSoftware.Properties.Resources.PenColor_32x32;
            this.tSBChinhsuaC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBChinhsuaC.Name = "tSBChinhsuaC";
            this.tSBChinhsuaC.Size = new System.Drawing.Size(97, 24);
            this.tSBChinhsuaC.Text = "Chỉnh sửa";
            // 
            // tSBDelC
            // 
            this.tSBDelC.Image = global::CoffeeManagementSoftware.Properties.Resources.Delete_16x16;
            this.tSBDelC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBDelC.Name = "tSBDelC";
            this.tSBDelC.Size = new System.Drawing.Size(96, 24);
            this.tSBDelC.Text = "Xóa (Del)";
            // 
            // tSBInC
            // 
            this.tSBInC.Image = ((System.Drawing.Image)(resources.GetObject("tSBInC.Image")));
            this.tSBInC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBInC.Name = "tSBInC";
            this.tSBInC.Size = new System.Drawing.Size(45, 24);
            this.tSBInC.Text = "In";
            // 
            // tSBLocC
            // 
            this.tSBLocC.Image = global::CoffeeManagementSoftware.Properties.Resources.Lookup_Reference_32x32;
            this.tSBLocC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBLocC.Name = "tSBLocC";
            this.tSBLocC.Size = new System.Drawing.Size(56, 24);
            this.tSBLocC.Text = "Lọc";
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
            // frmCustumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 626);
            this.Controls.Add(this.pnlKhachhang);
            this.Controls.Add(this.pnlThanhvien);
            this.Name = "frmCustumer";
            this.Text = "Khách hàng";
            this.pnlThanhvien.ResumeLayout(false);
            this.pnlThanhvien.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlKhachhang.ResumeLayout(false);
            this.pnlKhachhang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlThanhvien;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Panel pnlKhachhang;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.TreeView trvThanhvien;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton tSBThemmoiC;
        private System.Windows.Forms.ToolStripButton tSBChinhsuaC;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameC;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneC;
        private System.Windows.Forms.DataGridViewTextBoxColumn RankC;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailC;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaxC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoteC;
        private System.Windows.Forms.ToolStripButton tSBDelC;
        private System.Windows.Forms.ToolStripButton tSBInC;
        private System.Windows.Forms.ToolStripButton tSBLocC;
    }
}