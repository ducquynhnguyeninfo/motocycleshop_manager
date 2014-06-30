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
    public partial class frmXuatHang : Form
    {
        private XuatHangBUS xhBUS = new XuatHangBUS();
        private KhachHangBUS khBUS = new KhachHangBUS();
        private NhanVienBUS nvBUS = new NhanVienBUS();
        private int pos = 0;
        bool bienXH = true;
        public frmXuatHang()
        {
            InitializeComponent();
        }

        //Thiet lap thuoc tinh
        private void ThietLapThuocTinhXuatHang(bool flag)
        {
            txtMaXuat.Enabled = flag;
            txtMaXe.Enabled = flag;
            dateTimePickerXuatHang.Enabled = flag;
            cboTenKH.Enabled = flag;
            cboTenNV.Enabled = flag;
        }

        //Thiet lap nut
        private void ThietLapNutXuatHang(bool flag)
        {
            //Nut bang phieu nhap
            btn_ThemPXuat.Enabled = flag;
            btn_ThoatPXuat.Enabled = flag;
            btn_LuuPXuat.Enabled = !flag;
            //Nut bang chi tiet phieu nhap
            btn_NhapCTPX.Enabled = !flag;
            btn_LuuCTPX.Enabled = !flag;
            btn_SuaCTPX.Enabled = !flag;
            btn_XoaCTPX.Enabled = !flag;
            btn_ThoatCTPX.Enabled = !flag;
            //btn_ThemCTPX.Enabled = !flag;
        }

        private void frmXuatHang_Load(object sender, EventArgs e)
        {
            //Load du lieu len combobox ten khach hang
            cboTenKH.DataSource = khBUS.LayDanhSachKhachHang();
            cboTenKH.DisplayMember = "TENKH";
            cboTenKH.ValueMember = "MAKH";

            //Load du lieu len combobox ten nhan vien
            cboTenNV.DataSource = nvBUS.LayDanhSachNhanVien();
            cboTenNV.DisplayMember = "TENNV";
            cboTenNV.ValueMember = "MANV";

            //Load du lieu len dataGridView
            dataGridViewXuatHang.DataSource = xhBUS.LayDanhSachHangHoaXuat();
            ThietLapNutXuatHang(true);
            ThietLapThuocTinhXuatHang(false);
            dataGridViewXuatHang.ReadOnly = true;
            dataGridViewSuaCTPX.Visible = false;
            btn_ThaoTacCTPX.Enabled = true;
            btn_XoaCTPX.Text = "Tìm Xóa";
            btn_SuaCTPX.Enabled = false;
            btn_XoaCTPX.Enabled = false;
        }

        private void dataGridViewXuatHang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaXuat.Text = dataGridViewXuatHang.Rows[dong].Cells["MaXuat"].Value.ToString();
            txtMaXe.Text = dataGridViewXuatHang.Rows[dong].Cells["MaXe"].Value.ToString();
            dateTimePickerXuatHang.Text = dataGridViewXuatHang.Rows[dong].Cells["NgayXuat"].Value.ToString();
            cboTenKH.Text = dataGridViewXuatHang.Rows[dong].Cells["colTenKH"].Value.ToString();
            cboTenNV.Text = dataGridViewXuatHang.Rows[dong].Cells["colTenNV"].Value.ToString();
        }

        //Them moi
        private void ThemMoiXH()
        {
            dateTimePickerXuatHang.ResetText();
        }

        private void btn_ThemPXuat_Click(object sender, EventArgs e)
        {
            if (btn_ThemPXuat.Text == "Thêm P_Xuất")
            {
                txtMaXuat.Text = xhBUS.PhatSinhMaPhieuXuatKeTiep();
                txtMaXe.Text = xhBUS.PhatSinhMaXeKeTiep();
                ThietLapThuocTinhXuatHang(true);
                //ThietLapNutNhapHang(false);
                //Cac nut thap tac den bang phieu xuat
                btn_ThemPXuat.Enabled = true;
                btn_ThoatPXuat.Enabled = false;
                btn_LuuPXuat.Enabled = true;

                //Cac nut thao tac den bang chi tiet phieu xuat
                btn_ThaoTacCTPX.Enabled = false;
                btn_LuuCTPX.Enabled = false;

                btn_SuaCTPX.Enabled = false;
                btn_XoaCTPX.Enabled = false;
                btn_ThoatCTPX.Enabled = false;
                btn_NhapCTPX.Enabled = false;

                //Thong tin phieu nhap
                txtMaXuat.Enabled = false;
                txtMaXe.Enabled = false;
                btn_ThemPXuat.Enabled = true;
                dataGridViewXuatHang.Enabled = false;

                ThemMoiXH();
                btn_ThemPXuat.Text = "Ngừng";
                dataGridViewXuatHang.Focus();
            }
            else//btnThem.Text == "Ngừng"
            {
                dataGridViewXuatHang.Enabled = true;
                btn_ThemPXuat.Text = "Thêm P_Xuất";
                btn_ThoatPXuat.Enabled = true;
                btn_ThaoTacCTPX.Enabled = true;
                frmXuatHang_Load(sender, e);
            }
        }

        //Lay thong tin tren phieu nhap
        private XuatHang LayThongTinPhieuXuat()
        {
            XuatHang xh = new XuatHang();
            xh.MaXuat = txtMaXuat.Text;
            xh.MaXe = txtMaXe.Text;
            xh.NgayXuat = Convert.ToDateTime(dateTimePickerXuatHang.Value.ToShortDateString());
            xh.TenKH = khBUS.LayMaKhachHang(cboTenKH.Text);
            xh.TenNV = nvBUS.LayMaNhanVien(cboTenNV.Text);
            return xh;
        }

        //Luu thong tin dua vao bang phieu xuat va chi tiet phieu xuat
        private void btn_LuuPXuat_Click(object sender, EventArgs e)
        {
            XuatHang xh = LayThongTinPhieuXuat();

            xhBUS.ThemPhieuXuat(xh);
            xhBUS.ThemCTPhieuXuat(xh);

            frmXuatHang_Load(sender, e);
            btn_LuuPXuat.Enabled = false;
            btn_ThemPXuat.Text = "Thêm P_Xuất";
            btn_ThaoTacCTPX.Enabled = true;
        }

        //CAC THAO TAC TAC DONG DEN VIEC NHAP DU LIEU CHO BANG CHI TIET PHIEU XUAT
        private void btn_ThaoTacCTPX_Click(object sender, EventArgs e)
        {
            if (btn_ThaoTacCTPX.Text == "Thao Tác Trên Bảng CT Phiếu Xuất")
            {
                ThietLapTrenBangPX(true);
                ThietLapTrenBangCTPX(true);
                btn_ThaoTacCTPX.Text = "Ngừng Thao Tác Trên Bảng CT Phiếu Xuất";
                dataGridViewXuatHang.ReadOnly = true;
            }
            else
            {
                btn_NhapCTPX.Text = "Nhập";
                btn_ThaoTacCTPX.Text = "Thao Tác Trên Bảng CT Phiếu Xuất";
                ThietLapTrenBangPX(false);
                ThietLapTrenBangCTPX(false);
                btn_LuuCTPX.Enabled = false;
                btn_LuuPXuat.Enabled = false;
                txtMaXuat.Enabled = false;
                txtMaXe.Enabled = false;
                dateTimePickerXuatHang.Enabled = false;
                cboTenKH.Enabled = false;
                cboTenNV.Enabled = false;
                dataGridViewXuatHang.ReadOnly = true;
                btn_XoaCTPX.Text = "Tìm Xóa";
            }
        }
        //AN CAC THUOC TINH LIEN QUAN DEN BANG PHIEU NHAP
        private void ThietLapTrenBangPX(bool flag)
        {
            txtMaXuat.Enabled = !flag;
            txtMaXe.Enabled = !flag;
            dateTimePickerXuatHang.Enabled = !flag;
            cboTenKH.Enabled = !flag;
            cboTenNV.Enabled = !flag;
            btn_ThemPXuat.Enabled = !flag;
            btn_LuuPXuat.Enabled = !flag;
            btn_ThoatPXuat.Enabled = !flag;
        }

        //HIEN CAC THUOC TINH LIEN QUAN DEN BANG CHI TIET PHIEU NHAP
        private void ThietLapTrenBangCTPX(bool flag)
        {
            btn_NhapCTPX.Enabled = flag;
            btn_LuuCTPX.Enabled = !flag;
            btn_SuaCTPX.Enabled = flag;
            btn_XoaCTPX.Enabled = flag;
            btn_ThoatCTPX.Enabled = flag;
        }

        //Nhap thong tin vao bang chi tiet phieu xuat
        private void btn_NhapCTPX_Click(object sender, EventArgs e)
        {
            if (btn_NhapCTPX.Text == "Nhập")
            {
                dataGridViewXuatHang.Enabled = true;
                dataGridViewXuatHang.ReadOnly = false;
                btn_NhapCTPX.Text = "Ngừng";
                btn_LuuCTPX.Enabled = true;
                btn_SuaCTPX.Enabled = false;
                btn_XoaCTPX.Enabled = false;
                btn_ThoatCTPX.Enabled = false;
            }
            else
            {
                dataGridViewXuatHang.ReadOnly = true;
                btn_NhapCTPX.Text = "Nhập";
                btn_LuuCTPX.Enabled = false;
                btn_SuaCTPX.Enabled = true;
                btn_XoaCTPX.Enabled = true;
                btn_ThoatCTPX.Enabled = true;
                dataGridViewXuatHang.Enabled = false;
                btn_XoaCTPX.Text = "Tìm Xóa";
                dataGridViewSuaCTPX.Visible = false;
                btn_ThaoTacCTPX.Enabled = true;
            }
        }
        //Lay thong tin de them du lieu cho bang phieu xuat va CTPX
        private XuatHang LayThongTinCTPX(int pos)
        {
            XuatHang myctpx = new XuatHang();

            myctpx.MaXuat = dataGridViewXuatHang.Rows[pos].Cells["MaXuat"].Value.ToString().Trim();
            myctpx.SLXuat = int.Parse(dataGridViewXuatHang.Rows[pos].Cells["cotSoLuong"].Value.ToString().Trim());
            myctpx.GiaXuat = dataGridViewXuatHang.Rows[pos].Cells["cotGiaXuat"].Value.ToString().Trim();
            myctpx.ThueXuat = dataGridViewXuatHang.Rows[pos].Cells["cotThueXuat"].Value.ToString().Trim();

            return myctpx;
        }
        //Lay thong tin de sua bang chi tiet phieu xuat
        private XuatHang LayThongTinSuaCTPX(int pos)
        {
            XuatHang myctpx = new XuatHang();

            myctpx.MaXuat = dataGridViewSuaCTPX.Rows[pos].Cells["CTMaXuat"].Value.ToString().Trim();
            myctpx.SLXuat = int.Parse(dataGridViewSuaCTPX.Rows[pos].Cells["CTSoLuong"].Value.ToString().Trim());
            myctpx.GiaXuat = dataGridViewSuaCTPX.Rows[pos].Cells["CTGiaXuat"].Value.ToString().Trim();
            myctpx.ThueXuat = dataGridViewSuaCTPX.Rows[pos].Cells["CTThueXuat"].Value.ToString().Trim();

            return myctpx;
        }

        //LUU THONG TIN
        bool kttt;
        private void btn_LuuCTPX_Click(object sender, EventArgs e)
        {
            if (btn_SuaCTPX.Text == "Tìm Sửa")
            {
                XuatHang ctpx;
                for (int i = 0; i < dataGridViewXuatHang.RowCount; i++)
                {
                    if (dataGridViewXuatHang.Rows[i].Cells["cotSoLuong"].Value != null && dataGridViewXuatHang.Rows[i].Cells["cotGiaXuat"].Value != null && dataGridViewXuatHang.Rows[i].Cells["cotThueXuat"].Value != null)
                    {
                        ctpx = LayThongTinCTPX(i);
                        xhBUS.ThemCTPX(ctpx);
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
                    MessageBox.Show("Lưu bảng thông tin chi tiết phiếu xuất thành công!", "Thông báo");
                    btn_ThaoTacCTPX.Text = "Thao Tác Trên Bảng CT Phiếu Xuất";
                    btn_NhapCTPX.Text = "Nhập";
                    frmXuatHang_Load(sender, e);
                }
            }
            else
            {
                XuatHang ctpx;
                for (int i = 0; i < dataGridViewSuaCTPX.RowCount - 1; i++)
                {
                    ctpx = LayThongTinSuaCTPX(i);
                    xhBUS.ThemCTPX(ctpx);
                }

                MessageBox.Show("Sửa dữ liệu bảng thông tin chi tiết phiếu xuất thành công!", "Thông báo");
                btn_ThaoTacCTPX.Text = "Thao Tác Trên Bảng CT Phiếu Xuất";
                btn_ThaoTacCTPX.Enabled = true;
                dataGridViewSuaCTPX.Visible = false;
                btn_SuaCTPX.Text = "Tìm Sửa";
                frmXuatHang_Load(sender, e);
            }
        }

        //SUA BANG THONG TIN CHI TIET PHIEU XUAT
        private void btn_SuaCTPX_Click(object sender, EventArgs e)
        {
            if (btn_SuaCTPX.Text == "Tìm Sửa")
            {
                dataGridViewSuaCTPX.DataSource = xhBUS.LayDanhSachCTPhieuXuat();
                btn_SuaCTPX.Text = "Ngừng";
                dataGridViewSuaCTPX.Visible = true;
                btn_LuuCTPX.Enabled = true;
                btn_XoaCTPX.Enabled = false;
                btn_NhapCTPX.Enabled = false;
                btn_ThoatCTPX.Enabled = false;
                btn_ThaoTacCTPX.Enabled = false;
                dataGridViewSuaCTPX.ReadOnly = false;
            }
            else
            {
                btn_SuaCTPX.Text = "Tìm Sửa";
                dataGridViewSuaCTPX.Visible = false;
                btn_LuuCTPX.Enabled = false;
                btn_XoaCTPX.Enabled = true;
                btn_NhapCTPX.Enabled = true;
                btn_ThoatCTPX.Enabled = true;
                btn_ThaoTacCTPX.Enabled = true;
            }
        }

        //Xoa du lieu trong bang chi tiet phieu xuat
        private void btn_XoaCTPX_Click(object sender, EventArgs e)
        {
            if (btn_XoaCTPX.Text == "Tìm Xóa")
            {
                dataGridViewSuaCTPX.DataSource = xhBUS.LayDanhSachXoaCTPhieuXuat();
                dataGridViewSuaCTPX.Visible = true;
                btn_XoaCTPX.Text = "Xóa";
                btn_NhapCTPX.Text = "Ngừng";
                btn_SuaCTPX.Enabled = false;
                btn_LuuCTPX.Enabled = false;
                btn_ThoatCTPX.Enabled = false;
                dataGridViewSuaCTPX.ReadOnly = true;
                btn_ThaoTacCTPX.Enabled = false;
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn xóa phiếu xuất này không?", "Hỏi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (xhBUS.XoaCTPhieuXuat(txtMaXuat.Text))
                    {
                        btn_ThaoTacCTPX.Text = "Thao Tác Trên Bảng CT Phiếu Xuất";
                        btn_NhapCTPX.Text = "Nhập";
                        dataGridViewSuaCTPX.Visible = true;
                        frmXuatHang_Load(sender, e);
                    }
                }
            }
        }

        // Lay du lieu len luoi de xoa thong tin CTPX
        private void DuaDuLieuLendataGridViewSuaCTPX(int dong)
        {
            if (dong >= dataGridViewSuaCTPX.RowCount)
                return;
            txtMaXuat.Text = dataGridViewSuaCTPX.Rows[dong].Cells["CTMaXuat"].Value.ToString();
            txtMaXe.Text = dataGridViewSuaCTPX.Rows[dong].Cells["CTMaXe"].Value.ToString();
        }
        // Lay du lieu len luoi de xoa thong tin CTPX
        private void dataGridViewSuaCTPX_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong == dataGridViewSuaCTPX.RowCount - 1)
            {
                MessageBox.Show("Không có dữ liệu tại dòng này!", "Thông báo");
                if (btn_SuaCTPX.Text == "Ngừng")
                {
                    btn_LuuCTPX.Enabled = false;
                }
                else
                {
                    btn_XoaCTPX.Enabled = false;
                }
                bienXH = false;
                dong--;
            }
            else if (bienXH == false)
            {
                if (btn_SuaCTPX.Text == "Ngừng")
                {
                    btn_LuuCTPX.Enabled = true;
                }
                else
                {
                    btn_XoaCTPX.Enabled = true;
                }
            }
            DuaDuLieuLendataGridViewSuaCTPX(dong);
            pos = dong;
            
        }
        //CAC NUT THOAT
        private void btn_ThoatPXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi bảng này không?", "Hỏi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_ThoatCTPX_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi bảng này không?", "Hỏi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
