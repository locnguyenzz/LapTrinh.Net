using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoffeeManagementSoftware
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public Boolean CheckExist(string frmName)// Kiểm tra xem nut do co ton tai hay chua
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name.Equals(frmName))
                {
                    frm.Activate();
                    return true;
                }
            }
            return false;
        }

        public void openForm(Form frm) // Kiem tra xem nut do co dang duoc sử dụng hay k
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == frm.GetType())
                {
                    f.Activate();
                    return;
                }

            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }
        private void tSBUseService_Click(object sender, EventArgs e)
        {
            if (CheckExist("frmUseService"))
            {
                XtraMessageBox.Show("Bạn Ðang Sử D?ng Chức Nang Này", "Thông báo");
                return;
            }
            else
            {
                frmUseService use = new frmUseService();
                openForm(use);
            }
        }

    }
}
