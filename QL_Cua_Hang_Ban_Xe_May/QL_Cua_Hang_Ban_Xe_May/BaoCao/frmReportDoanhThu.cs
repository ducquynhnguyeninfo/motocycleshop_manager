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
    public partial class frmReportDoanhThu : Form
    {
        DoanhThuReportBUS doanhthureportBUS = new DoanhThuReportBUS();
        PhieuXuatReportBUS PXRBus = new PhieuXuatReportBUS();

        String Year;
        String Month;
        public frmReportDoanhThu()
        {
            InitializeComponent();
           
            
        }

        void cbxThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Year != null && this.Month != null)
            {

                Year = cbxNam.SelectedValue.ToString();
                Month = cbxThang.SelectedValue.ToString();

                cbxNgay.DataSource = doanhthureportBUS.getDay(Year, Month);
                cbxNgay.DisplayMember = "DAY";
                cbxNgay.ValueMember = "DAY";
                cbxNgay.SelectedIndex = 0;
            }
        }

        void cbxNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Year != null && this.Month != null)
            {
                Year = cbxNam.SelectedValue.ToString();
                Month = cbxThang.SelectedValue.ToString();
                cbxThang.DataSource = doanhthureportBUS.getMonth(Year);
                cbxThang.DisplayMember = "MONTH";
                cbxThang.ValueMember = "MONTH";
                cbxThang.SelectedIndex = 0;

                cbxNgay.DataSource = doanhthureportBUS.getDay(Year, Month);
                cbxNgay.DisplayMember = "DAY";
                cbxNgay.ValueMember = "DAY";
                cbxNgay.SelectedIndex = 0;
            }
        }
        

        private void frmReportDoanhThu_Load(object sender, EventArgs e)
        {
            
            DataTable DsDT = new DataTable() ;// = doanhthureportBUS.LayDoanhThu();
            
            DataRow dr = DsDT.NewRow();
            //dr["NGAYXUAT"] = Convert.ToDateTime("ALL").ToShortDateString();
            ////dr["TenHCC"] = "Tất cả";
            DsDT.Rows.InsertAt(dr, 0);
            cbxNam.DataSource = doanhthureportBUS.getYear();
            cbxNam.DisplayMember = "YEAR";
            cbxNam.ValueMember = "YEAR";
            cbxNam.SelectedIndex = 0;
            Year = cbxNam.SelectedValue.ToString();
            
            cbxThang.DataSource = doanhthureportBUS.getMonth(Year);
            cbxThang.DisplayMember = "MONTH";
            cbxThang.ValueMember = "MONTH";
            cbxThang.SelectedIndex = 0;

            Month = cbxThang.SelectedValue.ToString();
            cbxNgay.DataSource = doanhthureportBUS.getDay(Year, Month);
            cbxNgay.DisplayMember = "DAY";
            cbxNgay.ValueMember = "DAY";
            cbxNgay.SelectedIndex = 0;

            ReportDoanhThuBindingSource.DataSource = doanhthureportBUS.LayDoanhThu();
            this.reportViewerDoanhThu.RefreshReport();
            //cbxThang.SelectedValue = "";
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_XemDSKH_Click(object sender, EventArgs e)
        {
           
            string NguoiLap = txt_NguoiLap.Text;
             
            IList<ReportParameter> param = new List<ReportParameter>();
            param.Add(new ReportParameter("Nam", cbxNam.SelectedValue.ToString()));
            param.Add(new ReportParameter("Thang", cbxThang.SelectedValue.ToString()));
            param.Add(new ReportParameter("NguoiLap", NguoiLap));
            reportViewerDoanhThu.LocalReport.SetParameters(param);

            ReportDoanhThuBindingSource.DataSource = doanhthureportBUS.LayDoanhThu(Year,Month,cbxNgay.SelectedValue.ToString());
            this.reportViewerDoanhThu.RefreshReport();
        }

    }
}
