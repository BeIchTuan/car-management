using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSM_Project.Model
{
    public class PhieuSuaXe
    {
        public string MaPSX { get; set; }
        public string MaTN { get; set; }
        public string MaNV { get; set; }
        public DateTime NgaySua { get; set; }

        public PhieuSuaXe() { }

        public PhieuSuaXe(string maPSX, string maTN, string maNV, DateTime ngaySua)
        {
            MaPSX = maPSX;
            MaTN = maTN;
            MaNV = maNV;
            NgaySua = ngaySua;
        }
    }

}
