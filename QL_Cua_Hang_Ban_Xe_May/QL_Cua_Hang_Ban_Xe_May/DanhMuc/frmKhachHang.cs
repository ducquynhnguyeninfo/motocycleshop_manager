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
    public partial class frmKhachHang : Form
    {
        private KhachHangBUS khBUS = new KhachHangBUS();
        private int pos = 0;

        public frmKhachHang()
        {
            InitializeComponent();
        }
        private void bt_thoat(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            cbGioiTinh.DataSource = khBUS.LayDanhSachGioiTinh();
            cbGioiTinh.DisplayMember = "GIOITINH";
            cbGioiTinh.ValueMember = "GIOITINH";

            dataGridViewKhachhang.DataSource = khBUS.LayDanhSachKhachHang();
            ThietLapNut(true);
            ThietLapThuocTinh(false);
        }

        private void CheckKeyPress(object sender, KeyPressEventArgs e) //chỉ cho nhập số và kí tự control như lên, xuống, trái, phải...
        {
            //   char checkedchar = "";
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) //&&                (checkedchar = "(" || checkedchar = ")"))
                e.Handled = true;
        }
        private void ThietLapThuocTinh(bool flag)
        {
            TxtMakh.Enabled = flag;
            txtTenKH.Enabled = flag;
            cbGioiTinh.Enabled = flag;
            txtHKTT.Enabled = flag;
            txtDiaChi.Enabled = flag;
            txtDT.Enabled = flag;
            txtCMND.Enabled = flag;
            dateTimePickerNS.Enabled = flag;
        }
        private void ThietLapNut(bool flag)
        {
            btn_LuuKH.Enabled = !flag;
            btn_ThemKH.Enabled = flag;
            btn_SuaKH.Enabled = flag;
            btn_XoaKH.Enabled = flag;
            btn_ThoatKH.Enabled = flag;
        }
        private void DuaDuLieuLendataGridViewNhanVien(int dong)
        {
            if (dong >= dataGridViewKhachhang.RowCount)
                return;
            TxtMakh.Text = dataGridViewKhachhang.Rows[dong].Cells["MAKH"].Value.ToString();
            txtTenKH.Text = dataGridViewKhachhang.Rows[dong].Cells["TENKH"].Value.ToString();
            cbGioiTinh.SelectedValue = dataGridViewKhachhang.Rows[dong].Cells["GIOITINH"].Value.ToString();
            dateTimePickerNS.Text = dataGridViewKhachhang.Rows[dong].Cells["NGAYSINH"].Value.ToString();
            txtDiaChi.Text = dataGridViewKhachhang.Rows[dong].Cells["DC_HIENTAI"].Value.ToString();
            txtHKTT.Text = dataGridViewKhachhang.Rows[dong].Cells["HKTT"].Value.ToString();
            txtDT.Text = dataGridViewKhachhang.Rows[dong].Cells["DTKH"].Value.ToString();
            txtCMND.Text = dataGridViewKhachhang.Rows[dong].Cells["SCMND"].Value.ToString();
        }
        private void dataGridView_KH_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong == dataGridViewKhachhang.RowCount - 1)
            {
                MessageBox.Show("Không có dữ liệu tại dòng này!", "Thông báo");
                dong--;
            }
            DuaDuLieuLendataGridViewNhanVien(dong);
            pos = dong;
        }
        //ThemMoi
        private void ThemMoi()
        {
            txtTenKH.Clear();
            txtHKTT.Text = "";
            txtDiaChi.Text = "";
            txtDT.Text = "";
            dateTimePickerNS.ResetText();
            txtCMND.Text="";
        }

        private void btn_ThemKH_Click(object sender, EventArgs e)
        {
            if (btn_ThemKH.Text == "Thêm")
            {
                TxtMakh.Text = khBUS.PhatSinhMaKeTiep();
                ThietLapThuocTinh(true);
                ThemMoi();
                ThietLapNut(false);
                btn_ThemKH.Text = "Ngừng";
                TxtMakh.Enabled = false;
                btn_ThemKH.Enabled = true;
                dataGridViewKhachhang.Enabled = false;
                txtTenKH.Focus();
            }
            else//btnThem.Text == "Ngừng"
            {
                dataGridViewKhachhang.Enabled = true;
                btn_ThemKH.Text = "Thêm";
                frmKhachHang_Load(sender, e);
            }
        }

        private void btn_SuaKH_Click(object sender, EventArgs e)
        {
            btn_ThemKH.Text = "Ngừng";

            //Sua thi hien thi o thong tin
            txtTenKH.Enabled = true;
            cbGioiTinh.Enabled = true;
            txtHKTT.Enabled = true;
            dateTimePickerNS.Enabled = true;
            txtDiaChi.Enabled = true;
            txtDT.Enabled = true;
            txtCMND.Enabled = true;

            //an cac nut sau
            btn_LuuKH.Enabled = true;
            btn_SuaKH.Enabled = false;
            btn_XoaKH.Enabled = false;

            //an dataGridView
            dataGridViewKhachhang.Enabled = false;
        }
        private KhachHang LayThongTinKhachHang()
        {
            KhachHang kh = new KhachHang();
            kh.MaKH = TxtMakh.Text;
            kh.TenKH = txtTenKH.Text;
            kh.GioiTinh = cbGioiTinh.Text;
            kh.NgSinh = Convert.ToDateTime(dateTimePickerNS.Value.ToShortDateString());
            kh.DiaChi = txtDiaChi.Text;
            kh.Hktt = txtHKTT.Text;
            kh.DienThoai = txtDT.Text;
            kh.CmND = txtCMND.Text;
            return kh;
        }

        private void btn_LuuKH_Click(object sender, EventArgs e)
        {
            KhachHang kh = LayThongTinKhachHang();
            //Ton tai makh (nut Sua)
            if (khBUS.CheckExists(kh.MaKH))
            {
                if (khBUS.SuaKhachHang(kh))
                {
                    frmKhachHang_Load(sender, e);
                    btn_ThemKH.Text = "Thêm";
                    dataGridViewKhachhang.Enabled = true;
                }
            }
            else //(nut Them)
            {
                if (khBUS.ThemKhachHang(kh))
                {
                    frmKhachHang_Load(sender, e);
                    btn_ThemKH.Text = "Thêm";
                    dataGridViewKhachhang.Enabled = true;
                }
            }
        }
        private void btn_XoaKH_Click(object sender, EventArgs e)
        {
            khBUS.XoaKhachHang(TxtMakh.Text);
            frmKhachHang_Load(sender, e);
        }
    }
}
