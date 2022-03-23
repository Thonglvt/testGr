using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailTextBox
{
    public class MailTextBox:TextBox
    {
        public MailTextBox()
        {
            this.Leave += MailTextBox_Leave;
        }

        private void MailTextBox_Leave(object sender, EventArgs e)
        {
            ErrorProvider error = new ErrorProvider();
            bool kt1 = this.Text.ToLower().Contains("@"), kt2 = this.Text.ToLower().Contains(".com");
            if (kt1 && kt2)
            {
                error.Clear();
            }
            else
            {
                error.SetError(this, "Phai co @ va .com nghe chuaa");
            }
        }
    }
}
