namespace QL_Cua_Hang_Ban_Xe_May
{
    partial class frmTraCuuNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraCuuNhanVien));
            this.lblLuong2 = new System.Windows.Forms.Label();
            this.dataGridViewNV = new System.Windows.Forms.DataGridView();
            this.dgcSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcLuongCoBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcNgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLuong1 = new System.Windows.Forms.TextBox();
            this.lblLuong = new System.Windows.Forms.Label();
            this.txtLuong2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lbl_MaNV = new System.Windows.Forms.Label();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLuong2
            // 
            this.lblLuong2.AutoSize = true;
            this.lblLuong2.Location = new System.Drawing.Point(224, 119);
            this.lblLuong2.Name = "lblLuong2";
            this.lblLuong2.Size = new System.Drawing.Size(25, 14);
            this.lblLuong2.TabIndex = 45;
            this.lblLuong2.Text = "đến";
            // 
            // dataGridViewNV
            // 
            this.dataGridViewNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcSTT,
            this.dgcMaNV,
            this.dgcTenNV,
            this.dgcGioiTinh,
            this.dgcDiaChi,
            this.dgcLuongCoBan,
            this.dgcChucVu,
            this.dgcNgayBatDau});
            this.dataGridViewNV.Location = new System.Drawing.Point(20, 188);
            this.dataGridViewNV.Name = "dataGridViewNV";
            this.dataGridViewNV.ReadOnly = true;
            this.dataGridViewNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNV.Size = new System.Drawing.Size(817, 241);
            this.dataGridViewNV.TabIndex = 31;
            this.dataGridViewNV.TabStop = false;
            // 
            // dgcSTT
            // 
            this.dgcSTT.HeaderText = "STT";
            this.dgcSTT.MaxInputLength = 3;
            this.dgcSTT.Name = "dgcSTT";
            this.dgcSTT.ReadOnly = true;
            this.dgcSTT.Width = 50;
            // 
            // dgcMaNV
            // 
            this.dgcMaNV.DataPropertyName = "MANV";
            this.dgcMaNV.HeaderText = "Mã NV";
            this.dgcMaNV.Name = "dgcMaNV";
            this.dgcMaNV.ReadOnly = true;
            this.dgcMaNV.Width = 80;
            // 
            // dgcTenNV
            // 
            this.dgcTenNV.DataPropertyName = "TenNV";
            this.dgcTenNV.HeaderText = "Tên NV";
            this.dgcTenNV.Name = "dgcTenNV";
            this.dgcTenNV.ReadOnly = true;
            this.dgcTenNV.Width = 120;
            // 
            // dgcGioiTinh
            // 
            this.dgcGioiTinh.DataPropertyName = "GioiTinh";
            this.dgcGioiTinh.HeaderText = "Giới Tính";
            this.dgcGioiTinh.Name = "dgcGioiTinh";
            this.dgcGioiTinh.ReadOnly = true;
            this.dgcGioiTinh.Width = 80;
            // 
            // dgcDiaChi
            // 
            this.dgcDiaChi.DataPropertyName = "DiaChi";
            this.dgcDiaChi.HeaderText = "Địa Chỉ";
            this.dgcDiaChi.Name = "dgcDiaChi";
            this.dgcDiaChi.ReadOnly = true;
            this.dgcDiaChi.Width = 132;
            // 
            // dgcLuongCoBan
            // 
            this.dgcLuongCoBan.DataPropertyName = "LCB";
            this.dgcLuongCoBan.HeaderText = "Lương";
            this.dgcLuongCoBan.Name = "dgcLuongCoBan";
            this.dgcLuongCoBan.ReadOnly = true;
            // 
            // dgcChucVu
            // 
            this.dgcChucVu.DataPropertyName = "TEN_CV";
            this.dgcChucVu.HeaderText = "Chức Vụ";
            this.dgcChucVu.Name = "dgcChucVu";
            this.dgcChucVu.ReadOnly = true;
            // 
            // dgcNgayBatDau
            // 
            this.dgcNgayBatDau.DataPropertyName = "NgVaoLam";
            this.dgcNgayBatDau.HeaderText = "Ngày vào làm";
            this.dgcNgayBatDau.Name = "dgcNgayBatDau";
            this.dgcNgayBatDau.ReadOnly = true;
            this.dgcNgayBatDau.Width = 112;
            // 
            // txtLuong1
            // 
            this.txtLuong1.Location = new System.Drawing.Point(131, 114);
            this.txtLuong1.Name = "txtLuong1";
            this.txtLuong1.Size = new System.Drawing.Size(89, 20);
            this.txtLuong1.TabIndex = 3;
            this.txtLuong1.TextChanged += new System.EventHandler(this.txtLuong1_TextChanged);
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Location = new System.Drawing.Point(35, 117);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(52, 14);
            this.lblLuong.TabIndex = 43;
            this.lblLuong.Text = "Lương từ";
            // 
            // txtLuong2
            // 
            this.txtLuong2.Location = new System.Drawing.Point(257, 114);
            this.txtLuong2.Name = "txtLuong2";
            this.txtLuong2.Size = new System.Drawing.Size(124, 20);
            this.txtLuong2.TabIndex = 4;
            this.txtLuong2.TextChanged += new System.EventHandler(this.txtLuong2_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTimMoi);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Location = new System.Drawing.Point(20, 437);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(817, 52);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tác vụ";
            // 
            // btnTimMoi
            // 
            this.btnTimMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnTimMoi.Image")));
            this.btnTimMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimMoi.Location = new System.Drawing.Point(620, 18);
            this.btnTimMoi.Name = "btnTimMoi";
            this.btnTimMoi.Size = new System.Drawing.Size(80, 25);
            this.btnTimMoi.TabIndex = 8;
            this.btnTimMoi.Text = "Tìm mới";
            this.btnTimMoi.UseVisualStyleBackColor = false;
            this.btnTimMoi.Click += new System.EventHandler(this.btnTimMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(714, 18);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 25);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLuong2);
            this.groupBox1.Controls.Add(this.txtLuong1);
            this.groupBox1.Controls.Add(this.lblLuong);
            this.groupBox1.Controls.Add(this.txtLuong2);
            this.groupBox1.Controls.Add(this.cboGioiTinh);
            this.groupBox1.Controls.Add(this.lblChucVu);
            this.groupBox1.Controls.Add(this.lblDiachi);
            this.groupBox1.Controls.Add(this.lblGioiTinh);
            this.groupBox1.Controls.Add(this.lblTenNV);
            this.groupBox1.Controls.Add(this.lbl_MaNV);
            this.groupBox1.Controls.Add(this.cboChucVu);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Location = new System.Drawing.Point(20, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(817, 162);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Location = new System.Drawing.Point(560, 33);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(140, 23);
            this.cboGioiTinh.TabIndex = 5;
            this.cboGioiTinh.SelectedIndexChanged += new System.EventHandler(this.cboGioiTinh_SelectedIndexChanged);
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Location = new System.Drawing.Point(470, 117);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(48, 14);
            this.lblChucVu.TabIndex = 40;
            this.lblChucVu.Text = "Chức vụ";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Location = new System.Drawing.Point(470, 76);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(40, 14);
            this.lblDiachi.TabIndex = 39;
            this.lblDiachi.Text = "Địa chỉ";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(470, 39);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(46, 14);
            this.lblGioiTinh.TabIndex = 38;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(35, 76);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(43, 14);
            this.lblTenNV.TabIndex = 36;
            this.lblTenNV.Text = "Tên NV";
            // 
            // lbl_MaNV
            // 
            this.lbl_MaNV.AutoSize = true;
            this.lbl_MaNV.Location = new System.Drawing.Point(35, 36);
            this.lbl_MaNV.Name = "lbl_MaNV";
            this.lbl_MaNV.Size = new System.Drawing.Size(39, 14);
            this.lbl_MaNV.TabIndex = 35;
            this.lbl_MaNV.Text = "Mã NV";
            // 
            // cboChucVu
            // 
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Location = new System.Drawing.Point(560, 115);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(233, 22);
            this.cboChucVu.TabIndex = 7;
            this.cboChucVu.SelectedIndexChanged += new System.EventHandler(this.cboChucVu_SelectedIndexChanged);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(560, 76);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(233, 20);
            this.txtDiaChi.TabIndex = 6;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(131, 73);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(250, 20);
            this.txtTenNV.TabIndex = 2;
            this.txtTenNV.TextChanged += new System.EventHandler(this.txtTenNV_TextChanged);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(131, 33);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(130, 20);
            this.txtMaNV.TabIndex = 1;
            this.txtMaNV.TextChanged += new System.EventHandler(this.txtMaNV_TextChanged);
            // 
            // frmTraCuuNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(856, 507);
            this.Controls.Add(this.dataGridViewNV);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTraCuuNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu nhân viên";
            this.Load += new System.EventHandler(this.frmTraCuuNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLuong2;
        private System.Windows.Forms.DataGridView dataGridViewNV;
        private System.Windows.Forms.TextBox txtLuong1;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.TextBox txtLuong2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimMoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lbl_MaNV;
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLuongCoBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcNgayBatDau;

    }
}