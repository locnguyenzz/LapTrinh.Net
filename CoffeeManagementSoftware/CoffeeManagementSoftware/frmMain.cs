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
            tssShowAccount.Text = Program.loginForm.NameAccount;
            
            frmUseService use = new frmUseService();
            openForm(use);
        }
        private void tSBUseService_Click(object sender, EventArgs e)
        {
            if (CheckExist("frmUseService"))
            {
                XtraMessageBox.Show("Bạn Ðang Sử Dụng Chức Năng Này", "Thông báo");
                return;
            }
            else
            {
                frmUseService use = new frmUseService();
                openForm(use);
            }
        }

        private void sửDụngDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tSBUseService.PerformClick();
        }

        private void danhMụcKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(CheckExist("frmCustumer"))
            {
                XtraMessageBox.Show("Chuc nang nay dang su dung!","Thong Bao");
                return;
            }
            else
            {
                frmCustumer use = new frmCustumer();
                openForm(use);
            }
            
        }


        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.loginForm.Visible = true;
        }

        private void đổiMậtKhẩuĐăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckExist("frmChangePass"))
            {
                XtraMessageBox.Show("Chuc nang nay dang su dung!", "Thong Bao");
                return;
            }
            else
            {
                frmChangePass use = new frmChangePass();
                openForm(use);
            }
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (CheckExist("frmAddUserToGroup"))
            {
                XtraMessageBox.Show("Chuc nang nay dang su dung!", "Thong Bao");
                return;
            }
            else
            {
                frmAddUserToGroup use = new frmAddUserToGroup();
                openForm(use);
            }
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (CheckExist("frmRole"))
            {
                XtraMessageBox.Show("Chuc nang nay dang su dung!", "Thong Bao");
                return;
            }
            else
            {
                frmRole use = new frmRole();
                openForm(use);
            }
        }

        private void danhSáchNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckExist("frmSupplier"))
            {
                XtraMessageBox.Show("Chuc nang nay dang su dung!", "Thong Bao");
                return;
            }
            else
            {
                frmSupplier use = new frmSupplier();
                openForm(use);
            }
        }

        private void danhMụcMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckExist("frmItem"))
            {
                XtraMessageBox.Show("Chuc nang nay dang su dung!", "Thong Bao");
                return;
            }
            else
            {
                frmItem use = new frmItem();
                openForm(use);
            }
        }

        private void tồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckExist("frmInventory"))
            {
                XtraMessageBox.Show("Chuc nang nay dang su dung!", "Thong Bao");
                return;
            }
            else
            {
                frmInventory use = new frmInventory();
                openForm(use);
            }
        }

        private void caLàmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimeKeeping frm = new frmTimeKeeping();
            frm.ShowDialog();
        }
    }
}
