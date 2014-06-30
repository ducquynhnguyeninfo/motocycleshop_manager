namespace QL_Cua_Hang_Ban_Xe_May.BaoCao
{
    partial class frmReportBaoHanh
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
            System.Windows.Forms.Button btn_Xembc;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportBaoHanh));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.BaoHanhReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.cbo_HangCungCap = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nguoilap = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewerBaoHanh = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            btn_Xembc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BaoHanhReportBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaoHanhReportBindingSource
            // 
            this.BaoHanhReportBindingSource.DataSource = typeof(QL_Cua_Hang_Ban_Xe_May.BusinessObject.BaoHanhReport);
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
            this.panel1.Size = new System.Drawing.Size(708, 117);
            this.panel1.TabIndex = 0;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Image")));
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(152, 27);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(97, 27);
            this.btn_thoat.TabIndex = 17;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // cbo_HangCungCap
            // 
            this.cbo_HangCungCap.FormattingEnabled = true;
            this.cbo_HangCungCap.Location = new System.Drawing.Point(159, 29);
            this.cbo_HangCungCap.Name = "cbo_HangCungCap";
            this.cbo_HangCungCap.Size = new System.Drawing.Size(188, 22);
            this.cbo_HangCungCap.TabIndex = 12;
            // 
            // btn_Xembc
            // 
            btn_Xembc.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xembc.Image")));
            btn_Xembc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_Xembc.Location = new System.Drawing.Point(31, 27);
            btn_Xembc.Name = "btn_Xembc";
            btn_Xembc.Size = new System.Drawing.Size(106, 27);
            btn_Xembc.TabIndex = 16;
            btn_Xembc.Text = "Lập báo cáo";
            btn_Xembc.UseVisualStyleBackColor = true;
            btn_Xembc.Click += new System.EventHandler(this.btn_Xembc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 14);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tên hãng cung cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 14);
            this.label2.TabIndex = 15;
            this.label2.Text = "Người lập";
            // 
            // txt_nguoilap
            // 
            this.txt_nguoilap.Location = new System.Drawing.Point(159, 65);
            this.txt_nguoilap.Name = "txt_nguoilap";
            this.txt_nguoilap.Size = new System.Drawing.Size(188, 20);
            this.txt_nguoilap.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewerBaoHanh);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 355);
            this.panel2.TabIndex = 1;
            // 
            // reportViewerBaoHanh
            // 
            this.reportViewerBaoHanh.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "BaoHanhReport";
            reportDataSource2.Value = this.BaoHanhReportBindingSource;
            this.reportViewerBaoHanh.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerBaoHanh.LocalReport.ReportEmbeddedResource = "QL_Cua_Hang_Ban_Xe_May.BaoCao.BaoHanh.rdlc";
            this.reportViewerBaoHanh.Location = new System.Drawing.Point(0, 0);
            this.reportViewerBaoHanh.Name = "reportViewerBaoHanh";
            this.reportViewerBaoHanh.Size = new System.Drawing.Size(708, 355);
            this.reportViewerBaoHanh.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(btn_Xembc);
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Location = new System.Drawing.Point(411, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 73);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tác vụ";
            // 
            // frmReportBaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 472);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmReportBaoHanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo bảo hành";
            this.Load += new System.EventHandler(this.frmReportBaoHanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BaoHanhReportBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerBaoHanh;
        private System.Windows.Forms.BindingSource BaoHanhReportBindingSource;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.ComboBox cbo_HangCungCap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nguoilap;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}