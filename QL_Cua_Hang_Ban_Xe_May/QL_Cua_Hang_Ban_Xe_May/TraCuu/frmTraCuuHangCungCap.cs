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
    public partial class frmTraCuuHangCungCap : Form
    {
        private tknhacungcapBUS tknhacungcapBUS = new tknhacungcapBUS();
        private NhaCungCapBUS nccBUS = new NhaCungCapBUS();
        private string mySql = "";
        public frmTraCuuHangCungCap()
        {
            InitializeComponent();
        }

        private void frmTraCuuHangCungCap_Load(object sender, EventArgs e)
        {
            DataTable myDTKD = nccBUS.LayDanhSachDiaChiNCC();

            TCNhaCungCap tknhacungcap = LayThongTinTCNhaCungCap();
            mySql = tknhacungcapBUS.XacDinhTruyVan(tknhacungcap);

            dataGridViewTCNhaCungCap.DataSource = tknhacungcapBUS.DanhSachNhaCungCap(mySql);
            LopDungChung.DanhSTTNCC(dataGridViewTCNhaCungCap, "cotSTT", 1);
        }
        private TCNhaCungCap LayThongTinTCNhaCungCap()
        {
            TCNhaCungCap tcnhacungcap = new TCNhaCungCap();

            tcnhacungcap.MaNCC = txtTCMaNCC.Text;
            tcnhacungcap.TenNCC = txtTCTenNCC.Text;
            tcnhacungcap.DiaChiNCC = txt_diachi.Text;

            return tcnhacungcap;
        }
        private void TimMoiNCC()
        {
            txtTCMaNCC.Clear();
            txtTCTenNCC.Clear();
            txt_diachi.Text = "";
        }
        private void btn_TimMoiNCC_Click(object sender, EventArgs e)
        {
            TimMoiNCC();
            txtTCMaNCC.Focus();
        }
        private void btn_ThoatNCC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTCMaNCC_TextChanged(object sender, EventArgs e)
        {
            TCNhaCungCap tknhacungcap = LayThongTinTCNhaCungCap();
            mySql = tknhacungcapBUS.XacDinhTruyVan(tknhacungcap);
            dataGridViewTCNhaCungCap.DataSource = tknhacungcapBUS.DanhSachNhaCungCap(mySql);
            LopDungChung.DanhSTTNCC(dataGridViewTCNhaCungCap, "cotSTT", 1);
        }

        private void txtTCTenNCC_TextChanged(object sender, EventArgs e)
        {
            TCNhaCungCap tknhacungcap = LayThongTinTCNhaCungCap();
            mySql = tknhacungcapBUS.XacDinhTruyVan(tknhacungcap);
            dataGridViewTCNhaCungCap.DataSource = tknhacungcapBUS.DanhSachNhaCungCap(mySql);
            LopDungChung.DanhSTTNCC(dataGridViewTCNhaCungCap, "cotSTT", 1);
        }

        private void txt_diachi_TextChanged(object sender, EventArgs e)
        {
            TCNhaCungCap tknhacungcap = LayThongTinTCNhaCungCap();
            mySql = tknhacungcapBUS.XacDinhTruyVan(tknhacungcap);
            dataGridViewTCNhaCungCap.DataSource = tknhacungcapBUS.DanhSachNhaCungCap(mySql);
            LopDungChung.DanhSTTNCC(dataGridViewTCNhaCungCap, "cotSTT", 1);
        }
    }
}
