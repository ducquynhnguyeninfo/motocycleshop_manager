using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QL_Cua_Hang_Ban_Xe_May.DataAccessLayer;
using System.Data;

namespace QL_Cua_Hang_Ban_Xe_May.BusinessLogic
{
    class PhieuNhapReportBUS
    {
        DataAccess myDaAcc = new DataAccess();

        public DataTable LayTTPhieuNhap()
        {
            string strSql = " select a.MaNhap, a.MaXe,c.TenXe,GiaNhap,SLNhap,ThueNhap from CHITIET_P_NHAP a,PHIEUNHAP b,THONGTINXEMAY c where a.MaNhap=b.MANHAP and c.MaXe=a.MaXe";
            return myDaAcc.TaoBang(strSql);
        }
        public DataTable LayTTPhieuNhapHangCungCap(string MAHCC)
        {
            string strSql = "select a.MaNhap, a.MaXe,c.TenXe,GiaNhap,SLNhap,ThueNhap from CHITIET_P_NHAP a,PHIEUNHAP b,THONGTINXEMAY c, HANGCUNGCAP d";
            if (MAHCC != "ALL")
                strSql += " where a.MaNhap=b.MaNhap and c.MaXe=a.MaXe and d.MaHCC=b.MaHCC and d.MaHCC='" + MAHCC + "'";
            else
                strSql = "select a.MaNhap, a.MaXe,c.TenXe,GiaNhap,SLNhap,ThueNhap from CHITIET_P_NHAP a,PHIEUNHAP b,THONGTINXEMAY c, HANGCUNGCAP d where a.MANHAP = b.MANHAP and c.MAXE = a.MAXE and b.MAHCC = d.MAHCC";
            return myDaAcc.TaoBang(strSql);
        }
    }
}
