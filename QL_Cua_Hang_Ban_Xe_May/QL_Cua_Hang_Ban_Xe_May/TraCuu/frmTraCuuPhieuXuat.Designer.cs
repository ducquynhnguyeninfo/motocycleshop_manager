namespace QL_Cua_Hang_Ban_Xe_May
{
    partial class frmTraCuuPhieuXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraCuuPhieuXuat));
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Gia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.txtTenXe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_timmoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_phieuxuat = new System.Windows.Forms.DataGridView();
            this.cotSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgc_maPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgc_ngayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgc_donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgc_nhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENXE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgc_soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_TenKH = new System.Windows.Forms.TextBox();
            this.txt_TenNV = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_phieuxuat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(448, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 14);
            this.label7.TabIndex = 12;
            this.label7.Text = "Khách hàng";
            // 
            // txt_Gia
            // 
            this.txt_Gia.Location = new System.Drawing.Point(553, 70);
            this.txt_Gia.Name = "txt_Gia";
            this.txt_Gia.Size = new System.Drawing.Size(262, 20);
            this.txt_Gia.TabIndex = 4;
            this.txt_Gia.TextChanged += new System.EventHandler(this.txt_Gia_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giá xuất";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Image")));
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_thoat.Location = new System.Drawing.Point(735, 19);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(80, 27);
            this.btn_thoat.TabIndex = 35;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // txtTenXe
            // 
            this.txtTenXe.Location = new System.Drawing.Point(160, 71);
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.Size = new System.Drawing.Size(238, 20);
            this.txtTenXe.TabIndex = 2;
            this.txtTenXe.TextChanged += new System.EventHandler(this.txtTenXe_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tên xe";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_timmoi);
            this.groupBox2.Controls.Add(this.btn_thoat);
            this.groupBox2.Location = new System.Drawing.Point(17, 435);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(841, 61);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tác vụ";
            // 
            // btn_timmoi
            // 
            this.btn_timmoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_timmoi.Image")));
            this.btn_timmoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timmoi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_timmoi.Location = new System.Drawing.Point(640, 19);
            this.btn_timmoi.Name = "btn_timmoi";
            this.btn_timmoi.Size = new System.Drawing.Size(80, 27);
            this.btn_timmoi.TabIndex = 36;
            this.btn_timmoi.Text = "Tìm mới";
            this.btn_timmoi.UseVisualStyleBackColor = false;
            this.btn_timmoi.Click += new System.EventHandler(this.btn_timmoi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên nhân viên";
            // 
            // dataGridView_phieuxuat
            // 
            this.dataGridView_phieuxuat.AllowUserToAddRows = false;
            this.dataGridView_phieuxuat.AllowUserToDeleteRows = false;
            this.dataGridView_phieuxuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_phieuxuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cotSTT,
            this.dgc_maPhieuNhap,
            this.dgc_ngayNhap,
            this.dgc_donGia,
            this.dgc_nhaCungCap,
            this.TENXE,
            this.ChucVu,
            this.dgc_soLuong});
            this.dataGridView_phieuxuat.Location = new System.Drawing.Point(17, 139);
            this.dataGridView_phieuxuat.Name = "dataGridView_phieuxuat";
            this.dataGridView_phieuxuat.ReadOnly = true;
            this.dataGridView_phieuxuat.Size = new System.Drawing.Size(841, 288);
            this.dataGridView_phieuxuat.TabIndex = 37;
            // 
            // cotSTT
            // 
            this.cotSTT.HeaderText = "STT";
            this.cotSTT.Name = "cotSTT";
            this.cotSTT.ReadOnly = true;
            // 
            // dgc_maPhieuNhap
            // 
            this.dgc_maPhieuNhap.DataPropertyName = "MAXUAT";
            this.dgc_maPhieuNhap.HeaderText = "Mã phiếu xuất";
            this.dgc_maPhieuNhap.Name = "dgc_maPhieuNhap";
            this.dgc_maPhieuNhap.ReadOnly = true;
            // 
            // dgc_ngayNhap
            // 
            this.dgc_ngayNhap.DataPropertyName = "NGAYXUAT";
            this.dgc_ngayNhap.HeaderText = "Ngày xuất";
            this.dgc_ngayNhap.Name = "dgc_ngayNhap";
            this.dgc_ngayNhap.ReadOnly = true;
            // 
            // dgc_donGia
            // 
            this.dgc_donGia.DataPropertyName = "TENNV";
            this.dgc_donGia.HeaderText = "Nhân viên";
            this.dgc_donGia.Name = "dgc_donGia";
            this.dgc_donGia.ReadOnly = true;
            // 
            // dgc_nhaCungCap
            // 
            this.dgc_nhaCungCap.DataPropertyName = "TENKH";
            this.dgc_nhaCungCap.HeaderText = "Khách hàng";
            this.dgc_nhaCungCap.Name = "dgc_nhaCungCap";
            this.dgc_nhaCungCap.ReadOnly = true;
            // 
            // TENXE
            // 
            this.TENXE.DataPropertyName = "TENXE";
            this.TENXE.HeaderText = "Tên xe";
            this.TENXE.Name = "TENXE";
            this.TENXE.ReadOnly = true;
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "GIAXUAT";
            this.ChucVu.HeaderText = "Giá xuất";
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.ReadOnly = true;
            // 
            // dgc_soLuong
            // 
            this.dgc_soLuong.DataPropertyName = "THUEXUAT";
            this.dgc_soLuong.HeaderText = "Thuế xuất";
            this.dgc_soLuong.Name = "dgc_soLuong";
            this.dgc_soLuong.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_TenKH);
            this.groupBox1.Controls.Add(this.txt_TenNV);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_Gia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTenXe);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(841, 117);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tra Cứu";
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Location = new System.Drawing.Point(553, 38);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(262, 20);
            this.txt_TenKH.TabIndex = 3;
            this.txt_TenKH.TextChanged += new System.EventHandler(this.txt_TenKH_TextChanged);
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.Location = new System.Drawing.Point(160, 38);
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.Size = new System.Drawing.Size(238, 20);
            this.txt_TenNV.TabIndex = 1;
            this.txt_TenNV.TextChanged += new System.EventHandler(this.txt_TenNV_TextChanged);
            // 
            // frmTraCuuPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(876, 505);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView_phieuxuat);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTraCuuPhieuXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu phiếu xuất";
            this.Load += new System.EventHandler(this.frmTraCuuPhieuXuat_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_phieuxuat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Gia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.TextBox txtTenXe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_timmoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_phieuxuat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_TenKH;
        private System.Windows.Forms.TextBox txt_TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgc_maPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgc_ngayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgc_donGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgc_nhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENXE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgc_soLuong;

    }
}