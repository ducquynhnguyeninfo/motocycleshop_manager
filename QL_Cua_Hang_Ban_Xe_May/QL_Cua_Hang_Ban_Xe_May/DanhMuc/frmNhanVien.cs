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
    public partial class frmNhanVien : Form
    {
        NhanVienBUS nvBUS = new NhanVienBUS();
        ChucVuBUS cvBUS = new ChucVuBUS();
        bool bienNV = true;
        private int pos = 0;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            cboChucVu.DataSource = nvBUS.LayDanhSachChucVu();
            cboChucVu.DisplayMember = "TEN_CV";
            cboChucVu.ValueMember = "MA_CV";

            cbGioiTinh.DataSource = nvBUS.LayDanhSachGioiTinh();
            cbGioiTinh.DisplayMember = "GIOITINH";
            cbGioiTinh.ValueMember = "GIOITINH";


            //cboKieuDangHH.DataSource = hhBUS.LayDanhSachKieuDang();
            //cboKieuDangHH.DisplayMember = "KieuDang";
            //cboKieuDangHH.ValueMember = "KieuDang";
            //cboGioiTinh.DataSource = nvBUS.LayDanhSachGioiTinh();
            //cboGioiTinh.DisplayMember = "GIOITINH";
            //cboGioiTinh.ValueMember = "GIOITINH";

            dataGridViewNhanVien.DataSource = nvBUS.LayDanhSachNhanVien();
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
            //txtMaSV.Enabled = flag;
            txtMaNV.Enabled = flag;
            txtTenNV.Enabled = flag;
            cboChucVu.Enabled = flag;
            txtDienThoai.Enabled = flag;
            txtDiaChi.Enabled = flag;
            txtLuong.Enabled = flag;
            cbGioiTinh.Enabled = flag;
            dateTimePickerNS.Enabled = flag;
            dateTimePickerNVL.Enabled = flag;
            //cboGioiTinh.Enabled = flag;
        }
        //Thiet lap nut
        private void ThietLapNut(bool flag)
        {
            btn_LuuHH.Enabled = !flag;
            btn_ThemHH.Enabled = flag;
            btn_SuaHH.Enabled = flag;
            btn_XoaHH.Enabled = flag;
            btn_ThoatHH.Enabled = flag;
        }
        private void DuaDuLieuLendataGridViewNhanVien(int dong)
        {
            if (dong >= dataGridViewNhanVien.RowCount)
                return;
            txtMaNV.Text = dataGridViewNhanVien.Rows[dong].Cells["MANV"].Value.ToString();
            txtTenNV.Text = dataGridViewNhanVien.Rows[dong].Cells["TENNV"].Value.ToString();
            dateTimePickerNS.Text = dataGridViewNhanVien.Rows[dong].Cells["NGSINH"].Value.ToString();
            cbGioiTinh.SelectedValue = dataGridViewNhanVien.Rows[dong].Cells["GIOITINH"].Value.ToString();
            txtDiaChi.Text = dataGridViewNhanVien.Rows[dong].Cells["DIACHI"].Value.ToString();
            txtDienThoai.Text = dataGridViewNhanVien.Rows[dong].Cells["DTNV"].Value.ToString();
            txtLuong.Text = dataGridViewNhanVien.Rows[dong].Cells["LCB"].Value.ToString();
            dateTimePickerNVL.Text = dataGridViewNhanVien.Rows[dong].Cells["NGVAOLAM"].Value.ToString();
            cboChucVu.Text = dataGridViewNhanVien.Rows[dong].Cells["TEN_CV"].Value.ToString();
        }
        private void dataGridViewNhanVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong == dataGridViewNhanVien.RowCount - 1)
            {
                MessageBox.Show("Không có dữ liệu tại dòng này!", "Thông báo");
                btn_SuaHH.Enabled = false;
                btn_XoaHH.Enabled = false;
                bienNV = false;
                dong--;
            }
            else if (bienNV == false)
            {
                btn_XoaHH.Enabled = true;
                btn_SuaHH.Enabled = true;
            }
            DuaDuLieuLendataGridViewNhanVien(dong);
            pos = dong;
        }
        private void btn_ThoatHH_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //ThemMoi
        private void ThemMoi()
        {
            txtTenNV.Clear();
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            txtLuong.Text = "";
            dateTimePickerNS.ResetText();
            dateTimePickerNVL.ResetText();
        }
        private void btn_ThemHH_Click(object sender, EventArgs e)
        {
            if (btn_ThemHH.Text == "Thêm")
            {
                txtMaNV.Text = nvBUS.PhatSinhMaKeTiep();
                ThietLapThuocTinh(true);
                ThemMoi();
                ThietLapNut(false);
                btn_ThemHH.Text = "Ngừng";
                txtMaNV.Enabled = false;
                btn_ThemHH.Enabled = true;
                dataGridViewNhanVien.Enabled = false;
                txtTenNV.Focus();
            }
            else//btnThem.Text == "Ngừng"
            {
                dataGridViewNhanVien.Enabled = true;
                btn_ThemHH.Text = "Thêm";
                frmNhanVien_Load(sender, e);
            }
        }

        private void btn_SuaHH_Click(object sender, EventArgs e)
        {
            //HangHoa hh = LayThongTinHangHoa();
            btn_ThemHH.Text = "Ngừng";

            //Sua thi hien thi o thong tin
            txtTenNV.Enabled = true;
            cbGioiTinh.Enabled = true;
            cboChucVu.Enabled = true;
            dateTimePickerNS.Enabled = true;
            dateTimePickerNVL.Enabled = true;
            txtDienThoai.Enabled = true;
            txtLuong.Enabled = true;
            txtDiaChi.Enabled = true;

            //an cac nut sau
            btn_LuuHH.Enabled = true;
            btn_SuaHH.Enabled = false;
            btn_XoaHH.Enabled = false;

            //an dataGridView
            dataGridViewNhanVien.Enabled = false;
        }
        private NhanVien LayThongTinNhanVien()
        {
            NhanVien nv = new NhanVien();
            nv.MaNV = txtMaNV.Text;
            nv.TenNV = txtTenNV.Text;
            nv.NgSinh = Convert.ToDateTime(dateTimePickerNS.Value.ToShortDateString());
            nv.GioiTinh = cbGioiTinh.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.DtNv = txtDienThoai.Text;
            nv.Lcb = txtLuong.Text;
            nv.NgVLam = Convert.ToDateTime(dateTimePickerNVL.Value.ToShortDateString());
            nv.MaCV = cvBUS.LayMaChucVu(cboChucVu.Text);
            //nh.TenNV = nvBUS.LayMaNhanVien(cboTenNV.Text);
            return nv;
        }
        private void btn_LuuHH_Click(object sender, EventArgs e)
        {
            NhanVien nv = LayThongTinNhanVien();
            //Ton tai manv (nut Sua)
            if (nvBUS.CheckExists(nv.MaNV))
            {
                if (nvBUS.SuaNhanVien(nv))
                {
                    frmNhanVien_Load(sender, e);
                    btn_ThemHH.Text = "Thêm";
                    dataGridViewNhanVien.Enabled = true;
                }
            }
            else //(nut Them)
            {
                if (nvBUS.ThemNhanVien(nv))
                {
                    frmNhanVien_Load(sender, e);
                    btn_ThemHH.Text = "Thêm";
                    dataGridViewNhanVien.Enabled = true;
                }
            }
        }
        private void btn_XoaHH_Click(object sender, EventArgs e)
        {
            nvBUS.XoaNhanVien(txtMaNV.Text);
            frmNhanVien_Load(sender, e);
        }

        private void dataGridViewNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
