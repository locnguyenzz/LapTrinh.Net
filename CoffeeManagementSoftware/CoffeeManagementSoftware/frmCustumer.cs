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
using CoffeeLibrary;
namespace CoffeeManagementSoftware
{
    public partial class frmCustumer : DevExpress.XtraEditors.XtraForm
    {
        Custumer_CL dll = new Custumer_CL();
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

        private void frmCustumer_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dll.LoadCustumer();
        }
    }
}