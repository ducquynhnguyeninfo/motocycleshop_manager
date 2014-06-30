using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QL_Cua_Hang_Ban_Xe_May.BusinessObject
{
    class PhieuXuatReport
    {
        public string MAXUAT { get; set; }
        public string MAXE { get; set; }
        public string TENXE { get; set; }
        public string TENKH { get; set; }
        public string TENNV { get; set; }
        public int SLXUAT { get; set; }
        public string GIAXUAT { get; set; }
        public string THUEXUAT { get; set; }
        public KhachHang MAKH { get; set; }
    }
}
