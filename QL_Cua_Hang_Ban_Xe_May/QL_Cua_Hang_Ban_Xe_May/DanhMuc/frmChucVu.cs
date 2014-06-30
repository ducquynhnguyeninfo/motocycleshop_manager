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
    public partial class frmChucVu : Form
    {
        private ChucVuBUS cvBUS = new ChucVuBUS();
        Boolean bienCV = true;
        private int pos = 0;
        public frmChucVu()
        {
            InitializeComponent();
        }

        private void frmChucVu_Load(object sender, EventArgs e)
        {
            dtg_ChucVu.DataSource = cvBUS.LayDanhSachChucVu();
            ThietLapNut(true);
            ThietLapThuocTinh(false);
        }
        private void ThietLapThuocTinh(bool flag)
        {
            txt_GhiChu.Enabled = flag;
            txt_MaChucVu.Enabled = flag;
            txt_TenChucVu.Enabled = flag;
        }
        private void ThietLapNut(bool flag)
        {
            btn_them.Enabled = flag;
            btn_xoa.Enabled = flag;
            btn_sua.Enabled = flag;
            btn_luu.Enabled = !flag;
            btn_thoat.Enabled = flag;
        }
        private void GanDuLieu(int dong)
        {
            if (dong >= dtg_ChucVu.RowCount)
                return;
            txt_MaChucVu.Text = dtg_ChucVu.Rows[dong].Cells["MA_CV"].Value.ToString();
            txt_TenChucVu.Text = dtg_ChucVu.Rows[dong].Cells["TEN_CV"].Value.ToString();
            txt_GhiChu.Text = dtg_ChucVu.Rows[dong].Cells["GHICHU"].Value.ToString();
        }

        private void dtg_ChucVu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong == dtg_ChucVu.RowCount - 1)
            {
                MessageBox.Show("Không có dữ liệu tại dòng này!", "Thông báo");
                btn_xoa.Enabled = false;
                btn_sua.Enabled = false;
                bienCV = false;
                dong--;
            }
            else if (bienCV == false)
            {
                btn_xoa.Enabled = true;
                btn_sua.Enabled = true;
            }
            GanDuLieu(dong);
            pos = dong;
        }
        private void ThemMoi()
        {
            txt_MaChucVu.Text = "";
            txt_TenChucVu.Text = "";
            txt_GhiChu.Text = "";
        }
        private ChucVu LayThongTinChucVu()
        {
            ChucVu cv = new ChucVu();
            cv.MaChucVu = txt_MaChucVu.Text;
            cv.TenChucVu = txt_TenChucVu.Text;
            cv.GhiChu = txt_GhiChu.Text;
            return cv;
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            ChucVu cv = LayThongTinChucVu();
            //Ton tai maxe (nut Sua)
            if (cvBUS.CheckExists(cv.MaChucVu))
            {
                if (cvBUS.SuaChucVu(cv))
                {
                    frmChucVu_Load(sender, e);
                    btn_them.Text = "Thêm";
                    dtg_ChucVu.Enabled = true;
                }
            }
            else //(nut Them)
            {
                if (cvBUS.ThemChucVu(cv))
                {
                    frmChucVu_Load(sender, e);
                    btn_them.Text = "Thêm";
                    dtg_ChucVu.Enabled = true;
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            btn_them.Text = "Ngừng";
            //Sua thi hien thi o thong tin
            txt_TenChucVu.Enabled = true;
            txt_GhiChu.Enabled = true;
            //an cac nut sau
            btn_luu.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;

            //an dataGridView
            dtg_ChucVu.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa chức vụ " + txt_TenChucVu.Text + " không?", "Hỏi",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (cvBUS.XoaChucVu(txt_MaChucVu.Text))
                {
                    frmChucVu_Load(sender, e);
                }
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (btn_them.Text == "Thêm")
            {
                txt_MaChucVu.Text = cvBUS.PhatSinhMaKeTiep();
                ThietLapThuocTinh(true);
                ThemMoi();
                ThietLapNut(false);

                btn_them.Text = "Ngừng";
                txt_MaChucVu.Enabled = false;
                btn_them.Enabled = true;
                dtg_ChucVu.Enabled = false;
                txt_TenChucVu.Focus();
            }
            else//btnThem.Text == "Ngừng"
            {
                dtg_ChucVu.Enabled = true;
                btn_them.Text = "Thêm";
                frmChucVu_Load(sender, e);
            }
        }
    }
}

