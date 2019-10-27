namespace CoffeeManagementSoftware
{
    partial class frmRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRole));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grant_rightDkDataGridView = new System.Windows.Forms.DataGridView();
            this.group_userDataGridView = new System.Windows.Forms.DataGridView();
            this.btn_ExitRole = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SaveRole = new DevExpress.XtraEditors.SimpleButton();
            this.grant_rightDkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Grand = new CoffeeManagementSoftware.DS_Grand();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.group_userTableAdapter = new CoffeeManagementSoftware.DS_GrandTableAdapters.group_userTableAdapter();
            this.tableAdapterManager = new CoffeeManagementSoftware.DS_GrandTableAdapters.TableAdapterManager();
            this.grant_rightTableAdapter = new CoffeeManagementSoftware.DS_GrandTableAdapters.grant_rightTableAdapter();
            this.grant_rightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grant_rightDKTableAdapter = new CoffeeManagementSoftware.DS_GrandTableAdapters.grant_rightDKTableAdapter();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grant_rightDkDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.group_userDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grant_rightDkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Grand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.group_userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grant_rightBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.84288F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.6553F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.38002F));
            this.tableLayoutPanel1.Controls.Add(this.grant_rightDkDataGridView, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.group_userDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_ExitRole, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_SaveRole, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.2807F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.7193F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(821, 384);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grant_rightDkDataGridView
            // 
            this.grant_rightDkDataGridView.AllowUserToAddRows = false;
            this.grant_rightDkDataGridView.AllowUserToDeleteRows = false;
            this.grant_rightDkDataGridView.AutoGenerateColumns = false;
            this.grant_rightDkDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grant_rightDkDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.grant_rightDkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grant_rightDkDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1});
            this.tableLayoutPanel1.SetColumnSpan(this.grant_rightDkDataGridView, 2);
            this.grant_rightDkDataGridView.DataSource = this.grant_rightDkBindingSource;
            this.grant_rightDkDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grant_rightDkDataGridView.Location = new System.Drawing.Point(404, 50);
            this.grant_rightDkDataGridView.MultiSelect = false;
            this.grant_rightDkDataGridView.Name = "grant_rightDkDataGridView";
            this.grant_rightDkDataGridView.ReadOnly = true;
            this.grant_rightDkDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grant_rightDkDataGridView.Size = new System.Drawing.Size(414, 331);
            this.grant_rightDkDataGridView.TabIndex = 4;
            // 
            // group_userDataGridView
            // 
            this.group_userDataGridView.AllowUserToAddRows = false;
            this.group_userDataGridView.AllowUserToDeleteRows = false;
            this.group_userDataGridView.AutoGenerateColumns = false;
            this.group_userDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.group_userDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.group_userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.group_userDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.group_userDataGridView.DataSource = this.group_userBindingSource;
            this.group_userDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group_userDataGridView.Location = new System.Drawing.Point(3, 50);
            this.group_userDataGridView.Name = "group_userDataGridView";
            this.group_userDataGridView.ReadOnly = true;
            this.group_userDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.group_userDataGridView.Size = new System.Drawing.Size(395, 331);
            this.group_userDataGridView.TabIndex = 3;
            this.group_userDataGridView.SelectionChanged += new System.EventHandler(this.group_userDataGridView_SelectionChanged);
            // 
            // btn_ExitRole
            // 
            this.btn_ExitRole.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_ExitRole.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ExitRole.ImageOptions.Image")));
            this.btn_ExitRole.Location = new System.Drawing.Point(590, 3);
            this.btn_ExitRole.Name = "btn_ExitRole";
            this.btn_ExitRole.Size = new System.Drawing.Size(95, 41);
            this.btn_ExitRole.TabIndex = 2;
            this.btn_ExitRole.Text = "Hủy bỏ";
            this.btn_ExitRole.Click += new System.EventHandler(this.btn_ExitRole_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHÂN QUYỀN NHÓM NGƯỜI DÙNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_SaveRole
            // 
            this.btn_SaveRole.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_SaveRole.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_SaveRole.ImageOptions.Image")));
            this.btn_SaveRole.Location = new System.Drawing.Point(489, 3);
            this.btn_SaveRole.Name = "btn_SaveRole";
            this.btn_SaveRole.Size = new System.Drawing.Size(95, 41);
            this.btn_SaveRole.TabIndex = 1;
            this.btn_SaveRole.Text = "Lưu";
            this.btn_SaveRole.Click += new System.EventHandler(this.btn_SaveRole_Click);
            // 
            // grant_rightDkBindingSource
            // 
            this.grant_rightDkBindingSource.DataMember = "grant_rightDk";
            this.grant_rightDkBindingSource.DataSource = this.dS_Grand;
            // 
            // dS_Grand
            // 
            this.dS_Grand.DataSetName = "DS_Grand";
            this.dS_Grand.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Nhóm";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NAME_GROUP";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Nhóm";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "STATUS";
            this.dataGridViewTextBoxColumn3.HeaderText = "Trạng Thái";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // group_userBindingSource
            // 
            this.group_userBindingSource.DataMember = "group_user";
            this.group_userBindingSource.DataSource = this.dS_Grand;
            // 
            // group_userTableAdapter
            // 
            this.group_userTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.accountTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.grant_rightTableAdapter = this.grant_rightTableAdapter;
            this.tableAdapterManager.group_userTableAdapter = this.group_userTableAdapter;
            this.tableAdapterManager.screenTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CoffeeManagementSoftware.DS_GrandTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_group_userDKTableAdapter = null;
            this.tableAdapterManager.user_group_userTableAdapter = null;
            // 
            // grant_rightTableAdapter
            // 
            this.grant_rightTableAdapter.ClearBeforeFill = true;
            // 
            // grant_rightBindingSource
            // 
            this.grant_rightBindingSource.DataMember = "grant_right";
            this.grant_rightBindingSource.DataSource = this.dS_Grand;
            // 
            // grant_rightDKTableAdapter
            // 
            this.grant_rightDKTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mã Màn Hình";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NAME_SCREEN";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tên Màn Hình";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "ROLE";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Quyền";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // frmRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 384);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmRole";
            this.Text = "Phân Quyền Chức Năng";
            this.Load += new System.EventHandler(this.frmRole_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grant_rightDkDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.group_userDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grant_rightDkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Grand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.group_userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grant_rightBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btn_ExitRole;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_SaveRole;
        private DS_Grand dS_Grand;
        private System.Windows.Forms.BindingSource group_userBindingSource;
        private DS_GrandTableAdapters.group_userTableAdapter group_userTableAdapter;
        private DS_GrandTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView group_userDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DS_GrandTableAdapters.grant_rightTableAdapter grant_rightTableAdapter;
        private System.Windows.Forms.BindingSource grant_rightBindingSource;
        private System.Windows.Forms.BindingSource grant_rightDkBindingSource;
        private DS_GrandTableAdapters.grant_rightDKTableAdapter grant_rightDKTableAdapter;
        private System.Windows.Forms.DataGridView grant_rightDkDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}