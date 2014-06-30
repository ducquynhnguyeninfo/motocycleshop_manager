namespace QL_Cua_Hang_Ban_Xe_May
{
    partial class frmReportPhieuXuat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportPhieuXuat));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PhieuXuatReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.cbo_KhachHang = new System.Windows.Forms.ComboBox();
            this.btn_xembc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NguoiLap = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewerPhieuXuat = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PhieuXuatReportBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PhieuXuatReportBindingSource
            // 
            this.PhieuXuatReportBindingSource.DataSource = typeof(QL_Cua_Hang_Ban_Xe_May.BusinessObject.PhieuXuatReport);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.cbo_KhachHang);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_NguoiLap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 127);
            this.panel1.TabIndex = 0;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Image")));
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(151, 32);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(97, 27);
            this.btn_thoat.TabIndex = 18;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // cbo_KhachHang
            // 
            this.cbo_KhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_KhachHang.FormattingEnabled = true;
            this.cbo_KhachHang.Location = new System.Drawing.Point(162, 37);
            this.cbo_KhachHang.Name = "cbo_KhachHang";
            this.cbo_KhachHang.Size = new System.Drawing.Size(194, 22);
            this.cbo_KhachHang.TabIndex = 13;
            // 
            // btn_xembc
            // 
            this.btn_xembc.Image = ((System.Drawing.Image)(resources.GetObject("btn_xembc.Image")));
            this.btn_xembc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xembc.Location = new System.Drawing.Point(26, 32);
            this.btn_xembc.Name = "btn_xembc";
            this.btn_xembc.Size = new System.Drawing.Size(106, 27);
            this.btn_xembc.TabIndex = 17;
            this.btn_xembc.Text = "Lập báo cáo";
            this.btn_xembc.UseVisualStyleBackColor = true;
            this.btn_xembc.Click += new System.EventHandler(this.btn_xembc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 14);
            this.label1.TabIndex = 14;
            this.label1.Text = "Khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 14);
            this.label2.TabIndex = 16;
            this.label2.Text = "Người lập";
            // 
            // txt_NguoiLap
            // 
            this.txt_NguoiLap.Location = new System.Drawing.Point(162, 75);
            this.txt_NguoiLap.Name = "txt_NguoiLap";
            this.txt_NguoiLap.Size = new System.Drawing.Size(194, 20);
            this.txt_NguoiLap.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewerPhieuXuat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 345);
            this.panel2.TabIndex = 1;
            // 
            // reportViewerPhieuXuat
            // 
            this.reportViewerPhieuXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSetPhieuXuat";
            reportDataSource2.Value = this.PhieuXuatReportBindingSource;
            this.reportViewerPhieuXuat.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerPhieuXuat.LocalReport.ReportEmbeddedResource = "QL_Cua_Hang_Ban_Xe_May.BaoCao.PhieuXuat.rdlc";
            this.reportViewerPhieuXuat.Location = new System.Drawing.Point(0, 0);
            this.reportViewerPhieuXuat.Name = "reportViewerPhieuXuat";
            this.reportViewerPhieuXuat.Size = new System.Drawing.Size(708, 345);
            this.reportViewerPhieuXuat.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_xembc);
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Location = new System.Drawing.Point(407, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 86);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tác vụ";
            // 
            // frmReportPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 472);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmReportPhieuXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo xuất hàng";
            this.Load += new System.EventHandler(this.frmReportPhieuXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PhieuXuatReportBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.ComboBox cbo_KhachHang;
        private System.Windows.Forms.Button btn_xembc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NguoiLap;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPhieuXuat;
        private System.Windows.Forms.BindingSource PhieuXuatReportBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}