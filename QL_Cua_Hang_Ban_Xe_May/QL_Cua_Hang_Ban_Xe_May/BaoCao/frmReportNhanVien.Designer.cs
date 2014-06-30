namespace QL_Cua_Hang_Ban_Xe_May.BaoCao
{
    partial class frmReportNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportNhanVien));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.NhanVienReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Xembc = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NguoiLap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_ChucVu = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewerNhanVien = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienReportBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NhanVienReportBindingSource
            // 
            this.NhanVienReportBindingSource.DataSource = typeof(QL_Cua_Hang_Ban_Xe_May.BusinessObject.NhanVienReport);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_NguoiLap);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbo_ChucVu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 132);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Xembc);
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Location = new System.Drawing.Point(402, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 88);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tác vụ";
            // 
            // btn_Xembc
            // 
            this.btn_Xembc.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xembc.Image")));
            this.btn_Xembc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xembc.Location = new System.Drawing.Point(29, 34);
            this.btn_Xembc.Name = "btn_Xembc";
            this.btn_Xembc.Size = new System.Drawing.Size(106, 27);
            this.btn_Xembc.TabIndex = 4;
            this.btn_Xembc.Text = "Lập báo cáo";
            this.btn_Xembc.UseVisualStyleBackColor = true;
            this.btn_Xembc.Click += new System.EventHandler(this.btn_Xembc_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Image")));
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(153, 34);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(97, 27);
            this.btn_thoat.TabIndex = 5;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Người lập";
            // 
            // txt_NguoiLap
            // 
            this.txt_NguoiLap.Location = new System.Drawing.Point(149, 70);
            this.txt_NguoiLap.Name = "txt_NguoiLap";
            this.txt_NguoiLap.Size = new System.Drawing.Size(193, 20);
            this.txt_NguoiLap.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên chức vụ";
            // 
            // cbo_ChucVu
            // 
            this.cbo_ChucVu.FormattingEnabled = true;
            this.cbo_ChucVu.Location = new System.Drawing.Point(149, 38);
            this.cbo_ChucVu.Name = "cbo_ChucVu";
            this.cbo_ChucVu.Size = new System.Drawing.Size(193, 22);
            this.cbo_ChucVu.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewerNhanVien);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 340);
            this.panel2.TabIndex = 1;
            // 
            // reportViewerNhanVien
            // 
            this.reportViewerNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSNhanVien";
            reportDataSource1.Value = this.NhanVienReportBindingSource;
            this.reportViewerNhanVien.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerNhanVien.LocalReport.ReportEmbeddedResource = "QL_Cua_Hang_Ban_Xe_May.BaoCao.NhanVien.rdlc";
            this.reportViewerNhanVien.Location = new System.Drawing.Point(0, 0);
            this.reportViewerNhanVien.Name = "reportViewerNhanVien";
            this.reportViewerNhanVien.Size = new System.Drawing.Size(708, 340);
            this.reportViewerNhanVien.TabIndex = 0;
            // 
            // frmReportNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 472);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmReportNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo nhà cung cấp";
            this.Load += new System.EventHandler(this.frmReportNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienReportBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerNhanVien;
        private System.Windows.Forms.BindingSource NhanVienReportBindingSource;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_Xembc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NguoiLap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_ChucVu;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}