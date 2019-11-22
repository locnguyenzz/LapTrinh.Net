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
    public partial class frmTimeKeeping : DevExpress.XtraEditors.XtraForm
    {
        TimeKeeping_CL dll = new TimeKeeping_CL();
        public frmTimeKeeping()
        {
            InitializeComponent();
        }
        public void LoadCa()
        {
            cbo_Time.DataSource = dll.LoadShift();
            cbo_Time.DisplayMember = "SHIFT";
            cbo_Time.ValueMember = "ID";
        }

        private void frmTimeKeeping_Load(object sender, EventArgs e)
        {
            LoadCa();
        }


        
    }
}