using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QL_Cua_Hang_Ban_Xe_May.DataAccessLayer;

namespace QL_Cua_Hang_Ban_Xe_May.BusinessLogic
{
    class PhieuXuatReportBUS
    {
        DataAccess myDaAcc = new DataAccess();

        public DataTable LayTTPhieuXuat()
        {
            string strSql = " select a.MAXUAT, a.MAXE,c.TENXE,GIAXUAT,SLXUAT,THUEXUAT from CHITIET_P_XUAT a,PHIEUXUAT b,THONGTINXEMAY c where a.MAXUAT=b.MAXUAT and c.MaXe=a.MaXe";
            return myDaAcc.TaoBang(strSql);
        }
        public DataTable LayNgayXuat()
        {
            string strSql = "select NGAYXUAT FROM PHIEUXUAT";
            return myDaAcc.TaoBang(strSql);
        }
     
        public DataTable LayTTPhieuXuatKhachHang(string MAKH)
        {
            string strSql = "select a.MAXUAT, a.MAXE,c.TENXE,GIAXUAT,SLXUAT,THUEXUAT from CHITIET_P_XUAT a,PHIEUXUAT b,THONGTINXEMAY c, KHACHHANG d";
            if (MAKH != "ALL")
                strSql += " where a.MAXUAT=b.MAXUAT and c.MAXE=a.MAXE and d.MAKH=b.MAKH and d.MAKH='" + MAKH + "'";
            else
                strSql = "select a.MAXUAT, a.MAXE,c.TENXE,GIAXUAT,SLXUAT,THUEXUAT from CHITIET_P_XUAT a,PHIEUXUAT b,THONGTINXEMAY c, KHACHHANG d where a.MAXUAT = b.MAXUAT and c.MAXE = a.MAXE and b.MAKH = d.MAKH";
            return myDaAcc.TaoBang(strSql);
        }
    }
}
