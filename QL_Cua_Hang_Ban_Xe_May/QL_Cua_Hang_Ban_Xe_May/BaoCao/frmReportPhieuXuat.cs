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
    public partial class frmReportPhieuXuat : Form
    {
        PhieuXuatReportBUS phieuxuatreportBUS = new PhieuXuatReportBUS();
        KhachHangBUS khBUS = new KhachHangBUS();
        public frmReportPhieuXuat()
        {
            InitializeComponent();
        }

        private void frmReportPhieuXuat_Load(object sender, EventArgs e)
        {
            DataTable dtChucVu = khBUS.LayDanhSachKhachHang();
            cbo_KhachHang.DataSource = dtChucVu;
            DataRow dr = dtChucVu.NewRow();
            dr["MAKH"] = "ALL";
            dr["TENKH"] = "Tất cả";
            dtChucVu.Rows.InsertAt(dr, 0);
            cbo_KhachHang.DataSource = dtChucVu;
            cbo_KhachHang.DisplayMember = "TENKH";
            cbo_KhachHang.ValueMember = "MAKH";
            cbo_KhachHang.SelectedIndex = 0;
            PhieuXuatReportBindingSource.DataSource = phieuxuatreportBUS.LayTTPhieuXuat();
            this.reportViewerPhieuXuat.RefreshReport();
        }

        private void btn_xembc_Click(object sender, EventArgs e)
        {
            string MAKH = cbo_KhachHang.SelectedValue.ToString();
            string NguoiLap = txt_NguoiLap.Text;
            string TENKH = cbo_KhachHang.Text;

            IList<ReportParameter> param = new List<ReportParameter>();
            param.Add(new ReportParameter("TENKH", TENKH));
            param.Add(new ReportParameter("NguoiLap", NguoiLap));

            reportViewerPhieuXuat.LocalReport.SetParameters(param);

            PhieuXuatReportBindingSource.DataSource = phieuxuatreportBUS.LayTTPhieuXuatKhachHang(MAKH);
            this.reportViewerPhieuXuat.RefreshReport();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
