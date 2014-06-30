namespace QL_Cua_Hang_Ban_Xe_May
{
    partial class frmReportNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportNhaCungCap));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ReportNhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_XemDSNCC = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NguoiLap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_NhaCungCap = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewerNCC = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ReportNhaCungCapBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReportNhaCungCapBindingSource
            // 
            this.ReportNhaCungCapBindingSource.DataSource = typeof(QL_Cua_Hang_Ban_Xe_May.BusinessObject.ReportNhaCungCap);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_NguoiLap);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbo_NhaCungCap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 124);
            this.panel1.TabIndex = 0;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_Thoat.Image")));
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(156, 35);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(97, 27);
            this.btn_Thoat.TabIndex = 12;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_XemDSNCC
            // 
            this.btn_XemDSNCC.Image = ((System.Drawing.Image)(resources.GetObject("btn_XemDSNCC.Image")));
            this.btn_XemDSNCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XemDSNCC.Location = new System.Drawing.Point(29, 35);
            this.btn_XemDSNCC.Name = "btn_XemDSNCC";
            this.btn_XemDSNCC.Size = new System.Drawing.Size(106, 27);
            this.btn_XemDSNCC.TabIndex = 11;
            this.btn_XemDSNCC.Text = "Lập báo cáo";
            this.btn_XemDSNCC.UseVisualStyleBackColor = true;
            this.btn_XemDSNCC.Click += new System.EventHandler(this.btn_XemDSNCC_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "Người lập";
            // 
            // txt_NguoiLap
            // 
            this.txt_NguoiLap.Location = new System.Drawing.Point(170, 74);
            this.txt_NguoiLap.Name = "txt_NguoiLap";
            this.txt_NguoiLap.Size = new System.Drawing.Size(188, 20);
            this.txt_NguoiLap.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên nhà cung cấp";
            // 
            // cbo_NhaCungCap
            // 
            this.cbo_NhaCungCap.FormattingEnabled = true;
            this.cbo_NhaCungCap.Location = new System.Drawing.Point(170, 36);
            this.cbo_NhaCungCap.Name = "cbo_NhaCungCap";
            this.cbo_NhaCungCap.Size = new System.Drawing.Size(188, 22);
            this.cbo_NhaCungCap.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewerNCC);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 348);
            this.panel2.TabIndex = 1;
            // 
            // reportViewerNCC
            // 
            this.reportViewerNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSetNhaCungCap";
            reportDataSource2.Value = this.ReportNhaCungCapBindingSource;
            this.reportViewerNCC.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerNCC.LocalReport.ReportEmbeddedResource = "QL_Cua_Hang_Ban_Xe_May.BaoCao.NhaCungCap.rdlc";
            this.reportViewerNCC.Location = new System.Drawing.Point(0, 0);
            this.reportViewerNCC.Name = "reportViewerNCC";
            this.reportViewerNCC.Size = new System.Drawing.Size(708, 348);
            this.reportViewerNCC.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Thoat);
            this.groupBox1.Controls.Add(this.btn_XemDSNCC);
            this.groupBox1.Location = new System.Drawing.Point(400, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 86);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tác vụ";
            // 
            // frmReportNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 472);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmReportNhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo nhà cung cấp";
            this.Load += new System.EventHandler(this.frmReportNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportNhaCungCapBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_XemDSNCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NguoiLap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_NhaCungCap;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerNCC;
        private System.Windows.Forms.BindingSource ReportNhaCungCapBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}