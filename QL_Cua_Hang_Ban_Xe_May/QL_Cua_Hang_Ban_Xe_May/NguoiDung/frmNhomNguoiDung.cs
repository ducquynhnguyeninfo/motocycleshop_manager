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

namespace QL_Cua_Hang_Ban_Xe_May.NguoiDung
{
    public partial class N : Form
    {
        private NhomNguoiDungBUS ndBUS = new NhomNguoiDungBUS();
        private int pos = 0;
        public N()
        {
            InitializeComponent();
        }

        private void frmNhomNguoiDung_Load(object sender, EventArgs e)
        {
            dataGridViewNguoiDung.DataSource = ndBUS.LayDanhSachNhomNguoiDung();
            ThietLapNut(true);
            ThietLapThuocTinh(false);
        }
        private void ThietLapThuocTinh(bool flag)
        {
            txt_manhom.Enabled = flag;
            txt_tennhom.Enabled = flag;
        }
        private void ThietLapNut(bool flag)
        {
            btn_ThemHH.Enabled = flag;
            btn_SuaHH.Enabled = flag;
            btn_XoaHH.Enabled = flag;
            btn_ThoatHH.Enabled = flag;
            btn_LuuHH.Enabled = !flag;
        }
        private void DuaDuLieuLendataGridViewNguoiDung(int dong)
        {
            if (dong >= dataGridViewNguoiDung.RowCount)
                return;
            txt_manhom.Text = dataGridViewNguoiDung.Rows[dong].Cells["MANHOM"].Value.ToString();
            txt_tennhom.Text = dataGridViewNguoiDung.Rows[dong].Cells["TENNHOM"].Value.ToString();
        }
        private void dataGridViewNguoiDung_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong == dataGridViewNguoiDung.RowCount - 1)
            {
                MessageBox.Show("Không có dữ liệu tại dòng này!", "Thông báo");
                dong--;
            }
            DuaDuLieuLendataGridViewNguoiDung(dong);
            pos = dong;

        }
        private void btn_ThemHH_Click(object sender, EventArgs e)
        {
            if (btn_ThemHH.Text == "Thêm")
            {
                txt_manhom.Text = ndBUS.PhatSinhMaKeTiep();
                ThietLapThuocTinh(true);
                ThemMoi();
                ThietLapNut(false);
                btn_ThemHH.Text = "Ngừng";
                txt_manhom.Enabled = false;
                btn_ThemHH.Enabled = true;
                dataGridViewNguoiDung.Enabled = false;
                txt_tennhom.Focus();
            }
            else
            {
                dataGridViewNguoiDung.Enabled = true;
                btn_ThemHH.Text = "Thêm";
                frmNhomNguoiDung_Load(sender, e);
            }
        }
        private void ThemMoi()
        {
            txt_tennhom.Clear();
        }

        private void btn_LuuHH_Click(object sender, EventArgs e)
        {
            NhomNguoiDung nnd = LayThongTinNhomNguoiDung();
            //Ton tai maxe (nut Sua)
            if (ndBUS.CheckExists(nnd.MaNhom))
            {
                if (ndBUS.SuaNhomNguoiDung(nnd))
                {
                    frmNhomNguoiDung_Load(sender, e);
                    btn_ThemHH.Text = "Thêm";
                    dataGridViewNguoiDung.Enabled = true;
                }
            }
            else //(nut Them)
            {
                if (ndBUS.ThemNguoiDung(nnd))
                {
                    frmNhomNguoiDung_Load(sender, e);
                    btn_ThemHH.Text = "Thêm";
                    dataGridViewNguoiDung.Enabled = true;
                }
            }
        }
        private NhomNguoiDung LayThongTinNhomNguoiDung()
        {
            NhomNguoiDung nnd = new NhomNguoiDung();
            nnd.MaNhom = txt_manhom.Text;
            nnd.TenNhom = txt_tennhom.Text;
            return nnd;
        }

        private void btn_SuaHH_Click(object sender, EventArgs e)
        {
            btn_ThemHH.Text = "Ngừng";
            txt_tennhom.Enabled = true;

            //an cac nut sau
            btn_LuuHH.Enabled = true;
            btn_SuaHH.Enabled = false;
            btn_XoaHH.Enabled = false;

            //an dataGridView
            dataGridViewNguoiDung.Enabled = false;
        }

        private void btn_XoaHH_Click(object sender, EventArgs e)
        {
            ndBUS.XoaNguoiDung(txt_manhom.Text);
            frmNhomNguoiDung_Load(sender, e);
        }

        private void btn_ThoatHH_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
