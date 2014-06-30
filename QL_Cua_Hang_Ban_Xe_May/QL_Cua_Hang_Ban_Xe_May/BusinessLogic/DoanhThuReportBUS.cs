using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QL_Cua_Hang_Ban_Xe_May.DataAccessLayer;
using System.Data;

namespace QL_Cua_Hang_Ban_Xe_May.BaoCao
{
    class DoanhThuReportBUS
    {
        DataAccess myDAc = new DataAccess();

        public DataTable LayDoanhThu()
        {
            string strSql = "select * from DOANHTHU";
            return myDAc.TaoBang(strSql);
        }
        public DataTable getYear()
        {
            string strSql = "select distinct YEAR(NGAYXUAT) as YEAR from doanhthu";
            return myDAc.TaoBang(strSql);
        }

         
        public DataTable getMonth(String Year)
        {
            string strSql;
            strSql = "select distinct MONTH(NGAYXUAT) as MONTH from doanhthu ";
            if (Year != null)
            {
                strSql += " where YEAR(NGAYXUAT) = " + Year;
            }
            
            return myDAc.TaoBang(strSql);
        }

        public DataTable getDay(String Year, String Month)
        {
            string strSql = "select distinct DAY(NGAYXUAT) as DAY from doanhthu";
            if (Year != null && Month != null)
            {
                strSql += " where YEAR(NGAYXUAT) = " + Year + " and MONTH(NgayXuat) = " + Month;
            }
            return myDAc.TaoBang(strSql);
        }

        public DataTable LayDoanhThu(String Year, String Month, String Day)
        {
            string strSql = "select * from DOANHTHU";
            strSql += "  where YEAR(NGAYXUAT) = " + Year + " and MONTH(NgayXuat) = " + Month;
                //select distinct DoanhThu.MAXUAT, DoanhThu.TENXE, DoanhThu.GiaNhap, DoanhThu.GiaXuat,DoanhThu.NgayXuat, DoanhThu.doanhthu from DoanhThu, PHIEUXUAT where DoanhThu.MAXUAT = PHIEUXUAT.MAXUAT and doanhthu.ngayxuat = PHIEUXUAT.NGAYXUAT";
            return myDAc.TaoBang(strSql);
        }
    }
}
