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

namespace QL_Cua_Hang_Ban_Xe_May.BaoCao
{
    public partial class frmReportPhieuNhap : Form
    {
        PhieuNhapReportBUS phieunhapreportBUS = new PhieuNhapReportBUS();
        NhaCungCapBUS nccBUS = new NhaCungCapBUS();
        public frmReportPhieuNhap()
        {
            InitializeComponent();
        }

        private void frmReportPhieuNhap_Load(object sender, EventArgs e)
        {
            DataTable dtChucVu = nccBUS.LayDanhSachNhaCungCap();
            cbo_HangCungCap.DataSource = dtChucVu;
            DataRow dr = dtChucVu.NewRow();
            dr["MAHCC"] = "ALL";
            dr["TENHCC"] = "Tất cả";
            dtChucVu.Rows.InsertAt(dr, 0);
            cbo_HangCungCap.DataSource = dtChucVu;
            cbo_HangCungCap.DisplayMember = "TENHCC";
            cbo_HangCungCap.ValueMember = "MAHCC";
            cbo_HangCungCap.SelectedIndex = 0;
            PhieuNhapReportBindingSource.DataSource = phieunhapreportBUS.LayTTPhieuNhap();
            this.reportViewerPhieuNhap.RefreshReport();
        }

        private void btn_Xembc_Click(object sender, EventArgs e)
        {
            string MAHCC = cbo_HangCungCap.SelectedValue.ToString();
            string NguoiLap = txt_nguoilap.Text;
            string TenHCC = cbo_HangCungCap.Text;

            IList<ReportParameter> param = new List<ReportParameter>();
            param.Add(new ReportParameter("TENHCC", TenHCC));
            param.Add(new ReportParameter("NguoiLap", NguoiLap));

            reportViewerPhieuNhap.LocalReport.SetParameters(param);

            PhieuNhapReportBindingSource.DataSource = phieunhapreportBUS.LayTTPhieuNhapHangCungCap(MAHCC);
            this.reportViewerPhieuNhap.RefreshReport();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
