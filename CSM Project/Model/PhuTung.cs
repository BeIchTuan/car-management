using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSM_Project.Model
{
    public class PhuTung
    {
        public string MaPT { get; set; }
        public string MaLoai { get; set; }
        public string TenPT { get; set; }
        public string DVT { get; set; }
        public float GiaThamKhao { get; set; }

        public PhuTung() { }

        public PhuTung(string maPT, string maLoai, string tenPT, string dvt, float giaThamKhao)
        {
            MaPT = maPT;
            MaLoai = maLoai;
            TenPT = tenPT;
            DVT = dvt;
            GiaThamKhao = giaThamKhao;
        }
    }

}
