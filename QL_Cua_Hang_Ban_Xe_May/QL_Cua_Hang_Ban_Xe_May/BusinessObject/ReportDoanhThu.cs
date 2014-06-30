using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QL_Cua_Hang_Ban_Xe_May.BusinessObject
{
    class ReportDoanhThu
    {
        public string MAXUAT { get; set; }
        public HangHoa TENXE { get; set; }
        public string GIAXUAT { get; set; }
        public TCPhieuNhap GIANHAP { get; set; }
        public DateTime NGAYXUAT { get; set; }
        public string DOANHTHU { get; set; }
    }
}
