﻿namespace CoffeeManagementSoftware
{
    partial class frmAddUserToGroup
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.group_userComboBox = new System.Windows.Forms.ComboBox();
            this.group_userBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Grand1 = new CoffeeManagementSoftware.DS_Grand();
            this.user_group_userDKDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_group_userDKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.accountDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddGrant = new DevExpress.XtraEditors.SimpleButton();
            this.btn_DeleteGrant = new DevExpress.XtraEditors.SimpleButton();
            this.user_group_userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountTableAdapter = new CoffeeManagementSoftware.DS_GrandTableAdapters.accountTableAdapter();
            this.tableAdapterManager = new CoffeeManagementSoftware.DS_GrandTableAdapters.TableAdapterManager();
            this.group_userTableAdapter = new CoffeeManagementSoftware.DS_GrandTableAdapters.group_userTableAdapter();
            this.user_group_userTableAdapter = new CoffeeManagementSoftware.DS_GrandTableAdapters.user_group_userTableAdapter();
            this.group_userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_group_userDKTableAdapter = new CoffeeManagementSoftware.DS_GrandTableAdapters.user_group_userDKTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.group_userBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Grand1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_group_userDKDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_group_userDKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_group_userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.group_userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.3578F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.600918F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.58091F));
            this.tableLayoutPanel1.Controls.Add(this.group_userComboBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.user_group_userDKDataGridView, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.accountDataGridView, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_AddGrant, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_DeleteGrant, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.52381F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.857143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.41176F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.47059F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(889, 420);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // group_userComboBox
            // 
            this.group_userComboBox.DataSource = this.group_userBindingSource1;
            this.group_userComboBox.DisplayMember = "NAME_GROUP";
            this.group_userComboBox.FormattingEnabled = true;
            this.group_userComboBox.Location = new System.Drawing.Point(538, 85);
            this.group_userComboBox.Name = "group_userComboBox";
            this.group_userComboBox.Size = new System.Drawing.Size(300, 21);
            this.group_userComboBox.TabIndex = 7;
            this.group_userComboBox.ValueMember = "ID";
            this.group_userComboBox.SelectedValueChanged += new System.EventHandler(this.group_userComboBox_SelectedValueChanged_1);
            // 
            // group_userBindingSource1
            // 
            this.group_userBindingSource1.DataMember = "group_user";
            this.group_userBindingSource1.DataSource = this.dS_Grand1;
            // 
            // dS_Grand1
            // 
            this.dS_Grand1.DataSetName = "DS_Grand";
            this.dS_Grand1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // user_group_userDKDataGridView
            // 
            this.user_group_userDKDataGridView.AllowUserToAddRows = false;
            this.user_group_userDKDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow;
            this.user_group_userDKDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.user_group_userDKDataGridView.AutoGenerateColumns = false;
            this.user_group_userDKDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.user_group_userDKDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.user_group_userDKDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_group_userDKDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.user_group_userDKDataGridView.DataSource = this.user_group_userDKBindingSource;
            this.user_group_userDKDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user_group_userDKDataGridView.Location = new System.Drawing.Point(538, 118);
            this.user_group_userDKDataGridView.Name = "user_group_userDKDataGridView";
            this.user_group_userDKDataGridView.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.user_group_userDKDataGridView, 3);
            this.user_group_userDKDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.user_group_userDKDataGridView.Size = new System.Drawing.Size(348, 299);
            this.user_group_userDKDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID_ACCOUNT";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mã TK";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ID_GROUP";
            this.dataGridViewTextBoxColumn6.HeaderText = "Mã Nhóm";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "STATUS";
            this.dataGridViewTextBoxColumn7.HeaderText = "Trạng Thái";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // user_group_userDKBindingSource
            // 
            this.user_group_userDKBindingSource.DataMember = "user_group_userDK";
            this.user_group_userDKBindingSource.DataSource = this.dS_Grand1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(453, 82);
            this.label2.TabIndex = 5;
            this.label2.Text = "PHÂN NHÓM NGƯỜI DÙNG";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accountDataGridView
            // 
            this.accountDataGridView.AllowUserToAddRows = false;
            this.accountDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Yellow;
            this.accountDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.accountDataGridView.AutoGenerateColumns = false;
            this.accountDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.accountDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.accountDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tableLayoutPanel1.SetColumnSpan(this.accountDataGridView, 2);
            this.accountDataGridView.DataSource = this.accountBindingSource;
            this.accountDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountDataGridView.Location = new System.Drawing.Point(3, 118);
            this.accountDataGridView.Name = "accountDataGridView";
            this.accountDataGridView.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.accountDataGridView, 3);
            this.accountDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.accountDataGridView.Size = new System.Drawing.Size(453, 299);
            this.accountDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã TK";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "USERNAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên TK";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PASSWORD";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mật Khẩu";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "STATUS";
            this.dataGridViewTextBoxColumn4.HeaderText = "Trạng Thái";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "account";
            this.accountBindingSource.DataSource = this.dS_Grand1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhóm Người Dùng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_AddGrant
            // 
            this.btn_AddGrant.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_AddGrant.ImageOptions.Image = global::CoffeeManagementSoftware.Properties.Resources.doublenext_32x32;
            this.btn_AddGrant.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_AddGrant.Location = new System.Drawing.Point(462, 220);
            this.btn_AddGrant.Name = "btn_AddGrant";
            this.btn_AddGrant.Size = new System.Drawing.Size(70, 42);
            this.btn_AddGrant.TabIndex = 6;
            this.btn_AddGrant.Click += new System.EventHandler(this.btn_AddGrant_Click);
            // 
            // btn_DeleteGrant
            // 
            this.btn_DeleteGrant.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_DeleteGrant.ImageOptions.Image = global::CoffeeManagementSoftware.Properties.Resources.doubleprev_32x32;
            this.btn_DeleteGrant.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_DeleteGrant.Location = new System.Drawing.Point(462, 268);
            this.btn_DeleteGrant.Name = "btn_DeleteGrant";
            this.btn_DeleteGrant.Size = new System.Drawing.Size(70, 40);
            this.btn_DeleteGrant.TabIndex = 7;
            this.btn_DeleteGrant.Click += new System.EventHandler(this.btn_DeleteGrant_Click);
            // 
            // user_group_userBindingSource
            // 
            this.user_group_userBindingSource.DataMember = "user_group_user";
            this.user_group_userBindingSource.DataSource = this.dS_Grand1;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.accountTableAdapter = this.accountTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.grant_rightTableAdapter = null;
            this.tableAdapterManager.group_userTableAdapter = this.group_userTableAdapter;
            this.tableAdapterManager.screenTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CoffeeManagementSoftware.DS_GrandTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_group_userDKTableAdapter = null;
            this.tableAdapterManager.user_group_userTableAdapter = this.user_group_userTableAdapter;
            // 
            // group_userTableAdapter
            // 
            this.group_userTableAdapter.ClearBeforeFill = true;
            // 
            // user_group_userTableAdapter
            // 
            this.user_group_userTableAdapter.ClearBeforeFill = true;
            // 
            // group_userBindingSource
            // 
            this.group_userBindingSource.DataMember = "group_user";
            this.group_userBindingSource.DataSource = this.dS_Grand1;
            // 
            // user_group_userDKTableAdapter
            // 
            this.user_group_userDKTableAdapter.ClearBeforeFill = true;
            // 
            // frmAddUserToGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(889, 420);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmAddUserToGroup";
            this.Text = "Phân Nhóm Người Dùng";
            this.Load += new System.EventHandler(this.frmAddUserToGroup_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.group_userBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Grand1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_group_userDKDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_group_userDKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_group_userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.group_userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private DS_Grand dS_Grand1;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private DS_GrandTableAdapters.accountTableAdapter accountTableAdapter;
        private DS_GrandTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView accountDataGridView;
        private DS_GrandTableAdapters.group_userTableAdapter group_userTableAdapter;
        private System.Windows.Forms.BindingSource group_userBindingSource;
        private DS_GrandTableAdapters.user_group_userTableAdapter user_group_userTableAdapter;
        private System.Windows.Forms.BindingSource user_group_userBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btn_AddGrant;
        private DevExpress.XtraEditors.SimpleButton btn_DeleteGrant;
        private System.Windows.Forms.BindingSource user_group_userDKBindingSource;
        private DS_GrandTableAdapters.user_group_userDKTableAdapter user_group_userDKTableAdapter;
        private System.Windows.Forms.DataGridView user_group_userDKDataGridView;
        private System.Windows.Forms.ComboBox group_userComboBox;
        private System.Windows.Forms.BindingSource group_userBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}