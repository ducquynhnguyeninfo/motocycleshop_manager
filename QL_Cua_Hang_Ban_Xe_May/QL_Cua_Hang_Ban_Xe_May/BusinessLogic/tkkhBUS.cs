using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QL_Cua_Hang_Ban_Xe_May.DataAccessLayer;
using QL_Cua_Hang_Ban_Xe_May.BusinessObject;
using System.Data;

namespace QL_Cua_Hang_Ban_Xe_May.BusinessLogic
{
    class tkkhBUS
    {
        DataAccess myDataAc = new DataAccess();

        public string XacDinhTruyVan(TKKH ttkh)
        {
            string strTam = "SELECT MAKH,TENKH,GIOITINH,NGAYSINH,DC_HIENTAI,HKTT,SCMND FROM KHACHHANG";

            //if (ttsv.MaSV != "" || ttsv.TenSV != "" || ttsv.GioiTinh != "Tất cả" || ttsv.DiaChi != "" || ttsv.MaKhoa != "Tất cả" || ttsv.HocBongTu != "" || ttsv.HocBongDen != "" || ttsv.Tinh != "")
            //    strTam += " Where ";
            //
            if (ttkh.MaKH != "")
            {
                strTam += " WHERE MAKH Like '%" + ttkh.MaKH + "%'";
            }
            //
            if (ttkh.TenKH != "")
            {
                if (ttkh.MaKH != "")
                {
                    strTam += " AND TENKH Like N'%" + ttkh.TenKH + "%'";
                }
                else
                {
                    strTam += " WHERE TENKH Like N'%" + ttkh.TenKH + "%'";
                }
            }
            //
            if (ttkh.GioiTinh != "Tất cả")
            {
                if (ttkh.MaKH != "" || ttkh.TenKH != "")
                {
                    strTam += " AND GIOITINH Like N'%" + ttkh.GioiTinh + "%'";
                }
                else
                {
                    strTam += " WHERE GIOITINH Like N'%" + ttkh.GioiTinh + "%'";
                }
            }
            //
            if (ttkh.DiaChi != "")
            {
                if (ttkh.MaKH != "" || ttkh.TenKH != "")
                {
                    strTam += " AND DC_HIENTAI like N'" + ttkh.DiaChi + "'";
                }
                else if (ttkh.GioiTinh != "Tất cả")
                {
                    strTam += " AND DC_HIENTAI like N'" + ttkh.DiaChi + "'";
                }
                else
                {
                    strTam += " WHERE DC_HIENTAI Like N'%" + ttkh.DiaChi + "%'";
                }
            }
            //
            if (ttkh.HKtt != "")
            {
                if (ttkh.MaKH != "" || ttkh.TenKH != "")
                {
                    strTam += " AND HKTT like N'" + ttkh.HKtt + "'";
                }
                else if (ttkh.GioiTinh != "Tất cả")
                {
                    strTam += " AND HKTT like N'" + ttkh.HKtt + "'";
                }
                else if (ttkh.DiaChi != "")
                {
                    strTam += " AND HKTT Like N'%" + ttkh.HKtt + "%'";
                }
                else
                {
                    strTam += " WHERE HKTT Like N'%" + ttkh.HKtt + "%'";
                }
            }
            //
            return strTam;
        }
        //
        public DataTable DanhSachKhachHang(string strSql)
        {
            return myDataAc.TaoBang(strSql);
        }
    }
}
