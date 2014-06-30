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
    public partial class frmTraCuuXe : Form
    {
        private tkhanghoaBUS tkhanghoaBUS = new tkhanghoaBUS();
        private HangHoaBUS hhBUS = new HangHoaBUS();
        private string mySql = "";
        public frmTraCuuXe()
        {
            InitializeComponent();
        }

        private void frmTraCuuXe_Load(object sender, EventArgs e)
        {
            //
            DataTable myDTKD = hhBUS.LayDanhSachKieuDang();
            cboTCKieuDangHH.Items.Add("Tất cả");
            for (int i = 0; i < myDTKD.Rows.Count; i++)
            {
                cboTCKieuDangHH.Items.Add(myDTKD.Rows[i]["KIEUDANG"]);
            }
            cboTCKieuDangHH.Text = "Tất cả";

            DataTable myDTNHASX = hhBUS.LayDanhSachNhaSX();
            cboTCNhaSXHH.Items.Add("Tất cả");
            for (int i = 0; i < myDTNHASX.Rows.Count; i++)
            {
                cboTCNhaSXHH.Items.Add(myDTNHASX.Rows[i]["NHASX"]);
            }
            cboTCNhaSXHH.Text = "Tất cả";

            DataTable myDTMAUXE = hhBUS.LayDanhSachMauXe();
            cboTCMauXeHH.Items.Add("Tất cả");
            for (int i = 0; i < myDTMAUXE.Rows.Count; i++)
            {
                cboTCMauXeHH.Items.Add(myDTMAUXE.Rows[i]["MAUXE"]);
            }
            cboTCMauXeHH.Text = "Tất cả";

            //Gan du lieu vao luoi
            TCHangHoa tkhanghoa = LayThongTinTCHangHoa();
            mySql = tkhanghoaBUS.XacDinhTruyVan(tkhanghoa);
            dataGridViewTCHangHoa.DataSource = tkhanghoaBUS.DanhSachHangHoa(mySql);
            LopDungChung.DanhSTT(dataGridViewTCHangHoa, "cotSTT", 1);
        }

        private TCHangHoa LayThongTinTCHangHoa()
        {
            TCHangHoa tchanghoa = new TCHangHoa();

            tchanghoa.MaXe = txtTCMaXeHH.Text;
            tchanghoa.TenXe = txtTCTenXeHH.Text;
            tchanghoa.NhaSX = cboTCNhaSXHH.Text;
            tchanghoa.KieuDang = cboTCKieuDangHH.Text;
            tchanghoa.MauXe = cboTCMauXeHH.Text;
            tchanghoa.SoKhung = txtTCSoKhungHH.Text;
            tchanghoa.SoSuon = txtTCSoSuonHH.Text;

            return tchanghoa;
        }

        private void cboTCNhaSXHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            TCHangHoa tkhanghoa = LayThongTinTCHangHoa();
            mySql = tkhanghoaBUS.XacDinhTruyVan(tkhanghoa);
            dataGridViewTCHangHoa.DataSource = tkhanghoaBUS.DanhSachHangHoa(mySql);
            LopDungChung.DanhSTT(dataGridViewTCHangHoa, "cotSTT", 1);
        }

        private void cboTCKieuDangHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            TCHangHoa tkhanghoa = LayThongTinTCHangHoa();
            mySql = tkhanghoaBUS.XacDinhTruyVan(tkhanghoa);
            dataGridViewTCHangHoa.DataSource = tkhanghoaBUS.DanhSachHangHoa(mySql);
            LopDungChung.DanhSTT(dataGridViewTCHangHoa, "cotSTT", 1);
        }

        private void txtTCMaXeHH_TextChanged(object sender, EventArgs e)
        {
            TCHangHoa tkhanghoa = LayThongTinTCHangHoa();
            mySql = tkhanghoaBUS.XacDinhTruyVan(tkhanghoa);
            dataGridViewTCHangHoa.DataSource = tkhanghoaBUS.DanhSachHangHoa(mySql);
            LopDungChung.DanhSTT(dataGridViewTCHangHoa, "cotSTT", 1);
        }

        private void txtTCTenXeHH_TextChanged(object sender, EventArgs e)
        {
            TCHangHoa tkhanghoa = LayThongTinTCHangHoa();
            mySql = tkhanghoaBUS.XacDinhTruyVan(tkhanghoa);
            dataGridViewTCHangHoa.DataSource = tkhanghoaBUS.DanhSachHangHoa(mySql);
            LopDungChung.DanhSTT(dataGridViewTCHangHoa, "cotSTT", 1);
        }

        private void cboTCMauXeHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            TCHangHoa tkhanghoa = LayThongTinTCHangHoa();
            mySql = tkhanghoaBUS.XacDinhTruyVan(tkhanghoa);
            dataGridViewTCHangHoa.DataSource = tkhanghoaBUS.DanhSachHangHoa(mySql);
            LopDungChung.DanhSTT(dataGridViewTCHangHoa, "cotSTT", 1);
        }

        private void txtTCSoKhungHH_TextChanged(object sender, EventArgs e)
        {
            TCHangHoa tkhanghoa = LayThongTinTCHangHoa();
            mySql = tkhanghoaBUS.XacDinhTruyVan(tkhanghoa);
            dataGridViewTCHangHoa.DataSource = tkhanghoaBUS.DanhSachHangHoa(mySql);
            LopDungChung.DanhSTT(dataGridViewTCHangHoa, "cotSTT", 1);
        }

        private void txtTCSoSuonHH_TextChanged(object sender, EventArgs e)
        {
            TCHangHoa tkhanghoa = LayThongTinTCHangHoa();
            mySql = tkhanghoaBUS.XacDinhTruyVan(tkhanghoa);
            dataGridViewTCHangHoa.DataSource = tkhanghoaBUS.DanhSachHangHoa(mySql);
            LopDungChung.DanhSTT(dataGridViewTCHangHoa, "cotSTT", 1);
        }

        private void TimMoi()
        {
            txtTCMaXeHH.Clear();
            txtTCTenXeHH.Clear();
            cboTCNhaSXHH.Text = "Tất cả";
            cboTCKieuDangHH.Text = "Tất cả";
            cboTCMauXeHH.Text = "Tất cả";
            txtTCSoKhungHH.Clear();
            txtTCSoSuonHH.Clear();
        }

        private void btn_TimMoiHH_Click(object sender, EventArgs e)
        {
            TimMoi();
            txtTCMaXeHH.Focus();
        }

        private void btn_ThoatHH_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
