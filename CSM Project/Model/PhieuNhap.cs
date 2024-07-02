using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSM_Project.Model
{
    public class PhieuNhap
    {
        public string MaPN { get; set; }
        public string MaNV { get; set; }
        public string MaNCC { get; set; }
        public DateTime NgayLapPhieu { get; set; }

        public PhieuNhap() { }

        public PhieuNhap(string maPN, string maNV, string maNCC, DateTime ngayLapPhieu)
        {
            MaPN = maPN;
            MaNV = maNV;
            MaNCC = maNCC;
            NgayLapPhieu = ngayLapPhieu;
        }
    }

}
