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
    public partial class frmNhaCungCap : Form
    {
        private NhaCungCapBUS nccBUS = new NhaCungCapBUS();
        private int pos = 0;
        bool bienNCC = true;
        public frmNhaCungCap()
        {
            InitializeComponent();
        }


        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            dataGridViewNhaCungCap.DataSource = nccBUS.LayDanhSachNhaCungCap();
            ThietLapThuocTinhFormNCC(false);
            ThietLapNutFormNCC(true);
        }

        private void dataGridViewNhaCungCap_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;

            if (dong == dataGridViewNhaCungCap.RowCount - 1)
            {
                MessageBox.Show("Không có dữ liệu tại dòng này!", "Thông báo");
                btn_XoaNCC.Enabled = false;
                btn_SuaNCC.Enabled = false;
                bienNCC = false;
                dong--;
            }
            else if (bienNCC == false)
            {
                btn_XoaNCC.Enabled = true;
                btn_SuaNCC.Enabled = true;
            }
            DuaDuLieuLendataGridViewNhaCungCap(dong);
            pos = dong;
        }

        private void DuaDuLieuLendataGridViewNhaCungCap(int dong)
        {
            if (dong >= dataGridViewNhaCungCap.RowCount)
                return;
            txtMaNCC.Text = dataGridViewNhaCungCap.Rows[dong].Cells["MaNCC"].Value.ToString();
            txtTenNCC.Text = dataGridViewNhaCungCap.Rows[dong].Cells["TenNCC"].Value.ToString();
            txtEmailNCC.Text = dataGridViewNhaCungCap.Rows[dong].Cells["Email"].Value.ToString();
            txtDiaChiNCC.Text = dataGridViewNhaCungCap.Rows[dong].Cells["DiaChi"].Value.ToString();
            txtDienThoaiNCC.Text = dataGridViewNhaCungCap.Rows[dong].Cells["DienThoai"].Value.ToString();
        }

        private void ThietLapThuocTinhFormNCC(bool flag)
        {
            txtMaNCC.Enabled = flag;
            txtTenNCC.Enabled = flag;
            txtEmailNCC.Enabled = flag;
            txtDiaChiNCC.Enabled = flag;
            txtDienThoaiNCC.Enabled = flag;
        }

        //Thiet lap nut
        private void ThietLapNutFormNCC(bool flag)
        {
            btn_LuuNCC.Enabled = !flag;
            btn_ThemNCC.Enabled = flag;
            btn_SuaNCC.Enabled = flag;
            btn_XoaNCC.Enabled = flag;
            btn_ThoatNCC.Enabled = flag;
        }

        private void ThemMoiNCC()
        {
            txtTenNCC.Text = "";
            txtDienThoaiNCC.Clear();
            txtDiaChiNCC.Clear();
            txtEmailNCC.Clear();
        }

        private void btn_ThemNCC_Click(object sender, EventArgs e)
        {
            if (btn_ThemNCC.Text == "Thêm")
            {
                txtMaNCC.Text = nccBUS.PhatSinhMaKeTiep();
                ThietLapThuocTinhFormNCC(true);
                ThemMoiNCC();
                ThietLapNutFormNCC(false);
                btn_ThemNCC.Text = "Ngừng";
                txtMaNCC.Enabled = false;
                btn_ThemNCC.Enabled = true;
                dataGridViewNhaCungCap.Enabled = false;
                txtTenNCC.Focus();
            }
            else//btnThem.Text == "Ngừng"
            {
                dataGridViewNhaCungCap.Enabled = true;
                btn_ThemNCC.Text = "Thêm";
                frmNhaCungCap_Load(sender, e);
            }
        }

        
        private void btn_SuaNCC_Click(object sender, EventArgs e)
        {
            btn_ThemNCC.Text = "Ngừng";

            //Sua thi hien thi o thong tin
            txtTenNCC.Enabled = true;
            txtEmailNCC.Enabled = true;
            txtDiaChiNCC.Enabled = true;
            txtDienThoaiNCC.Enabled = true;

            //an cac nut sau
            btn_LuuNCC.Enabled = true;
            btn_SuaNCC.Enabled = false;
            btn_XoaNCC.Enabled = false;

            //an dataGridView
            dataGridViewNhaCungCap.Enabled = false;
        }

        private NhaCungCap LayThongTinNhaCungCap()
        {
            NhaCungCap ncc = new NhaCungCap();
            ncc.MaNCC = txtMaNCC.Text;
            ncc.TenNCC = txtTenNCC.Text;
            ncc.EmailNCC = txtEmailNCC.Text;
            ncc.DiaChiNCC = txtDiaChiNCC.Text;
            ncc.DienThoaiNCC = txtDienThoaiNCC.Text;
            return ncc;
        }

        private void btn_XoaNCC_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hàng hóa " + txtTenNCC.Text + " không?", "Hỏi",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (nccBUS.XoaNhaCungCap(txtMaNCC.Text))
                {
                    frmNhaCungCap_Load(sender, e);
                }
            }
        }

        private void btn_LuuNCC_Click(object sender, EventArgs e)
        {
            NhaCungCap ncc = LayThongTinNhaCungCap();
            //Ton tai mahcc (nut Sua)
            if (nccBUS.CheckExistsNCC(ncc.MaNCC))
            {
                if (nccBUS.SuaNhaCungCap(ncc))
                {
                    frmNhaCungCap_Load(sender, e);
                    btn_ThemNCC.Text = "Thêm";
                    dataGridViewNhaCungCap.Enabled = true;
                }
            }
            else //(nut Them)
            {
                if (nccBUS.ThemNhaCungCapSP("pro_ThemHangCungCap", ncc)) //nccBUS.ThemNhaCungCap(ncc)
                {
                    MessageBox.Show("Thêm thông tin nhà cung cấp thành công!", "Thông báo");
                    frmNhaCungCap_Load(sender, e);
                    btn_ThemNCC.Text = "Thêm";
                    dataGridViewNhaCungCap.Enabled = true;
                }
            }
        }

        private void btn_ThoatNCC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Kiem tra nhap vao phai kieu so ko
        private void txtDienThoaiNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) 
            {
                e.Handled = true;
            }
        }
    }
}
