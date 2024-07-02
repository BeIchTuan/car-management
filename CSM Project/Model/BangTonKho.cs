using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSM_Project.Model
{
    public class BangTonKho
    {
        public string MaTK { get; set; }
        public string MaPT { get; set; }
        public string GhiChu { get; set; }

        public BangTonKho() { }

        public BangTonKho(string maTK, string maPT, string ghiChu)
        {
            MaTK = maTK;
            MaPT = maPT;
            GhiChu = ghiChu;
        }
    }

}
