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
    public partial class frmTraCuuKhachHang : Form
    {
        GioiTinhBUS gtBUS = new GioiTinhBUS();
        private string mySql = "";
        private tkkhBUS tkkhBUS = new tkkhBUS();

        public frmTraCuuKhachHang()
        {
            InitializeComponent();
        }
        private void frmTraCuuKhachHang_Load(object sender, EventArgs e)
        {
            //Lay thong tin gioi tinh
            DataTable myDTKhoa = gtBUS.LayDanhSachGioiTinh();
            cbGioiTinh.Items.Add("Tất cả");
            for (int i = 0; i < myDTKhoa.Rows.Count; i++)
            {
                cbGioiTinh.Items.Add(myDTKhoa.Rows[i]["GIOITINH"]);
            }
            cbGioiTinh.Text = "Tất cả";

            //Gan du lieu vao luoi
            TKKH tksvOb = LayThongTinTKKH();
            mySql = tkkhBUS.XacDinhTruyVan(tksvOb);
            dataGridViewKhachhang.DataSource = tkkhBUS.DanhSachKhachHang(mySql);
            LopDungChung.DanhSTT(dataGridViewKhachhang, "cotSTT", 1);
        }
        private TKKH LayThongTinTKKH()
        {
            TKKH ttkh = new TKKH();

            ttkh.MaKH = TxtMakh.Text;
            ttkh.TenKH = txtTenKH.Text;
            ttkh.GioiTinh = cbGioiTinh.Text;
            ttkh.DiaChi = txtDiaChi.Text;
            ttkh.HKtt = txt_hkttru.Text;

            return ttkh;
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {
            TKKH tksvOb = LayThongTinTKKH();
            mySql = tkkhBUS.XacDinhTruyVan(tksvOb);
            dataGridViewKhachhang.DataSource = tkkhBUS.DanhSachKhachHang(mySql);
            LopDungChung.DanhSTT(dataGridViewKhachhang, "cotSTT", 1);
        }
        private void TimMoi()
        {
            TxtMakh.Clear();
            txtTenKH.Clear();
            cbGioiTinh.Text = "Tất cả";
            txtDiaChi.Clear();
            txt_hkttru.Clear();
        }
        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            TKKH tksvOb = LayThongTinTKKH();
            mySql = tkkhBUS.XacDinhTruyVan(tksvOb);
            dataGridViewKhachhang.DataSource = tkkhBUS.DanhSachKhachHang(mySql);
            LopDungChung.DanhSTT(dataGridViewKhachhang, "cotSTT", 1);
        }

        private void txt_hkttru_TextChanged(object sender, EventArgs e)
        {
            TKKH tksvOb = LayThongTinTKKH();
            mySql = tkkhBUS.XacDinhTruyVan(tksvOb);
            dataGridViewKhachhang.DataSource = tkkhBUS.DanhSachKhachHang(mySql);
            LopDungChung.DanhSTT(dataGridViewKhachhang, "cotSTT", 1);
        }

        private void cbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            TKKH tksvOb = LayThongTinTKKH();
            mySql = tkkhBUS.XacDinhTruyVan(tksvOb);
            dataGridViewKhachhang.DataSource = tkkhBUS.DanhSachKhachHang(mySql);
            LopDungChung.DanhSTT(dataGridViewKhachhang, "cotSTT", 1);
        }

        private void TxtMakh_TextChanged(object sender, EventArgs e)
        {
            TKKH tksvOb = LayThongTinTKKH();
            mySql = tkkhBUS.XacDinhTruyVan(tksvOb);
            dataGridViewKhachhang.DataSource = tkkhBUS.DanhSachKhachHang(mySql);
            LopDungChung.DanhSTT(dataGridViewKhachhang, "cotSTT", 1);
        }

        private void btn_ThoatHH_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_TimMoiHH_Click(object sender, EventArgs e)
        {
            TimMoi();
            TxtMakh.Focus();
        }
    }
}