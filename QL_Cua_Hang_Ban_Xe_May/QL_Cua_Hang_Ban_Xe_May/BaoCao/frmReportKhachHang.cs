using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QL_Cua_Hang_Ban_Xe_May.BusinessLogic;
using Microsoft.Reporting.WinForms;

namespace QL_Cua_Hang_Ban_Xe_May
{
    public partial class frmReportKhachHang : Form
    {
        //KhachHangBUS khBus = new KhachHangBUS();
        KhachHangReportBUS khRBus = new KhachHangReportBUS();
        public frmReportKhachHang()
        {
            InitializeComponent();
        }

        private void frmReportKhachHang_Load(object sender, EventArgs e)
        {
            DataTable DsHK = khRBus.LayDanhSachKH();
            DataRow dr = DsHK.NewRow();
            dr["MAKH"] = "ALL";
            dr["TENKH"] = "Tất cả";
            DsHK.Rows.InsertAt(dr, 0);
            cbo_KhachHang.DataSource = DsHK;
            cbo_KhachHang.DisplayMember = "TENKH";
            cbo_KhachHang.ValueMember = "MAKH";
            cbo_KhachHang.SelectedIndex = 0;
            ReportKhachHangBindingSource.DataSource = khRBus.LayDanhSachKH();
            this.reportViewerKH.RefreshReport();
        }

        private void btn_XemDSKH_Click(object sender, EventArgs e)
        {
            string MaKH = cbo_KhachHang.SelectedValue.ToString();
            string NguoiLap = txt_NguoiLap.Text;
            string TenKH = cbo_KhachHang.Text;
            IList<ReportParameter> param = new List<ReportParameter>();
            param.Add(new ReportParameter("TENKH", TenKH));
            param.Add(new ReportParameter("NguoiLap", NguoiLap));
            reportViewerKH.LocalReport.SetParameters(param);
            ReportKhachHangBindingSource.DataSource = khRBus.LayDanhSachKH(MaKH);
            this.reportViewerKH.RefreshReport();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
