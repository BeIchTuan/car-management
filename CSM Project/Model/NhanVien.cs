using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSM_Project.Model
{
    public class NhanVien : NguoiDung
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string CCCD { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public int Quyen { get; set; }
        public DateTime NgaySinh { get; set; }

        public NhanVien() { }

        public NhanVien(string maNV, string hoTen, string gioiTinh, string cccd, string diaChi, string sdt, int quyen, DateTime ngaySinh)
        {
            MaNV = maNV;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            CCCD = cccd;
            DiaChi = diaChi;
            SDT = sdt;
            Quyen = quyen;
            NgaySinh = ngaySinh;
        }
    }

}
