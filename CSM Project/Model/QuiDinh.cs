using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSM_Project.Model
{
    public class QuiDinh
    {
        public string MaQD { get; set; }
        public float MaxTienCong { get; set; }
        public int MaxHieuXe { get; set; }

        public QuiDinh() { }

        public QuiDinh(string maQD, float maxTienCong, int maxHieuXe)
        {
            MaQD = maQD;
            MaxTienCong = maxTienCong;
            MaxHieuXe = maxHieuXe;
        }
    }

}
