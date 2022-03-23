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

namespace sv
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        string filename = "E:\\LuuDuLieuSinhVien\\QUIN\\dssv.txt";
        private string[] thongtin(string mssv)
        {
            using (StreamReader file = new StreamReader(filename))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    string[] ktra = line.Split(',');
                    if (ktra[0].Equals(mssv))
                    {
                        return ktra;
                    }
                }
                file.Close();
            }
            return null;
        }
        private void btnNhap_Click(object sender, EventArgs e)
        {
           String[] ttsv= thongtin(txtMSSV.Text);
           txtMSSV.Text=ttsv[0] ;
           txtHoten.Text=ttsv[1] ;
           txtMaLop.Text= ttsv[2] ;
           txtNgaysinh.Text=ttsv[3] ;
           txtGioitinh.Text=ttsv[4] ;
           txtCMND.Text= ttsv[5] ;
        }
    }
}
