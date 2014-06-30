namespace QL_Cua_Hang_Ban_Xe_May
{
    partial class frmXuatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXuatHang));
            this.grbx_phieuNhap = new System.Windows.Forms.GroupBox();
            this.panel_phieuNhap = new System.Windows.Forms.Panel();
            this.btn_ThoatPXuat = new System.Windows.Forms.Button();
            this.txtMaXe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaXuat = new System.Windows.Forms.TextBox();
            this.cboTenKH = new System.Windows.Forms.ComboBox();
            this.btn_ThemPXuat = new System.Windows.Forms.Button();
            this.cboTenNV = new System.Windows.Forms.ComboBox();
            this.dateTimePickerXuatHang = new System.Windows.Forms.DateTimePicker();
            this.btn_LuuPXuat = new System.Windows.Forms.Button();
            this.lb_nhanVien = new System.Windows.Forms.Label();
            this.lb_nhaCungCap = new System.Windows.Forms.Label();
            this.lb_ngayNhap = new System.Windows.Forms.Label();
            this.lb_maHoaDon = new System.Windows.Forms.Label();
            this.dataGridViewXuatHang = new System.Windows.Forms.DataGridView();
            this.MaXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotGiaXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotThueXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbx_function = new System.Windows.Forms.GroupBox();
            this.btn_ThaoTacCTPX = new System.Windows.Forms.Button();
            this.btn_NhapCTPX = new System.Windows.Forms.Button();
            this.btn_ThoatCTPX = new System.Windows.Forms.Button();
            this.btn_LuuCTPX = new System.Windows.Forms.Button();
            this.btn_XoaCTPX = new System.Windows.Forms.Button();
            this.btn_SuaCTPX = new System.Windows.Forms.Button();
            this.dataGridViewSuaCTPX = new System.Windows.Forms.DataGridView();
            this.CTMaXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTMaXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTGiaXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTThueXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbx_phieuNhap.SuspendLayout();
            this.panel_phieuNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXuatHang)).BeginInit();
            this.grbx_function.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuaCTPX)).BeginInit();
            this.SuspendLayout();
            // 
            // grbx_phieuNhap
            // 
            this.grbx_phieuNhap.Controls.Add(this.panel_phieuNhap);
            this.grbx_phieuNhap.Location = new System.Drawing.Point(18, 12);
            this.grbx_phieuNhap.Name = "grbx_phieuNhap";
            this.grbx_phieuNhap.Size = new System.Drawing.Size(948, 159);
            this.grbx_phieuNhap.TabIndex = 21;
            this.grbx_phieuNhap.TabStop = false;
            this.grbx_phieuNhap.Text = "Nhập Thông Tin Cho Phiếu Xuất";
            // 
            // panel_phieuNhap
            // 
            this.panel_phieuNhap.BackColor = System.Drawing.Color.Transparent;
            this.panel_phieuNhap.Controls.Add(this.btn_ThoatPXuat);
            this.panel_phieuNhap.Controls.Add(this.txtMaXe);
            this.panel_phieuNhap.Controls.Add(this.label1);
            this.panel_phieuNhap.Controls.Add(this.txtMaXuat);
            this.panel_phieuNhap.Controls.Add(this.cboTenKH);
            this.panel_phieuNhap.Controls.Add(this.btn_ThemPXuat);
            this.panel_phieuNhap.Controls.Add(this.cboTenNV);
            this.panel_phieuNhap.Controls.Add(this.dateTimePickerXuatHang);
            this.panel_phieuNhap.Controls.Add(this.btn_LuuPXuat);
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
            // btn_ThoatPXuat
            // 
            this.btn_ThoatPXuat.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThoatPXuat.Image")));
            this.btn_ThoatPXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThoatPXuat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ThoatPXuat.Location = new System.Drawing.Point(569, 104);
            this.btn_ThoatPXuat.Name = "btn_ThoatPXuat";
            this.btn_ThoatPXuat.Size = new System.Drawing.Size(118, 25);
            this.btn_ThoatPXuat.TabIndex = 7;
            this.btn_ThoatPXuat.Text = "Thoát P_Xuất";
            this.btn_ThoatPXuat.UseVisualStyleBackColor = false;
            this.btn_ThoatPXuat.Click += new System.EventHandler(this.btn_ThoatPXuat_Click);
            // 
            // txtMaXe
            // 
            this.txtMaXe.Location = new System.Drawing.Point(165, 39);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(200, 20);
            this.txtMaXe.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(64, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã Xe";
            // 
            // txtMaXuat
            // 
            this.txtMaXuat.Location = new System.Drawing.Point(165, 14);
            this.txtMaXuat.Name = "txtMaXuat";
            this.txtMaXuat.Size = new System.Drawing.Size(200, 20);
            this.txtMaXuat.TabIndex = 0;
            // 
            // cboTenKH
            // 
            this.cboTenKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenKH.FormattingEnabled = true;
            this.cboTenKH.Items.AddRange(new object[] {
            "bvhbhjb",
            "kjbkjbkjb",
            "kjbkbkj",
            "kmb kbkj"});
            this.cboTenKH.Location = new System.Drawing.Point(656, 12);
            this.cboTenKH.Name = "cboTenKH";
            this.cboTenKH.Size = new System.Drawing.Size(200, 21);
            this.cboTenKH.TabIndex = 3;
            // 
            // btn_ThemPXuat
            // 
            this.btn_ThemPXuat.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemPXuat.Image")));
            this.btn_ThemPXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThemPXuat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ThemPXuat.Location = new System.Drawing.Point(309, 104);
            this.btn_ThemPXuat.Margin = new System.Windows.Forms.Padding(23, 0, 0, 12);
            this.btn_ThemPXuat.Name = "btn_ThemPXuat";
            this.btn_ThemPXuat.Size = new System.Drawing.Size(118, 25);
            this.btn_ThemPXuat.TabIndex = 5;
            this.btn_ThemPXuat.Text = "Thêm P_Xuất";
            this.btn_ThemPXuat.UseVisualStyleBackColor = false;
            this.btn_ThemPXuat.Click += new System.EventHandler(this.btn_ThemPXuat_Click);
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
            this.cboTenNV.Location = new System.Drawing.Point(656, 39);
            this.cboTenNV.Name = "cboTenNV";
            this.cboTenNV.Size = new System.Drawing.Size(200, 21);
            this.cboTenNV.TabIndex = 4;
            // 
            // dateTimePickerXuatHang
            // 
            this.dateTimePickerXuatHang.Location = new System.Drawing.Point(165, 65);
            this.dateTimePickerXuatHang.Name = "dateTimePickerXuatHang";
            this.dateTimePickerXuatHang.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerXuatHang.TabIndex = 2;
            // 
            // btn_LuuPXuat
            // 
            this.btn_LuuPXuat.Image = ((System.Drawing.Image)(resources.GetObject("btn_LuuPXuat.Image")));
            this.btn_LuuPXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LuuPXuat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_LuuPXuat.Location = new System.Drawing.Point(439, 104);
            this.btn_LuuPXuat.Name = "btn_LuuPXuat";
            this.btn_LuuPXuat.Size = new System.Drawing.Size(118, 25);
            this.btn_LuuPXuat.TabIndex = 6;
            this.btn_LuuPXuat.Text = "Lưu P_Xuất";
            this.btn_LuuPXuat.UseVisualStyleBackColor = false;
            this.btn_LuuPXuat.Click += new System.EventHandler(this.btn_LuuPXuat_Click);
            // 
            // lb_nhanVien
            // 
            this.lb_nhanVien.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lb_nhanVien.Location = new System.Drawing.Point(539, 42);
            this.lb_nhanVien.Name = "lb_nhanVien";
            this.lb_nhanVien.Size = new System.Drawing.Size(102, 18);
            this.lb_nhanVien.TabIndex = 15;
            this.lb_nhanVien.Text = "Tên Nhân Viên";
            // 
            // lb_nhaCungCap
            // 
            this.lb_nhaCungCap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lb_nhaCungCap.Location = new System.Drawing.Point(539, 15);
            this.lb_nhaCungCap.Name = "lb_nhaCungCap";
            this.lb_nhaCungCap.Size = new System.Drawing.Size(102, 19);
            this.lb_nhaCungCap.TabIndex = 13;
            this.lb_nhaCungCap.Text = "Tên Khách Hàng";
            // 
            // lb_ngayNhap
            // 
            this.lb_ngayNhap.AutoSize = true;
            this.lb_ngayNhap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lb_ngayNhap.Location = new System.Drawing.Point(64, 67);
            this.lb_ngayNhap.Name = "lb_ngayNhap";
            this.lb_ngayNhap.Size = new System.Drawing.Size(57, 13);
            this.lb_ngayNhap.TabIndex = 11;
            this.lb_ngayNhap.Text = "Ngày Xuất";
            // 
            // lb_maHoaDon
            // 
            this.lb_maHoaDon.AutoSize = true;
            this.lb_maHoaDon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lb_maHoaDon.Location = new System.Drawing.Point(64, 17);
            this.lb_maHoaDon.Name = "lb_maHoaDon";
            this.lb_maHoaDon.Size = new System.Drawing.Size(77, 13);
            this.lb_maHoaDon.TabIndex = 9;
            this.lb_maHoaDon.Text = "Mã Phiếu Xuất";
            // 
            // dataGridViewXuatHang
            // 
            this.dataGridViewXuatHang.AllowUserToAddRows = false;
            this.dataGridViewXuatHang.AllowUserToDeleteRows = false;
            this.dataGridViewXuatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXuatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaXuat,
            this.MaXe,
            this.NgayXuat,
            this.colTenNV,
            this.colTenKH,
            this.cotSoLuong,
            this.cotGiaXuat,
            this.cotThueXuat});
            this.dataGridViewXuatHang.Location = new System.Drawing.Point(18, 180);
            this.dataGridViewXuatHang.Name = "dataGridViewXuatHang";
            this.dataGridViewXuatHang.Size = new System.Drawing.Size(948, 232);
            this.dataGridViewXuatHang.TabIndex = 22;
            this.dataGridViewXuatHang.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewXuatHang_RowEnter);
            // 
            // MaXuat
            // 
            this.MaXuat.DataPropertyName = "MAXUAT";
            this.MaXuat.Frozen = true;
            this.MaXuat.HeaderText = "Mã CT Phiếu Xuất";
            this.MaXuat.Name = "MaXuat";
            this.MaXuat.ReadOnly = true;
            // 
            // MaXe
            // 
            this.MaXe.DataPropertyName = "MAXE";
            this.MaXe.Frozen = true;
            this.MaXe.HeaderText = "Mã Xe";
            this.MaXe.Name = "MaXe";
            this.MaXe.ReadOnly = true;
            // 
            // NgayXuat
            // 
            this.NgayXuat.DataPropertyName = "NGAYXUAT";
            this.NgayXuat.HeaderText = "Ngày Xuất";
            this.NgayXuat.Name = "NgayXuat";
            this.NgayXuat.ReadOnly = true;
            // 
            // colTenNV
            // 
            this.colTenNV.DataPropertyName = "TENNV";
            this.colTenNV.HeaderText = "Nhân Viên";
            this.colTenNV.Name = "colTenNV";
            this.colTenNV.ReadOnly = true;
            this.colTenNV.Width = 150;
            // 
            // colTenKH
            // 
            this.colTenKH.DataPropertyName = "TENKH";
            this.colTenKH.HeaderText = "Khách Hàng";
            this.colTenKH.Name = "colTenKH";
            this.colTenKH.ReadOnly = true;
            this.colTenKH.Width = 150;
            // 
            // cotSoLuong
            // 
            this.cotSoLuong.HeaderText = "Số Lượng";
            this.cotSoLuong.Name = "cotSoLuong";
            // 
            // cotGiaXuat
            // 
            this.cotGiaXuat.HeaderText = "Giá Xuất";
            this.cotGiaXuat.Name = "cotGiaXuat";
            // 
            // cotThueXuat
            // 
            this.cotThueXuat.HeaderText = "Thuế Xuất";
            this.cotThueXuat.Name = "cotThueXuat";
            // 
            // grbx_function
            // 
            this.grbx_function.Controls.Add(this.btn_ThaoTacCTPX);
            this.grbx_function.Controls.Add(this.btn_NhapCTPX);
            this.grbx_function.Controls.Add(this.btn_ThoatCTPX);
            this.grbx_function.Controls.Add(this.btn_LuuCTPX);
            this.grbx_function.Controls.Add(this.btn_XoaCTPX);
            this.grbx_function.Controls.Add(this.btn_SuaCTPX);
            this.grbx_function.Location = new System.Drawing.Point(15, 419);
            this.grbx_function.Name = "grbx_function";
            this.grbx_function.Size = new System.Drawing.Size(948, 59);
            this.grbx_function.TabIndex = 23;
            this.grbx_function.TabStop = false;
            this.grbx_function.Text = "Nhập Thông Tin Cho Chi Tiết Phiếu Xuất";
            // 
            // btn_ThaoTacCTPX
            // 
            this.btn_ThaoTacCTPX.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThaoTacCTPX.Image")));
            this.btn_ThaoTacCTPX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThaoTacCTPX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ThaoTacCTPX.Location = new System.Drawing.Point(200, 21);
            this.btn_ThaoTacCTPX.Name = "btn_ThaoTacCTPX";
            this.btn_ThaoTacCTPX.Size = new System.Drawing.Size(261, 25);
            this.btn_ThaoTacCTPX.TabIndex = 8;
            this.btn_ThaoTacCTPX.Text = "Thao Tác Trên Bảng CT Phiếu Xuất";
            this.btn_ThaoTacCTPX.UseVisualStyleBackColor = false;
            this.btn_ThaoTacCTPX.Click += new System.EventHandler(this.btn_ThaoTacCTPX_Click);
            // 
            // btn_NhapCTPX
            // 
            this.btn_NhapCTPX.Image = ((System.Drawing.Image)(resources.GetObject("btn_NhapCTPX.Image")));
            this.btn_NhapCTPX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NhapCTPX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_NhapCTPX.Location = new System.Drawing.Point(474, 21);
            this.btn_NhapCTPX.Name = "btn_NhapCTPX";
            this.btn_NhapCTPX.Size = new System.Drawing.Size(80, 25);
            this.btn_NhapCTPX.TabIndex = 9;
            this.btn_NhapCTPX.Text = "Nhập";
            this.btn_NhapCTPX.UseVisualStyleBackColor = false;
            this.btn_NhapCTPX.Click += new System.EventHandler(this.btn_NhapCTPX_Click);
            // 
            // btn_ThoatCTPX
            // 
            this.btn_ThoatCTPX.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThoatCTPX.Image")));
            this.btn_ThoatCTPX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThoatCTPX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ThoatCTPX.Location = new System.Drawing.Point(845, 21);
            this.btn_ThoatCTPX.Name = "btn_ThoatCTPX";
            this.btn_ThoatCTPX.Size = new System.Drawing.Size(80, 25);
            this.btn_ThoatCTPX.TabIndex = 13;
            this.btn_ThoatCTPX.Text = "Thoát";
            this.btn_ThoatCTPX.UseVisualStyleBackColor = false;
            this.btn_ThoatCTPX.Click += new System.EventHandler(this.btn_ThoatCTPX_Click);
            // 
            // btn_LuuCTPX
            // 
            this.btn_LuuCTPX.Image = ((System.Drawing.Image)(resources.GetObject("btn_LuuCTPX.Image")));
            this.btn_LuuCTPX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LuuCTPX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_LuuCTPX.Location = new System.Drawing.Point(753, 21);
            this.btn_LuuCTPX.Name = "btn_LuuCTPX";
            this.btn_LuuCTPX.Size = new System.Drawing.Size(80, 25);
            this.btn_LuuCTPX.TabIndex = 12;
            this.btn_LuuCTPX.Text = "Lưu";
            this.btn_LuuCTPX.UseVisualStyleBackColor = false;
            this.btn_LuuCTPX.Click += new System.EventHandler(this.btn_LuuCTPX_Click);
            // 
            // btn_XoaCTPX
            // 
            this.btn_XoaCTPX.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaCTPX.Image")));
            this.btn_XoaCTPX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaCTPX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_XoaCTPX.Location = new System.Drawing.Point(661, 21);
            this.btn_XoaCTPX.Name = "btn_XoaCTPX";
            this.btn_XoaCTPX.Size = new System.Drawing.Size(80, 25);
            this.btn_XoaCTPX.TabIndex = 11;
            this.btn_XoaCTPX.Text = "Tìm Xóa";
            this.btn_XoaCTPX.UseVisualStyleBackColor = false;
            this.btn_XoaCTPX.Click += new System.EventHandler(this.btn_XoaCTPX_Click);
            // 
            // btn_SuaCTPX
            // 
            this.btn_SuaCTPX.Image = ((System.Drawing.Image)(resources.GetObject("btn_SuaCTPX.Image")));
            this.btn_SuaCTPX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SuaCTPX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_SuaCTPX.Location = new System.Drawing.Point(568, 21);
            this.btn_SuaCTPX.Name = "btn_SuaCTPX";
            this.btn_SuaCTPX.Size = new System.Drawing.Size(80, 25);
            this.btn_SuaCTPX.TabIndex = 10;
            this.btn_SuaCTPX.Text = "Tìm Sửa";
            this.btn_SuaCTPX.UseVisualStyleBackColor = false;
            this.btn_SuaCTPX.Click += new System.EventHandler(this.btn_SuaCTPX_Click);
            // 
            // dataGridViewSuaCTPX
            // 
            this.dataGridViewSuaCTPX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSuaCTPX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CTMaXuat,
            this.CTMaXe,
            this.CTSoLuong,
            this.CTGiaXuat,
            this.CTThueXuat});
            this.dataGridViewSuaCTPX.Location = new System.Drawing.Point(18, 180);
            this.dataGridViewSuaCTPX.Name = "dataGridViewSuaCTPX";
            this.dataGridViewSuaCTPX.Size = new System.Drawing.Size(948, 232);
            this.dataGridViewSuaCTPX.TabIndex = 24;
            this.dataGridViewSuaCTPX.Visible = false;
            this.dataGridViewSuaCTPX.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSuaCTPX_RowEnter);
            // 
            // CTMaXuat
            // 
            this.CTMaXuat.DataPropertyName = "MAXUAT";
            this.CTMaXuat.HeaderText = "Mã Xuất";
            this.CTMaXuat.Name = "CTMaXuat";
            this.CTMaXuat.ReadOnly = true;
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
            this.CTSoLuong.DataPropertyName = "SLXUAT";
            this.CTSoLuong.HeaderText = "Số Lượng Xuất";
            this.CTSoLuong.Name = "CTSoLuong";
            // 
            // CTGiaXuat
            // 
            this.CTGiaXuat.DataPropertyName = "GIAXUAT";
            this.CTGiaXuat.HeaderText = "Giá Xuất";
            this.CTGiaXuat.Name = "CTGiaXuat";
            // 
            // CTThueXuat
            // 
            this.CTThueXuat.DataPropertyName = "THUEXUAT";
            this.CTThueXuat.HeaderText = "Thuế Xuất";
            this.CTThueXuat.Name = "CTThueXuat";
            // 
            // frmXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(984, 492);
            this.Controls.Add(this.dataGridViewSuaCTPX);
            this.Controls.Add(this.grbx_phieuNhap);
            this.Controls.Add(this.dataGridViewXuatHang);
            this.Controls.Add(this.grbx_function);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 530);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 530);
            this.Name = "frmXuatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nghiệp vụ xuất hàng";
            this.Load += new System.EventHandler(this.frmXuatHang_Load);
            this.grbx_phieuNhap.ResumeLayout(false);
            this.panel_phieuNhap.ResumeLayout(false);
            this.panel_phieuNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXuatHang)).EndInit();
            this.grbx_function.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuaCTPX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_phieuNhap;
        private System.Windows.Forms.Panel panel_phieuNhap;
        private System.Windows.Forms.Button btn_ThoatPXuat;
        private System.Windows.Forms.TextBox txtMaXe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaXuat;
        private System.Windows.Forms.ComboBox cboTenKH;
        private System.Windows.Forms.Button btn_ThemPXuat;
        private System.Windows.Forms.ComboBox cboTenNV;
        private System.Windows.Forms.DateTimePicker dateTimePickerXuatHang;
        private System.Windows.Forms.Button btn_LuuPXuat;
        private System.Windows.Forms.Label lb_nhanVien;
        private System.Windows.Forms.Label lb_nhaCungCap;
        private System.Windows.Forms.Label lb_ngayNhap;
        private System.Windows.Forms.Label lb_maHoaDon;
        private System.Windows.Forms.DataGridView dataGridViewXuatHang;
        private System.Windows.Forms.GroupBox grbx_function;
        private System.Windows.Forms.Button btn_ThaoTacCTPX;
        private System.Windows.Forms.Button btn_NhapCTPX;
        private System.Windows.Forms.Button btn_ThoatCTPX;
        private System.Windows.Forms.Button btn_LuuCTPX;
        private System.Windows.Forms.Button btn_XoaCTPX;
        private System.Windows.Forms.Button btn_SuaCTPX;
        private System.Windows.Forms.DataGridView dataGridViewSuaCTPX;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTMaXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTMaXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTGiaXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTThueXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotGiaXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotThueXuat;
    }
}