namespace QL_Cua_Hang_Ban_Xe_May
{
    partial class frmTraCuuXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraCuuXe));
            this.dataGridViewTCHangHoa = new System.Windows.Forms.DataGridView();
            this.cotSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhaSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKieuDang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMauXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoKhung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoSuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTCSoSuonHH = new System.Windows.Forms.TextBox();
            this.lb_SoSuon = new System.Windows.Forms.Label();
            this.txtTCSoKhungHH = new System.Windows.Forms.TextBox();
            this.lb_Sokhung = new System.Windows.Forms.Label();
            this.cboTCMauXeHH = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboTCKieuDangHH = new System.Windows.Forms.ComboBox();
            this.cboTCNhaSXHH = new System.Windows.Forms.ComboBox();
            this.txtTCTenXeHH = new System.Windows.Forms.TextBox();
            this.txtTCMaXeHH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ThoatHH = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_TimMoiHH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTCHangHoa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTCHangHoa
            // 
            this.dataGridViewTCHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTCHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cotSTT,
            this.MaXe,
            this.TenXe,
            this.colNhaSX,
            this.colKieuDang,
            this.colMauXe,
            this.SoKhung,
            this.SoSuon});
            this.dataGridViewTCHangHoa.Location = new System.Drawing.Point(21, 156);
            this.dataGridViewTCHangHoa.Name = "dataGridViewTCHangHoa";
            this.dataGridViewTCHangHoa.ReadOnly = true;
            this.dataGridViewTCHangHoa.Size = new System.Drawing.Size(866, 284);
            this.dataGridViewTCHangHoa.TabIndex = 17;
            // 
            // cotSTT
            // 
            this.cotSTT.HeaderText = "STT";
            this.cotSTT.Name = "cotSTT";
            this.cotSTT.ReadOnly = true;
            // 
            // MaXe
            // 
            this.MaXe.DataPropertyName = "MAXE";
            this.MaXe.HeaderText = "Mã Xe";
            this.MaXe.Name = "MaXe";
            this.MaXe.ReadOnly = true;
            // 
            // TenXe
            // 
            this.TenXe.DataPropertyName = "TENXE";
            this.TenXe.HeaderText = "Tên Xe";
            this.TenXe.Name = "TenXe";
            this.TenXe.ReadOnly = true;
            this.TenXe.Width = 110;
            // 
            // colNhaSX
            // 
            this.colNhaSX.DataPropertyName = "NHASX";
            this.colNhaSX.HeaderText = "Nhà SX";
            this.colNhaSX.Name = "colNhaSX";
            this.colNhaSX.ReadOnly = true;
            this.colNhaSX.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colNhaSX.Width = 110;
            // 
            // colKieuDang
            // 
            this.colKieuDang.DataPropertyName = "KIEUDANG";
            this.colKieuDang.HeaderText = "Kiểu Dáng";
            this.colKieuDang.Name = "colKieuDang";
            this.colKieuDang.ReadOnly = true;
            this.colKieuDang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colMauXe
            // 
            this.colMauXe.DataPropertyName = "MAUXE";
            this.colMauXe.HeaderText = "Màu Xe";
            this.colMauXe.Name = "colMauXe";
            this.colMauXe.ReadOnly = true;
            this.colMauXe.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // SoKhung
            // 
            this.SoKhung.DataPropertyName = "SOKHUNG";
            this.SoKhung.HeaderText = "Số Khung";
            this.SoKhung.Name = "SoKhung";
            this.SoKhung.ReadOnly = true;
            // 
            // SoSuon
            // 
            this.SoSuon.DataPropertyName = "SOSUON";
            this.SoSuon.HeaderText = "Số Sườn";
            this.SoSuon.Name = "SoSuon";
            this.SoSuon.ReadOnly = true;
            this.SoSuon.Width = 102;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTCSoSuonHH);
            this.groupBox1.Controls.Add(this.lb_SoSuon);
            this.groupBox1.Controls.Add(this.txtTCSoKhungHH);
            this.groupBox1.Controls.Add(this.lb_Sokhung);
            this.groupBox1.Controls.Add(this.cboTCMauXeHH);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cboTCKieuDangHH);
            this.groupBox1.Controls.Add(this.cboTCNhaSXHH);
            this.groupBox1.Controls.Add(this.txtTCTenXeHH);
            this.groupBox1.Controls.Add(this.txtTCMaXeHH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(866, 127);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin xe máy";
            // 
            // txtTCSoSuonHH
            // 
            this.txtTCSoSuonHH.Location = new System.Drawing.Point(675, 63);
            this.txtTCSoSuonHH.Name = "txtTCSoSuonHH";
            this.txtTCSoSuonHH.Size = new System.Drawing.Size(168, 20);
            this.txtTCSoSuonHH.TabIndex = 7;
            this.txtTCSoSuonHH.TextChanged += new System.EventHandler(this.txtTCSoSuonHH_TextChanged);
            // 
            // lb_SoSuon
            // 
            this.lb_SoSuon.AutoSize = true;
            this.lb_SoSuon.Location = new System.Drawing.Point(594, 63);
            this.lb_SoSuon.Name = "lb_SoSuon";
            this.lb_SoSuon.Size = new System.Drawing.Size(49, 14);
            this.lb_SoSuon.TabIndex = 16;
            this.lb_SoSuon.Text = "Số sườn";
            // 
            // txtTCSoKhungHH
            // 
            this.txtTCSoKhungHH.Location = new System.Drawing.Point(675, 31);
            this.txtTCSoKhungHH.Name = "txtTCSoKhungHH";
            this.txtTCSoKhungHH.Size = new System.Drawing.Size(168, 20);
            this.txtTCSoKhungHH.TabIndex = 6;
            this.txtTCSoKhungHH.TextChanged += new System.EventHandler(this.txtTCSoKhungHH_TextChanged);
            // 
            // lb_Sokhung
            // 
            this.lb_Sokhung.AutoSize = true;
            this.lb_Sokhung.Location = new System.Drawing.Point(594, 35);
            this.lb_Sokhung.Name = "lb_Sokhung";
            this.lb_Sokhung.Size = new System.Drawing.Size(52, 14);
            this.lb_Sokhung.TabIndex = 14;
            this.lb_Sokhung.Text = "Số khung";
            // 
            // cboTCMauXeHH
            // 
            this.cboTCMauXeHH.FormattingEnabled = true;
            this.cboTCMauXeHH.Location = new System.Drawing.Point(102, 92);
            this.cboTCMauXeHH.Name = "cboTCMauXeHH";
            this.cboTCMauXeHH.Size = new System.Drawing.Size(168, 22);
            this.cboTCMauXeHH.TabIndex = 3;
            this.cboTCMauXeHH.SelectedIndexChanged += new System.EventHandler(this.cboTCMauXeHH_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 14);
            this.label8.TabIndex = 6;
            this.label8.Text = "Màu xe";
            // 
            // cboTCKieuDangHH
            // 
            this.cboTCKieuDangHH.FormattingEnabled = true;
            this.cboTCKieuDangHH.Location = new System.Drawing.Point(397, 63);
            this.cboTCKieuDangHH.Name = "cboTCKieuDangHH";
            this.cboTCKieuDangHH.Size = new System.Drawing.Size(155, 22);
            this.cboTCKieuDangHH.TabIndex = 5;
            this.cboTCKieuDangHH.SelectedIndexChanged += new System.EventHandler(this.cboTCKieuDangHH_SelectedIndexChanged);
            // 
            // cboTCNhaSXHH
            // 
            this.cboTCNhaSXHH.FormattingEnabled = true;
            this.cboTCNhaSXHH.Location = new System.Drawing.Point(397, 29);
            this.cboTCNhaSXHH.Name = "cboTCNhaSXHH";
            this.cboTCNhaSXHH.Size = new System.Drawing.Size(155, 22);
            this.cboTCNhaSXHH.TabIndex = 4;
            this.cboTCNhaSXHH.SelectedIndexChanged += new System.EventHandler(this.cboTCNhaSXHH_SelectedIndexChanged);
            // 
            // txtTCTenXeHH
            // 
            this.txtTCTenXeHH.Location = new System.Drawing.Point(102, 61);
            this.txtTCTenXeHH.Name = "txtTCTenXeHH";
            this.txtTCTenXeHH.Size = new System.Drawing.Size(168, 20);
            this.txtTCTenXeHH.TabIndex = 2;
            this.txtTCTenXeHH.TextChanged += new System.EventHandler(this.txtTCTenXeHH_TextChanged);
            // 
            // txtTCMaXeHH
            // 
            this.txtTCMaXeHH.Location = new System.Drawing.Point(102, 29);
            this.txtTCMaXeHH.Name = "txtTCMaXeHH";
            this.txtTCMaXeHH.Size = new System.Drawing.Size(168, 20);
            this.txtTCMaXeHH.TabIndex = 1;
            this.txtTCMaXeHH.TextChanged += new System.EventHandler(this.txtTCMaXeHH_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên xe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 14);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kiểu dáng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhà SX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã xe";
            // 
            // btn_ThoatHH
            // 
            this.btn_ThoatHH.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThoatHH.Image")));
            this.btn_ThoatHH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThoatHH.Location = new System.Drawing.Point(763, 19);
            this.btn_ThoatHH.Name = "btn_ThoatHH";
            this.btn_ThoatHH.Size = new System.Drawing.Size(80, 27);
            this.btn_ThoatHH.TabIndex = 9;
            this.btn_ThoatHH.Text = "Thoát";
            this.btn_ThoatHH.UseVisualStyleBackColor = false;
            this.btn_ThoatHH.Click += new System.EventHandler(this.btn_ThoatHH_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_TimMoiHH);
            this.groupBox2.Controls.Add(this.btn_ThoatHH);
            this.groupBox2.Location = new System.Drawing.Point(21, 448);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(866, 56);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tác vụ";
            // 
            // btn_TimMoiHH
            // 
            this.btn_TimMoiHH.Image = ((System.Drawing.Image)(resources.GetObject("btn_TimMoiHH.Image")));
            this.btn_TimMoiHH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimMoiHH.Location = new System.Drawing.Point(671, 19);
            this.btn_TimMoiHH.Name = "btn_TimMoiHH";
            this.btn_TimMoiHH.Size = new System.Drawing.Size(80, 27);
            this.btn_TimMoiHH.TabIndex = 8;
            this.btn_TimMoiHH.Text = "Tìm mới";
            this.btn_TimMoiHH.UseVisualStyleBackColor = false;
            this.btn_TimMoiHH.Click += new System.EventHandler(this.btn_TimMoiHH_Click);
            // 
            // frmTraCuuXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(905, 520);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridViewTCHangHoa);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTraCuuXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu thông tin xe máy";
            this.Load += new System.EventHandler(this.frmTraCuuXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTCHangHoa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTCHangHoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTCSoSuonHH;
        private System.Windows.Forms.Label lb_SoSuon;
        private System.Windows.Forms.TextBox txtTCSoKhungHH;
        private System.Windows.Forms.Label lb_Sokhung;
        private System.Windows.Forms.ComboBox cboTCMauXeHH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboTCKieuDangHH;
        private System.Windows.Forms.ComboBox cboTCNhaSXHH;
        private System.Windows.Forms.TextBox txtTCTenXeHH;
        private System.Windows.Forms.TextBox txtTCMaXeHH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ThoatHH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_TimMoiHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhaSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKieuDang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMauXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoKhung;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoSuon;


    }
}