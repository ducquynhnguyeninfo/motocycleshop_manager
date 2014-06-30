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
    class XuatHangBUS
    {
        DataAccess connData = new DataAccess();
        //Lay danh sach hang hoa trong bang xuat hang , SLXUAT, GIAXUAT, THUEXUAT
        public DataTable LayDanhSachHangHoaXuat()
        {
            string sql = "SELECT CTPX.MAXUAT, CTPX.MAXE, NGAYXUAT, TENNV, TENKH FROM CHITIET_P_XUAT AS CTPX, PHIEUXUAT AS PX, KHACHHANG AS KH, NHANVIEN AS NV WHERE CTPX.MAXUAT = PX.MAXUAT AND PX.MAKH = KH.MAKH AND PX.MANV = NV.MANV AND CTPX.SLXUAT = 0 AND CTPX.GIAXUAT = 0 AND CTPX.THUEXUAT = 0 ";
            return connData.TaoBang(sql);
        }

        //Lay danh sach bang chi tiet phieu xuat
        public DataTable LayDanhSachCTPhieuXuat()
        {
            string sql = ("SELECT MAXUAT, MAXE, SLXUAT, GIAXUAT, THUEXUAT FROM CHITIET_P_XUAT WHERE SLXUAT != ''");
            return connData.TaoBang(sql);
        }

        //Lay danh sach de xoa bang chi tiet phieu xuat
        public DataTable LayDanhSachXoaCTPhieuXuat()
        {
            string sql = ("SELECT MAXUAT, MAXE, SLXUAT, GIAXUAT, THUEXUAT FROM CHITIET_P_XUAT");
            return connData.TaoBang(sql);
        }

        //Xoa CT phieu xuat
        public bool XoaCTPhieuXuat(string strMaXuat)
        {
            string strSql = string.Format("DELETE FROM PHIEUXUAT WHERE MAXUAT='{0}'", strMaXuat);
            if (connData.ThucThiTruyVan(strSql))
            {
                MessageBox.Show(string.Format("Xóa phiếu xuất có mã số '{0}' thành công!", strMaXuat), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        //Phat sinh MaXuat tu dong
        public string PhatSinhMaPhieuXuatKeTiep()
        {
            return LopDungChung.PhatSinhMaKeTiep(connData.LayThuocTinhPhatSinh("CHITIET_P_XUAT", "MAXUAT"), "PX");
        }
        //Phat sinh MaXe tu dong
        public string PhatSinhMaXeKeTiep()
        {
            return LopDungChung.PhatSinhMaKeTiep(connData.LayThuocTinhPhatSinh("CHITIET_P_XUAT", "MAXE"), "XM");
        }

        //Them vao phieu nhap
        public bool ThemPhieuXuat(XuatHang xh)
        {
            if (KiemTraTruocKhiLuu(xh))
            {
                string sql = string.Format("INSERT INTO PHIEUXUAT (MAXUAT, NGAYXUAT, MANV, MAKH)"
                             + " VALUES ('{0}','{1}','{2}','{3}')", xh.MaXuat, xh.NgayXuat, xh.TenNV, xh.TenKH);
                if (connData.ThucThiTruyVan(sql))
                {
                    MessageBox.Show("Thêm phiếu xuất thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Them vao chi tiet phieu nhap
        public bool ThemCTPhieuXuat(XuatHang xh)
        {
            if (KiemTraTruocKhiLuu(xh))
            {
                string sql = string.Format("INSERT INTO CHITIET_P_XUAT (MAXUAT, MAXE, SLXUAT, GIAXUAT, THUEXUAT)"
                             + " VALUES ('{0}','{1}','{2}','{3}','{4}')", xh.MaXuat, xh.MaXe, xh.SLXuat = 0, xh.GiaXuat = "", xh.ThueXuat = "");
                if (connData.ThucThiTruyVan(sql))
                {
                    MessageBox.Show("Thêm chi tiết phiếu xuất thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        public bool ThemCTPX(XuatHang xh)
        {
            string strSql = string.Format("UPDATE CHITIET_P_XUAT SET SLXUAT = '{0}', GIAXUAT = '{1}', THUEXUAT = '{2}' WHERE MAXUAT = '{3}'", xh.SLXuat, xh.GiaXuat, xh.ThueXuat, xh.MaXuat);
            if (connData.ThucThiTruyVan(strSql))
            {
                return true;
            }
            return false;
        }

        //Kiem tra hang hoa truoc khi luu
        public bool KiemTraTruocKhiLuu(XuatHang xh)
        {
            if (xh.TenKH.Equals(""))
            {
                MessageBox.Show("Tên khách hàng không hợp lệ!");
                return false;
            }

            if (xh.TenNV.Equals(""))
            {
                MessageBox.Show("Tên nhân viên không hợp lệ!");
                return false;
            }
            return true;
        }
    }
}
