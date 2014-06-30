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
    public partial class frmReportThongTinXeMay : Form
    {
        ThongTinXeMayReportBUS ttxmReportBUS = new ThongTinXeMayReportBUS();
        public frmReportThongTinXeMay()
        {
            InitializeComponent();
        }

        private void frmReportThongTinXeMay_Load(object sender, EventArgs e)
        {
            DataTable myDTTENXE = ttxmReportBUS.LayDSTenXe();
            DataRow drow = myDTTENXE.NewRow();
            drow["TENXE"] = "ALL";
            drow["TENXE"] = "Tất cả";
            myDTTENXE.Rows.InsertAt(drow, 0);
            cbxTenXe.DataSource = myDTTENXE;
            cbxTenXe.DisplayMember = "TENXE";
            cbxTenXe.ValueMember = "TENXE";
            cbxTenXe.SelectedIndex = 0;

            //

            cboNhaSanXuat.DataSource = ttxmReportBUS.LayDSNXBTenXe(cbxTenXe.SelectedValue.ToString());
            cboNhaSanXuat.DisplayMember = "NHASX";
            cboNhaSanXuat.ValueMember = "NHASX";

            ReportThongTinXeMayBindingSource.DataSource = ttxmReportBUS.LayDanhSachThongTinXeMay(cboNhaSanXuat.Text);
            this.reportViewerThongTinXeMay.RefreshReport();
        }

        private void btn_XemBCTTXM_Click(object sender, EventArgs e)
        {
            ReportThongTinXeMayBindingSource.DataSource = ttxmReportBUS.LayDanhSachThongTinXeMay(cboNhaSanXuat.Text);
            string HangSanXuat = cboNhaSanXuat.Text;
            string NguoiLap = txtNguoiLap.Text;
            IList<ReportParameter> param = new List<ReportParameter>();
            param.Add(new ReportParameter("HangSanXuat", HangSanXuat));
            param.Add(new ReportParameter("NguoiLap", NguoiLap));
            reportViewerThongTinXeMay.LocalReport.SetParameters(param);
            this.reportViewerThongTinXeMay.RefreshReport();
        }

        private void cbxTenXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable myT = ttxmReportBUS.LayDSNXBTenXe(cbxTenXe.SelectedValue.ToString());
            if (myT.Rows.Count <= 0)
            {
                cboNhaSanXuat.Text = "";
                //cbxTenXe.Text = "Tất cả";
                frmReportThongTinXeMay_Load(sender, e);
                
            }
            else
            {
                cboNhaSanXuat.DataSource = myT;
                cboNhaSanXuat.DisplayMember = "NHASX";
                cboNhaSanXuat.ValueMember = "NHASX";
            }
        }


        private void btn_ThoatBCTTXM_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
