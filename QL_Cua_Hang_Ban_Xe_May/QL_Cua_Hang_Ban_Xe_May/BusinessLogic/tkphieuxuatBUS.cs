using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QL_Cua_Hang_Ban_Xe_May.DataAccessLayer;
using System.Data;

namespace QL_Cua_Hang_Ban_Xe_May.BusinessObject
{
    class tkphieuxuatBUS
    {
        DataAccess myDataAc = new DataAccess();

        public string XacDinhTruyVan(TCPhieuXuat ttphieuxuat)
        {
            string strTamHH = "Select B.MAXUAT, NGAYXUAT, TENNV, TENKH, TENXE,GIAXUAT,THUEXUAT  FROM NHANVIEN A, CHITIET_P_XUAT B, PHIEUXUAT C, KHACHHANG D, THONGTINXEMAY E WHERE A.MANV=C.MANV AND B.MAXUAT=C.MAXUAT AND D.MAKH=C.MAKH AND B.MAXE=E.MAXE";

            if (ttphieuxuat.TenNV != "")
            {
                strTamHH += " AND TENNV Like N'%" + ttphieuxuat.TenNV + "%'";
            }
            if (ttphieuxuat.TenXe != "")
            {
                if (ttphieuxuat.TenNV != "")
                {
                    strTamHH += " and TENXE Like N'%" + ttphieuxuat.TenXe + "%'";
                }
                else
                {
                    strTamHH += " AND TENXE Like N'%" + ttphieuxuat.TenXe + "%'";
                }
            }
            if (ttphieuxuat.TenKH != "")
            {
                if (ttphieuxuat.TenXe != "" || ttphieuxuat.TenNV != "")
                {
                    strTamHH += " and TENKH Like N'%" + ttphieuxuat.TenKH + "%'";
                }
                else
                {
                    strTamHH += " AND TENKH Like N'%" + ttphieuxuat.TenKH + "%'";
                }
            }
            if (ttphieuxuat.GiaXuat != "")
            {
                if (ttphieuxuat.TenXe != "" || ttphieuxuat.TenNV != "" || ttphieuxuat.TenKH != "")
                {
                    strTamHH += " and GIAXUAT Like N'%" + ttphieuxuat.GiaXuat + "%'";
                }
                else
                {
                    strTamHH += " AND GIAXUAT Like N'%" + ttphieuxuat.GiaXuat + "%'";
                }
            }
    
            return strTamHH;
        }
        public DataTable DanhSachPhieuXuat(string strSql)
        {
            return myDataAc.TaoBang(strSql);
        }
    }
}
