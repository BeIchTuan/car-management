using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSM_Project.Model
{
    public class PhieuNhapCT
    {
        public string MaPN { get; set; }
        public string MaPT { get; set; }
        public float DonGia { get; set; }
        public int SoLuong { get; set; }

        public PhieuNhapCT() { }

        public PhieuNhapCT(string maPN, string maPT, float donGia, int soLuong)
        {
            MaPN = maPN;
            MaPT = maPT;
            DonGia = donGia;
            SoLuong = soLuong;
        }
    }

}
