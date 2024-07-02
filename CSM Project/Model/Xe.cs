using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSM_Project.Model
{
    public class Xe
    {
        public string MaBX { get; set; }
        public string MaCX { get; set; }
        public string MaHX { get; set; }
        public string MoTa { get; set; }

        public Xe() { }

        public Xe(string maBX, string maCX, string maHX, string moTa)
        {
            MaBX = maBX;
            MaCX = maCX;
            MaHX = maHX;
            MoTa = moTa;
        }
    }

}
