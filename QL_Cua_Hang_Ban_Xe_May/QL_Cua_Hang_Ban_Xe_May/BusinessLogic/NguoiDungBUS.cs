using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QL_Cua_Hang_Ban_Xe_May.DataAccessLayer;
using System.Data;
using System.Windows.Forms;
using QL_Cua_Hang_Ban_Xe_May.BusinessObject;
using System.Data.SqlClient;

namespace QL_Cua_Hang_Ban_Xe_May.BusinessLogic
{
    class NguoiDungBUS
    {
        DataAccess connData = new DataAccess();
        public DataTable LayDanhSachNguoiDung()
        {
            string sql = "SELECT  MAND, TENDN, MATKHAU, NGUOIDUNG.MANHOM, NHOMNGUOIDUNG.TENNHOM, HOTEN, NGAYSINH, SDT, DIACHI FROM (NGUOIDUNG INNER JOIN NHOMNGUOIDUNG ON NGUOIDUNG.MANHOM = NHOMNGUOIDUNG.MANHOM)";
            return connData.TaoBang(sql);
        }
        public DataTable LayDanhSachNhomNguoiDung()
        {
            string sql = "SELECT MANHOM, TENNHOM FROM NHOMNGUOIDUNG";
            return connData.TaoBang(sql);
        }
        public bool ThemNguoiDung(NguoiDungObject ndOB)
        {
            if (KiemTraDuLieuDauVao(ndOB) == true)
            {
                string sql = string.Format("set dateformat dmy INSERT INTO NGUOIDUNG (MAND, TENDN, MATKHAU, HOTEN, NGAYSINH, SDT, DIACHI, MANHOM)"
                    + " VALUES ('{0}','{1}','{2}',N'{3}','{4}','{5}','{6}','{7}')", ndOB.MaNd, ndOB.TenDN, ndOB.MatKhau, ndOB.HoTen, ndOB.NgaySinh.ToString("dd-MM-yyyy"), ndOB.Sdt, ndOB.DiaChi, ndOB.MaNhom);
                if (connData.ThucThiTruyVan(sql))
                {
                    MessageBox.Show("Thêm người dùng thành công", "Thông báo:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //SU DUNG SP
        #region
        //
        public bool ThemNguoiDungSP(string tenSP, NguoiDungObject ndOB)
        {
            bool co = false;
            if (KiemTraDuLieuDauVao(ndOB))
            {
                SqlCommand myComm = new SqlCommand();
                myComm.CommandText = tenSP;
                myComm.CommandType = CommandType.StoredProcedure;

                myComm.Parameters.Add("@MAND", SqlDbType.NVarChar).Value= ndOB.MaNd;
                myComm.Parameters.Add("@TENDN", SqlDbType.NVarChar).Value = ndOB.TenDN;
                myComm.Parameters.Add("@MATKHAU", SqlDbType.NVarChar).Value = ndOB.MatKhau;
                myComm.Parameters.Add("@HOTEN", SqlDbType.NVarChar).Value = ndOB.HoTen;
                myComm.Parameters.Add("@NGAYSINH", SqlDbType.Date).Value = ndOB.NgaySinh;
                myComm.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = ndOB.Sdt;
                myComm.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = ndOB.DiaChi;
                myComm.Parameters.Add("@MANHOM", SqlDbType.NVarChar).Value = ndOB.MaNhom;

                co = connData.ThucThiTruyVanSP(myComm);
            }
            return co;
        }
        //
        #endregion

        public bool SuaNguoiDung(NguoiDungObject ndOB)
        {
            if (KiemTraDuLieuDauVao(ndOB))
            {
                string sql = string.Format("set dateformat dmy UPDATE NGUOIDUNG SET TENDN = '{0}', MATKHAU = '{1}', HOTEN = N'{2}', NGAYSINH = '{3}', SDT = '{4}', DIACHI = '{5}', MANHOM = '{6}'"
                                + " Where MAND = '{7}'", ndOB.TenDN, ndOB.MatKhau, ndOB.HoTen, ndOB.NgaySinh.ToString("dd-MM-yyyy"), ndOB.Sdt, ndOB.DiaChi, ndOB.MaNhom, ndOB.MaNd);
                if (connData.ThucThiTruyVan(sql))
                {
                    MessageBox.Show("Sửa người dùng thành công", "Thông báo:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }
        public bool XoaNguoiDung(string strMaND)
        {
            string strSql = string.Format("DELETE FROM NGUOIDUNG WHERE MAND = '{0}'", strMaND);
            if (connData.ThucThiTruyVan(strSql))
            {
                MessageBox.Show(string.Format("Xóa người dùng có mã số '{0}' thành công!", strMaND), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
                MessageBox.Show(string.Format("Xóa người dùng '{0}' thất bại!", strMaND), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }


        public bool CheckExists(string tendn)
        {
            if (connData.CheckExistValue("NGUOIDUNG", "MAND", tendn))
                return true;
            return false;
        }
        public string PhatSinhMaKeTiep()
        {
            return LopDungChung.PhatSinhMaKeTiep(connData.LayThuocTinhPhatSinh("NGUOIDUNG", "MAND"), "ND");
        }

        public bool KiemTraDuLieuDauVao(NguoiDungObject ndOB)
        {
            //ndOB = new NguoiDungObject();

            if (ndOB.TenDN.Equals(""))
            {
                MessageBox.Show("Tên đăng nhập không hợp lệ!");
                return false;
            }
            if (ndOB.MatKhau.Equals(""))
            {
                MessageBox.Show("Mật khẩu không hợp lệ!");
                return false;
            }
            if (ndOB.HoTen.Equals(""))
            {
                MessageBox.Show("Họ tên  không hợp lệ!");
                return false;
            }
            if (ndOB.DiaChi.Equals(""))
            {
                MessageBox.Show("Địa chỉ không hợp lệ!");
                return false;
            }
            if (ndOB.Sdt.Equals(""))
            {
                MessageBox.Show("Số điện thoại  không hợp lệ!");
                return false;
            }
            return true;
        }
    }
}
