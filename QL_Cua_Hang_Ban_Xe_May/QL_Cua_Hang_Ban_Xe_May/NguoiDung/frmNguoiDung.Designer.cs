namespace QL_Cua_Hang_Ban_Xe_May
{
    partial class frmNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNguoiDung));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.cbo_tennhomnd = new System.Windows.Forms.ComboBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.DateNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtMaND = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.dataGridViewNguoidung = new System.Windows.Forms.DataGridView();
            this.dgcSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcmaND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgctendn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcmatkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcMANHOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcTenNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgchoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcNGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcDIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNguoidung)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Luu);
            this.groupBox3.Controls.Add(this.btn_Thoat);
            this.groupBox3.Controls.Add(this.btn_Sua);
            this.groupBox3.Controls.Add(this.btn_Xoa);
            this.groupBox3.Controls.Add(this.btn_Them);
            this.groupBox3.Location = new System.Drawing.Point(23, 432);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(975, 67);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tác vụ";
            // 
            // btn_Luu
            // 
            this.btn_Luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Luu.Image")));
            this.btn_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Luu.Location = new System.Drawing.Point(778, 20);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(80, 27);
            this.btn_Luu.TabIndex = 11;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_Thoat.Image")));
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(869, 20);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(80, 27);
            this.btn_Thoat.TabIndex = 12;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.Image")));
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(685, 20);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(80, 27);
            this.btn_Sua.TabIndex = 10;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(591, 20);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(80, 27);
            this.btn_Xoa.TabIndex = 9;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(498, 20);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(80, 27);
            this.btn_Them.TabIndex = 8;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSDT);
            this.groupBox2.Controls.Add(this.cbo_tennhomnd);
            this.groupBox2.Controls.Add(this.txtTen);
            this.groupBox2.Controls.Add(this.DateNgaySinh);
            this.groupBox2.Controls.Add(this.txtMaND);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.txtMatKhau);
            this.groupBox2.Controls.Add(this.txtTenDN);
            this.groupBox2.Location = new System.Drawing.Point(23, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(975, 144);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin ";
            // 
            // txtSDT
            // 
            this.txtSDT.Enabled = false;
            this.txtSDT.Location = new System.Drawing.Point(764, 41);
            this.txtSDT.MaxLength = 13;
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(187, 21);
            this.txtSDT.TabIndex = 6;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckKeyPress);
            // 
            // cbo_tennhomnd
            // 
            this.cbo_tennhomnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tennhomnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_tennhomnd.Location = new System.Drawing.Point(484, 39);
            this.cbo_tennhomnd.Name = "cbo_tennhomnd";
            this.cbo_tennhomnd.Size = new System.Drawing.Size(187, 22);
            this.cbo_tennhomnd.TabIndex = 3;
            // 
            // txtTen
            // 
            this.txtTen.Enabled = false;
            this.txtTen.Location = new System.Drawing.Point(484, 71);
            this.txtTen.Multiline = true;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(187, 21);
            this.txtTen.TabIndex = 4;
            // 
            // DateNgaySinh
            // 
            this.DateNgaySinh.Enabled = false;
            this.DateNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateNgaySinh.Location = new System.Drawing.Point(484, 104);
            this.DateNgaySinh.Name = "DateNgaySinh";
            this.DateNgaySinh.Size = new System.Drawing.Size(187, 20);
            this.DateNgaySinh.TabIndex = 5;
            this.DateNgaySinh.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            // 
            // txtMaND
            // 
            this.txtMaND.Enabled = false;
            this.txtMaND.Location = new System.Drawing.Point(139, 34);
            this.txtMaND.Multiline = true;
            this.txtMaND.Name = "txtMaND";
            this.txtMaND.Size = new System.Drawing.Size(193, 22);
            this.txtMaND.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 14);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tên đăng nhập";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(364, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 14);
            this.label8.TabIndex = 1;
            this.label8.Text = "Nhóm người dùng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 14);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã người dùng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 14);
            this.label9.TabIndex = 1;
            this.label9.Text = "Mật khẩu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(364, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 14);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ngày sinh";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(364, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 14);
            this.label11.TabIndex = 2;
            this.label11.Text = "Họ tên";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(698, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 14);
            this.label12.TabIndex = 4;
            this.label12.Text = "SĐT";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(699, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 14);
            this.label13.TabIndex = 5;
            this.label13.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Location = new System.Drawing.Point(764, 72);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(187, 21);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Enabled = false;
            this.txtMatKhau.Location = new System.Drawing.Point(139, 102);
            this.txtMatKhau.Multiline = true;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(193, 22);
            this.txtMatKhau.TabIndex = 2;
            // 
            // txtTenDN
            // 
            this.txtTenDN.Enabled = false;
            this.txtTenDN.Location = new System.Drawing.Point(139, 68);
            this.txtTenDN.Multiline = true;
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(193, 22);
            this.txtTenDN.TabIndex = 1;
            // 
            // dataGridViewNguoidung
            // 
            this.dataGridViewNguoidung.AllowUserToDeleteRows = false;
            this.dataGridViewNguoidung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNguoidung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcSTT,
            this.dgcmaND,
            this.dgctendn,
            this.dgcmatkhau,
            this.dgcMANHOM,
            this.dgcTenNhom,
            this.dgchoten,
            this.dgcNGAYSINH,
            this.dgcSDT,
            this.dgcDIACHI});
            this.dataGridViewNguoidung.Location = new System.Drawing.Point(23, 170);
            this.dataGridViewNguoidung.MultiSelect = false;
            this.dataGridViewNguoidung.Name = "dataGridViewNguoidung";
            this.dataGridViewNguoidung.ReadOnly = true;
            this.dataGridViewNguoidung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNguoidung.Size = new System.Drawing.Size(975, 253);
            this.dataGridViewNguoidung.TabIndex = 9;
            this.dataGridViewNguoidung.TabStop = false;
            this.dataGridViewNguoidung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNguoidung_CellContentClick);
            this.dataGridViewNguoidung.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNguoidung_RowEnter);
            // 
            // dgcSTT
            // 
            this.dgcSTT.DataPropertyName = "STT";
            this.dgcSTT.HeaderText = "STT";
            this.dgcSTT.Name = "dgcSTT";
            this.dgcSTT.ReadOnly = true;
            this.dgcSTT.Width = 50;
            // 
            // dgcmaND
            // 
            this.dgcmaND.DataPropertyName = "MAND";
            this.dgcmaND.HeaderText = "Mã người dùng";
            this.dgcmaND.Name = "dgcmaND";
            this.dgcmaND.ReadOnly = true;
            this.dgcmaND.Width = 110;
            // 
            // dgctendn
            // 
            this.dgctendn.DataPropertyName = "TENDN";
            this.dgctendn.HeaderText = "Tên đăng nhập";
            this.dgctendn.Name = "dgctendn";
            this.dgctendn.ReadOnly = true;
            this.dgctendn.Width = 110;
            // 
            // dgcmatkhau
            // 
            this.dgcmatkhau.DataPropertyName = "MATKHAU";
            this.dgcmatkhau.HeaderText = "Mật khẩu";
            this.dgcmatkhau.Name = "dgcmatkhau";
            this.dgcmatkhau.ReadOnly = true;
            // 
            // dgcMANHOM
            // 
            this.dgcMANHOM.DataPropertyName = "MANHOM";
            this.dgcMANHOM.HeaderText = "Mã nhóm người dùng";
            this.dgcMANHOM.Name = "dgcMANHOM";
            this.dgcMANHOM.ReadOnly = true;
            this.dgcMANHOM.Width = 110;
            // 
            // dgcTenNhom
            // 
            this.dgcTenNhom.DataPropertyName = "TENNHOM";
            this.dgcTenNhom.HeaderText = "Nhóm người dùng";
            this.dgcTenNhom.Name = "dgcTenNhom";
            this.dgcTenNhom.ReadOnly = true;
            // 
            // dgchoten
            // 
            this.dgchoten.DataPropertyName = "HOTEN";
            this.dgchoten.FillWeight = 110F;
            this.dgchoten.HeaderText = "Họ tên nhân viên";
            this.dgchoten.Name = "dgchoten";
            this.dgchoten.ReadOnly = true;
            this.dgchoten.Width = 130;
            // 
            // dgcNGAYSINH
            // 
            this.dgcNGAYSINH.DataPropertyName = "NGAYSINH";
            this.dgcNGAYSINH.HeaderText = "Ngày sinh";
            this.dgcNGAYSINH.Name = "dgcNGAYSINH";
            this.dgcNGAYSINH.ReadOnly = true;
            // 
            // dgcSDT
            // 
            this.dgcSDT.DataPropertyName = "SDT";
            this.dgcSDT.HeaderText = "Số điện thoại";
            this.dgcSDT.Name = "dgcSDT";
            this.dgcSDT.ReadOnly = true;
            // 
            // dgcDIACHI
            // 
            this.dgcDIACHI.DataPropertyName = "DIACHI";
            this.dgcDIACHI.HeaderText = "Địa chỉ";
            this.dgcDIACHI.Name = "dgcDIACHI";
            this.dgcDIACHI.ReadOnly = true;
            this.dgcDIACHI.Width = 122;
            // 
            // frmNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1020, 519);
            this.Controls.Add(this.dataGridViewNguoidung);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Người dùng hệ thống";
            this.Load += new System.EventHandler(this.frmNguoiDung_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNguoidung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbo_tennhomnd;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.DateTimePicker DateNgaySinh;
        private System.Windows.Forms.TextBox txtMaND;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.DataGridView dataGridViewNguoidung;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcmaND;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgctendn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcmatkhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcMANHOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTenNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgchoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcNGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDIACHI;
    }
}