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
    class HangHoaBUS
    {
        DataAccess connData = new DataAccess();
        //Lay danh sach hang hoa
        public DataTable LayDanhSachHangHoa()
        {
            string sql = "SELECT MAXE, TENXE, GIADENGHI, NHASX, NGAYSX, MAUXE, KIEUDANG, SOKHUNG, SOSUON FROM THONGTINXEMAY WHERE TENXE != ''";
            return connData.TaoBang(sql);
        }

        public DataTable LayDanhSachNhapTTXM()
        {
            string sql = "SELECT MAXE, TENXE, GIADENGHI, NHASX, NGAYSX, MAUXE, KIEUDANG, SOKHUNG, SOSUON FROM THONGTINXEMAY WHERE TENXE = ''";
            return connData.TaoBang(sql);
        }

        //Lay danh sach de xoa
        public DataTable LayDanhSachXoaTTXM()
        {
            string sql = "SELECT MAXE, TENXE, GIADENGHI, NHASX, NGAYSX, MAUXE, KIEUDANG, SOKHUNG, SOSUON FROM THONGTINXEMAY";
            return connData.TaoBang(sql);
        }

        //Xoa dữ liệu bảng thông tin xe máy
        public bool XoaTTXeMay(string strMaXe)
        {
            string strSql = string.Format("DELETE FROM THONGTINXEMAY WHERE MAXE='{0}'", strMaXe);
            if (connData.ThucThiTruyVan(strSql))
            {
                MessageBox.Show(string.Format("Xóa thông tin xe máy có mã số '{0}' thành công!", strMaXe), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        //Lay danh sach gia de nghi
        public DataTable LayDanhSachGiaDeNghi()
        {
            string sql = "SELECT DISTINCT GIADENGHI FROM THONGTINXEMAY";
            return connData.TaoBang(sql);
        }
        //Lay danh sach kieu dang cua xe
        public DataTable LayDanhSachKieuDang()
        {
            string sql = "SELECT DISTINCT KIEUDANG FROM THONGTINXEMAY";
            return connData.TaoBang(sql);
        }
        //Lay danh sach mau xe
        public DataTable LayDanhSachMauXe()
        {
            string sql = "SELECT DISTINCT MAUXE FROM THONGTINXEMAY";
            return connData.TaoBang(sql);
        }
        public DataTable LayDanhSachNhaSX()
        {
            string sql = "SELECT DISTINCT NHASX FROM THONGTINXEMAY";
            return connData.TaoBang(sql);
        }

        //Phat sinh MaXE tu dong
        public string PhatSinhMaKeTiep()
        {
            return LopDungChung.PhatSinhMaKeTiep(connData.LayThuocTinhPhatSinh("THONGTINXEMAY", "MAXE"), "XM");
        }

        //Thêm chi tiết vào bảng thông tin xe máySuaTTXM
        public bool ThemTTXM(HangHoa hh)
        {
            string strSql = string.Format("UPDATE THONGTINXEMAY SET TENXE = '{0}', NHASX = '{1}', NGAYSX = '{2}', MAUXE = N'{3}', KIEUDANG = N'{4}', SOKHUNG = '{5}', SOSUON = '{6}', GIADENGHI = '{7}' WHERE MAXE = '{8}'", hh.TenXe, hh.NhaSX, hh.NgaySX, hh.MauXe, hh.KieuDang, hh.SoKhung, hh.SoSuon, hh.GiaDeNghi, hh.MaXe);
            if (connData.ThucThiTruyVan(strSql))
            {
                return true;
            }
            return false;
        }

        //Sửa chi tiết vào bảng thông tin xe máy
        public bool SuaTTXM(HangHoa hh)
        {
            string strSql = string.Format("UPDATE THONGTINXEMAY SET TENXE = '{0}', NHASX = '{1}', NGAYSX = '{2}', MAUXE = N'{3}', KIEUDANG = N'{4}', SOKHUNG = '{5}', SOSUON = '{6}', GIADENGHI = '{7}' WHERE MAXE = '{8}'", hh.TenXe, hh.NhaSX, hh.NgaySX, hh.MauXe, hh.KieuDang, hh.SoKhung, hh.SoSuon, hh.GiaDeNghi, hh.MaXe);
            if (connData.ThucThiTruyVan(strSql))
            {
                return true;
            }
            return false;
        }

        //Them hang hoa NOTE:Se bo di
        public bool ThemHangHoa(HangHoa hh)
        {
            if (KiemTraTruocKhiLuu(hh))
            {
                string sql = string.Format("INSERT INTO THONGTINXEMAY (MAXE, TENXE, NHASX, NGAYSX, MAUXE, KIEUDANG, SOKHUNG, SOSUON, GIADENGHI)"
                             + " VALUES ('{0}','{1}','{2}','{3}',N'{4}',N'{5}','{6}','{7}','{8}')", hh.MaXe, hh.TenXe, hh.NhaSX, hh.NgaySX, hh.MauXe, hh.KieuDang, hh.SoKhung, hh.SoSuon, hh.GiaDeNghi);
              if (connData.ThucThiTruyVan(sql))
                {
                    MessageBox.Show("Thêm thông tin xe máy thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        ////Them thong tin xe may
        //public bool ThemThongTinXeMay(HangHoa hh)
        //{
        //    if (KiemTraTruocKhiLuu(hh))
        //    {
        //        string sql = string.Format("INSERT INTO THONGTINXEMAY (MAXE, TENXE, NHASX, NGAYSX, MAUXE, KIEUDANG, SOKHUNG, SOSUON, GIADENGHI)"
        //                     + " VALUES ('{0}','{1}','{2}','{3}',N'{4}',N'{5}','{6}','{7}','{8}')", hh.MaXe, hh.TenXe, hh.NhaSX, hh.NgaySX, hh.MauXe, hh.KieuDang, hh.SoKhung, hh.SoSuon, hh.GiaDeNghi);
        //        if (connData.ThucThiTruyVan(sql))
        //        {
        //            MessageBox.Show("Thêm thông tin xe máy thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        public bool CheckExists(string maxe)
        {
            if (connData.CheckExistValue("THONGTINXEMAY", "MAXE", maxe))
                return true;
            return false;
        }

        //Sua hang hoa
        public bool SuaHangHoa(HangHoa hh)
        {
            if (KiemTraTruocKhiLuu(hh))
            {
                string sql = string.Format("UPDATE THONGTINXEMAY SET TENXE = '{0}', NHASX = '{1}', NGAYSX = '{2}', MAUXE = N'{3}', KIEUDANG = N'{4}', SOKHUNG = '{5}', SOSUON = '{6}', GIADENGHI = '{7}' WHERE MAXE = '{8}'",
                             hh.TenXe, hh.NhaSX, hh.NgaySX, hh.MauXe, hh.KieuDang, hh.SoKhung, hh.SoSuon, hh.GiaDeNghi, hh.MaXe);
                if (connData.ThucThiTruyVan(sql))
                {
                    MessageBox.Show("Sửa thông tin xe máy thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Xoa hang hoa
        public bool XoaHangHoa(string strMaXE)
        {
            string strSql = string.Format("Delete From THONGTINXEMAY Where MAXE='{0}'", strMaXE);
            if (connData.ThucThiTruyVan(strSql))
            {
                MessageBox.Show(string.Format("Xóa xe máy có mã số '{0}' thành công!", strMaXE), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        //Kiem tra hang hoa truoc khi luu
        public bool KiemTraTruocKhiLuu(HangHoa hh)
        {
            if (hh.TenXe.Equals(""))
            {
                MessageBox.Show("Tên xe không hợp lệ!");
                return false;
            }

            if (hh.NgaySX.Year < 1975)
            {
                MessageBox.Show("Năm sản xuất không hợp lệ!");
                return false;
            }

            if (hh.SoKhung.Equals(""))
            {
                MessageBox.Show("Số khung không hợp lệ!");
                return false;
            }

            if (hh.SoSuon.Equals(""))
            {
                MessageBox.Show("Số sườn không hợp lệ!");
                return false;
            }
            return true;
        }
    }
}
