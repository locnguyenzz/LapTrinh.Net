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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Inventory = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE_SELL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE_PURCHASE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_TYPE_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Refresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inventory)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Inventory
            // 
            this.dgv_Inventory.AllowUserToAddRows = false;
            this.dgv_Inventory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow;
            this.dgv_Inventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Inventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Inventory.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Inventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PRICE_SELL,
            this.PRICE_PURCHASE,
            this.ID_TYPE_ITEM,
            this.STATUS,
            this.NAME_TYPE,
            this.type_item,
            this.NAME_ITEM,
            this.ID_ITEM,
            this.UNIT,
            this.NUMBER});
            this.tableLayoutPanel1.SetColumnSpan(this.dgv_Inventory, 3);
            this.dgv_Inventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Inventory.Location = new System.Drawing.Point(3, 42);
            this.dgv_Inventory.Name = "dgv_Inventory";
            this.dgv_Inventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Inventory.Size = new System.Drawing.Size(720, 362);
            this.dgv_Inventory.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã phiếu";
            this.ID.Name = "ID";
            // 
            // PRICE_SELL
            // 
            this.PRICE_SELL.DataPropertyName = "PRICE_SELL";
            this.PRICE_SELL.HeaderText = "Column1";
            this.PRICE_SELL.Name = "PRICE_SELL";
            this.PRICE_SELL.Visible = false;
            // 
            // PRICE_PURCHASE
            // 
            this.PRICE_PURCHASE.DataPropertyName = "PRICE_PURCHASE";
            this.PRICE_PURCHASE.HeaderText = "Column1";
            this.PRICE_PURCHASE.Name = "PRICE_PURCHASE";
            this.PRICE_PURCHASE.Visible = false;
            // 
            // ID_TYPE_ITEM
            // 
            this.ID_TYPE_ITEM.DataPropertyName = "ID_TYPE_ITEM";
            this.ID_TYPE_ITEM.HeaderText = "Column1";
            this.ID_TYPE_ITEM.Name = "ID_TYPE_ITEM";
            this.ID_TYPE_ITEM.Visible = false;
            // 
            // STATUS
            // 
            this.STATUS.DataPropertyName = "STATUS";
            this.STATUS.HeaderText = "Column1";
            this.STATUS.Name = "STATUS";
            this.STATUS.Visible = false;
            // 
            // NAME_TYPE
            // 
            this.NAME_TYPE.DataPropertyName = "NAME_TYPE";
            this.NAME_TYPE.HeaderText = "Column1";
            this.NAME_TYPE.Name = "NAME_TYPE";
            this.NAME_TYPE.Visible = false;
            // 
            // type_item
            // 
            this.type_item.DataPropertyName = "type_item";
            this.type_item.HeaderText = "Column1";
            this.type_item.Name = "type_item";
            this.type_item.Visible = false;
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.52342F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.31405F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.16253F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_Inventory, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Refresh, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.82801F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.17199F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(726, 407);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Refresh.ImageOptions.Image = global::CoffeeManagementSoftware.Properties.Resources.Refresh2_32x32;
            this.btn_Refresh.Location = new System.Drawing.Point(3, 3);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(143, 33);
            this.btn_Refresh.TabIndex = 1;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 407);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmInventory";
            this.Text = "Tồn Kho";
            this.Load += new System.EventHandler(this.frmInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inventory)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Inventory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE_SELL;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE_PURCHASE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TYPE_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMBER;
        private DevExpress.XtraEditors.SimpleButton btn_Refresh;
    }
}