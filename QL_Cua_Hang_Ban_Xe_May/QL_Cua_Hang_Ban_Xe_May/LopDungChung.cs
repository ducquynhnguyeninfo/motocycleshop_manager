using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QL_Cua_Hang_Ban_Xe_May.BusinessObject;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace QL_Cua_Hang_Ban_Xe_May
{
    class LopDungChung
    {
        
        //Phát sinh MAXE tự động
        public static string PhatSinhMaKeTiep(string lastID, string prefixID)
        {
            int nextID = int.Parse(lastID.Remove(0, prefixID.Length)) + 1;
            int lengthNumerID = lastID.Length - prefixID.Length;
            string zeroNumber = "";
            for (int i = 1; i <= lengthNumerID; i++)
            {
                if (nextID < Math.Pow(10, i))
                {
                    for (int j = 1; j <= lengthNumerID - i; i++)
                    {
                        zeroNumber += "0";
                    }
                    return prefixID + zeroNumber + nextID.ToString();
                }
            }
            return prefixID + nextID;

        }

        public static string MaHoaMD5(string text)
        {
            MD5CryptoServiceProvider _md5Hasher = new MD5CryptoServiceProvider();
            byte[] bs = Encoding.UTF8.GetBytes(text);
            bs = _md5Hasher.ComputeHash(bs);
            StringBuilder s = new StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2"));
            }
            return s.ToString();
        }

        //Đánh số thứ tự trên lưới tra cuu hang hoa
        public static void DanhSTT(DataGridView myDGrid, string tenCot, int sobd)
        {
            for (int i = 0; i < myDGrid.RowCount - 1; i++)
            {
                myDGrid.Rows[i].Cells[tenCot].Value = sobd + i;
            }
        }
        //Đánh số thứ tự trên lưới tra cuu hang hoa
        public static void DanhSTTNCC(DataGridView myDGrid, string tenCot, int sobd)
        {
            for (int i = 0; i < myDGrid.RowCount; i++)
            {
                myDGrid.Rows[i].Cells[tenCot].Value = sobd + i;
            }
        }
        public static void CapNhatCotLuoi(DataGridView dgrid, string tenCot, bool co)
        {
            for (int i = 0; i < dgrid.RowCount - 1; i++)
            {
                dgrid.Rows[i].Cells[tenCot].ReadOnly = co;
            }
        }
        #region Thông tin User

            public static User user = new User();

        #endregion
    }
}
