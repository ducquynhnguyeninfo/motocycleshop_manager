using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QL_Cua_Hang_Ban_Xe_May.DataAccessLayer;
using QL_Cua_Hang_Ban_Xe_May.BusinessObject;
namespace QL_Cua_Hang_Ban_Xe_May.BusinessLogic
{
    class NhomNguoiDungBUS
    {
        DataAccess connData = new DataAccess();
        //Lay danh sach hang hoa
        public DataTable LayDanhSachNhomNguoiDung()
        {
            string sql = "SELECT MANHOM, TENNHOM  FROM NHOMNGUOIDUNG";
            return connData.TaoBang(sql);
        }
        //Phat sinh tu dong
        public string PhatSinhMaKeTiep()
        {
            return LopDungChung.PhatSinhMaKeTiep(connData.LayThuocTinhPhatSinh("NHOMNGUOIDUNG", "MANHOM"), "MN");
        }
        public bool ThemNguoiDung(NhomNguoiDung nnd)
        {
            //MessageBox.Show(hh.NgaySX.ToString("dd/MM/yyyy"));
            //string s = hh.NgaySX.ToString("dd/MM/yyyy");
            //MessageBox.Show(s);
            if (KiemTraTruocKhiLuu(nnd))
            {
                string sql = string.Format("INSERT INTO NHOMNGUOIDUNG (MANHOM, TENNHOM)" + " VALUES ('{0}',N'{1}')", nnd.MaNhom, nnd.TenNhom);
                if (connData.ThucThiTruyVan(sql))
                {
                    MessageBox.Show("Thêm nhóm người dùng thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        public bool CheckExists(string manhom)
        {
            if (connData.CheckExistValue("NHOMNGUOIDUNG", "MANHOM", manhom))
                return true;
            return false;
        }
        public bool SuaNhomNguoiDung(NhomNguoiDung nnd)
        {
            if (KiemTraTruocKhiLuu(nnd))
            {
                string sql = string.Format("UPDATE NHOMNGUOIDUNG SET TENNHOM = N'{0}' WHERE MANHOM = '{1}'", nnd.TenNhom, nnd.MaNhom);
                if (connData.ThucThiTruyVan(sql))
                {
                    MessageBox.Show("Sửa nhóm người dùng thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        public bool XoaNguoiDung(string strMaNhom)
        {
            string strSql = string.Format("Delete From NHOMNGUOIDUNG Where MANHOM='{0}'", strMaNhom);
            if (connData.ThucThiTruyVan(strSql))
            {
                MessageBox.Show(string.Format("Xóa nhóm người dùng có mã số '{0}' thành công!", strMaNhom), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
        //Kiem tra hang hoa truoc khi luu
        public bool KiemTraTruocKhiLuu(NhomNguoiDung nnd)
        {
            if (nnd.TenNhom.Equals(""))
            {
                MessageBox.Show("Tên nhóm người dùng không hợp lệ!");
                return false;
            }
            return true;
        }
    }
}
