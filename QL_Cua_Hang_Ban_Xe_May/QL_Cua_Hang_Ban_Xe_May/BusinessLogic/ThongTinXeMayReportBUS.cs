using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QL_Cua_Hang_Ban_Xe_May.DataAccessLayer;
using System.Data;

namespace QL_Cua_Hang_Ban_Xe_May.BusinessLogic
{
    class ThongTinXeMayReportBUS
    {
        DataAccess myDataAc = new DataAccess();
        public DataTable LayDanhSachThongTinXeMay(string NHASX)
        {
            string strSql = "SELECT MAXE, TENXE, NGAYSX, NHASX, KIEUDANG, MAUXE, SOKHUNG, SOSUON, GIADENGHI FROM THONGTINXEMAY WHERE TENXE !=''";
            if (NHASX != "")
                strSql += " AND NHASX ='" + NHASX + "'";
            
            return myDataAc.TaoBang(strSql);
        }
        public DataTable LayDSTenXe()
        {
            string strSql = "select DISTINCT TENXE from THONGTINXEMAY";
            return myDataAc.TaoBang(strSql);
        }

        public DataTable LayDSNXBTenXe(string TenXe)
        {
            string strSql = "Select DISTINCT NHASX from THONGTINXEMAY";
            if (TenXe != "ALL")
                strSql += " where tenxe='" + TenXe + "'";
            return myDataAc.TaoBang(strSql);
        }
    }
}
