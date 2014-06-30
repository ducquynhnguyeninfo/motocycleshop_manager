using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QL_Cua_Hang_Ban_Xe_May.DataAccessLayer;
using System.Data;

namespace QL_Cua_Hang_Ban_Xe_May.BusinessLogic
{
    class KhachHangReportBUS
    {
        DataAccess myDAc = new DataAccess();


        public DataTable LayDanhSachKH()
        {
            string strSql = "select MAKH, TENKH, NGAYSINH, DC_HIENTAI, HKTT, DTKH, SCMND from KHACHHANG";
            return myDAc.TaoBang(strSql);
        }

        public DataTable LayDanhSachKH(string MAKH)
        {
            string strsql = "select KHACHHANG.MAKH, KHACHHANG.TENKH, KHACHHANG.NGAYSINH, KHACHHANG.DC_HIENTAI, KHACHHANG.HKTT, KHACHHANG.DTKH, KHACHHANG.SCMND from KHACHHANG ";
            if (MAKH != "ALL")
                strsql += " WHERE KHACHHANG.MAKH = '" + MAKH + "'";
            return myDAc.TaoBang(strsql);
        }
    }
}
