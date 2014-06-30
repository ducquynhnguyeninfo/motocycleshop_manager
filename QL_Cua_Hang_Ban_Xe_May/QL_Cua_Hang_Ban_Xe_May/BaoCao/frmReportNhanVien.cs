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
    public partial class frmReportNhanVien : Form
    {
        NhanVienReportBUS nhanvienreportBUS = new NhanVienReportBUS();
        ChucVuBUS cvBUS = new ChucVuBUS();
        public frmReportNhanVien()
        {
            InitializeComponent();
        }

        private void frmReportNhanVien_Load(object sender, EventArgs e)
        {
            DataTable dtChucVu = cvBUS.LayDanhSachChucVu();
            cbo_ChucVu.DataSource = dtChucVu;
            DataRow dr = dtChucVu.NewRow();
            dr["Ma_CV"] = "ALL";
            dr["Ten_CV"] = "Tất cả";
            dtChucVu.Rows.InsertAt(dr, 0);
            cbo_ChucVu.DataSource = dtChucVu;
            cbo_ChucVu.DisplayMember = "Ten_CV";
            cbo_ChucVu.ValueMember = "Ma_CV";
            cbo_ChucVu.SelectedIndex = 0;
            NhanVienReportBindingSource.DataSource = nhanvienreportBUS.LayTTNhanVien();
            this.reportViewerNhanVien.RefreshReport();
        }
        private void btn_Xembc_Click(object sender, EventArgs e)
        {
            string MaChucVu = cbo_ChucVu.SelectedValue.ToString();
            string NguoiLap = txt_NguoiLap.Text;
            string Ten_CV = cbo_ChucVu.Text;
            IList<ReportParameter> param = new List<ReportParameter>();
            param.Add(new ReportParameter("Ten_CV", Ten_CV));
            param.Add(new ReportParameter("NguoiLap", NguoiLap));
            reportViewerNhanVien.LocalReport.SetParameters(param);
            NhanVienReportBindingSource.DataSource = nhanvienreportBUS.LayTTNhanVienTheoChucVu(MaChucVu);
            this.reportViewerNhanVien.RefreshReport();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
