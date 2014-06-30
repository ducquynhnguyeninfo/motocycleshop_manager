using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QL_Cua_Hang_Ban_Xe_May.DataAccessLayer;
using System.Data;

namespace QL_Cua_Hang_Ban_Xe_May.BusinessLogic
{
    class GioiTinhBUS
    {
        DataAccess myDataAc = new DataAccess();
        //Lay danh sach gioi tinh
        public DataTable LayDanhSachGioiTinh()
        {
            string mySql = "SELECT DISTINCT GIOITINH FROM KHACHHANG";
            return myDataAc.TaoBang(mySql);
        }
    }
}
