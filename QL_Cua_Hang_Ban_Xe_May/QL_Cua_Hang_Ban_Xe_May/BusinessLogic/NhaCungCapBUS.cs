using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QL_Cua_Hang_Ban_Xe_May.DataAccessLayer;
using System.Data;
using QL_Cua_Hang_Ban_Xe_May.BusinessObject;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_Cua_Hang_Ban_Xe_May.BusinessLogic
{
    class NhaCungCapBUS
    {
        DataAccess connData = new DataAccess();
        //Lay danh sach nha cung cap
        public DataTable LayDanhSachNhaCungCap()
        {
            string sql = "SELECT MAHCC, TENHCC, DIACHI, DTHCC, EMAIL FROM HANGCUNGCAP";
            return connData.TaoBang(sql);
        }

        //Lay ds dia chi nha cung cap
        public DataTable LayDanhSachDiaChiNCC()
        {
            string sql = "SELECT DISTINCT DIACHI FROM HANGCUNGCAP";
            return connData.TaoBang(sql);
        }

        //Phat sinh MaNCC tu dong
        public string PhatSinhMaKeTiep()
        {
            return LopDungChung.PhatSinhMaKeTiep(connData.LayThuocTinhPhatSinh("HANGCUNGCAP", "MAHCC"), "HCC");
        }

        //Them nha cung cap
        public bool ThemNhaCungCap(NhaCungCap ncc)
        {
            if (KiemTraTruocKhiLuu(ncc))
            {
                string sql = string.Format("INSERT INTO HANGCUNGCAP (MAHCC, TENHCC, DIACHI, DTHCC, EMAIL)"
                             + " VALUES ('{0}',N'{1}',N'{2}','{3}','{4}')", ncc.MaNCC, ncc.TenNCC, ncc.DiaChiNCC, ncc.DienThoaiNCC, ncc.EmailNCC);
                if (connData.ThucThiTruyVan(sql))
                {
                    MessageBox.Show("Thêm nhà cung cấp thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //SU DUNG SP
        #region
        //
        public bool ThemNhaCungCapSP(string tenSP, NhaCungCap ncc)
        {
            bool co = false;
            if (KiemTraTruocKhiLuu(ncc))
            {
                SqlCommand myComm = new SqlCommand();
                myComm.CommandText = tenSP;
                myComm.CommandType = CommandType.StoredProcedure;

                myComm.Parameters.Add("@MAHCC", SqlDbType.NVarChar).Value = ncc.MaNCC;
                myComm.Parameters.Add("@TENHCC", SqlDbType.NVarChar).Value = ncc.TenNCC;
                myComm.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = ncc.DiaChiNCC;
                myComm.Parameters.Add("@DTHCC", SqlDbType.NVarChar).Value = ncc.DienThoaiNCC;
                myComm.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = ncc.EmailNCC;

                co = connData.ThucThiTruyVanSP(myComm);
            }
            return co;
        }
        //
        #endregion

        //Kiem tra ton tai
        public bool CheckExistsNCC(string mancc)
        {
            if (connData.CheckExistValue("HANGCUNGCAP", "MAHCC", mancc))
                return true;
            return false;
        }

        //Sửa nhà cung cấp
        public bool SuaNhaCungCap(NhaCungCap ncc)
        {
            if (KiemTraTruocKhiLuu(ncc))
            {
                string sql = string.Format("UPDATE HANGCUNGCAP SET TENHCC = N'{0}', DIACHI = N'{1}', DTHCC = '{2}', EMAIL = N'{3}' WHERE MAHCC = '{4}'",
                             ncc.TenNCC, ncc.DiaChiNCC, ncc.DienThoaiNCC, ncc.EmailNCC, ncc.MaNCC);
                if (connData.ThucThiTruyVan(sql))
                {
                    MessageBox.Show("Sửa nhà cung cấp thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Xoa nha cung cap
        public bool XoaNhaCungCap(string strMaNCC)
        {
            string strSql = string.Format("Delete From HANGCUNGCAP Where MAHCC='{0}'", strMaNCC);
            if (connData.ThucThiTruyVan(strSql))
            {
                MessageBox.Show(string.Format("Xóa nhà cung cấp có mã số '{0}' thành công!", strMaNCC), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        //Kiem tra hang hoa truoc khi luu
        public bool KiemTraTruocKhiLuu(NhaCungCap ncc)
        {
            if (ncc.TenNCC.Equals(""))
            {
                MessageBox.Show("Tên nhà cung cấp không hợp lệ!");
                return false;
            }

            if (ncc.EmailNCC.Equals(""))
            {
                MessageBox.Show("Email nhà cung cấp không hợp lệ!");
                return false;
            }

            if (ncc.DiaChiNCC.Equals(""))
            {
                MessageBox.Show("Địa chỉ nhà cung cấp không hợp lệ!");
                return false;
            }

            if (ncc.DienThoaiNCC.Equals(""))
            {
                MessageBox.Show("Số điện thoại nhà cung cấp không hợp lệ!");
                return false;
            }
            return true;
        }

        public string LayMaNhaCC(string tenNhaCC)
        {
            string sql = "SELECT MAHCC FROM HANGCUNGCAP WHERE TENHCC = N'" + tenNhaCC + "'";
            DataTable dt = connData.TaoBang(sql);
            DataRow dr = dt.Rows[0];

            string maNCC = dr["MAHCC"].ToString();

            return maNCC;
        }
    }
}
