using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QL_Cua_Hang_Ban_Xe_May.DataAccessLayer;
using System.Data;

namespace QL_Cua_Hang_Ban_Xe_May.BusinessLogic
{
    class NhaCungCapReportBUS
    {
        DataAccess myDAc = new DataAccess();
        //

        public DataTable LayDanhSachNhaCC()
        {
            string strSql = "Select HANGCUNGCAP.MAHCC, HANGCUNGCAP.TENHCC, HANGCUNGCAP.EMAIL, HANGCUNGCAP.DTHCC, HANGCUNGCAP.DIACHI from HANGCUNGCAP";
            return myDAc.TaoBang(strSql);
        }

        public DataTable LayDanhSachNhaCC(string MAHCC)
        {
            string strsql = "Select HANGCUNGCAP.MAHCC, HANGCUNGCAP.TENHCC, HANGCUNGCAP.EMAIL, HANGCUNGCAP.DTHCC, HANGCUNGCAP.DIACHI from HANGCUNGCAP ";
            if (MAHCC != "ALL")
                strsql += " WHERE HANGCUNGCAP.MAHCC = '" + MAHCC + "'";
            return myDAc.TaoBang(strsql);
        }
    }
}
