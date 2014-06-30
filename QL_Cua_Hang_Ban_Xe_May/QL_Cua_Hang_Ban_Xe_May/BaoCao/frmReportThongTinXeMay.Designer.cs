namespace QL_Cua_Hang_Ban_Xe_May
{
    partial class frmReportThongTinXeMay
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportThongTinXeMay));
            this.ReportThongTinXeMayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewerThongTinXeMay = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_thang = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_TenXe = new System.Windows.Forms.ComboBox();
            this.lb_nam = new System.Windows.Forms.Label();
            this.cbx_NhaSanXuat = new System.Windows.Forms.ComboBox();
            this.btn_xem = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.txt_NguoiLap = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNguoiLap = new System.Windows.Forms.TextBox();
            this.btn_ThoatBCTTXM = new System.Windows.Forms.Button();
            this.btn_XemBCTTXM = new System.Windows.Forms.Button();
            this.cboNhaSanXuat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxTenXe = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReportThongTinXeMayBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReportThongTinXeMayBindingSource
            // 
            this.ReportThongTinXeMayBindingSource.DataSource = typeof(QL_Cua_Hang_Ban_Xe_May.BusinessObject.ReportThongTinXeMay);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewerThongTinXeMay);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(789, 326);
            this.panel2.TabIndex = 1;
            // 
            // reportViewerThongTinXeMay
            // 
            this.reportViewerThongTinXeMay.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetThongTinXeMay";
            reportDataSource1.Value = this.ReportThongTinXeMayBindingSource;
            this.reportViewerThongTinXeMay.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerThongTinXeMay.LocalReport.ReportEmbeddedResource = "QL_Cua_Hang_Ban_Xe_May.BaoCao.ThongTinXeMay.rdlc";
            this.reportViewerThongTinXeMay.Location = new System.Drawing.Point(0, 0);
            this.reportViewerThongTinXeMay.Name = "reportViewerThongTinXeMay";
            this.reportViewerThongTinXeMay.Size = new System.Drawing.Size(789, 326);
            this.reportViewerThongTinXeMay.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label3.Location = new System.Drawing.Point(297, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(290, 0, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Báo Cáo Thông Tin Xe Máy";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_thang
            // 
            this.lb_thang.AutoSize = true;
            this.lb_thang.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_thang.Location = new System.Drawing.Point(28, 75);
            this.lb_thang.Name = "lb_thang";
            this.lb_thang.Size = new System.Drawing.Size(58, 17);
            this.lb_thang.TabIndex = 15;
            this.lb_thang.Text = "Tên Xe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(28, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Người Lập:";
            // 
            // cbx_TenXe
            // 
            this.cbx_TenXe.DisplayMember = "1";
            this.cbx_TenXe.FormattingEnabled = true;
            this.cbx_TenXe.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            ""});
            this.cbx_TenXe.Location = new System.Drawing.Point(113, 72);
            this.cbx_TenXe.Name = "cbx_TenXe";
            this.cbx_TenXe.Size = new System.Drawing.Size(150, 21);
            this.cbx_TenXe.TabIndex = 16;
            // 
            // lb_nam
            // 
            this.lb_nam.AutoSize = true;
            this.lb_nam.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_nam.Location = new System.Drawing.Point(312, 75);
            this.lb_nam.Name = "lb_nam";
            this.lb_nam.Size = new System.Drawing.Size(61, 17);
            this.lb_nam.TabIndex = 17;
            this.lb_nam.Text = "Nhà SX:";
            // 
            // cbx_NhaSanXuat
            // 
            this.cbx_NhaSanXuat.DisplayMember = "1";
            this.cbx_NhaSanXuat.FormattingEnabled = true;
            this.cbx_NhaSanXuat.Items.AddRange(new object[] {
            "for(int i = 2001; i<2100; i++)",
            "{",
            "\tprintln(i);",
            "}"});
            this.cbx_NhaSanXuat.Location = new System.Drawing.Point(372, 72);
            this.cbx_NhaSanXuat.Name = "cbx_NhaSanXuat";
            this.cbx_NhaSanXuat.Size = new System.Drawing.Size(150, 21);
            this.cbx_NhaSanXuat.TabIndex = 18;
            // 
            // btn_xem
            // 
            this.btn_xem.BackColor = System.Drawing.Color.Transparent;
            this.btn_xem.Image = ((System.Drawing.Image)(resources.GetObject("btn_xem.Image")));
            this.btn_xem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xem.Location = new System.Drawing.Point(577, 68);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Size = new System.Drawing.Size(80, 25);
            this.btn_xem.TabIndex = 19;
            this.btn_xem.Text = "Xem";
            this.btn_xem.UseVisualStyleBackColor = false;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.Transparent;
            this.btn_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Image")));
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(681, 68);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(80, 25);
            this.btn_thoat.TabIndex = 20;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            // 
            // txt_NguoiLap
            // 
            this.txt_NguoiLap.Location = new System.Drawing.Point(113, 99);
            this.txt_NguoiLap.Name = "txt_NguoiLap";
            this.txt_NguoiLap.Size = new System.Drawing.Size(150, 20);
            this.txt_NguoiLap.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txt_NguoiLap);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_thoat);
            this.panel1.Controls.Add(this.btn_xem);
            this.panel1.Controls.Add(this.cbx_NhaSanXuat);
            this.panel1.Controls.Add(this.lb_nam);
            this.panel1.Controls.Add(this.cbx_TenXe);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lb_thang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 136);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNguoiLap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_ThoatBCTTXM);
            this.groupBox1.Controls.Add(this.btn_XemBCTTXM);
            this.groupBox1.Controls.Add(this.cboNhaSanXuat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbxTenXe);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.MaximumSize = new System.Drawing.Size(788, 128);
            this.groupBox1.MinimumSize = new System.Drawing.Size(788, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 128);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // txtNguoiLap
            // 
            this.txtNguoiLap.Location = new System.Drawing.Point(408, 57);
            this.txtNguoiLap.Name = "txtNguoiLap";
            this.txtNguoiLap.Size = new System.Drawing.Size(150, 20);
            this.txtNguoiLap.TabIndex = 12;
            // 
            // btn_ThoatBCTTXM
            // 
            this.btn_ThoatBCTTXM.BackColor = System.Drawing.Color.Transparent;
            this.btn_ThoatBCTTXM.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThoatBCTTXM.Image")));
            this.btn_ThoatBCTTXM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThoatBCTTXM.Location = new System.Drawing.Point(681, 54);
            this.btn_ThoatBCTTXM.Name = "btn_ThoatBCTTXM";
            this.btn_ThoatBCTTXM.Size = new System.Drawing.Size(80, 25);
            this.btn_ThoatBCTTXM.TabIndex = 11;
            this.btn_ThoatBCTTXM.Text = "Thoát";
            this.btn_ThoatBCTTXM.UseVisualStyleBackColor = false;
            this.btn_ThoatBCTTXM.Click += new System.EventHandler(this.btn_ThoatBCTTXM_Click);
            // 
            // btn_XemBCTTXM
            // 
            this.btn_XemBCTTXM.BackColor = System.Drawing.Color.Transparent;
            this.btn_XemBCTTXM.Image = ((System.Drawing.Image)(resources.GetObject("btn_XemBCTTXM.Image")));
            this.btn_XemBCTTXM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XemBCTTXM.Location = new System.Drawing.Point(584, 54);
            this.btn_XemBCTTXM.Name = "btn_XemBCTTXM";
            this.btn_XemBCTTXM.Size = new System.Drawing.Size(80, 25);
            this.btn_XemBCTTXM.TabIndex = 10;
            this.btn_XemBCTTXM.Text = "Xem";
            this.btn_XemBCTTXM.UseVisualStyleBackColor = false;
            this.btn_XemBCTTXM.Click += new System.EventHandler(this.btn_XemBCTTXM_Click);
            // 
            // cboNhaSanXuat
            // 
            this.cboNhaSanXuat.DisplayMember = "1";
            this.cboNhaSanXuat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhaSanXuat.FormattingEnabled = true;
            this.cboNhaSanXuat.Items.AddRange(new object[] {
            "for(int i = 2001; i<2100; i++)",
            "{",
            "\tprintln(i);",
            "}"});
            this.cboNhaSanXuat.Location = new System.Drawing.Point(130, 72);
            this.cboNhaSanXuat.Name = "cboNhaSanXuat";
            this.cboNhaSanXuat.Size = new System.Drawing.Size(150, 21);
            this.cboNhaSanXuat.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(27, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nhà sản xuất:";
            // 
            // cbxTenXe
            // 
            this.cbxTenXe.DisplayMember = "1";
            this.cbxTenXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTenXe.FormattingEnabled = true;
            this.cbxTenXe.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            ""});
            this.cbxTenXe.Location = new System.Drawing.Point(130, 45);
            this.cbxTenXe.Name = "cbxTenXe";
            this.cbxTenXe.Size = new System.Drawing.Size(150, 21);
            this.cbxTenXe.TabIndex = 7;
            this.cbxTenXe.SelectedIndexChanged += new System.EventHandler(this.cbxTenXe_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(323, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Người Lập:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(27, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tên Xe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label1.Location = new System.Drawing.Point(297, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(290, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Báo Cáo Thông Tin Xe Máy";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmReportThongTinXeMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(789, 462);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmReportThongTinXeMay";
            this.Text = "frmReportThongTinXeMay";
            this.Load += new System.EventHandler(this.frmReportThongTinXeMay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportThongTinXeMayBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerThongTinXeMay;
        private System.Windows.Forms.BindingSource ReportThongTinXeMayBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_thang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_TenXe;
        private System.Windows.Forms.Label lb_nam;
        private System.Windows.Forms.ComboBox cbx_NhaSanXuat;
        private System.Windows.Forms.Button btn_xem;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.TextBox txt_NguoiLap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNguoiLap;
        private System.Windows.Forms.Button btn_ThoatBCTTXM;
        private System.Windows.Forms.Button btn_XemBCTTXM;
        private System.Windows.Forms.ComboBox cboNhaSanXuat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxTenXe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}