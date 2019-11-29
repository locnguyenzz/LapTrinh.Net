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
    public partial class frmInventory : DevExpress.XtraEditors.XtraForm
    {
        //Inventory_CL dll = new Inventory_CL();
        Item_CL dli = new Item_CL();
        public frmInventory()
        {
            InitializeComponent();
        }
       
        public void LoadData()
        {
            dgv_Inventory.DataSource = dli.LoadItem();
        }
        private void frmInventory_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}