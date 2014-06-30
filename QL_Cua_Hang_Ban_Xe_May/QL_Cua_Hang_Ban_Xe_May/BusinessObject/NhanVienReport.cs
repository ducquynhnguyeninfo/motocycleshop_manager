using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QL_Cua_Hang_Ban_Xe_May.BusinessObject
{
    class NhanVienReport
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public DateTime NgSinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string DtNv { get; set; }
        public string Lcb { get; set; }
        public DateTime NgVLam { get; set; }
        public ChucVu TenChucVu { get; set; }

    }
}
