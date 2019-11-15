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
    public partial class frmItem : DevExpress.XtraEditors.XtraForm
    {
        Item_CL dll = new Item_CL();
        public frmItem()
        {
            InitializeComponent();
        }

        public void LoadData()
        {

            dataGridView1.DataSource = dll.LoadItem();
        }

        private void tSBThemmoi_Click(object sender, EventArgs e)
        {
            frmChitietmathang ct = new frmChitietmathang();
            ct.ShowDialog();

        }

        private void frmItem_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}