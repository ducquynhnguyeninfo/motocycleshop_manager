using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QL_Cua_Hang_Ban_Xe_May.DataAccessLayer;
using System.Data;
using QL_Cua_Hang_Ban_Xe_May.BusinessObject;
using System.Windows.Forms;

namespace QL_Cua_Hang_Ban_Xe_May.BusinessLogic
{
    class KhachHangBUS
    {
        DataAccess connData = new DataAccess();
        //Lay danh sach khach hang
        public DataTable LayDanhSachKhachHang()
        {
            string sql = "SELECT MAKH, TENKH, GIOITINH, NGAYSINH,DC_HIENTAI, HKTT, DTKH, SCMND FROM KHACHHANG";
            return connData.TaoBang(sql);
        }

        //Lay danh sach gioi tinh
        public DataTable LayDanhSachGioiTinh()
        {
            string sql = "SELECT DISTINCT GIOITINH FROM KHACHHANG";
            return connData.TaoBang(sql);
        }
        //Kiem tra hang hoa truoc khi luu
         public bool KiemTraTruocKhiLuu(KhachHang kh)
        {

            if (kh.TenKH.Equals(""))
            {
                MessageBox.Show("Tên khách hàng không hợp lệ!");
                return false;
            }
            if (kh.DienThoai.Equals(""))
            {
                MessageBox.Show("Điện thoại khách hàng không hợp lệ!");
                return false;
            }
            if (kh.DiaChi.Equals(""))
            {
                MessageBox.Show("Địa chỉ khách hàng không hợp lệ!");
                return false;
            }
            if (kh.Hktt.Equals(""))
            {
                MessageBox.Show("Hộ khẩu thường trú không hợp lệ!");
                return false;
            }
            if (kh.NgSinh.Year < 1975)
            {
                MessageBox.Show("Ngày sinh không hợp lệ!");
                return false;
            }
            if (kh.CmND.Equals(""))
            {
                MessageBox.Show("Số Chứng minh nhân nhân không hợp lệ!");
                return false;
            }
            return true;
        }
        //Them khach hang
        public bool ThemKhachHang(KhachHang kh)
        {
            if (KiemTraTruocKhiLuu(kh))
            {
                string sql = string.Format("INSERT INTO KHACHHANG(MAKH, TENKH, GIOITINH,NGAYSINH, DC_HIENTAI, HKTT, DTKH, SCMND)"
                             + " VALUES ('{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}','{6}','{7}')", kh.MaKH, kh.TenKH, kh.GioiTinh, kh.NgSinh, kh.DiaChi, kh.Hktt, kh.DienThoai, kh.CmND);
                if (connData.ThucThiTruyVan(sql))
                {
                    MessageBox.Show("Thêm khách hàng thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }
        //Sua khach hang
        public bool SuaKhachHang(KhachHang kh)
        {
            if (KiemTraTruocKhiLuu(kh))
            {
                string sql = string.Format("UPDATE KHACHHANG SET TENKH= N'{0}', GIOITINH= N'{1}', NGAYSINH = N'{2}', DC_HIENTAI = N'{3}', HKTT = '{4}', DTKH = '{5}', SCMND = '{6}' WHERE MAKH = '{7}'",
                             kh.TenKH, kh.GioiTinh, kh.NgSinh, kh.DiaChi, kh.Hktt, kh.DienThoai, kh.CmND, kh.MaKH);
                if (connData.ThucThiTruyVan(sql))
                {
                    MessageBox.Show("Sửa thông tin khách hàng thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }
        //Xoa khach hang
        public bool XoaKhachHang(string strMaKH)
        {
            string strSql = string.Format("Delete From KHACHHANG Where MAKH='{0}'", strMaKH);
            if (connData.ThucThiTruyVan(strSql))
            {
                MessageBox.Show(string.Format("Xóa khách hàng có mã số '{0}' thành công!", strMaKH), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
        //Phat sinh MaKH tu dong
        public string PhatSinhMaKeTiep()
        {
            return LopDungChung.PhatSinhMaKeTiep(connData.LayThuocTinhPhatSinh("KHACHHANG", "MAKH"), "KH");
        }
        //Kiem tra ma
        public bool CheckExists(string makh)
        {
            if (connData.CheckExistValue("KHACHHANG", "MAKH", makh))
                return true;
            return false;
        }

        //Lay ma khach hang
        public string LayMaKhachHang(string tenKH)
        {
            string sql = "SELECT MAKH FROM KHACHHANG WHERE TENKH = N'" + tenKH + "'";
            DataTable dt = connData.TaoBang(sql);
            DataRow dr = dt.Rows[0];

            string maKH = dr["MAKH"].ToString();

            return maKH;
        }
    }
}
