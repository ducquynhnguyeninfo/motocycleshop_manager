using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QL_Cua_Hang_Ban_Xe_May.DataAccessLayer;
using System.Data;

namespace QL_Cua_Hang_Ban_Xe_May.BusinessObject
{
    class tkhanghoaBUS
    {
        DataAccess myDataAc = new DataAccess();

        public string XacDinhTruyVan(TCHangHoa tthanghoa)
        {
            string strTamHH = "Select MAXE, TENXE, NHASX, MAUXE, KIEUDANG, SOKHUNG, SOSUON from THONGTINXEMAY";

            //if (ttsv.MaSV != "" || ttsv.TenSV != "" || ttsv.GioiTinh != "Tất cả" || ttsv.DiaChi != "" || ttsv.MaKhoa != "Tất cả" || ttsv.HocBongTu != "" || ttsv.HocBongDen != "" || ttsv.Tinh != "")
            //    strTam += " Where ";
            //1
            if (tthanghoa.MaXe != "")
            {
                strTamHH += " WHERE MAXE Like '%" + tthanghoa.MaXe + "%'";
            }
            //2
            if (tthanghoa.TenXe != "")
            {
                if (tthanghoa.MaXe != "")
                {
                    strTamHH += " AND TENXE Like '%" + tthanghoa.TenXe + "%'";
                }
                else
                {
                    strTamHH += " WHERE TENXE Like '%" + tthanghoa.TenXe + "%'";
                }
            }
            //3
            if (tthanghoa.NhaSX != "Tất cả")
            {
                if (tthanghoa.MaXe != "" || tthanghoa.TenXe != "")
                {
                    strTamHH += " AND NHASX Like '%" + tthanghoa.NhaSX + "%'";
                }
                else
                {
                    strTamHH += " WHERE NHASX Like '%" + tthanghoa.NhaSX + "%'";
                }
            }
            //4
            if (tthanghoa.KieuDang != "Tất cả")
            {
                if (tthanghoa.NhaSX != "Tất cả" && tthanghoa.MauXe != "Tất cả")
                {
                    strTamHH += " AND KIEUDANG Like N'%" + tthanghoa.KieuDang + "%'";
                }
                else if (tthanghoa.NhaSX != "Tất cả")
                {
                    strTamHH += " AND KIEUDANG Like N'%" + tthanghoa.KieuDang + "%'";
                }
                else if (tthanghoa.MauXe != "Tất cả")
                {
                    strTamHH += " AND KIEUDANG Like N'%" + tthanghoa.KieuDang + "%'";
                }
                else if (tthanghoa.MaXe != "" || tthanghoa.TenXe != "")
                {
                    strTamHH += " AND KIEUDANG Like N'%" + tthanghoa.KieuDang + "%'";
                }
                else
                {
                    strTamHH += " WHERE KIEUDANG Like N'%" + tthanghoa.KieuDang + "%'";
                }
            }

            //7
            if (tthanghoa.MauXe != "Tất cả")
            {
                if (tthanghoa.NhaSX != "Tất cả" || tthanghoa.MaXe != "" || tthanghoa.TenXe != "")
                {
                    strTamHH += " AND MAUXE Like N'%" + tthanghoa.MauXe + "%'";
                }
                //else if (tthanghoa.NhaSX != "Tất cả" && tthanghoa.MauXe != "" && tthanghoa.TenXe != "")
                //{
                //    strTamHH += " AND MAUXE Like N'%" + tthanghoa.MauXe + "%'";
                //}
                else
                {
                    strTamHH += " WHERE MAUXE Like N'%" + tthanghoa.MauXe + "%'";
                }
            }

            //5
            if (tthanghoa.SoKhung != "")
            {
                if (tthanghoa.MaXe != "" || tthanghoa.TenXe != "")
                {
                    strTamHH += " AND SOKHUNG = '" + tthanghoa.SoKhung + "'";
                }
                else if (tthanghoa.KieuDang != "Tất cả" || tthanghoa.NhaSX != "Tất cả" || tthanghoa.MauXe != "Tất cả")
                {
                    strTamHH += " AND SOKHUNG = '" + tthanghoa.SoKhung + "'";
                }
                else
                {
                    strTamHH += " WHERE SOKHUNG = '" + tthanghoa.SoKhung + "'";
                }
            }
            //6
            if (tthanghoa.SoSuon != "")
            {
                if (tthanghoa.MaXe != "" || tthanghoa.TenXe != "")
                {
                    strTamHH += " AND SOSUON Like '%" + tthanghoa.SoSuon + "%'";
                }
                else if (tthanghoa.KieuDang != "Tất cả" || tthanghoa.NhaSX != "Tất cả" || tthanghoa.MauXe != "Tất cả")
                {
                    strTamHH += " AND SOSUON Like '%" + tthanghoa.SoSuon + "%'";
                }
                else
                {
                    strTamHH += " WHERE SOSUON Like '%" + tthanghoa.SoSuon + "%'";
                }
            }
            //
            return strTamHH;
        }

        public DataTable DanhSachHangHoa(string strSql)
        {
            return myDataAc.TaoBang(strSql);
        }
    }
}
