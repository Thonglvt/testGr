using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    public class sinhVien
    {
        public sinhVien()
        {

        }
        public string mssv { get; set; }
        public string hoten { get; set; }
        public string maLop { get; set; }
        public string ngaySinh { get; set; }
        public string sex { get; set; }
        public string cmnd { get; set; }
        public sinhVien(string mssv, string hoten, string maLop, string ngaySinh, string sex, string cmnd)
        {
            this.mssv = cmnd;
            this.hoten = hoten;
            this.maLop = maLop;
            this.ngaySinh = ngaySinh;
            this.sex = sex;
            this.cmnd = cmnd;
        }
    }
}
