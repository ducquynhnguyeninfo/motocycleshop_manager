namespace QL_Cua_Hang_Ban_Xe_May.BaoCao
{
    partial class frmReportPhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportPhieuNhap));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PhieuNhapReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.cbo_HangCungCap = new System.Windows.Forms.ComboBox();
            this.btn_Xembc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nguoilap = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewerPhieuNhap = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PhieuNhapReportBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PhieuNhapReportBindingSource
            // 
            this.PhieuNhapReportBindingSource.DataSource = typeof(QL_Cua_Hang_Ban_Xe_May.BusinessObject.PhieuNhapReport);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.cbo_HangCungCap);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_nguoilap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 135);
            this.panel1.TabIndex = 0;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Image")));
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(152, 34);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(97, 27);
            this.btn_thoat.TabIndex = 11;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // cbo_HangCungCap
            // 
            this.cbo_HangCungCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_HangCungCap.FormattingEnabled = true;
            this.cbo_HangCungCap.Location = new System.Drawing.Point(159, 34);
            this.cbo_HangCungCap.Name = "cbo_HangCungCap";
            this.cbo_HangCungCap.Size = new System.Drawing.Size(201, 22);
            this.cbo_HangCungCap.TabIndex = 6;
            // 
            // btn_Xembc
            // 
            this.btn_Xembc.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xembc.Image")));
            this.btn_Xembc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xembc.Location = new System.Drawing.Point(27, 34);
            this.btn_Xembc.Name = "btn_Xembc";
            this.btn_Xembc.Size = new System.Drawing.Size(106, 27);
            this.btn_Xembc.TabIndex = 10;
            this.btn_Xembc.Text = "Lập báo cáo";
            this.btn_Xembc.UseVisualStyleBackColor = true;
            this.btn_Xembc.Click += new System.EventHandler(this.btn_Xembc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hãng cung cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "Người lập";
            // 
            // txt_nguoilap
            // 
            this.txt_nguoilap.Location = new System.Drawing.Point(159, 74);
            this.txt_nguoilap.Name = "txt_nguoilap";
            this.txt_nguoilap.Size = new System.Drawing.Size(201, 20);
            this.txt_nguoilap.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewerPhieuNhap);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 337);
            this.panel2.TabIndex = 1;
            // 
            // reportViewerPhieuNhap
            // 
            this.reportViewerPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "PhieuNhap";
            reportDataSource2.Value = this.PhieuNhapReportBindingSource;
            this.reportViewerPhieuNhap.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerPhieuNhap.LocalReport.ReportEmbeddedResource = "QL_Cua_Hang_Ban_Xe_May.BaoCao.PhieuNhap.rdlc";
            this.reportViewerPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.reportViewerPhieuNhap.Name = "reportViewerPhieuNhap";
            this.reportViewerPhieuNhap.Size = new System.Drawing.Size(708, 337);
            this.reportViewerPhieuNhap.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Xembc);
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Location = new System.Drawing.Point(403, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 88);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tác vụ";
            // 
            // frmReportPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 472);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmReportPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo nhập hàng";
            this.Load += new System.EventHandler(this.frmReportPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PhieuNhapReportBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPhieuNhap;
        private System.Windows.Forms.BindingSource PhieuNhapReportBindingSource;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.ComboBox cbo_HangCungCap;
        private System.Windows.Forms.Button btn_Xembc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nguoilap;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}