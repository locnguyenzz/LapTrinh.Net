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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Chưa thiết lập", 1, 1);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Vàng");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Bạc đồng");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Đồng");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("VIP");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Thùng rác");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustumer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tSBCustumer = new System.Windows.Forms.ToolStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAddCustumer = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnCustumer1 = new System.Windows.Forms.ToolStripButton();
            this.btnCustumer2 = new System.Windows.Forms.ToolStripButton();
            this.btnXoaCustumer = new System.Windows.Forms.ToolStripButton();
            this.btnIn = new System.Windows.Forms.ToolStripButton();
            this.btnLoc = new System.Windows.Forms.ToolStripButton();
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
            this.tSBCustumer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Controls.Add(this.tSBCustumer);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 699);
            this.panel1.TabIndex = 0;
            // 
            // tSBCustumer
            // 
            this.tSBCustumer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tSBCustumer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tSBCustumer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddCustumer,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton1});
            this.tSBCustumer.Location = new System.Drawing.Point(0, 0);
            this.tSBCustumer.Name = "tSBCustumer";
            this.tSBCustumer.Size = new System.Drawing.Size(365, 27);
            this.tSBCustumer.TabIndex = 0;
            this.tSBCustumer.Text = "toolStrip1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.toolStrip2);
            this.panel2.Location = new System.Drawing.Point(384, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(968, 699);
            this.panel2.TabIndex = 1;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCustumer1,
            this.btnCustumer2,
            this.btnXoaCustumer,
            this.btnIn,
            this.btnLoc});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(968, 27);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.Window;
            this.treeView1.ImageKey = "BOLocalization_32x32.png";
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(3, 30);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Tất cả";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "Node2";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Text = "Chưa thiết lập";
            treeNode3.ImageIndex = 2;
            treeNode3.Name = "Node3";
            treeNode3.Text = "Vàng";
            treeNode4.ImageIndex = 3;
            treeNode4.Name = "Node4";
            treeNode4.Text = "Bạc đồng";
            treeNode5.ImageIndex = 4;
            treeNode5.Name = "Node5";
            treeNode5.Text = "Đồng";
            treeNode6.ImageIndex = 5;
            treeNode6.Name = "Node6";
            treeNode6.Text = "VIP";
            treeNode7.ImageIndex = 6;
            treeNode7.Name = "Node7";
            treeNode7.Text = "Thùng rác";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(165, 182);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "BOLocalization_32x32.png");
            this.imageList1.Images.SetKeyName(1, "IconSetTrafficLights3_32x32.png");
            this.imageList1.Images.SetKeyName(2, "gold.png");
            this.imageList1.Images.SetKeyName(3, "gold.png");
            this.imageList1.Images.SetKeyName(4, "gold.png");
            this.imageList1.Images.SetKeyName(5, "gold.png");
            this.imageList1.Images.SetKeyName(6, "Trash_32x32.png");
            // 
            // btnAddCustumer
            // 
            this.btnAddCustumer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddCustumer.Image = global::CoffeeManagementSoftware.Properties.Resources.Add_32x32;
            this.btnAddCustumer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddCustumer.Name = "btnAddCustumer";
            this.btnAddCustumer.Size = new System.Drawing.Size(24, 24);
            this.btnAddCustumer.Text = "Thêm mới thành viên";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::CoffeeManagementSoftware.Properties.Resources.pencolor_32x32;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::CoffeeManagementSoftware.Properties.Resources.open_16x16;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::CoffeeManagementSoftware.Properties.Resources.gradientlightbluedatabar_32x32;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::CoffeeManagementSoftware.Properties.Resources.Refresh_32x32;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // btnCustumer1
            // 
            this.btnCustumer1.Image = global::CoffeeManagementSoftware.Properties.Resources.Add_32x32;
            this.btnCustumer1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustumer1.Name = "btnCustumer1";
            this.btnCustumer1.Size = new System.Drawing.Size(150, 24);
            this.btnCustumer1.Text = "Thêm mới (Insert)";
            this.btnCustumer1.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // btnCustumer2
            // 
            this.btnCustumer2.Image = global::CoffeeManagementSoftware.Properties.Resources.pencolor_32x32;
            this.btnCustumer2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustumer2.Name = "btnCustumer2";
            this.btnCustumer2.Size = new System.Drawing.Size(97, 24);
            this.btnCustumer2.Text = "Chỉnh sửa";
            // 
            // btnXoaCustumer
            // 
            this.btnXoaCustumer.Image = global::CoffeeManagementSoftware.Properties.Resources.Delete_16x16;
            this.btnXoaCustumer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaCustumer.Name = "btnXoaCustumer";
            this.btnXoaCustumer.Size = new System.Drawing.Size(96, 24);
            this.btnXoaCustumer.Text = "Xóa (Del)";
            // 
            // btnIn
            // 
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(45, 24);
            this.btnIn.Text = "In";
            // 
            // btnLoc
            // 
            this.btnLoc.Image = ((System.Drawing.Image)(resources.GetObject("btnLoc.Image")));
            this.btnLoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(56, 24);
            this.btnLoc.Text = "Lọc";
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(844, 150);
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
            this.PhoneC.HeaderText = "Điện thoại";
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
            this.ClientSize = new System.Drawing.Size(1364, 724);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmCustumer";
            this.Text = "frmCustumer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tSBCustumer.ResumeLayout(false);
            this.tSBCustumer.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip tSBCustumer;
        private System.Windows.Forms.ToolStripButton btnAddCustumer;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripButton btnCustumer1;
        private System.Windows.Forms.ToolStripButton btnCustumer2;
        private System.Windows.Forms.ToolStripButton btnXoaCustumer;
        private System.Windows.Forms.ToolStripButton btnIn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameC;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneC;
        private System.Windows.Forms.DataGridViewTextBoxColumn RankC;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailC;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaxC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoteC;
        private System.Windows.Forms.ToolStripButton btnLoc;
    }
}