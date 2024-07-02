using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSM_Project.Model
{
    public class ChuXe : NguoiDung
    {
        public string MaCX { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public DateTime NgaySinh { get; set; }

        public ChuXe() { }

        public ChuXe(string maCX, string hoTen, string diaChi, string sdt, DateTime ngaySinh)
        {
            MaCX = maCX;
            HoTen = hoTen;
            DiaChi = diaChi;
            SDT = sdt;
            NgaySinh = ngaySinh;
        }
    }

}
