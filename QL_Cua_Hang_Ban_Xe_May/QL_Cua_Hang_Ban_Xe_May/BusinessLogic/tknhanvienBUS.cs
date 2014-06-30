using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QL_Cua_Hang_Ban_Xe_May.DataAccessLayer;
using QL_Cua_Hang_Ban_Xe_May.BusinessObject;
using System.Data;

namespace QL_Cua_Hang_Ban_Xe_May.BusinessLogic
{
    class tknhanvienBUS
    {
        DataAccess dataAccess = new DataAccess();
        public string all = "Tất cả";
        public string ALL()
        {
            return all;
        }
        public String XacDinhTruyVan(NVKQ nv)
        {
            //nv = new NhanVien();

            string strSql = "SELECT NHANVIEN.MANV, NHANVIEN.TENNV, NHANVIEN.LCB, NHANVIEN.GIOITINH, NHANVIEN.DIACHI, CHUC_VU.TEN_CV, NHANVIEN.NGVAOLAM FROM NHANVIEN INNER JOIN CHUC_VU ON NHANVIEN.MA_CV = CHUC_VU.MA_CV";
            if (nv.MaNV != "")
            {
                strSql += " AND MANV LIKE '%" + nv.MaNV + "%'";
            }
            if (nv.TenNV != "")
            {
                if (nv.MaNV != "")
                {
                    strSql += " AND  TENNV Like N'%" + nv.TenNV + "%'";
                }
                else
                {
                    strSql += " WHERE TENNV Like N'%" + nv.TenNV + "%'";
                }
            }
            if (nv.GioiTinh != "Tất cả")
            {
                if (nv.TenNV != "" || nv.MaNV != "")
                {
                    strSql += " AND GIOITINH Like N'%" + nv.GioiTinh + "%'";
                }
                else
                {
                    strSql += " WHERE GIOITINH Like N'%" + nv.GioiTinh + "%'";
                }
            }
            if (nv.TENCV != "Tất cả")
            {
                if (nv.TenNV != "" || nv.MaNV != "" || nv.GioiTinh != "")
                {
                    strSql += " AND TEN_CV Like N'%" + nv.TENCV + "%'";
                }
                else
                {
                    strSql += " WHERE TEN_CV Like N'%" + nv.TENCV + "%'";
                }
            }
            //_---------------------------------------------------------------------------
            if ((nv.Lcb != "") && (nv.Lgh != ""))
            {
                strSql += " AND NHANVIEN.LCB >= " + nv.Lcb + " AND NHANVIEN.LCB <= " + nv.Lgh;
            }
            else
            {
                if (nv.Lcb != "")
                    strSql += " AND NHANVIEN.LCB >= " + nv.Lcb;
                if (nv.Lgh != "")
                    strSql += " AND NHANVIEN.LCB <= " + nv.Lgh;
            }
            if (nv.DiaChi != "")
            {
                if (nv.TenNV != "" || nv.MaNV != "" || nv.GioiTinh != "" || nv.TENCV != "")
                {
                    strSql += " AND  DIACHI Like N'%" + nv.DiaChi + "%'";
                }
                else
                {
                    strSql += " WHERE DIACHI Like N'%" + nv.DiaChi + "%'";
                }
            }
            return strSql;
        }
        public DataTable LocBangNhanVien(string sqls)
        {
            DataTable FiltedTable = new DataTable();
            FiltedTable = dataAccess.TaoBang(sqls);
            return FiltedTable;
        }
    }
}
