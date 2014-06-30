using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QL_Cua_Hang_Ban_Xe_May.DataAccessLayer;
using QL_Cua_Hang_Ban_Xe_May.BusinessObject;
using System.Data;

namespace QL_Cua_Hang_Ban_Xe_May.BusinessLogic
{
    class UserBUS
    {
        DataAccess connData = new DataAccess();
        
        //Lay thong tin cua nguoi dung, dua vao username
        public bool LayThongTinUser(string username, string password)
        {
            string strSql = "Select * From NguoiDung Where TenDN ='" + username + "' and MatKhau='" + password + "'";
            DataTable tbUser = connData.TaoBang(strSql);

            if (tbUser.Rows.Count == 0)
                return false;
            else return true;
        }
        public string LayNhomQuyen(string tendangnhap)
        {
                string strSql = "Select MANHOM from NGUOIDUNG where TENDN = '" + tendangnhap + "'";
                DataTable tbUser = connData.TaoBang(strSql);
                

                DataRow dr = tbUser.Rows[0];
                string ma = dr["MANHOM"].ToString();
                return ma;
        }
    }
}
