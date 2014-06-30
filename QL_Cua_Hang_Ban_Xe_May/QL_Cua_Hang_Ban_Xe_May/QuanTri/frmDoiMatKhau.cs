using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QL_Cua_Hang_Ban_Xe_May.BusinessLogic;
using QL_Cua_Hang_Ban_Xe_May.BusinessObject;

namespace QL_Cua_Hang_Ban_Xe_May
{
    public partial class frmDoiMatKhau : Form
    {
        MatKhauBUS MatKhauBUS = new MatKhauBUS();
        MatKhau MatKhau = new MatKhau();
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            ten_dnhap.Text = frmChinh.tendangnhap;
            ThietLapThuocTinh(false);
            ThietLapNut(true);
            matkhauold.Focus();
        }
        private void ThietLapThuocTinh(bool flag)//không cần
        {
            ten_dnhap.Enabled = flag;
        }
        private void ThietLapNut(bool flag)
        {
            luu_mkhau.Enabled = flag;
            thoat.Enabled = flag;
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void luu_mkhau_Click(object sender, EventArgs e)
        {
            string mk = MatKhauBUS.LayMatKhauHienTai(ten_dnhap.Text);

            if (matkhauold.Text != mk)
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (matkhaunew1.Text == "")
                {
                    MessageBox.Show("Mật khẩu mới chưa được nhập", "Thông báo", MessageBoxButtons.OK);
                    matkhaunew1.Focus();
                }
                    else
                    {
                        if (matkhaunew1.Text != matkhaunew2.Text)
                        {
                            MessageBox.Show("Mật khẩu mới không được để trống và phải trùng khớp!", "Thông báo", MessageBoxButtons.OK);
                            matkhaunew2.Focus();
                        }
                        else
                        {
                            MatKhau.TENDN = ten_dnhap.Text;
                            MatKhau.MATKHAU = matkhaunew1.Text;

                            if (MatKhauBUS.DoiMatKhau(MatKhau))
                            {
                                ten_dnhap.Text = frmChinh.tendangnhap;
                                matkhauold.Text = "";
                                matkhaunew1.Text = "";
                                matkhaunew2.Text = "";
                                matkhauold.Focus();
                            }
                        }
                    }
                }
             }

        private void ngung_Click(object sender, EventArgs e)
        {
            if (ngung.Text == "Quay lại")
            {
                matkhauold.Clear();
                matkhaunew1.Clear();
                matkhaunew2.Clear();
                matkhauold.Focus();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
