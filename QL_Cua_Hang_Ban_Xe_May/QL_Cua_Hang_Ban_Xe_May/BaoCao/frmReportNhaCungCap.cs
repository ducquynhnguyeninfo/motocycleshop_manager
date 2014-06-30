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
    public partial class frmReportNhaCungCap : Form
    {
        NhaCungCapReportBUS nccReportBUS = new NhaCungCapReportBUS();
        NhaCungCapBUS nccBUS = new NhaCungCapBUS();
        public frmReportNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmReportNhaCungCap_Load(object sender, EventArgs e)
        {
            DataTable DsNCC = nccBUS.LayDanhSachNhaCungCap();
            cbo_NhaCungCap.DataSource = DsNCC;
            DataRow dr = DsNCC.NewRow();
            dr["MaHCC"] = "ALL";
            dr["TenHCC"] = "Tất cả";
            DsNCC.Rows.InsertAt(dr, 0);
            cbo_NhaCungCap.DataSource = DsNCC;
            cbo_NhaCungCap.DisplayMember = "TenHCC";
            cbo_NhaCungCap.ValueMember = "MaHCC";
            cbo_NhaCungCap.SelectedIndex = 0;
            ReportNhaCungCapBindingSource.DataSource = nccReportBUS.LayDanhSachNhaCC();
            this.reportViewerNCC.RefreshReport();
        }

        private void btn_XemDSNCC_Click(object sender, EventArgs e)
        {
            string MaHCC = cbo_NhaCungCap.SelectedValue.ToString();
            string NguoiLap = txt_NguoiLap.Text;
            string TenHCC = cbo_NhaCungCap.Text;
            IList<ReportParameter> param = new List<ReportParameter>();
            param.Add(new ReportParameter("TenHCC", TenHCC));
            param.Add(new ReportParameter("NguoiLap", NguoiLap));
            reportViewerNCC.LocalReport.SetParameters(param);
            ReportNhaCungCapBindingSource.DataSource = nccReportBUS.LayDanhSachNhaCC(MaHCC);
            this.reportViewerNCC.RefreshReport();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
