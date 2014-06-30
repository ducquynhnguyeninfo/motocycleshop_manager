using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QL_Cua_Hang_Ban_Xe_May.BusinessObject
{
    class NhapHang
    {
        public string MaNhap { get; set; }
        public string MaXe { get; set; }
        public DateTime NgayNhap { get; set; }
        public string TenNCC { get; set; }
        public string TenNV { get; set; }
        public int SLNhap { get; set; }
        public string GiaNhap { get; set; }
        public string ThueNhap { get; set; }

        public string TenXe { get; set; }
        public string GiaDeNghi { get; set; }
        public string NhaSX { get; set; }
        public DateTime NgaySX { get; set; }
        public string KieuDang { get; set; }
        public string MauXe { get; set; }
        public string SoKhung { get; set; }
        public string SoSuon { get; set; }
    }
}
