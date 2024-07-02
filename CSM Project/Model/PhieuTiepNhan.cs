using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSM_Project.Model
{
    public class PhieuTiepNhan
    {
        public string MaTN { get; set; }
        public string MaBX { get; set; }
        public string MaNV { get; set; }
        public string GhiChu { get; set; }

        public PhieuTiepNhan() { }

        public PhieuTiepNhan(string maTN, string maBX, string maNV, string ghiChu)
        {
            MaTN = maTN;
            MaBX = maBX;
            MaNV = maNV;
            GhiChu = ghiChu;
        }
    }

}
