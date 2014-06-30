using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QL_Cua_Hang_Ban_Xe_May.DataAccessLayer
{
    class DataAccess
    {
        private SqlConnection myCon;
        private SqlDataAdapter myDataAd;

        private DataTable myDataTable;
        
        public DataAccess()
        {
            KetNoi();
        }

        //Viet ham tao ham ket noi CSDL
        public void KetNoi()
        {
            string strCon = @"Data Source=localhost; Initial Catalog=QUANLYXEMAY; User ID=sa; Password=sa";
            try
            {
                myCon = new SqlConnection(strCon);
                myCon.Open();
                myCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi do kết nối: " + ex.Message);
            }
        }

        public DataTable TaoBang(string strSql)
        {
            myDataAd = new SqlDataAdapter(strSql, myCon);
            //DataTable myTable=new DataTable();
            myDataTable = new DataTable();
            myDataAd.Fill(myDataTable);
            return myDataTable;
        }
        public bool ThucThiTruyVan(string strSql)
        {
            int numCount = 0;

            if (myCon.State == ConnectionState.Closed)
                myCon.Open();

            try
            {
                SqlCommand myComm = new SqlCommand(strSql, myCon);
                numCount = myComm.ExecuteNonQuery();
                myComm.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi do thực thi câu lệnh (Insert, Update, Delete): " + ex.Message);
            }

            if (myCon.State == ConnectionState.Open)
                myCon.Close();

            if (numCount > 0)
                return true;
            return false;
        }


        //STORED PROCEDURE
        public bool ThucThiTruyVanSP(SqlCommand m_Command)
        {
            bool co = false;
            try
            {
                if (myCon.State == ConnectionState.Closed)
                    myCon.Open();

                m_Command.Connection = myCon;

                if (m_Command.ExecuteNonQuery() > 0)
                {
                    co = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi do thực thi câu lệnh SQL(SP): " + ex.Message);
            }

            if (myCon.State == ConnectionState.Open)
                myCon.Close();
            return co;
        }
        //Lay ve gia tri sau cung trong 1 bang, dua tren mot thuoc tinh (dung de phat sinh ma tu dong theo y nguoi dung)
        public string LayThuocTinhPhatSinh(string TenBang, string TenTruong)
        {
            string sql = "Select TOP 1 " + TenTruong + " From " + TenBang + " Order by " + TenTruong + " DESC";
            TaoBang(sql);
            return myDataTable.Rows[0][TenTruong].ToString();
        }

        public bool CheckExistValue(string nameTable, string nameField, string value)
        {
            string sql = "SELECT * FROM " + nameTable + " WHERE " + nameField + " = '" + value + "'";
            TaoBang(sql);
            if (myDataTable.Rows.Count > 0)
                return true;
            return false;
        }
    }
}
