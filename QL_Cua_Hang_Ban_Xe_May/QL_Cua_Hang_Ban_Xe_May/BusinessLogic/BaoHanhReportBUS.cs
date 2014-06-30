using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QL_Cua_Hang_Ban_Xe_May.DataAccessLayer;
using System.Data;

namespace QL_Cua_Hang_Ban_Xe_May.BusinessLogic
{
    class BaoHanhReportBUS
    {
        DataAccess myDaAcc = new DataAccess();

        public DataTable LayTTBaoHanh()
        {
            string strSql = "Select MaCTBH, MaKH, SoKhung, NgayDenBH, SoLanBH, ChiPhiBH from CHITIET_BAOHANH";
            return myDaAcc.TaoBang(strSql);
        }
        public DataTable LayTTBaoHanhCT(string MAHCC)
        {
            string strSql = "Select MaCTBH, MaKH, SoKhung, NgayDenBH, SoLanBH, ChiPhiBH,TENHCC from CHITIET_BAOHANH a,HANGCUNGCAP b where a.MAHCC=b.MAHCC";
            if (MAHCC != "ALL")
                strSql += " and b.MaHCC='" + MAHCC + "'";
            return myDaAcc.TaoBang(strSql);
        }
    }
}
