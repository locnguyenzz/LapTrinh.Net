using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CoffeeManagementSoftware
{
    public partial class frmCustumer : DevExpress.XtraEditors.XtraForm
    {
        public frmCustumer()
        {
            InitializeComponent();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            frmAddCustumer use = new frmAddCustumer();
            use.ShowDialog();
        }

        private void tSB_Add_Click(object sender, EventArgs e)
        {
            frmAddCustumer frm = new frmAddCustumer();
            frm.ShowDialog();
        }

        private void tSP_Edit_Click(object sender, EventArgs e)
        {
            frmAddCustumer frm = new frmAddCustumer();
            frm.ShowDialog();
        }
    }
}