namespace QL_Cua_Hang_Ban_Xe_May
{
    partial class frmReportKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportKhachHang));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_XemDSKH = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NguoiLap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_KhachHang = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewerKH = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReportKhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportKhachHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_NguoiLap);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbo_KhachHang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 115);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Thoat);
            this.groupBox1.Controls.Add(this.btn_XemDSKH);
            this.groupBox1.Location = new System.Drawing.Point(400, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 80);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tác vụ";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_Thoat.Image")));
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(156, 32);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(97, 25);
            this.btn_Thoat.TabIndex = 12;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_XemDSKH
            // 
            this.btn_XemDSKH.Image = ((System.Drawing.Image)(resources.GetObject("btn_XemDSKH.Image")));
            this.btn_XemDSKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XemDSKH.Location = new System.Drawing.Point(29, 32);
            this.btn_XemDSKH.Name = "btn_XemDSKH";
            this.btn_XemDSKH.Size = new System.Drawing.Size(106, 25);
            this.btn_XemDSKH.TabIndex = 11;
            this.btn_XemDSKH.Text = "Lập báo cáo";
            this.btn_XemDSKH.UseVisualStyleBackColor = true;
            this.btn_XemDSKH.Click += new System.EventHandler(this.btn_XemDSKH_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Người lập";
            // 
            // txt_NguoiLap
            // 
            this.txt_NguoiLap.Location = new System.Drawing.Point(170, 69);
            this.txt_NguoiLap.Name = "txt_NguoiLap";
            this.txt_NguoiLap.Size = new System.Drawing.Size(188, 20);
            this.txt_NguoiLap.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên khách hàng";
            // 
            // cbo_KhachHang
            // 
            this.cbo_KhachHang.FormattingEnabled = true;
            this.cbo_KhachHang.Location = new System.Drawing.Point(170, 33);
            this.cbo_KhachHang.Name = "cbo_KhachHang";
            this.cbo_KhachHang.Size = new System.Drawing.Size(188, 21);
            this.cbo_KhachHang.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewerKH);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 323);
            this.panel2.TabIndex = 1;
            // 
            // reportViewerKH
            // 
            this.reportViewerKH.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReportKhachHangBindingSource;
            this.reportViewerKH.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerKH.LocalReport.ReportEmbeddedResource = "QL_Cua_Hang_Ban_Xe_May.BaoCao.ReportKhachHang.rdlc";
            this.reportViewerKH.Location = new System.Drawing.Point(0, 0);
            this.reportViewerKH.Name = "reportViewerKH";
            this.reportViewerKH.Size = new System.Drawing.Size(708, 323);
            this.reportViewerKH.TabIndex = 0;
            // 
            // ReportKhachHangBindingSource
            // 
            this.ReportKhachHangBindingSource.DataSource = typeof(QL_Cua_Hang_Ban_Xe_May.BusinessObject.ReportKhachHang);
            // 
            // frmReportKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 438);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmReportKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo khách hàng";
            this.Load += new System.EventHandler(this.frmReportKhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReportKhachHangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_XemDSKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NguoiLap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_KhachHang;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerKH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource ReportKhachHangBindingSource;
    }
}