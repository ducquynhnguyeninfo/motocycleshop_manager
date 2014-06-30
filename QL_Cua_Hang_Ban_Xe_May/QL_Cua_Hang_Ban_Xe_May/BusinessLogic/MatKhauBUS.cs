using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QL_Cua_Hang_Ban_Xe_May.DataAccessLayer;
using System.Data;
using System.Windows.Forms;
using QL_Cua_Hang_Ban_Xe_May.BusinessObject;

namespace QL_Cua_Hang_Ban_Xe_May.BusinessLogic
{
    class MatKhauBUS
    {
        DataAccess myDataAc = new DataAccess();

        public string LayMatKhauHienTai(string username)
        {
            string mySql = "SELECT MATKHAU FROM NGUOIDUNG WHERE TENDN ='" + username + "'";
            DataTable dt = myDataAc.TaoBang(mySql);

            DataRow dr = dt.Rows[0];
            string mk = dr["MATKHAU"].ToString();

            return mk;
        }
        public bool DoiMatKhau(MatKhau MatKhau)
        {
            string strSql = string.Format("UPDATE NGUOIDUNG SET MATKHAU = '{0}' "
                                + "WHERE TENDN = '{1}'", MatKhau.MATKHAU, MatKhau.TENDN);

            if (myDataAc.ThucThiTruyVan(strSql))
            {
                MessageBox.Show(string.Format("Đổi mật khẩu '{0}' thành công!", MatKhau.TENDN), "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            return false;
        }
    }
}
