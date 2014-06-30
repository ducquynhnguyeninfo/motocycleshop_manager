namespace QL_Cua_Hang_Ban_Xe_May
{
    partial class frmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_ThoatKH = new System.Windows.Forms.Button();
            this.btn_SuaKH = new System.Windows.Forms.Button();
            this.btn_LuuKH = new System.Windows.Forms.Button();
            this.btn_XoaKH = new System.Windows.Forms.Button();
            this.btn_ThemKH = new System.Windows.Forms.Button();
            this.dataGridViewKhachhang = new System.Windows.Forms.DataGridView();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DC_HIENTAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HKTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHKTT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerNS = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMakh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_NgaySinh = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhachhang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_ThoatKH);
            this.groupBox3.Controls.Add(this.btn_SuaKH);
            this.groupBox3.Controls.Add(this.btn_LuuKH);
            this.groupBox3.Controls.Add(this.btn_XoaKH);
            this.groupBox3.Controls.Add(this.btn_ThemKH);
            this.groupBox3.Location = new System.Drawing.Point(21, 438);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(953, 60);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tác vụ";
            // 
            // btn_ThoatKH
            // 
            this.btn_ThoatKH.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThoatKH.Image")));
            this.btn_ThoatKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThoatKH.Location = new System.Drawing.Point(851, 19);
            this.btn_ThoatKH.Name = "btn_ThoatKH";
            this.btn_ThoatKH.Size = new System.Drawing.Size(80, 27);
            this.btn_ThoatKH.TabIndex = 0;
            this.btn_ThoatKH.Text = "Thoát";
            this.btn_ThoatKH.UseVisualStyleBackColor = false;
            this.btn_ThoatKH.Click += new System.EventHandler(this.bt_thoat);
            // 
            // btn_SuaKH
            // 
            this.btn_SuaKH.Image = ((System.Drawing.Image)(resources.GetObject("btn_SuaKH.Image")));
            this.btn_SuaKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SuaKH.Location = new System.Drawing.Point(666, 19);
            this.btn_SuaKH.Name = "btn_SuaKH";
            this.btn_SuaKH.Size = new System.Drawing.Size(80, 27);
            this.btn_SuaKH.TabIndex = 0;
            this.btn_SuaKH.Text = "Sửa";
            this.btn_SuaKH.UseVisualStyleBackColor = false;
            this.btn_SuaKH.Click += new System.EventHandler(this.btn_SuaKH_Click);
            // 
            // btn_LuuKH
            // 
            this.btn_LuuKH.Image = ((System.Drawing.Image)(resources.GetObject("btn_LuuKH.Image")));
            this.btn_LuuKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LuuKH.Location = new System.Drawing.Point(759, 19);
            this.btn_LuuKH.Name = "btn_LuuKH";
            this.btn_LuuKH.Size = new System.Drawing.Size(80, 27);
            this.btn_LuuKH.TabIndex = 0;
            this.btn_LuuKH.Text = "Lưu";
            this.btn_LuuKH.UseVisualStyleBackColor = false;
            this.btn_LuuKH.Click += new System.EventHandler(this.btn_LuuKH_Click);
            // 
            // btn_XoaKH
            // 
            this.btn_XoaKH.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaKH.Image")));
            this.btn_XoaKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaKH.Location = new System.Drawing.Point(572, 19);
            this.btn_XoaKH.Name = "btn_XoaKH";
            this.btn_XoaKH.Size = new System.Drawing.Size(80, 27);
            this.btn_XoaKH.TabIndex = 0;
            this.btn_XoaKH.Text = "Xóa";
            this.btn_XoaKH.UseVisualStyleBackColor = false;
            this.btn_XoaKH.Click += new System.EventHandler(this.btn_XoaKH_Click);
            // 
            // btn_ThemKH
            // 
            this.btn_ThemKH.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemKH.Image")));
            this.btn_ThemKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThemKH.Location = new System.Drawing.Point(477, 19);
            this.btn_ThemKH.Name = "btn_ThemKH";
            this.btn_ThemKH.Size = new System.Drawing.Size(80, 27);
            this.btn_ThemKH.TabIndex = 0;
            this.btn_ThemKH.Text = "Thêm";
            this.btn_ThemKH.UseVisualStyleBackColor = false;
            this.btn_ThemKH.Click += new System.EventHandler(this.btn_ThemKH_Click);
            // 
            // dataGridViewKhachhang
            // 
            this.dataGridViewKhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAKH,
            this.TENKH,
            this.GIOITINH,
            this.NGAYSINH,
            this.DC_HIENTAI,
            this.HKTT,
            this.DTKH,
            this.SCMND});
            this.dataGridViewKhachhang.Location = new System.Drawing.Point(21, 161);
            this.dataGridViewKhachhang.Name = "dataGridViewKhachhang";
            this.dataGridViewKhachhang.Size = new System.Drawing.Size(953, 269);
            this.dataGridViewKhachhang.TabIndex = 13;
            this.dataGridViewKhachhang.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_KH_RowEnter);
            // 
            // MAKH
            // 
            this.MAKH.DataPropertyName = "MAKH";
            this.MAKH.HeaderText = "Mã KH";
            this.MAKH.Name = "MAKH";
            this.MAKH.ReadOnly = true;
            // 
            // TENKH
            // 
            this.TENKH.DataPropertyName = "TENKH";
            this.TENKH.HeaderText = "Tên KH";
            this.TENKH.Name = "TENKH";
            this.TENKH.ReadOnly = true;
            this.TENKH.Width = 140;
            // 
            // GIOITINH
            // 
            this.GIOITINH.DataPropertyName = "GIOITINH";
            this.GIOITINH.HeaderText = "Giới Tính";
            this.GIOITINH.Name = "GIOITINH";
            this.GIOITINH.ReadOnly = true;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "Ngày Sinh";
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.ReadOnly = true;
            // 
            // DC_HIENTAI
            // 
            this.DC_HIENTAI.DataPropertyName = "DC_HIENTAI";
            this.DC_HIENTAI.HeaderText = "Địa Chỉ";
            this.DC_HIENTAI.Name = "DC_HIENTAI";
            this.DC_HIENTAI.ReadOnly = true;
            this.DC_HIENTAI.Width = 140;
            // 
            // HKTT
            // 
            this.HKTT.DataPropertyName = "HKTT";
            this.HKTT.HeaderText = "Hộ Khẩu TT";
            this.HKTT.Name = "HKTT";
            this.HKTT.ReadOnly = true;
            this.HKTT.Width = 130;
            // 
            // DTKH
            // 
            this.DTKH.DataPropertyName = "DTKH";
            this.DTKH.HeaderText = "Điện Thoại";
            this.DTKH.Name = "DTKH";
            this.DTKH.ReadOnly = true;
            // 
            // SCMND
            // 
            this.SCMND.DataPropertyName = "SCMND";
            this.SCMND.HeaderText = "Số CMND";
            this.SCMND.Name = "SCMND";
            this.SCMND.ReadOnly = true;
            this.SCMND.Width = 102;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbGioiTinh);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtHKTT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePickerNS);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtDT);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtMakh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lb_NgaySinh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(953, 132);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Location = new System.Drawing.Point(437, 30);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(100, 22);
            this.cbGioiTinh.TabIndex = 37;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(751, 66);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(180, 20);
            this.txtCMND.TabIndex = 36;
            this.txtCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckKeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(660, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 14);
            this.label7.TabIndex = 35;
            this.label7.Text = "Số CMND";
            // 
            // txtHKTT
            // 
            this.txtHKTT.Location = new System.Drawing.Point(437, 92);
            this.txtHKTT.Name = "txtHKTT";
            this.txtHKTT.Size = new System.Drawing.Size(180, 20);
            this.txtHKTT.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 14);
            this.label4.TabIndex = 33;
            this.label4.Text = "Hộ khẩu TT";
            // 
            // dateTimePickerNS
            // 
            this.dateTimePickerNS.Location = new System.Drawing.Point(104, 90);
            this.dateTimePickerNS.Name = "dateTimePickerNS";
            this.dateTimePickerNS.Size = new System.Drawing.Size(202, 20);
            this.dateTimePickerNS.TabIndex = 32;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(437, 63);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(180, 20);
            this.txtDiaChi.TabIndex = 28;
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(751, 35);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(180, 20);
            this.txtDT.TabIndex = 30;
            this.txtDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckKeyPress);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(104, 59);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(202, 20);
            this.txtTenKH.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 14);
            this.label3.TabIndex = 27;
            this.label3.Text = "Giới tính";
            // 
            // TxtMakh
            // 
            this.TxtMakh.Location = new System.Drawing.Point(104, 31);
            this.TxtMakh.Name = "TxtMakh";
            this.TxtMakh.Size = new System.Drawing.Size(100, 20);
            this.TxtMakh.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 14);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên KH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 14);
            this.label6.TabIndex = 20;
            this.label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(660, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 14);
            this.label5.TabIndex = 23;
            this.label5.Text = "Điện thoại";
            // 
            // lb_NgaySinh
            // 
            this.lb_NgaySinh.AutoSize = true;
            this.lb_NgaySinh.Location = new System.Drawing.Point(25, 94);
            this.lb_NgaySinh.Name = "lb_NgaySinh";
            this.lb_NgaySinh.Size = new System.Drawing.Size(55, 14);
            this.lb_NgaySinh.TabIndex = 24;
            this.lb_NgaySinh.Text = "Ngày sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 14);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mã KH";
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(996, 515);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridViewKhachhang);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục khách hàng";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhachhang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_ThoatKH;
        private System.Windows.Forms.Button btn_SuaKH;
        private System.Windows.Forms.Button btn_LuuKH;
        private System.Windows.Forms.Button btn_XoaKH;
        private System.Windows.Forms.Button btn_ThemKH;
        private System.Windows.Forms.DataGridView dataGridViewKhachhang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHKTT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerNS;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtMakh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_NgaySinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DC_HIENTAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn HKTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SCMND;
    }
}