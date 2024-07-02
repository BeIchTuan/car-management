using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSM_Project.Model
{
    public class LoaiPT
    {
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }

        public LoaiPT() { }

        public LoaiPT(string maLoai, string tenLoai)
        {
            MaLoai = maLoai;
            TenLoai = tenLoai;
        }
    }

}
