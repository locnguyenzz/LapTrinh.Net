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
    public partial class frmTypeItem : DevExpress.XtraEditors.XtraForm
    {
        TypeItem_CL dll = new TypeItem_CL();
        public frmTypeItem()
        {
            InitializeComponent();
        }

        private void frmTypeItem_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(dll.AddNewType(int.Parse(txt_ID.Text),txt_Name.Text))
            {
                XtraMessageBox.Show("Them nhom hang thanh cong", "Thong Bao");

            }
            else
            {
                XtraMessageBox.Show("Them nhom hang that bai!", "Thong Bao");
            }
        }
    }
}