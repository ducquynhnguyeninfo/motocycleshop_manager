using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QL_Cua_Hang_Ban_Xe_May.BusinessLogic;
namespace QL_Cua_Hang_Ban_Xe_May
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        UserBUS myUser = new UserBUS();
        
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool kt;
        private void btn_DongY_Click(object sender, EventArgs e)
        {
            bool kq = myUser.LayThongTinUser(txtTenDN.Text, txtMatKhau.Text);
            if (kq == true)
            {
                this.Close();
                kt = true;
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                frmDangNhap_Load(sender, e);
                kt = false;

            }
        }

        private void btn_Huy_Click(object sender, EventArgs e) //Day la nut thoat
        {     
                Application.Exit();  
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
