namespace CoffeeManagementSoftware
{
    partial class frmDanhmucmathang
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
            this.pnlNhomhang = new System.Windows.Forms.Panel();
            this.pnlMathang = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.pnlNhomhang.SuspendLayout();
            this.pnlMathang.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNhomhang
            // 
            this.pnlNhomhang.Controls.Add(this.toolStrip1);
            this.pnlNhomhang.Location = new System.Drawing.Point(13, 13);
            this.pnlNhomhang.Name = "pnlNhomhang";
            this.pnlNhomhang.Size = new System.Drawing.Size(376, 678);
            this.pnlNhomhang.TabIndex = 0;
            // 
            // pnlMathang
            // 
            this.pnlMathang.Controls.Add(this.toolStrip2);
            this.pnlMathang.Location = new System.Drawing.Point(396, 13);
            this.pnlMathang.Name = "pnlMathang";
            this.pnlMathang.Size = new System.Drawing.Size(807, 678);
            this.pnlMathang.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(376, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(807, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // frmDanhmucmathang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 703);
            this.Controls.Add(this.pnlMathang);
            this.Controls.Add(this.pnlNhomhang);
            this.Name = "frmDanhmucmathang";
            this.Text = "Danh mục mặt hàng";
            this.TopMost = true;
            this.pnlNhomhang.ResumeLayout(false);
            this.pnlNhomhang.PerformLayout();
            this.pnlMathang.ResumeLayout(false);
            this.pnlMathang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNhomhang;
        private System.Windows.Forms.Panel pnlMathang;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
    }
}