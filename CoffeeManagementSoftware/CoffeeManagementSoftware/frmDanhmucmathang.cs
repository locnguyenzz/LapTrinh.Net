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
    public partial class frmDanhmucmathang : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhmucmathang()
        {
            InitializeComponent();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton6_Click_1(object sender, EventArgs e)
        {

        }

        private void tSBThemmoi_Click(object sender, EventArgs e)
        {
            frmChitietmathang ct = new frmChitietmathang();
            ct.ShowDialog();

        }
    }
}