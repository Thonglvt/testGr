using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public class Class1:TextBox
    {
        public Class1()
        {
            this.Leave += userTextBox_Leave;
        }

        private void userTextBox_Leave(object sender, EventArgs e)
        {
            ErrorProvider error = new ErrorProvider();
            foreach (var c in this.Text)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    error.SetError(this, "Chuỗi không được chứa ký tự đặc biệt");
                }
            }
        }
    }
}
