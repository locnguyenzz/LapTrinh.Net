namespace CoffeeManagementSoftware
{
    partial class frmInventory
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
            this.dgv_Inventory = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_AddNew = new System.Windows.Forms.ToolStripButton();
            this.btn_Delete = new System.Windows.Forms.ToolStripButton();
            this.btn_Edit = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_Item = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inventory)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Inventory
            // 
            this.dgv_Inventory.AllowUserToAddRows = false;
            this.dgv_Inventory.AllowUserToDeleteRows = false;
            this.dgv_Inventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Inventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NAME_ITEM,
            this.ID_ITEM,
            this.UNIT,
            this.NUMBER});
            this.tableLayoutPanel1.SetColumnSpan(this.dgv_Inventory, 3);
            this.dgv_Inventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Inventory.Location = new System.Drawing.Point(3, 97);
            this.dgv_Inventory.Name = "dgv_Inventory";
            this.dgv_Inventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Inventory.Size = new System.Drawing.Size(720, 307);
            this.dgv_Inventory.TabIndex = 0;
            this.dgv_Inventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Inventory_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã phiếu";
            this.ID.Name = "ID";
            // 
            // NAME_ITEM
            // 
            this.NAME_ITEM.DataPropertyName = "NAME_ITEM";
            this.NAME_ITEM.HeaderText = "Mặt hàng";
            this.NAME_ITEM.Name = "NAME_ITEM";
            // 
            // ID_ITEM
            // 
            this.ID_ITEM.DataPropertyName = "ID_ITEM";
            this.ID_ITEM.HeaderText = "ID_ITEM";
            this.ID_ITEM.Name = "ID_ITEM";
            this.ID_ITEM.Visible = false;
            // 
            // UNIT
            // 
            this.UNIT.DataPropertyName = "UNIT";
            this.UNIT.HeaderText = "Đơn vị tính";
            this.UNIT.Name = "UNIT";
            // 
            // NUMBER
            // 
            this.NUMBER.DataPropertyName = "NUMBER";
            this.NUMBER.HeaderText = "Tồn";
            this.NUMBER.Name = "NUMBER";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv_Inventory, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_ID, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbo_Item, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.31941F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.388206F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.388206F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.90417F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(726, 407);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.toolStrip1, 3);
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_AddNew,
            this.btn_Delete,
            this.btn_Edit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(726, 42);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_AddNew
            // 
            this.btn_AddNew.Image = global::CoffeeManagementSoftware.Properties.Resources.Add_32x32;
            this.btn_AddNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_AddNew.Name = "btn_AddNew";
            this.btn_AddNew.Size = new System.Drawing.Size(69, 39);
            this.btn_AddNew.Text = "Thêm";
            this.btn_AddNew.Click += new System.EventHandler(this.btn_AddNew_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Image = global::CoffeeManagementSoftware.Properties.Resources.Remove_32x32;
            this.btn_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(56, 39);
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Image = global::CoffeeManagementSoftware.Properties.Resources.Refresh_32x32;
            this.btn_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(56, 39);
            this.btn_Edit.Text = "Sửa";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(245, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã phiếu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_ID
            // 
            this.txt_ID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ID.Location = new System.Drawing.Point(487, 45);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(236, 21);
            this.txt_ID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(245, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mặt hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbo_Item
            // 
            this.cbo_Item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_Item.FormattingEnabled = true;
            this.cbo_Item.Location = new System.Drawing.Point(487, 71);
            this.cbo_Item.Name = "cbo_Item";
            this.cbo_Item.Size = new System.Drawing.Size(236, 21);
            this.cbo_Item.TabIndex = 4;
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 407);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmInventory";
            this.Text = "frmInventory";
            this.Load += new System.EventHandler(this.frmInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inventory)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Inventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMBER;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_AddNew;
        private System.Windows.Forms.ToolStripButton btn_Delete;
        private System.Windows.Forms.ToolStripButton btn_Edit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_Item;
    }
}