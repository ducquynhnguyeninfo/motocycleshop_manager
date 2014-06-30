using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QL_Cua_Hang_Ban_Xe_May.BusinessObject
{
    class BaoHanhReport
    {
        public string MaCTBH { get; set; }
        public string MaBH { get; set; }
        public string MaHCC { get; set; }
        public string SoKhung { get; set; }
        public DateTime NgayDenBH { get; set; }
        public string SoLanBH { get; set; }
        public string ChiPhiBH { get; set; }
        public TCNhaCungCap TenNCC { get; set; }
        public KhachHang TenKH { get; set; }
    }
}
