using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BamGio
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        DateTime batDau;
        private void btnOnOff_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            btnOnOff.Text = timer1.Enabled ? "Stop" : "Start";
            batDau = DateTime.Now;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan t = DateTime.Now-batDau;
            string text = "";
            //if(t.Days>0)
            //{
            //    text += t.Days.ToString()+".";
            //}
            int tt = t.Milliseconds;
            text += t.Hours.ToString("00") + ":" + t.Minutes.ToString("00") + ":" + t.Seconds.ToString("00");

            label1.Text = text;
            label2.Text = tt.ToString("000");
        }

        private void btnLap_Click(object sender, EventArgs e)
        {
            TimeSpan t = DateTime.Now - batDau;
            string text = "";
           
            int tt = t.Milliseconds;
            text += t.Hours.ToString("00") + ":" + t.Minutes.ToString("00") + ":" + t.Seconds.ToString("00");
            File.WriteAllText("E:\\LuuDuLieuSinhVien\\QUIN\\gio.txt",text+" "+tt +"\n");
            //Console.ReadKey();
        }

    }
}
