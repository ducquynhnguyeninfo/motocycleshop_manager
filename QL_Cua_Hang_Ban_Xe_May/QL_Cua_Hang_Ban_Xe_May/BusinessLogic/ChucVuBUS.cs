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
    class ChucVuBUS
    {
        DataAccess connData = new DataAccess();
        //Lay danh sach chuc vu
        public DataTable LayDanhSachChucVu()
        {
            string sql = "SELECT MA_CV, TEN_CV, GHICHU FROM CHUC_VU";
            return connData.TaoBang(sql);
        }
        public string PhatSinhMaKeTiep()
        {
            return LopDungChung.PhatSinhMaKeTiep(connData.LayThuocTinhPhatSinh("CHUC_VU", "MA_CV"), "CV");
        }
        //Them chucvu
        public bool ThemChucVu(ChucVu cv)
        {
            if (KiemTraTruocKhiLuu(cv))
            {
                string sql = string.Format("INSERT INTO CHUC_VU (MA_CV, TEN_CV, GHICHU)"
                             + " VALUES ('{0}',N'{1}',N'{2}')", cv.MaChucVu, cv.TenChucVu, cv.GhiChu);
                if (connData.ThucThiTruyVan(sql))
                {
                    MessageBox.Show("Thêm chức vụ thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Xoa chuc vu
        public bool XoaChucVu(string strMaCV)
        {
            string strSql = string.Format("Delete From CHUC_VU Where MA_CV='{0}'", strMaCV);
            if (connData.ThucThiTruyVan(strSql))
            {
                MessageBox.Show(string.Format("Xóa chức vụ có mã số '{0}' thành công!", strMaCV), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
        //Sua chuc vu
        public bool SuaChucVu(ChucVu cv)
        {
            if (KiemTraTruocKhiLuu(cv))
            {
                string sql = string.Format("UPDATE CHUC_VU SET TEN_CV = N'{0}', GHICHU = N'{1}' WHERE MA_CV = '{2}'",
                             cv.TenChucVu, cv.GhiChu, cv.MaChucVu);
                if (connData.ThucThiTruyVan(sql))
                {
                    MessageBox.Show("Sửa chức vụ thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }


        public string LayMaChucVu(string tenCV)
        {
            string sql = "SELECT MA_CV FROM CHUC_VU WHERE TEN_CV = N'" + tenCV + "'";
            DataTable dt = connData.TaoBang(sql);
            DataRow dr = dt.Rows[0];

            string maCV = dr["MA_CV"].ToString();

            return maCV;
        }

        public bool CheckExists(string machucvu)
        {
            if (connData.CheckExistValue("CHUC_VU", "MA_CV", machucvu))
                return true;
            return false;
        }
        //Kiem tra chuc vu truoc khi luu
        public bool KiemTraTruocKhiLuu(ChucVu cv)
        {
            if (cv.TenChucVu.Equals(""))
            {
                MessageBox.Show("Tên Chức Vụ không hợp lệ!");
                return false;
            }
            return true;
        }
    }
}
