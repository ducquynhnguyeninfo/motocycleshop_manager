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
    public partial class frmTraCuuPhieuXuat : Form
    {
        private tkphieuxuatBUS tkphieuxuatBUS = new tkphieuxuatBUS();
        private string mySql = "";
        public frmTraCuuPhieuXuat()
        {
            InitializeComponent();
        }

        private void frmTraCuuPhieuXuat_Load(object sender, EventArgs e)
        {
            TCPhieuXuat ttphieuxuat = LayThongTinPhieuXuat();
            mySql = tkphieuxuatBUS.XacDinhTruyVan(ttphieuxuat);
            dataGridView_phieuxuat.DataSource = tkphieuxuatBUS.DanhSachPhieuXuat(mySql);
            LopDungChung.DanhSTTNCC(dataGridView_phieuxuat, "cotSTT", 1);
        }
        private TCPhieuXuat LayThongTinPhieuXuat()
        {
            TCPhieuXuat tcphieuxuat = new TCPhieuXuat();

            tcphieuxuat.TenNV = txt_TenNV.Text;
            tcphieuxuat.TenKH = txt_TenKH.Text;
            tcphieuxuat.TenXe = txtTenXe.Text;
            tcphieuxuat.GiaXuat = txt_Gia.Text;

            return tcphieuxuat;
        }

        private void txt_TenNV_TextChanged(object sender, EventArgs e)
        {
            TCPhieuXuat tkphieuxuat = LayThongTinPhieuXuat();
            mySql = tkphieuxuatBUS.XacDinhTruyVan(tkphieuxuat);
            dataGridView_phieuxuat.DataSource = tkphieuxuatBUS.DanhSachPhieuXuat(mySql);
            LopDungChung.DanhSTTNCC(dataGridView_phieuxuat, "cotSTT", 1);
        }

        private void txt_TenKH_TextChanged(object sender, EventArgs e)
        {
            TCPhieuXuat tkphieuxuat = LayThongTinPhieuXuat();
            mySql = tkphieuxuatBUS.XacDinhTruyVan(tkphieuxuat);
            dataGridView_phieuxuat.DataSource = tkphieuxuatBUS.DanhSachPhieuXuat(mySql);
            LopDungChung.DanhSTTNCC(dataGridView_phieuxuat, "cotSTT", 1);
        }

        private void txtTenXe_TextChanged(object sender, EventArgs e)
        {
            TCPhieuXuat tkphieuxuat = LayThongTinPhieuXuat();
            mySql = tkphieuxuatBUS.XacDinhTruyVan(tkphieuxuat);
            dataGridView_phieuxuat.DataSource = tkphieuxuatBUS.DanhSachPhieuXuat(mySql);
            LopDungChung.DanhSTTNCC(dataGridView_phieuxuat, "cotSTT", 1);
        }

        private void txt_Gia_TextChanged(object sender, EventArgs e)
        {
            TCPhieuXuat tkphieuxuat = LayThongTinPhieuXuat();
            mySql = tkphieuxuatBUS.XacDinhTruyVan(tkphieuxuat);
            dataGridView_phieuxuat.DataSource = tkphieuxuatBUS.DanhSachPhieuXuat(mySql);
            LopDungChung.DanhSTTNCC(dataGridView_phieuxuat, "cotSTT", 1);
        }
        private void TimMoi()
        {
            txt_TenNV.Clear();
            txt_TenKH.Clear();
            txtTenXe.Clear();
            txt_Gia.Clear();
        }
        private void btn_timmoi_Click(object sender, EventArgs e)
        {
            TimMoi();
            txt_TenNV.Focus();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
