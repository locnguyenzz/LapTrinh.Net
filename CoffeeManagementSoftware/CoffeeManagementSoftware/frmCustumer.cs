﻿using System;
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
            frmKhachhang use = new frmKhachhang();
            use.ShowDialog();
        }
    }
}