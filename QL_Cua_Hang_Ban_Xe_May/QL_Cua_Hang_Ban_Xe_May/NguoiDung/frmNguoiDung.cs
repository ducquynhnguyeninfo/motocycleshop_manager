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
    public partial class frmNguoiDung : Form
    {
        private NguoiDungBUS ngdungBUS = new NguoiDungBUS();
        private NhomNguoiDungBUS nhngdBUS = new NhomNguoiDungBUS();
        NguoiDungObject ndOB;// = new NguoiDungObject();
        int rowsnumber;
        int dong;

        public frmNguoiDung()
        {
            InitializeComponent();
        }

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            //DataTable tableNhomNguoiDung = nhngdBUS.LayDanhSachNguoiDung();
           
            //for (int i = 0; i < tableNhomNguoiDung.Rows.Count; i++)
            //{ 
            //    cbo_tennhomnd.Items.Add(tableNhomNguoiDung.Rows[i]["TenNhom"]);
                
            //}
            cbo_tennhomnd.DataSource = nhngdBUS.LayDanhSachNhomNguoiDung();
            cbo_tennhomnd.DisplayMember = "TENNHOM";
            cbo_tennhomnd.ValueMember = "MANHOM";
            ThietLapNut(true);
            ThietLapThuocTinhinput(false);
            txtMaND.Enabled = false;
            DataTable dsnguoidung = ngdungBUS.LayDanhSachNguoiDung();
            rowsnumber = dsnguoidung.Rows.Count;
            dataGridViewNguoidung.DataSource = dsnguoidung;
            LopDungChung.DanhSTT(dataGridViewNguoidung, "dgcSTT", 1);
            
        }

        private void CheckKeyPress(object sender, KeyPressEventArgs e) //chỉ cho nhập số và kí tự control như lên, xuống, trái, phải...
        {
            //   char checkedchar = "";
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) //&&                (checkedchar = "(" || checkedchar = ")"))
                e.Handled = true;
        }

        private void ThietLapThuocTinhinput(bool flag)
        {
            txtMaND.Enabled = flag;
            txtTenDN.Enabled = flag;
            cbo_tennhomnd.Enabled = flag;
            DateNgaySinh.Enabled = flag;
            txtMatKhau.Enabled = flag;
            txtTen.Enabled = flag;
            txtSDT.Enabled = flag;
            txtDiaChi.Enabled = flag;
        }
        private void ThietLapNut(bool flag)
        {
            btn_Luu.Enabled = !flag;
            btn_Them.Enabled = flag;
            btn_Sua.Enabled = flag;
            btn_Xoa.Enabled = flag;
            btn_Thoat.Enabled = flag;
        }

        private void dataGridViewNguoidung_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            if (dong == rowsnumber)
            {
                MessageBox.Show("Không tồn tại dữ liệu tại dòng này", "Thông báo:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                txtMaND.Text = dataGridViewNguoidung.Rows[dong].Cells["dgcMAND"].Value.ToString();
                txtTenDN.Text = dataGridViewNguoidung.Rows[dong].Cells["dgcTENDN"].Value.ToString();
                cbo_tennhomnd.Text = dataGridViewNguoidung.Rows[dong].Cells["dgcTenNhom"].Value.ToString();
                DateNgaySinh.Text = dataGridViewNguoidung.Rows[dong].Cells["dgcNGAYSINH"].Value.ToString();
                txtMatKhau.Text = dataGridViewNguoidung.Rows[dong].Cells["dgcMATKHAU"].Value.ToString();
                txtTen.Text = dataGridViewNguoidung.Rows[dong].Cells["dgcHOTEN"].Value.ToString();
                txtSDT.Text = dataGridViewNguoidung.Rows[dong].Cells["dgcSDT"].Value.ToString();
                txtDiaChi.Text = dataGridViewNguoidung.Rows[dong].Cells["dgcDIACHI"].Value.ToString();
                ThietLapThuocTinhinput(false);
                ThietLapNut(true);
                //btn_Xoa.Enabled = false;
                //btn_Sua.Enabled = false;
                //btn_Xoa.Enabled = true;
                //btn_Sua.Enabled = true;
            }
        }
        
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa người dùng có tài khoản " + txtTenDN.Text + " không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ngdungBUS.XoaNguoiDung(dataGridViewNguoidung.Rows[dong].Cells["dgcMAND"].Value.ToString()))
                {
                    frmNguoiDung_Load(sender, e);
                }
                else
                    frmNguoiDung_Load(sender, e);
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            btn_Them.Text = "Ngừng";

            txtTenDN.Enabled = true;
            cbo_tennhomnd.Enabled = true;
            DateNgaySinh.Enabled = true;
            txtMatKhau.Enabled = true;
            txtTen.Enabled = true;
            txtSDT.Enabled = true;
            txtDiaChi.Enabled = true;

            //an cac nut sau
            btn_Luu.Enabled = true;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            dataGridViewNguoidung.Enabled = false;
        }
        private void ThemMoi()
        {
            txtTen.Clear();
            txtMatKhau.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtTenDN.Clear();
            cbo_tennhomnd.ResetText();
            DateNgaySinh.ResetText();
            txtTenDN.Focus();
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (btn_Them.Text == "Thêm")
            {
                txtMaND.Text = ngdungBUS.PhatSinhMaKeTiep();
                ThietLapThuocTinhinput(true);
                ThemMoi();
                cbo_tennhomnd.Text = "Chọn nhóm";
                ThietLapNut(false);
                btn_Them.Text = "Ngừng";
                txtMaND.Enabled = false;
                btn_Them.Enabled = true;
                dataGridViewNguoidung.Enabled = false;
            }
            else
            {
                dataGridViewNguoidung.Enabled = true;
                btn_Them.Text = "Thêm";
                frmNguoiDung_Load(sender, e);
            }
        }
        private NguoiDungObject LayThongTinNguoiDung()
        {
            ndOB = new NguoiDungObject();
            ndOB.MaNd = txtMaND.Text;
            ndOB.MaNhom = cbo_tennhomnd.SelectedValue.ToString();
            ndOB.TenDN = txtTenDN.Text;
            ndOB.HoTen = txtTen.Text;
            ndOB.NgaySinh = Convert.ToDateTime(DateNgaySinh.Value.ToShortDateString());
            ndOB.MatKhau = txtMatKhau.Text;
            ndOB.DiaChi = txtDiaChi.Text;
            ndOB.Sdt = txtSDT.Text;
            return ndOB;
        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            NguoiDungObject ndBO = LayThongTinNguoiDung();
            //Ton tai maxe (nut Sua)
            if (ngdungBUS.CheckExists(ndBO.MaNd))
            {
                if (ngdungBUS.SuaNguoiDung(ndOB))
                {
                    frmNguoiDung_Load(sender, e);
                    btn_Them.Text = "Thêm";
                    dataGridViewNguoidung.Enabled = true;
                }
            }
            else 
            {
                if (ngdungBUS.ThemNguoiDungSP("pro_ThemNguoiDung", ndOB))//ngdungBUS.ThemNguoiDung(ndOB)//
                {
                    MessageBox.Show("Thêm thông tin người dùng thành công!", "Thông báo");
                    frmNguoiDung_Load(sender, e);
                    btn_Them.Text = "Thêm";
                    dataGridViewNguoidung.Enabled = true;
                }
            }
                
        }

        private void dataGridViewNguoidung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LopDungChung.DanhSTT(dataGridViewNguoidung, "dgcSTT", 1);
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
