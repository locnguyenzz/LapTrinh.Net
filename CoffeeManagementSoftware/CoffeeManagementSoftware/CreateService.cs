using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using System.Drawing;
namespace CoffeeManagementSoftware
{
    class CreateService
    {
        public FlowLayoutPanel CreateFloor(int numberFloor, Panel panelName)
        {
            //Thêm flowlayoutpanel
            FlowLayoutPanel floor = new FlowLayoutPanel();
            panelName.Controls.Add(floor);
            floor.Name = "flp_floor" + numberFloor;
            floor.Dock = DockStyle.Top;
            floor.AutoSize = true;
            //Thêm tên tầng
            Label nameFloor = new Label();
            nameFloor.Text = "Tầng " + numberFloor;
            nameFloor.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameFloor.ForeColor = System.Drawing.SystemColors.Highlight;
            nameFloor.Name = "lbl_Floor" + numberFloor;
            nameFloor.Dock = DockStyle.Top;
            panelName.Controls.Add(nameFloor);
            return floor;
        }

        //Create Button have chair icon
        public SimpleButton CreateButtonChair(int numberFloor, int numberChair, FlowLayoutPanel nameFloor, ContextMenuStrip nameCMS)
        {
            SimpleButton btnChair = new SimpleButton();
            nameFloor.Controls.Add(btnChair);
            btnChair.AppearancePressed.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnChair.AppearancePressed.Options.UseBackColor = true;
            btnChair.ImageOptions.Image = global::CoffeeManagementSoftware.Properties.Resources.cocktail;
            btnChair.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            btnChair.Name = "btnChair" + numberFloor + "." + numberChair;
            btnChair.Size = new System.Drawing.Size(100, 80);
            btnChair.Text = "Ghế " + numberFloor + "." + numberChair;
            btnChair.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            //btnChair.Dock = DockStyle.Left;
            btnChair.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            btnChair.ForeColor = Color.Black;
            btnChair.DoubleClick += btnChair_DoubleClick;
            btnChair.ContextMenuStrip = nameCMS;
            return btnChair;
        }

        //Sự kiện hiện form thanh toán
        void btnChair_DoubleClick(object sender, EventArgs e)
        {
            DialogResult r;
            r = DevExpress.XtraEditors.XtraMessageBox.Show("Tạo Form Tính Tiền", "Nhắc Nhở", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            DevExpress.XtraEditors.SimpleButton t;
            if (r == DialogResult.Yes)
            {
                if (sender.GetType() == typeof(DevExpress.XtraEditors.SimpleButton))
                {
                    t = (DevExpress.XtraEditors.SimpleButton)sender;
                    t.ImageOptions.Image = global::CoffeeManagementSoftware.Properties.Resources.ticket;
                }
            }
            else
            {
                t = (DevExpress.XtraEditors.SimpleButton)sender;
                t.ImageOptions.Image = global::CoffeeManagementSoftware.Properties.Resources.ticket_black;
            }
        }
    }
}
