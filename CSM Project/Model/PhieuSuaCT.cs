using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSM_Project.Model
{
    public class PhieuSuaCT
    {
        public string MaPSX { get; set; }
        public string MaPT { get; set; }
        public string NoiDung { get; set; }
        public float TienCong { get; set; }
        public float DonGia { get; set; }

        public PhieuSuaCT() { }

        public PhieuSuaCT(string maPSX, string maPT, string noiDung, float tienCong, float donGia)
        {
            MaPSX = maPSX;
            MaPT = maPT;
            NoiDung = noiDung;
            TienCong = tienCong;
            DonGia = donGia;
        }
    }

}
