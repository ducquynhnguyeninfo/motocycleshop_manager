using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QL_Cua_Hang_Ban_Xe_May.DataAccessLayer;
using System.Data;

namespace QL_Cua_Hang_Ban_Xe_May.BusinessLogic
{
    class NhanVienReportBUS
    {
        DataAccess myDaAcc = new DataAccess();

        public DataTable LayTTNhanVien()
        {
            string strSql = "Select MaNV, TenNV, NgSinh, GioiTinh, DiaChi, Lcb, DtNv from NhanVien";
            return myDaAcc.TaoBang(strSql);
        }
        public DataTable LayTTNhanVienTheoChucVu(string MaChucVu)
        {
            string strSql = "Select MaNV, TenNV, NgSinh, GioiTinh, DiaChi, Lcb from NhanVien";
            if (MaChucVu != "ALL")
                strSql += ", Chuc_Vu where NhanVien.Ma_CV=Chuc_Vu.Ma_CV and Chuc_Vu.Ma_CV='"+MaChucVu+"'";
            return myDaAcc.TaoBang(strSql);
        }
    }
}
