using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSM_Project.Model
{
    public class HieuXe
    {
        public string MaHX { get; set; }
        public string TenHX { get; set; }

        public HieuXe() { }

        public HieuXe(string maHX, string tenHX)
        {
            MaHX = maHX;
            TenHX = tenHX;
        }
    }

}
