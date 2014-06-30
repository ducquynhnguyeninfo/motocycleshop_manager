namespace QL_Cua_Hang_Ban_Xe_May
{
    partial class frmNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapHang));
            this.grbx_phieuNhap = new System.Windows.Forms.GroupBox();
            this.panel_phieuNhap = new System.Windows.Forms.Panel();
            this.btn_ThoatPNhap = new System.Windows.Forms.Button();
            this.txtMaXe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNhap = new System.Windows.Forms.TextBox();
            this.cboTenNCC = new System.Windows.Forms.ComboBox();
            this.btn_ThemNH = new System.Windows.Forms.Button();
            this.cboTenNV = new System.Windows.Forms.ComboBox();
            this.dateTimePickerNhapHang = new System.Windows.Forms.DateTimePicker();
            this.btn_NhapHang = new System.Windows.Forms.Button();
            this.lb_nhanVien = new System.Windows.Forms.Label();
            this.lb_nhaCungCap = new System.Windows.Forms.Label();
            this.lb_ngayNhap = new System.Windows.Forms.Label();
            this.lb_maHoaDon = new System.Windows.Forms.Label();
            this.dataGridViewNhapHang = new System.Windows.Forms.DataGridView();
            this.MaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotThueNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ThemCTPN = new System.Windows.Forms.Button();
            this.grbx_function = new System.Windows.Forms.GroupBox();
            this.btn_ThaoTacCTPN = new System.Windows.Forms.Button();
            this.btn_ThoatNH = new System.Windows.Forms.Button();
            this.btn_LuuNH = new System.Windows.Forms.Button();
            this.btn_XoaNH = new System.Windows.Forms.Button();
            this.btn_SuaNH = new System.Windows.Forms.Button();
            this.dataGridViewSuaCTPN = new System.Windows.Forms.DataGridView();
            this.CTMaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTMaXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTThueNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerNgaySanXuat = new System.Windows.Forms.DateTimePicker();
            this.grbx_phieuNhap.SuspendLayout();
            this.panel_phieuNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhapHang)).BeginInit();
            this.grbx_function.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuaCTPN)).BeginInit();
            this.SuspendLayout();
            // 
            // grbx_phieuNhap
            // 
            this.grbx_phieuNhap.Controls.Add(this.panel_phieuNhap);
            this.grbx_phieuNhap.Location = new System.Drawing.Point(18, 10);
            this.grbx_phieuNhap.Name = "grbx_phieuNhap";
            this.grbx_phieuNhap.Size = new System.Drawing.Size(948, 159);
            this.grbx_phieuNhap.TabIndex = 11;
            this.grbx_phieuNhap.TabStop = false;
            this.grbx_phieuNhap.Text = "Nhập Thông Tin Cho Phiếu Nhập";
            // 
            // panel_phieuNhap
            // 
            this.panel_phieuNhap.BackColor = System.Drawing.Color.Transparent;
            this.panel_phieuNhap.Controls.Add(this.dateTimePickerNgaySanXuat);
            this.panel_phieuNhap.Controls.Add(this.label2);
            this.panel_phieuNhap.Controls.Add(this.btn_ThoatPNhap);
            this.panel_phieuNhap.Controls.Add(this.txtMaXe);
            this.panel_phieuNhap.Controls.Add(this.label1);
            this.panel_phieuNhap.Controls.Add(this.txtMaNhap);
            this.panel_phieuNhap.Controls.Add(this.cboTenNCC);
            this.panel_phieuNhap.Controls.Add(this.btn_ThemNH);
            this.panel_phieuNhap.Controls.Add(this.cboTenNV);
            this.panel_phieuNhap.Controls.Add(this.dateTimePickerNhapHang);
            this.panel_phieuNhap.Controls.Add(this.btn_NhapHang);
            this.panel_phieuNhap.Controls.Add(this.lb_nhanVien);
            this.panel_phieuNhap.Controls.Add(this.lb_nhaCungCap);
            this.panel_phieuNhap.Controls.Add(this.lb_ngayNhap);
            this.panel_phieuNhap.Controls.Add(this.lb_maHoaDon);
            this.panel_phieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_phieuNhap.Location = new System.Drawing.Point(3, 16);
            this.panel_phieuNhap.Name = "panel_phieuNhap";
            this.panel_phieuNhap.Size = new System.Drawing.Size(942, 140);
            this.panel_phieuNhap.TabIndex = 0;
            // 
            // btn_ThoatPNhap
            // 
            this.btn_ThoatPNhap.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThoatPNhap.Image")));
            this.btn_ThoatPNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThoatPNhap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ThoatPNhap.Location = new System.Drawing.Point(568, 104);
            this.btn_ThoatPNhap.Name = "btn_ThoatPNhap";
            this.btn_ThoatPNhap.Size = new System.Drawing.Size(118, 25);
            this.btn_ThoatPNhap.TabIndex = 18;
            this.btn_ThoatPNhap.Text = "Thoát P_Nhập";
            this.btn_ThoatPNhap.UseVisualStyleBackColor = false;
            this.btn_ThoatPNhap.Click += new System.EventHandler(this.btn_ThoatPNhap_Click);
            // 
            // txtMaXe
            // 
            this.txtMaXe.Location = new System.Drawing.Point(167, 39);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(219, 20);
            this.txtMaXe.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(40, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã Xe";
            // 
            // txtMaNhap
            // 
            this.txtMaNhap.Location = new System.Drawing.Point(167, 14);
            this.txtMaNhap.Name = "txtMaNhap";
            this.txtMaNhap.Size = new System.Drawing.Size(219, 20);
            this.txtMaNhap.TabIndex = 0;
            // 
            // cboTenNCC
            // 
            this.cboTenNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenNCC.FormattingEnabled = true;
            this.cboTenNCC.Items.AddRange(new object[] {
            "bvhbhjb",
            "kjbkjbkjb",
            "kjbkbkj",
            "kmb kbkj"});
            this.cboTenNCC.Location = new System.Drawing.Point(680, 9);
            this.cboTenNCC.Name = "cboTenNCC";
            this.cboTenNCC.Size = new System.Drawing.Size(216, 21);
            this.cboTenNCC.TabIndex = 1;
            // 
            // btn_ThemNH
            // 
            this.btn_ThemNH.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemNH.Image")));
            this.btn_ThemNH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThemNH.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ThemNH.Location = new System.Drawing.Point(310, 104);
            this.btn_ThemNH.Margin = new System.Windows.Forms.Padding(23, 0, 0, 12);
            this.btn_ThemNH.Name = "btn_ThemNH";
            this.btn_ThemNH.Size = new System.Drawing.Size(118, 25);
            this.btn_ThemNH.TabIndex = 16;
            this.btn_ThemNH.Text = "Thêm P_Nhập";
            this.btn_ThemNH.UseVisualStyleBackColor = false;
            this.btn_ThemNH.Click += new System.EventHandler(this.btn_ThemNH_Click);
            // 
            // cboTenNV
            // 
            this.cboTenNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenNV.FormattingEnabled = true;
            this.cboTenNV.Items.AddRange(new object[] {
            "bvhbhjb",
            "kjbkjbkjb",
            "kjbkbkj",
            "kmb kbkj"});
            this.cboTenNV.Location = new System.Drawing.Point(680, 36);
            this.cboTenNV.Name = "cboTenNV";
            this.cboTenNV.Size = new System.Drawing.Size(216, 21);
            this.cboTenNV.TabIndex = 3;
            // 
            // dateTimePickerNhapHang
            // 
            this.dateTimePickerNhapHang.Location = new System.Drawing.Point(167, 65);
            this.dateTimePickerNhapHang.Name = "dateTimePickerNhapHang";
            this.dateTimePickerNhapHang.Size = new System.Drawing.Size(219, 20);
            this.dateTimePickerNhapHang.TabIndex = 2;
            // 
            // btn_NhapHang
            // 
            this.btn_NhapHang.Image = ((System.Drawing.Image)(resources.GetObject("btn_NhapHang.Image")));
            this.btn_NhapHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NhapHang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_NhapHang.Location = new System.Drawing.Point(439, 104);
            this.btn_NhapHang.Name = "btn_NhapHang";
            this.btn_NhapHang.Size = new System.Drawing.Size(118, 25);
            this.btn_NhapHang.TabIndex = 4;
            this.btn_NhapHang.Text = "Lưu P_Nhập";
            this.btn_NhapHang.UseVisualStyleBackColor = false;
            this.btn_NhapHang.Click += new System.EventHandler(this.btn_NhapHang_Click);
            // 
            // lb_nhanVien
            // 
            this.lb_nhanVien.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lb_nhanVien.Location = new System.Drawing.Point(538, 42);
            this.lb_nhanVien.Name = "lb_nhanVien";
            this.lb_nhanVien.Size = new System.Drawing.Size(100, 18);
            this.lb_nhanVien.TabIndex = 15;
            this.lb_nhanVien.Text = "Tên Nhân Viên";
            // 
            // lb_nhaCungCap
            // 
            this.lb_nhaCungCap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lb_nhaCungCap.Location = new System.Drawing.Point(538, 15);
            this.lb_nhaCungCap.Name = "lb_nhaCungCap";
            this.lb_nhaCungCap.Size = new System.Drawing.Size(102, 19);
            this.lb_nhaCungCap.TabIndex = 13;
            this.lb_nhaCungCap.Text = "Tên Nhà Cung Cấp";
            // 
            // lb_ngayNhap
            // 
            this.lb_ngayNhap.AutoSize = true;
            this.lb_ngayNhap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lb_ngayNhap.Location = new System.Drawing.Point(40, 67);
            this.lb_ngayNhap.Name = "lb_ngayNhap";
            this.lb_ngayNhap.Size = new System.Drawing.Size(61, 13);
            this.lb_ngayNhap.TabIndex = 11;
            this.lb_ngayNhap.Text = "Ngày Nhập";
            // 
            // lb_maHoaDon
            // 
            this.lb_maHoaDon.AutoSize = true;
            this.lb_maHoaDon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lb_maHoaDon.Location = new System.Drawing.Point(40, 17);
            this.lb_maHoaDon.Name = "lb_maHoaDon";
            this.lb_maHoaDon.Size = new System.Drawing.Size(81, 13);
            this.lb_maHoaDon.TabIndex = 9;
            this.lb_maHoaDon.Text = "Mã Phiếu Nhập";
            // 
            // dataGridViewNhapHang
            // 
            this.dataGridViewNhapHang.AllowUserToAddRows = false;
            this.dataGridViewNhapHang.AllowUserToDeleteRows = false;
            this.dataGridViewNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhap,
            this.MaXe,
            this.NgayNhap,
            this.colTenNV,
            this.colTenNCC,
            this.cotSoLuong,
            this.cotGiaNhap,
            this.cotThueNhap});
            this.dataGridViewNhapHang.Location = new System.Drawing.Point(18, 178);
            this.dataGridViewNhapHang.Name = "dataGridViewNhapHang";
            this.dataGridViewNhapHang.Size = new System.Drawing.Size(948, 232);
            this.dataGridViewNhapHang.TabIndex = 12;
            this.dataGridViewNhapHang.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNhapHang_RowEnter);
            // 
            // MaNhap
            // 
            this.MaNhap.DataPropertyName = "MANHAP";
            this.MaNhap.HeaderText = "Mã CT Phiếu Nhập";
            this.MaNhap.Name = "MaNhap";
            this.MaNhap.ReadOnly = true;
            // 
            // MaXe
            // 
            this.MaXe.DataPropertyName = "MAXE";
            this.MaXe.HeaderText = "Mã Xe";
            this.MaXe.Name = "MaXe";
            this.MaXe.ReadOnly = true;
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NGAYNHAP";
            this.NgayNhap.HeaderText = "Ngày Nhập";
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.ReadOnly = true;
            // 
            // colTenNV
            // 
            this.colTenNV.DataPropertyName = "TENNV";
            this.colTenNV.HeaderText = "Nhân Viên";
            this.colTenNV.Name = "colTenNV";
            this.colTenNV.ReadOnly = true;
            this.colTenNV.Width = 200;
            // 
            // colTenNCC
            // 
            this.colTenNCC.DataPropertyName = "TENHCC";
            this.colTenNCC.HeaderText = "Nhà Cung Cấp";
            this.colTenNCC.Name = "colTenNCC";
            this.colTenNCC.ReadOnly = true;
            // 
            // cotSoLuong
            // 
            this.cotSoLuong.HeaderText = "Số Lượng";
            this.cotSoLuong.Name = "cotSoLuong";
            // 
            // cotGiaNhap
            // 
            this.cotGiaNhap.HeaderText = "Giá Nhập";
            this.cotGiaNhap.Name = "cotGiaNhap";
            // 
            // cotThueNhap
            // 
            this.cotThueNhap.HeaderText = "Thuế Nhập";
            this.cotThueNhap.Name = "cotThueNhap";
            // 
            // btn_ThemCTPN
            // 
            this.btn_ThemCTPN.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemCTPN.Image")));
            this.btn_ThemCTPN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThemCTPN.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ThemCTPN.Location = new System.Drawing.Point(466, 20);
            this.btn_ThemCTPN.Name = "btn_ThemCTPN";
            this.btn_ThemCTPN.Size = new System.Drawing.Size(80, 25);
            this.btn_ThemCTPN.TabIndex = 23;
            this.btn_ThemCTPN.Text = "Nhập";
            this.btn_ThemCTPN.UseVisualStyleBackColor = false;
            this.btn_ThemCTPN.Click += new System.EventHandler(this.btn_ThemCTPN_Click);
            // 
            // grbx_function
            // 
            this.grbx_function.Controls.Add(this.btn_ThaoTacCTPN);
            this.grbx_function.Controls.Add(this.btn_ThemCTPN);
            this.grbx_function.Controls.Add(this.btn_ThoatNH);
            this.grbx_function.Controls.Add(this.btn_LuuNH);
            this.grbx_function.Controls.Add(this.btn_XoaNH);
            this.grbx_function.Controls.Add(this.btn_SuaNH);
            this.grbx_function.Location = new System.Drawing.Point(18, 420);
            this.grbx_function.Name = "grbx_function";
            this.grbx_function.Size = new System.Drawing.Size(948, 59);
            this.grbx_function.TabIndex = 13;
            this.grbx_function.TabStop = false;
            this.grbx_function.Text = "Nhập Thông Tin Cho Chi Tiết Phiếu Nhập";
            // 
            // btn_ThaoTacCTPN
            // 
            this.btn_ThaoTacCTPN.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThaoTacCTPN.Image")));
            this.btn_ThaoTacCTPN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThaoTacCTPN.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ThaoTacCTPN.Location = new System.Drawing.Point(187, 20);
            this.btn_ThaoTacCTPN.Name = "btn_ThaoTacCTPN";
            this.btn_ThaoTacCTPN.Size = new System.Drawing.Size(261, 25);
            this.btn_ThaoTacCTPN.TabIndex = 24;
            this.btn_ThaoTacCTPN.Text = "Thao Tác Trên Bảng CT Phiếu Nhập";
            this.btn_ThaoTacCTPN.UseVisualStyleBackColor = false;
            this.btn_ThaoTacCTPN.Click += new System.EventHandler(this.btn_ThaoTacCTPN_Click);
            // 
            // btn_ThoatNH
            // 
            this.btn_ThoatNH.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThoatNH.Image")));
            this.btn_ThoatNH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThoatNH.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ThoatNH.Location = new System.Drawing.Point(845, 20);
            this.btn_ThoatNH.Name = "btn_ThoatNH";
            this.btn_ThoatNH.Size = new System.Drawing.Size(80, 25);
            this.btn_ThoatNH.TabIndex = 22;
            this.btn_ThoatNH.Text = "Thoát";
            this.btn_ThoatNH.UseVisualStyleBackColor = false;
            this.btn_ThoatNH.Click += new System.EventHandler(this.btn_ThoatNH_Click);
            // 
            // btn_LuuNH
            // 
            this.btn_LuuNH.Image = ((System.Drawing.Image)(resources.GetObject("btn_LuuNH.Image")));
            this.btn_LuuNH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LuuNH.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_LuuNH.Location = new System.Drawing.Point(750, 20);
            this.btn_LuuNH.Name = "btn_LuuNH";
            this.btn_LuuNH.Size = new System.Drawing.Size(80, 25);
            this.btn_LuuNH.TabIndex = 19;
            this.btn_LuuNH.Text = "Lưu";
            this.btn_LuuNH.UseVisualStyleBackColor = false;
            this.btn_LuuNH.Click += new System.EventHandler(this.btn_LuuNH_Click);
            // 
            // btn_XoaNH
            // 
            this.btn_XoaNH.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaNH.Image")));
            this.btn_XoaNH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaNH.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_XoaNH.Location = new System.Drawing.Point(656, 20);
            this.btn_XoaNH.Name = "btn_XoaNH";
            this.btn_XoaNH.Size = new System.Drawing.Size(80, 25);
            this.btn_XoaNH.TabIndex = 18;
            this.btn_XoaNH.Text = "Tìm Xóa";
            this.btn_XoaNH.UseVisualStyleBackColor = false;
            this.btn_XoaNH.Click += new System.EventHandler(this.btn_XoaNH_Click);
            // 
            // btn_SuaNH
            // 
            this.btn_SuaNH.Image = ((System.Drawing.Image)(resources.GetObject("btn_SuaNH.Image")));
            this.btn_SuaNH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SuaNH.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_SuaNH.Location = new System.Drawing.Point(561, 20);
            this.btn_SuaNH.Name = "btn_SuaNH";
            this.btn_SuaNH.Size = new System.Drawing.Size(80, 25);
            this.btn_SuaNH.TabIndex = 17;
            this.btn_SuaNH.Text = "Tìm Sửa";
            this.btn_SuaNH.UseVisualStyleBackColor = false;
            this.btn_SuaNH.Click += new System.EventHandler(this.btn_SuaNH_Click);
            // 
            // dataGridViewSuaCTPN
            // 
            this.dataGridViewSuaCTPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSuaCTPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CTMaNhap,
            this.CTMaXe,
            this.CTSoLuong,
            this.CTGiaNhap,
            this.CTThueNhap});
            this.dataGridViewSuaCTPN.Location = new System.Drawing.Point(18, 178);
            this.dataGridViewSuaCTPN.Name = "dataGridViewSuaCTPN";
            this.dataGridViewSuaCTPN.Size = new System.Drawing.Size(948, 232);
            this.dataGridViewSuaCTPN.TabIndex = 20;
            this.dataGridViewSuaCTPN.Visible = false;
            this.dataGridViewSuaCTPN.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSuaCTPN_RowEnter);
            // 
            // CTMaNhap
            // 
            this.CTMaNhap.DataPropertyName = "MANHAP";
            this.CTMaNhap.HeaderText = "Mã Nhập";
            this.CTMaNhap.Name = "CTMaNhap";
            this.CTMaNhap.ReadOnly = true;
            // 
            // CTMaXe
            // 
            this.CTMaXe.DataPropertyName = "MAXE";
            this.CTMaXe.HeaderText = "Mã Xe";
            this.CTMaXe.Name = "CTMaXe";
            this.CTMaXe.ReadOnly = true;
            // 
            // CTSoLuong
            // 
            this.CTSoLuong.DataPropertyName = "SLNHAP";
            this.CTSoLuong.HeaderText = "Số Lượng Nhập";
            this.CTSoLuong.Name = "CTSoLuong";
            // 
            // CTGiaNhap
            // 
            this.CTGiaNhap.DataPropertyName = "GIANHAP";
            this.CTGiaNhap.HeaderText = "Giá Nhập";
            this.CTGiaNhap.Name = "CTGiaNhap";
            // 
            // CTThueNhap
            // 
            this.CTThueNhap.DataPropertyName = "THUENHAP";
            this.CTThueNhap.HeaderText = "Thuế Nhập";
            this.CTThueNhap.Name = "CTThueNhap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(538, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ngày sản xuất";
            // 
            // dateTimePickerNgaySanXuat
            // 
            this.dateTimePickerNgaySanXuat.Location = new System.Drawing.Point(680, 63);
            this.dateTimePickerNgaySanXuat.Name = "dateTimePickerNgaySanXuat";
            this.dateTimePickerNgaySanXuat.Size = new System.Drawing.Size(216, 20);
            this.dateTimePickerNgaySanXuat.TabIndex = 20;
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(984, 491);
            this.Controls.Add(this.dataGridViewSuaCTPN);
            this.Controls.Add(this.grbx_phieuNhap);
            this.Controls.Add(this.dataGridViewNhapHang);
            this.Controls.Add(this.grbx_function);
            this.Name = "frmNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nghiệp vụ nhập hàng";
            this.Load += new System.EventHandler(this.frmNhapHang_Load);
            this.grbx_phieuNhap.ResumeLayout(false);
            this.panel_phieuNhap.ResumeLayout(false);
            this.panel_phieuNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhapHang)).EndInit();
            this.grbx_function.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuaCTPN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_phieuNhap;
        private System.Windows.Forms.Panel panel_phieuNhap;
        private System.Windows.Forms.Button btn_ThoatPNhap;
        private System.Windows.Forms.TextBox txtMaXe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNhap;
        private System.Windows.Forms.ComboBox cboTenNCC;
        private System.Windows.Forms.Button btn_ThemNH;
        private System.Windows.Forms.ComboBox cboTenNV;
        private System.Windows.Forms.DateTimePicker dateTimePickerNhapHang;
        private System.Windows.Forms.Button btn_NhapHang;
        private System.Windows.Forms.Label lb_nhanVien;
        private System.Windows.Forms.Label lb_nhaCungCap;
        private System.Windows.Forms.Label lb_ngayNhap;
        private System.Windows.Forms.Label lb_maHoaDon;
        private System.Windows.Forms.DataGridView dataGridViewNhapHang;
        private System.Windows.Forms.Button btn_ThemCTPN;
        private System.Windows.Forms.GroupBox grbx_function;
        private System.Windows.Forms.Button btn_ThaoTacCTPN;
        private System.Windows.Forms.Button btn_ThoatNH;
        private System.Windows.Forms.Button btn_LuuNH;
        private System.Windows.Forms.Button btn_XoaNH;
        private System.Windows.Forms.Button btn_SuaNH;
        private System.Windows.Forms.DataGridView dataGridViewSuaCTPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTMaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTMaXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTThueNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotThueNhap;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaySanXuat;
        private System.Windows.Forms.Label label2;
    }
}