using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CoffeeLibrary
{
    public partial class MailTextBox : TextBox
    {
        public MailTextBox()
        {
            InitializeComponent();
        }

        public MailTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        ErrorProvider err = new ErrorProvider();
        private void MailTextBox_MouseLeave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            try
            {

                var mail = new System.Net.Mail.MailAddress(txt.Text);
                err.Clear();
            }
            catch
            {
                this.err.SetError(txt, "Not Format Email ");
            }
        }
    }
}
