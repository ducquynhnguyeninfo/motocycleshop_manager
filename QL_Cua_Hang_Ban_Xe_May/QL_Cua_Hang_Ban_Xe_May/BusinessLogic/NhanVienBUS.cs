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
    class NhanVienBUS
    {
        DataAccess connData = new DataAccess();
        //Lay danh sach nhan vien
        public DataTable LayDanhSachNhanVien()
        {
            string sql = "SELECT MANV, TENNV, NGSINH, GIOITINH, DIACHI,DTNV, LCB, NGVAOLAM, TEN_CV FROM NHANVIEN AS NV, CHUC_VU AS CV WHERE NV.MA_CV = CV.MA_CV";
            return connData.TaoBang(sql);
        }
        //Lay danh sach chuc vu
        public DataTable LayDanhSachChucVu()
        {
            string sql = "  SELECT DISTINCT NHANVIEN.MA_CV, CHUC_VU.TEN_CV  FROM(NHANVIEN INNER JOIN CHUC_VU ON NHANVIEN.MA_CV = CHUC_VU.MA_CV )";
            return connData.TaoBang(sql);
        }
        //Lay danh sach gioi tinh
        public DataTable LayDanhSachGioiTinh()
        {
            string sql = "SELECT DISTINCT GIOITINH FROM NHANVIEN";
            return connData.TaoBang(sql);
        }
        //Kiem tra hang hoa truoc khi luu
        public bool KiemTraTruocKhiLuu(NhanVien nv)
        {

            if (nv.TenNV.Equals(""))
            {
                MessageBox.Show("Tên nhân viên không hợp lệ!");
                return false;
            }
            if (nv.DtNv.Equals(""))
            {
                MessageBox.Show("Điện thoại nhân viên không hợp lệ!");
                return false;
            }
            if (nv.DiaChi.Equals(""))
            {
                MessageBox.Show("Địa chỉ nhân viên không hợp lệ!");
                return false;
            }
            if (nv.Lcb.Equals(""))
            {
                MessageBox.Show("Lương nhân viên không hợp lệ!");
                return false;
            }
            if (nv.NgSinh.Year < 1975)
            {
                MessageBox.Show("Ngày sinh không hợp lệ!");
                return false;
            }
            if ((nv.NgVLam.Year > 2012) && (nv.NgVLam.Year < 1975))
            {
                MessageBox.Show("Ngày vào làm không hợp lệ!");
                return false;
            }
            return true;
        }
        //Them nhan vien
        public bool ThemNhanVien(NhanVien nv)
        {
            if (KiemTraTruocKhiLuu(nv))
            {
                string sql = string.Format("INSERT INTO NHANVIEN(MANV, TENNV, NGSINH, GIOITINH, DIACHI, DTNV, LCB, NGVAOLAM, MA_CV)"
                             + " VALUES ('{0}',N'{1}','{2}',N'{3}',N'{4}',N'{5}','{6}','{7}','{8}')", nv.MaNV, nv.TenNV, nv.NgSinh, nv.GioiTinh, nv.DiaChi, nv.DtNv, nv.Lcb, nv.NgVLam, nv.MaCV);
                if (connData.ThucThiTruyVan(sql))
                {
                    MessageBox.Show("Thêm hàng hóa thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }
        //Sua nhan vien
        public bool SuaNhanVien(NhanVien nv)
        {
            //MessageBox.Show(hh.NgaySX.ToString("dd/MM/yyyy"));
            //string s = hh.NgaySX.ToString("dd/MM/yyyy");
            //MessageBox.Show(s);
            if (KiemTraTruocKhiLuu(nv))
            {
                string sql = string.Format("UPDATE NHANVIEN SET TENNV= N'{0}', NGSINH= '{1}', GIOITINH = N'{2}', DIACHI = N'{3}', DTNV = '{4}', LCB = '{5}', NGVAOLAM = '{6}', MA_CV = '{7}' WHERE MANV = '{8}'",
                             nv.TenNV, nv.NgSinh, nv.GioiTinh, nv.DiaChi, nv.DtNv, nv.Lcb, nv.NgVLam, nv.MaCV, nv.MaNV);
                if (connData.ThucThiTruyVan(sql))
                {
                    MessageBox.Show("Sửa hàng hóa thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }
        //Xoa nhan vien
        public bool XoaNhanVien(string strMaNV)
        {
            string strSql = string.Format("Delete From NHANVIEN Where MANV='{0}'", strMaNV);
            if (connData.ThucThiTruyVan(strSql))
            {
                MessageBox.Show(string.Format("Xóa nhân viên có mã số '{0}' thành công!", strMaNV), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
        //Phat sinh MaNV tu dong
        public string PhatSinhMaKeTiep()
        {
            return LopDungChung.PhatSinhMaKeTiep(connData.LayThuocTinhPhatSinh("NHANVIEN", "MANV"), "NV");
        }
        //Kiem tra ma
        public bool CheckExists(string manv)
        {
            if (connData.CheckExistValue("NHANVIEN", "MANV", manv))
                return true;
            return false;
        }

        public string LayMaNhanVien(string tenNV)
        {
            string sql = "SELECT MANV FROM NHANVIEN WHERE TENNV = N'" + tenNV + "'";
            DataTable dt = connData.TaoBang(sql);
            DataRow dr = dt.Rows[0];

            string maNV = dr["MANV"].ToString();

            return maNV;
        }
    }
}
