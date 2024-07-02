using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSM_Project.Model
{
    public class NhaCungCap
    {
        public string MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }

        public NhaCungCap() { }

        public NhaCungCap(string maNCC, string tenNCC, string sdt, string diaChi)
        {
            MaNCC = maNCC;
            TenNCC = tenNCC;
            SDT = sdt;
            DiaChi = diaChi;
        }
    }

}
