using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QL_Cua_Hang_Ban_Xe_May.BusinessObject;
using QL_Cua_Hang_Ban_Xe_May.BusinessLogic;

namespace QL_Cua_Hang_Ban_Xe_May
{
    public partial class frmTraCuuPhieuNhap : Form
    {
        private tkphieunhapBUS tkphieunhapBUS = new tkphieunhapBUS();
        private NhapHangBUS nhBUS = new NhapHangBUS();
        private string mySql = "";
        public frmTraCuuPhieuNhap()
        {
            InitializeComponent();
        }

        private void frmTraCuuPhieuNhap_Load(object sender, EventArgs e)
        {
            //Gan du lieu vao luoi
            TCPhieuNhap tkphieunhap = LayThongTinTCPhieuNhap();
            mySql = tkphieunhapBUS.XacDinhTruyVan(tkphieunhap);
            dataGridViewTCPhieuNhap.DataSource = tkphieunhapBUS.DanhSachPhieuNhap(mySql);
            LopDungChung.DanhSTTNCC(dataGridViewTCPhieuNhap, "cotSTT", 1);
        }

        private TCPhieuNhap LayThongTinTCPhieuNhap()
        {
            TCPhieuNhap tcphieunhap = new TCPhieuNhap();

            tcphieunhap.TenNV = txt_TCTenNV.Text;
            tcphieunhap.TenXe = txt_TCTenXe.Text;
            tcphieunhap.TenNCC = txt_TCTenNSX.Text;
            tcphieunhap.GiaNhap = txt_TCGiaNhap.Text;

            return tcphieunhap;
        }

        private void txt_TCTenNV_TextChanged(object sender, EventArgs e)
        {
            TCPhieuNhap tcphieunhap = LayThongTinTCPhieuNhap();
            mySql = tkphieunhapBUS.XacDinhTruyVan(tcphieunhap);
            dataGridViewTCPhieuNhap.DataSource = tkphieunhapBUS.DanhSachPhieuNhap(mySql);
            LopDungChung.DanhSTTNCC(dataGridViewTCPhieuNhap, "cotSTT", 1);
        }

        private void txt_TCTenXe_TextChanged(object sender, EventArgs e)
        {
            TCPhieuNhap tcphieunhap = LayThongTinTCPhieuNhap();
            mySql = tkphieunhapBUS.XacDinhTruyVan(tcphieunhap);
            dataGridViewTCPhieuNhap.DataSource = tkphieunhapBUS.DanhSachPhieuNhap(mySql);
            LopDungChung.DanhSTTNCC(dataGridViewTCPhieuNhap, "cotSTT", 1);
        }

        private void txt_TCTenNSX_TextChanged(object sender, EventArgs e)
        {
            TCPhieuNhap tcphieunhap = LayThongTinTCPhieuNhap();
            mySql = tkphieunhapBUS.XacDinhTruyVan(tcphieunhap);
            dataGridViewTCPhieuNhap.DataSource = tkphieunhapBUS.DanhSachPhieuNhap(mySql);
            LopDungChung.DanhSTTNCC(dataGridViewTCPhieuNhap, "cotSTT", 1);
        }

        private void txt_TCGiaNhap_TextChanged(object sender, EventArgs e)
        {
            TCPhieuNhap tcphieunhap = LayThongTinTCPhieuNhap();
            mySql = tkphieunhapBUS.XacDinhTruyVan(tcphieunhap);
            dataGridViewTCPhieuNhap.DataSource = tkphieunhapBUS.DanhSachPhieuNhap(mySql);
            LopDungChung.DanhSTTNCC(dataGridViewTCPhieuNhap, "cotSTT", 1);
        }


        private void TimMoi()
        {
            txt_TCTenNV.Clear();
            txt_TCTenXe.Clear();
            txt_TCTenNSX.Clear();
            txt_TCGiaNhap.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimMoi();
            txt_TCTenNV.Focus();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewTCPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
