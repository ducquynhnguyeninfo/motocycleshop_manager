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
    class NhapHangBUS
    {
        DataAccess connData = new DataAccess();
        //Lay danh sach hang hoa trong bang nhap hang , SLNHAP, GIANHAP, THUENHAP
        public DataTable LayDanhSachHangHoaNhap()
        {
            string sql = "SELECT CTPN.MANHAP, CTPN.MAXE, NGAYNHAP, TENNV, TENHCC FROM CHITIET_P_NHAP AS CTPN, PHIEUNHAP AS PN, HANGCUNGCAP AS HCC, NHANVIEN AS NV WHERE CTPN.MANHAP = PN.MANHAP AND PN.MAHCC = HCC.MAHCC AND PN.MANV = NV.MANV AND CTPN.SLNHAP = 0 AND CTPN.GIANHAP = 0 AND CTPN.THUENHAP = 0 ";
            return connData.TaoBang(sql);
        }
        //Lay danh sach bang chi tiet phieu nhap
        public DataTable LayDanhSachCTPhieuNhap()
        {
            string sql = ("SELECT MANHAP, MAXE, SLNHAP, GIANHAP, THUENHAP FROM CHITIET_P_NHAP WHERE SLNHAP != ''");
            return connData.TaoBang(sql);
        }
        //Lay danh sach de xoa bang chi tiet phieu nhap
        public DataTable LayDanhSachXoaCTPhieuNhap()
        {
            string sql = ("SELECT MANHAP, MAXE, SLNHAP, GIANHAP, THUENHAP FROM CHITIET_P_NHAP");
            return connData.TaoBang(sql);
        }

        //Phat sinh MaNhap tu dong
        public string PhatSinhMaPhieuNhapKeTiep()
        {
            return LopDungChung.PhatSinhMaKeTiep(connData.LayThuocTinhPhatSinh("PHIEUNHAP", "MANHAP"), "PN");
        }
        //Phat sinh MaXe tu dong
        public string PhatSinhMaXeKeTiep()
        {
            return LopDungChung.PhatSinhMaKeTiep(connData.LayThuocTinhPhatSinh("CHITIET_P_NHAP", "MAXE"), "XM");
        }

        //Them vao phieu nhap
        public bool ThemPhieuNhap(NhapHang nh)
        {
            if (KiemTraTruocKhiLuu(nh))
            {
                string sql = string.Format("INSERT INTO PHIEUNHAP (MANHAP, NGAYNHAP, MANV, MAHCC)"
                             + " VALUES ('{0}','{1}','{2}','{3}')", nh.MaNhap, nh.NgayNhap, nh.TenNV, nh.TenNCC);
                if (connData.ThucThiTruyVan(sql))
                {
                    MessageBox.Show("Thêm phiếu nhập thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Them vao chi tiet phieu nhap
        public bool ThemCTPhieuNhap(NhapHang nh)
        {
            if (KiemTraTruocKhiLuu(nh))
            {
                string sql = string.Format("INSERT INTO CHITIET_P_NHAP (MANHAP, MAXE, SLNHAP, GIANHAP, THUENHAP)"
                             + " VALUES ('{0}','{1}','{2}','{3}','{4}')", nh.MaNhap, nh.MaXe, nh.SLNhap = 0, nh.GiaNhap = "", nh.ThueNhap = "");
                if (connData.ThucThiTruyVan(sql))
                {
                    MessageBox.Show("Thêm chi tiết phiếu nhập thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Them thong tin xe may
        public bool ThemThongTinXeMay(NhapHang nh)
        {
            if (KiemTraTruocKhiLuu(nh))
            {
                string sql = string.Format("INSERT INTO THONGTINXEMAY (MAXE, TENXE, NHASX, NGAYSX, MAUXE, KIEUDANG, SOKHUNG, SOSUON, GIADENGHI)"
                             + " VALUES ('{0}','{1}','{2}','{3}',N'{4}',N'{5}','{6}','{7}','{8}')", nh.MaXe, nh.TenXe = "", nh.NhaSX, nh.NgaySX, nh.MauXe = "", nh.KieuDang = "", nh.SoKhung = "", nh.SoSuon = "", nh.GiaDeNghi = "");
                if (connData.ThucThiTruyVan(sql))
                {
                    MessageBox.Show("Thêm thông tin xe máy thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        public bool ThemCTPN(NhapHang nh)
        {
            //if (KiemTraHopLe(nh))
            //{
            string strSql = string.Format("UPDATE CHITIET_P_NHAP SET SLNHAP = '{0}', GIANHAP = '{1}', THUENHAP = '{2}' WHERE MANHAP = '{3}'", nh.SLNhap, nh.GiaNhap, nh.ThueNhap, nh.MaNhap);
            if (connData.ThucThiTruyVan(strSql))
            {
                return true;
            }
            //}
            return false;
        }

        public bool KiemTraHopLe(NhapHang nh)
        {
            if (nh.TenNCC.Equals(""))
            {
                MessageBox.Show("Tên nhà cung cấp không hợp lệ!");
                return false;
            }

            if (nh.TenNV.Equals(""))
            {
                MessageBox.Show("Tên nhân viên không hợp lệ!");
                return false;
            }
            return true;
        }

        //Xoa CT phieu nhap
        public bool XoaCTPhieuNhap(string strMaNhap)
        {
            string strSql = string.Format("DELETE FROM PHIEUNHAP WHERE MANHAP='{0}'", strMaNhap);
            if (connData.ThucThiTruyVan(strSql))
            {
                MessageBox.Show(string.Format("Xóa phiếu nhập có mã số '{0}' thành công!", strMaNhap), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
        //Xoa thong tin xe may
        public bool XoaTTXM(string strMaXe)
        {
            string strSql = string.Format("DELETE FROM THONGTINXEMAY WHERE MAXE='{0}'", strMaXe);
            if (connData.ThucThiTruyVan(strSql))
            {
                MessageBox.Show(string.Format("Xóa thông tin xe máy có mã số '{0}' thành công!", strMaXe), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        //Kiem tra hang hoa truoc khi luu
        public bool KiemTraTruocKhiLuu(NhapHang nh)
        {
            if (nh.TenNCC.Equals(""))
            {
                MessageBox.Show("Tên nhà cung cấp không hợp lệ!");
                return false;
            }

            if (nh.TenNV.Equals(""))
            {
                MessageBox.Show("Tên nhân viên không hợp lệ!");
                return false;
            }
            return true;
        }
    }
}
