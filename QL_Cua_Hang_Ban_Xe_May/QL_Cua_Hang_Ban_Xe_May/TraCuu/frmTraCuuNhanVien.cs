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
    public partial class frmTraCuuNhanVien : Form
    {
        private NhanVienBUS NVBus = new NhanVienBUS();
        tknhanvienBUS tkhanghoaBUS = new tknhanvienBUS();
        private string mySql = "";
        public frmTraCuuNhanVien()
        {
            InitializeComponent();
        }

        private void frmTraCuuNhanVien_Load(object sender, EventArgs e)
        {
            ////lấy thông tin giới tính
            DataTable tableGioiTinh = NVBus.LayDanhSachGioiTinh();
            cboGioiTinh.Items.Add("Tất cả");
            for (int i = 0; i < tableGioiTinh.Rows.Count; i++)
            {
                cboGioiTinh.Items.Add(tableGioiTinh.Rows[i]["GioiTinh"]);
            }
            cboGioiTinh.Text = "Tất cả";

            ////Lấy thông tin chức vụ
            DataTable tableChucVu = NVBus.LayDanhSachChucVu();
            cboChucVu.Items.Add("Tất cả");
            for (int i = 0; i < tableChucVu.Rows.Count; i++)
            {
                cboChucVu.Items.Add(tableChucVu.Rows[i]["TEN_CV"]);
                //cboChucVu.ValueMember = "MA_CV";
            }
            cboChucVu.Text = "Tất cả";

            ///Lấy thông tin gán và gridview
            NVKQ nvien = LayThongTinNhanVien();
            mySql = tkhanghoaBUS.XacDinhTruyVan(nvien);
            dataGridViewNV.DataSource = tkhanghoaBUS.LocBangNhanVien(mySql);
            LopDungChung.DanhSTT(dataGridViewNV, "dgcSTT", 1);
        }
        private NVKQ LayThongTinNhanVien()
        {
            NVKQ nv = new NVKQ();

            nv.MaNV = txtMaNV.Text;
            nv.TenNV = txtTenNV.Text;
            nv.Lcb = txtLuong1.Text;
            nv.Lgh = txtLuong2.Text;
            nv.GioiTinh = cboGioiTinh.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.TENCV = cboChucVu.Text;

            return nv;
        }
        private void ClearAll()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtLuong1.Clear();
            txtLuong2.Clear();
            cboGioiTinh.Text = tkhanghoaBUS.ALL();
            txtDiaChi.Clear();
            cboChucVu.Text = tkhanghoaBUS.ALL();
        }

        private void btnTimMoi_Click(object sender, EventArgs e)
        {
            ClearAll();
            txtMaNV.Focus();
        }
        private void ThaoTacTimKiem()
        {
            NVKQ nvOb = LayThongTinNhanVien();
            mySql = tkhanghoaBUS.XacDinhTruyVan(nvOb);
            dataGridViewNV.DataSource = tkhanghoaBUS.LocBangNhanVien(mySql);
            LopDungChung.DanhSTT(dataGridViewNV, "dgcSTT", 1);
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            ThaoTacTimKiem();
        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {
            ThaoTacTimKiem();
        }

        private void cboGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThaoTacTimKiem();
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            ThaoTacTimKiem();
        }

        private void cboChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThaoTacTimKiem();
        }

        private void txtLuong1_TextChanged(object sender, EventArgs e)
        {
            ThaoTacTimKiem();
        }

        private void txtLuong2_TextChanged(object sender, EventArgs e)
        {
            ThaoTacTimKiem();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
