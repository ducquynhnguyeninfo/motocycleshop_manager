using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QL_Cua_Hang_Ban_Xe_May.DataAccessLayer;
using QL_Cua_Hang_Ban_Xe_May.BusinessObject;
using System.Data;

namespace QL_Cua_Hang_Ban_Xe_May.BusinessLogic
{
    class tknhacungcapBUS
    {
        DataAccess myDataAc = new DataAccess();

        public string XacDinhTruyVan(TCNhaCungCap ttnhacungcap)
        {
            string strTamNCC = "Select MAHCC, TENHCC, DIACHI FROM HANGCUNGCAP";

            if (ttnhacungcap.MaNCC != "")
            {
                strTamNCC += " WHERE MAHCC Like '%" + ttnhacungcap.MaNCC + "%'";
            }

            if (ttnhacungcap.TenNCC != "")
            {
                if (ttnhacungcap.MaNCC != "")
                {
                    strTamNCC += " AND TenHCC Like N'%" + ttnhacungcap.TenNCC + "%'";
                }
                else
                {
                    strTamNCC += " WHERE TenHCC Like N'%" + ttnhacungcap.TenNCC + "%'";
                }
            }

            if (ttnhacungcap.DiaChiNCC != "")
            {
                if (ttnhacungcap.MaNCC != "" || ttnhacungcap.TenNCC != "")
                {
                    strTamNCC += " AND DiaChi Like N'%" + ttnhacungcap.DiaChiNCC + "%'";
                }
                else
                {
                    strTamNCC += " WHERE DiaChi Like N'%" + ttnhacungcap.DiaChiNCC + "%'";
                }
            }

            return strTamNCC;
        }

        public DataTable DanhSachNhaCungCap(string strSql)
        {
            return myDataAc.TaoBang(strSql);
        }
    }
}

