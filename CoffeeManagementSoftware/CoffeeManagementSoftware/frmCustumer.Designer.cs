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
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Tất cả");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Chưa thiết lập");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Vàng");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Bạc");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Đồng");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("VIP");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Thùng rác");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustumer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnThemmoiC = new System.Windows.Forms.ToolStripButton();
            this.btnChinhsuaC = new System.Windows.Forms.ToolStripButton();
            this.btnDelC = new System.Windows.Forms.ToolStripButton();
            this.btnInC = new System.Windows.Forms.ToolStripButton();
            this.btnLocC = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RankC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaxC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoteC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 601);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.toolStrip2);
            this.panel2.Location = new System.Drawing.Point(285, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(898, 601);
            this.panel2.TabIndex = 1;
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
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemmoiC,
            this.btnChinhsuaC,
            this.btnDelC,
            this.btnInC,
            this.btnLocC});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(898, 27);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
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
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(4, 31);
            this.treeView1.Name = "treeView1";
            treeNode8.Name = " trvTatca";
            treeNode8.Text = "Tất cả";
            treeNode9.ImageIndex = 1;
            treeNode9.Name = "trvChuathietlap";
            treeNode9.Text = "Chưa thiết lập";
            treeNode10.ImageIndex = 2;
            treeNode10.Name = "trvVang";
            treeNode10.Text = "Vàng";
            treeNode11.ImageIndex = 2;
            treeNode11.Name = "trvBac";
            treeNode11.Text = "Bạc";
            treeNode12.ImageIndex = 2;
            treeNode12.Name = "trvDong";
            treeNode12.Text = "Đồng";
            treeNode13.ImageIndex = 2;
            treeNode13.Name = "trvVIP";
            treeNode13.Text = "VIP";
            treeNode14.ImageIndex = 3;
            treeNode14.Name = "trvTrash";
            treeNode14.Text = "Thùng rác";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(258, 567);
            this.treeView1.TabIndex = 1;
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
            // btnThemmoiC
            // 
            this.btnThemmoiC.Image = global::CoffeeManagementSoftware.Properties.Resources.Add_32x32;
            this.btnThemmoiC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemmoiC.Name = "btnThemmoiC";
            this.btnThemmoiC.Size = new System.Drawing.Size(150, 24);
            this.btnThemmoiC.Text = "Thêm mới (Insert)";
            this.btnThemmoiC.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // btnChinhsuaC
            // 
            this.btnChinhsuaC.Image = global::CoffeeManagementSoftware.Properties.Resources.PenColor_32x32;
            this.btnChinhsuaC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChinhsuaC.Name = "btnChinhsuaC";
            this.btnChinhsuaC.Size = new System.Drawing.Size(97, 24);
            this.btnChinhsuaC.Text = "Chỉnh sửa";
            // 
            // btnDelC
            // 
            this.btnDelC.Image = global::CoffeeManagementSoftware.Properties.Resources.Delete_16x16;
            this.btnDelC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelC.Name = "btnDelC";
            this.btnDelC.Size = new System.Drawing.Size(96, 24);
            this.btnDelC.Text = "Xóa (Del)";
            // 
            // btnInC
            // 
            this.btnInC.Image = ((System.Drawing.Image)(resources.GetObject("btnInC.Image")));
            this.btnInC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInC.Name = "btnInC";
            this.btnInC.Size = new System.Drawing.Size(45, 24);
            this.btnInC.Text = "In";
            // 
            // btnLocC
            // 
            this.btnLocC.Image = global::CoffeeManagementSoftware.Properties.Resources.Lookup_Reference_32x32;
            this.btnLocC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLocC.Name = "btnLocC";
            this.btnLocC.Size = new System.Drawing.Size(56, 24);
            this.btnLocC.Text = "Lọc";
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
            this.dataGridView1.Size = new System.Drawing.Size(891, 567);
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
            // frmCustumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 626);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmCustumer";
            this.Text = "Khách hàng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton btnThemmoiC;
        private System.Windows.Forms.ToolStripButton btnChinhsuaC;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameC;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneC;
        private System.Windows.Forms.DataGridViewTextBoxColumn RankC;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailC;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaxC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoteC;
        private System.Windows.Forms.ToolStripButton btnDelC;
        private System.Windows.Forms.ToolStripButton btnInC;
        private System.Windows.Forms.ToolStripButton btnLocC;
    }
}