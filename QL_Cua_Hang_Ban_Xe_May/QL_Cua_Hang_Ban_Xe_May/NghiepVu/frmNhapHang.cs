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
    public partial class frmNhapHang : Form
    {
        private NhapHangBUS nhBUS = new NhapHangBUS();
        private NhaCungCapBUS nccBUS = new NhaCungCapBUS();
        private NhanVienBUS nvBUS = new NhanVienBUS();
        private HangHoaBUS hhBUS = new HangHoaBUS();
        private int pos = 0;
        bool bienNH = true;
        public frmNhapHang()
        {
            InitializeComponent();
        }

        //Thiet lap thuoc tinh
        private void ThietLapThuocTinhNhapHang(bool flag)
        {
            txtMaNhap.Enabled = flag;
            txtMaXe.Enabled = flag;
            dateTimePickerNhapHang.Enabled = flag;
            cboTenNCC.Enabled = flag;
            cboTenNV.Enabled = flag;
        }

        //Thiet lap nut
        private void ThietLapNutNhapHang(bool flag)
        {
            //Nut bang phieu nhap
            btn_ThemNH.Enabled = flag;
            btn_ThoatPNhap.Enabled = flag;
            //Nut bang chi tiet phieu nhap
            btn_NhapHang.Enabled = !flag;
            btn_LuuNH.Enabled = !flag;
            btn_SuaNH.Enabled = !flag;
            btn_XoaNH.Enabled = !flag;
            btn_ThoatNH.Enabled = !flag;
            btn_ThemCTPN.Enabled = !flag;
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            //Load du lieu len combobox ten nha cung cap
            cboTenNCC.DataSource = nccBUS.LayDanhSachNhaCungCap();
            cboTenNCC.DisplayMember = "TENHCC";
            cboTenNCC.ValueMember = "MAHCC";

            //Load du lieu len combobox ten nhan vien
            cboTenNV.DataSource = nvBUS.LayDanhSachNhanVien();
            cboTenNV.DisplayMember = "TENNV";
            cboTenNV.ValueMember = "MANV";

            //Load du lieu len dataGridView
            dataGridViewNhapHang.DataSource = nhBUS.LayDanhSachHangHoaNhap();
            //dataGridViewSuaCTPN.DataSource = nhBUS.LayDanhSachCTPhieuNhap();
            //dataGridViewSuaCTPN.DataSource = nhBUS.LayDanhSachSuaCTPhieuNhap();
            ThietLapNutNhapHang(true);
            ThietLapThuocTinhNhapHang(false);
            dataGridViewNhapHang.ReadOnly = true;
            dataGridViewSuaCTPN.Visible = false;
            btn_ThaoTacCTPN.Enabled = true;
            btn_XoaNH.Text = "Tìm Xóa";
            btn_SuaNH.Enabled = false;
            btn_XoaNH.Enabled = false;
        }

        private void dataGridViewNhapHang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaNhap.Text = dataGridViewNhapHang.Rows[dong].Cells["MaNhap"].Value.ToString();
            txtMaXe.Text = dataGridViewNhapHang.Rows[dong].Cells["MaXe"].Value.ToString();
            dateTimePickerNhapHang.Text = dataGridViewNhapHang.Rows[dong].Cells["NgayNhap"].Value.ToString();
            cboTenNCC.Text = dataGridViewNhapHang.Rows[dong].Cells["colTenNCC"].Value.ToString();
            cboTenNV.Text = dataGridViewNhapHang.Rows[dong].Cells["colTenNV"].Value.ToString();
        }

        //Them moi
        private void ThemMoiNH()
        {
            dateTimePickerNhapHang.ResetText();
        }

        private void btn_ThemNH_Click(object sender, EventArgs e)
        {
            if (btn_ThemNH.Text == "Thêm P_Nhập")
            {
                txtMaNhap.Text = nhBUS.PhatSinhMaPhieuNhapKeTiep();
                txtMaXe.Text = nhBUS.PhatSinhMaXeKeTiep();
                ThietLapThuocTinhNhapHang(true);
                //ThietLapNutNhapHang(false);
                //Cac nut thap tac den bang phieu nhap
                btn_NhapHang.Enabled = true;
                btn_ThoatPNhap.Enabled = false;

                //Cac nut thao tac den bang chi tiet phieu nhap
                btn_ThaoTacCTPN.Enabled = false;
                btn_LuuNH.Enabled = false;

                btn_SuaNH.Enabled = false;
                btn_XoaNH.Enabled = false;
                btn_ThoatNH.Enabled = false;
                btn_ThemCTPN.Enabled = false;

                //Thong tin phieu nhap
                txtMaNhap.Enabled = false;
                txtMaXe.Enabled = false;
                btn_ThemNH.Enabled = true;
                dataGridViewNhapHang.Enabled = false;

                ThemMoiNH();
                btn_ThemNH.Text = "Ngừng";
                dataGridViewNhapHang.Focus();
            }
            else//btnThem.Text == "Ngừng"
            {
                dataGridViewNhapHang.Enabled = true;
                btn_ThemNH.Text = "Thêm P_Nhập";
                btn_ThoatPNhap.Enabled = true;
                btn_ThaoTacCTPN.Enabled = true;
                frmNhapHang_Load(sender, e);
            }
        }

        //Lay thong tin tren phieu nhap
        private NhapHang LayThongTinPhieuNhap()
        {
            NhapHang nh = new NhapHang();
            nh.MaNhap = txtMaNhap.Text;
            nh.MaXe = txtMaXe.Text;
            nh.NgayNhap = Convert.ToDateTime(dateTimePickerNhapHang.Value.ToShortDateString());
            nh.NgaySX = Convert.ToDateTime(dateTimePickerNgaySanXuat.Value.ToShortDateString());
            nh.TenNCC = nccBUS.LayMaNhaCC(cboTenNCC.Text);
            nh.TenNV = nvBUS.LayMaNhanVien(cboTenNV.Text);
            nh.NhaSX = cboTenNCC.Text;
            return nh;
        }

        //Luu thong tin dua vao bang phieu nhap va chi tiet phieu nhap
        private void btn_NhapHang_Click(object sender, EventArgs e)
        {
            NhapHang nh = LayThongTinPhieuNhap();

            nhBUS.ThemThongTinXeMay(nh);
            nhBUS.ThemPhieuNhap(nh);
            nhBUS.ThemCTPhieuNhap(nh);
            

            frmNhapHang_Load(sender, e);
            btn_NhapHang.Enabled = false;
            btn_ThemNH.Text = "Thêm P_Nhập";
            btn_ThaoTacCTPN.Enabled = true;
            //dataGridViewNhapHang.ReadOnly = false;
        }

        //CAC THAO TAC TAC DONG DEN VIEC NHAP DU LIEU CHO BANG CHI TIET PHIEU NHAP
        private void btn_ThaoTacCTPN_Click(object sender, EventArgs e)
        {
            if (btn_ThaoTacCTPN.Text == "Thao Tác Trên Bảng CT Phiếu Nhập")
            {
                ThietLapTrenBangPN(true);
                ThietLapTrenBangCTPN(true);
                btn_ThaoTacCTPN.Text = "Ngừng Thao Tác Trên Bảng CT Phiếu Nhập";
                dataGridViewNhapHang.ReadOnly = true;
            }
            else
            {
                btn_ThemCTPN.Text = "Nhập";
                btn_ThaoTacCTPN.Text = "Thao Tác Trên Bảng CT Phiếu Nhập";
                ThietLapTrenBangPN(false);
                ThietLapTrenBangCTPN(false);
                btn_LuuNH.Enabled = false;
                btn_NhapHang.Enabled = false;
                txtMaNhap.Enabled = false;
                txtMaXe.Enabled = false;
                dateTimePickerNhapHang.Enabled = false;
                cboTenNCC.Enabled = false;
                cboTenNV.Enabled = false;
                dataGridViewNhapHang.ReadOnly = true;
                btn_XoaNH.Text = "Tìm Xóa";
            }
        }

        //AN CAC THUOC TINH LIEN QUAN DEN BANG PHIEU NHAP
        private void ThietLapTrenBangPN(bool flag)
        {
            txtMaNhap.Enabled = !flag;
            txtMaXe.Enabled = !flag;
            dateTimePickerNhapHang.Enabled = !flag;
            cboTenNCC.Enabled = !flag;
            cboTenNV.Enabled = !flag;
            btn_ThemNH.Enabled = !flag;
            btn_NhapHang.Enabled = !flag;
            btn_ThoatPNhap.Enabled = !flag;
        }

        //HIEN CAC THUOC TINH LIEN QUAN DEN BANG CHI TIET PHIEU NHAP
        private void ThietLapTrenBangCTPN(bool flag)
        {
            btn_ThemCTPN.Enabled = flag;
            btn_LuuNH.Enabled = !flag;
            btn_SuaNH.Enabled = flag;
            btn_XoaNH.Enabled = flag;
            btn_ThoatNH.Enabled = flag;
        }

        //Nhap thong tin vao bang chi tiet phieu nhap
        private void btn_ThemCTPN_Click(object sender, EventArgs e)
        {
            if (btn_ThemCTPN.Text == "Nhập")
            {
                dataGridViewNhapHang.Enabled = true;
                dataGridViewNhapHang.ReadOnly = false;
                btn_ThemCTPN.Text = "Ngừng";
                btn_LuuNH.Enabled = true;
                btn_SuaNH.Enabled = false;
                btn_XoaNH.Enabled = false;
                btn_ThoatNH.Enabled = false;
            }
            else
            {
                dataGridViewNhapHang.ReadOnly = true;
                btn_ThemCTPN.Text = "Nhập";
                btn_LuuNH.Enabled = false;
                btn_SuaNH.Enabled = true;
                btn_XoaNH.Enabled = true;
                btn_ThoatNH.Enabled = true;
                dataGridViewNhapHang.Enabled = false;
                btn_XoaNH.Text = "Tìm Xóa";
                dataGridViewSuaCTPN.Visible = false;
                btn_ThaoTacCTPN.Enabled = true;
            }
        }

        //Lay thong tin de them du lieu cho bang phieu nhap va CTPN
        private NhapHang LayThongTinCTPN(int pos)
        {
            NhapHang myctpn = new NhapHang();

            myctpn.MaNhap = dataGridViewNhapHang.Rows[pos].Cells["MaNhap"].Value.ToString().Trim();
            myctpn.SLNhap = int.Parse(dataGridViewNhapHang.Rows[pos].Cells["cotSoLuong"].Value.ToString().Trim());
            myctpn.GiaNhap = dataGridViewNhapHang.Rows[pos].Cells["cotGiaNhap"].Value.ToString().Trim();
            myctpn.ThueNhap = dataGridViewNhapHang.Rows[pos].Cells["cotThueNhap"].Value.ToString().Trim();

            return myctpn;
        }

        //Lay thong tin de sua bang chi tiet phieu nhap
        private NhapHang LayThongTinSuaCTPN(int pos)
        {
            NhapHang myctpn = new NhapHang();

            myctpn.MaNhap = dataGridViewSuaCTPN.Rows[pos].Cells["CTMaNhap"].Value.ToString().Trim();
            myctpn.SLNhap = int.Parse(dataGridViewSuaCTPN.Rows[pos].Cells["CTSoLuong"].Value.ToString().Trim());
            myctpn.GiaNhap = dataGridViewSuaCTPN.Rows[pos].Cells["CTGiaNhap"].Value.ToString().Trim();
            myctpn.ThueNhap = dataGridViewSuaCTPN.Rows[pos].Cells["CTThueNhap"].Value.ToString().Trim();

            return myctpn;
        }

        //LUU THONG TIN
        bool kttt;
        private void btn_LuuNH_Click(object sender, EventArgs e)
        {
            if (btn_SuaNH.Text == "Tìm Sửa")
            {
                NhapHang ctpn;
                for (int i = 0; i < dataGridViewNhapHang.RowCount; i++)
                {
                    if (dataGridViewNhapHang.Rows[i].Cells["cotSoLuong"].Value != null && dataGridViewNhapHang.Rows[i].Cells["cotGiaNhap"].Value != null && dataGridViewNhapHang.Rows[i].Cells["cotThueNhap"].Value != null)
                    {
                        ctpn = LayThongTinCTPN(i);
                        nhBUS.ThemCTPN(ctpn);
                        kttt = true;
                    }
                    else
                    {
                        MessageBox.Show("Bạn phải nhập đầy đủ thông tin trước khi lưu!", "Thông báo");
                        kttt = false;
                        break;
                    }
                }
                if (kttt == true)
                {
                    MessageBox.Show("Lưu bảng thông tin chi tiết phiếu nhập thành công!", "Thông báo");
                    btn_ThaoTacCTPN.Text = "Thao Tác Trên Bảng CT Phiếu Nhập";
                    btn_ThemCTPN.Text = "Nhập";
                    frmNhapHang_Load(sender, e);
                }
            }
            else
            {
                NhapHang ctpn;
                for (int i = 0; i < dataGridViewSuaCTPN.RowCount - 1; i++)
                {
                    ctpn = LayThongTinSuaCTPN(i);
                    nhBUS.ThemCTPN(ctpn);
                }

                MessageBox.Show("Sửa dữ liệu bảng thông tin chi tiết phiếu nhập thành công!", "Thông báo");
                btn_ThaoTacCTPN.Text = "Thao Tác Trên Bảng CT Phiếu Nhập";
                btn_ThaoTacCTPN.Enabled = true;
                dataGridViewSuaCTPN.Visible = false;
                btn_SuaNH.Text = "Tìm Sửa";
                frmNhapHang_Load(sender, e);
            }
        }

        //SUA BANG THONG TIN CHI TIET PHIEU NHAP
        private void btn_SuaNH_Click(object sender, EventArgs e)
        {
            if (btn_SuaNH.Text == "Tìm Sửa")
            {
                dataGridViewSuaCTPN.DataSource = nhBUS.LayDanhSachCTPhieuNhap();
                btn_SuaNH.Text = "Ngừng";
                dataGridViewSuaCTPN.Visible = true;
                btn_LuuNH.Enabled = true;
                btn_XoaNH.Enabled = false;
                btn_ThemCTPN.Enabled = false;
                btn_ThoatNH.Enabled = false;
                btn_ThaoTacCTPN.Enabled = false;
                dataGridViewSuaCTPN.ReadOnly = false;
            }
            else
            {
                btn_SuaNH.Text = "Tìm Sửa";
                dataGridViewSuaCTPN.Visible = false;
                btn_LuuNH.Enabled = false;
                btn_XoaNH.Enabled = true;
                btn_ThemCTPN.Enabled = true;
                btn_ThoatNH.Enabled = true;
                btn_ThaoTacCTPN.Enabled = true;
            }
        }

        //Xoa du lieu trong bang chi tiet phieu nhap
        private void btn_XoaNH_Click(object sender, EventArgs e)
        {
            if (btn_XoaNH.Text == "Tìm Xóa")
            {
                dataGridViewSuaCTPN.DataSource = nhBUS.LayDanhSachXoaCTPhieuNhap();
                dataGridViewSuaCTPN.Visible = true;
                btn_XoaNH.Text = "Xóa";
                btn_ThemCTPN.Text = "Ngừng";
                btn_SuaNH.Enabled = false;
                btn_LuuNH.Enabled = false;
                btn_ThoatNH.Enabled = false;
                dataGridViewSuaCTPN.ReadOnly = true;
                btn_ThaoTacCTPN.Enabled = false;
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn xóa phiếu nhập này không?", "Hỏi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //nhBUS.XoaCTPhieuNhap(txtMaNhap.Text);
                    if (nhBUS.XoaCTPhieuNhap(txtMaNhap.Text) && nhBUS.XoaTTXM(txtMaXe.Text))
                    {
                        btn_ThaoTacCTPN.Text = "Thao Tác Trên Bảng CT Phiếu Nhập";
                        btn_ThemCTPN.Text = "Nhập";
                        dataGridViewSuaCTPN.Visible = true;
                        frmNhapHang_Load(sender, e);
                    }
                }
            }
        }


        // Lay du lieu len luoi de xoa thong tin CTPX
        private void DuaDuLieuLendataGridViewSuaCTPN(int dong)
        {
            if (dong >= dataGridViewSuaCTPN.RowCount)
                return;
            txtMaNhap.Text = dataGridViewSuaCTPN.Rows[dong].Cells["CTMaNhap"].Value.ToString();
            txtMaXe.Text = dataGridViewSuaCTPN.Rows[dong].Cells["CTMaXe"].Value.ToString();
        }

        // Lay du lieu len luoi de xoa thong tin CTPN
        private void dataGridViewSuaCTPN_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong == dataGridViewSuaCTPN.RowCount - 1)
            {
                MessageBox.Show("Không có dữ liệu tại dòng này!", "Thông báo");
                if (btn_SuaNH.Text == "Ngừng")
                {
                    btn_LuuNH.Enabled = false;
                }
                else
                {
                    btn_XoaNH.Enabled = false;
                }
                bienNH = false;
                dong--;
            }
            else if (bienNH == false)
            {
                if (btn_SuaNH.Text == "Ngừng")
                {
                    btn_LuuNH.Enabled = true;
                }
                else
                {
                    btn_XoaNH.Enabled = true;
                }
            }
            DuaDuLieuLendataGridViewSuaCTPN(dong);
            pos = dong;
        }

        //CAC NUT THOAT
        private void btn_ThoatPNhap_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi bảng này không?", "Hỏi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_ThoatNH_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi bảng này không?", "Hỏi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
