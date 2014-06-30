using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QL_Cua_Hang_Ban_Xe_May.DataAccessLayer;
using QL_Cua_Hang_Ban_Xe_May.BusinessObject;
using System.Data;

namespace QL_Cua_Hang_Ban_Xe_May.BusinessLogic
{
    class tkphieunhapBUS
    {
        DataAccess myDataAc = new DataAccess();

        public string XacDinhTruyVan(TCPhieuNhap ttphieunhap)
        {
            string strTamPN = "SELECT PN.MANHAP, TENXE, TENNV, TENHCC, NGAYNHAP, SLNHAP, GIANHAP, THUENHAP FROM THONGTINXEMAY AS TTXM, CHITIET_P_NHAP AS CTPN, PHIEUNHAP AS PN, HANGCUNGCAP AS HCC, NHANVIEN AS NV WHERE CTPN.MANHAP = PN.MANHAP AND PN.MAHCC = HCC.MAHCC AND PN.MANV = NV.MANV AND TTXM.MAXE = CTPN.MAXE";

            if (ttphieunhap.TenNV != "")
            {
                strTamPN += " AND TENNV Like N'%" + ttphieunhap.TenNV + "%'";
            }

            if (ttphieunhap.TenXe != "")
            {
                strTamPN += " AND TENXE Like N'%" + ttphieunhap.TenXe + "%'";
            }

            if (ttphieunhap.TenNCC != "")
            {
                strTamPN += " AND TENHCC Like N'%" + ttphieunhap.TenNCC + "%'";
            }

            if (ttphieunhap.GiaNhap != "")
            {
                strTamPN += " AND GIANHAP Like '%" + ttphieunhap.GiaNhap + "%'";
            }

            return strTamPN;
        }

        public DataTable DanhSachPhieuNhap(string strSql)
        {
            return myDataAc.TaoBang(strSql);
        }
    }
}
