namespace QL_Cua_Hang_Ban_Xe_May
{
    partial class frmTraCuuKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraCuuKhachHang));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_TimMoiHH = new System.Windows.Forms.Button();
            this.btn_ThoatHH = new System.Windows.Forms.Button();
            this.dataGridViewKhachhang = new System.Windows.Forms.DataGridView();
            this.cotSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotMAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotTENKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotGIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotDC_HIENTAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotHKTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_hkttru = new System.Windows.Forms.TextBox();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMakh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhachhang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_TimMoiHH);
            this.groupBox2.Controls.Add(this.btn_ThoatHH);
            this.groupBox2.Location = new System.Drawing.Point(21, 420);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(879, 56);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tác vụ";
            // 
            // btn_TimMoiHH
            // 
            this.btn_TimMoiHH.Image = ((System.Drawing.Image)(resources.GetObject("btn_TimMoiHH.Image")));
            this.btn_TimMoiHH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimMoiHH.Location = new System.Drawing.Point(684, 19);
            this.btn_TimMoiHH.Name = "btn_TimMoiHH";
            this.btn_TimMoiHH.Size = new System.Drawing.Size(80, 27);
            this.btn_TimMoiHH.TabIndex = 6;
            this.btn_TimMoiHH.Text = "Tìm mới";
            this.btn_TimMoiHH.UseVisualStyleBackColor = false;
            this.btn_TimMoiHH.Click += new System.EventHandler(this.btn_TimMoiHH_Click);
            // 
            // btn_ThoatHH
            // 
            this.btn_ThoatHH.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThoatHH.Image")));
            this.btn_ThoatHH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThoatHH.Location = new System.Drawing.Point(778, 19);
            this.btn_ThoatHH.Name = "btn_ThoatHH";
            this.btn_ThoatHH.Size = new System.Drawing.Size(80, 27);
            this.btn_ThoatHH.TabIndex = 7;
            this.btn_ThoatHH.Text = "Thoát";
            this.btn_ThoatHH.UseVisualStyleBackColor = false;
            this.btn_ThoatHH.Click += new System.EventHandler(this.btn_ThoatHH_Click);
            // 
            // dataGridViewKhachhang
            // 
            this.dataGridViewKhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cotSTT,
            this.cotMAKH,
            this.cotTENKH,
            this.cotGIOITINH,
            this.cotDC_HIENTAI,
            this.cotHKTT,
            this.NGAYSINH,
            this.SCMND});
            this.dataGridViewKhachhang.Location = new System.Drawing.Point(21, 140);
            this.dataGridViewKhachhang.Name = "dataGridViewKhachhang";
            this.dataGridViewKhachhang.Size = new System.Drawing.Size(879, 269);
            this.dataGridViewKhachhang.TabIndex = 42;
            // 
            // cotSTT
            // 
            this.cotSTT.HeaderText = "STT";
            this.cotSTT.Name = "cotSTT";
            // 
            // cotMAKH
            // 
            this.cotMAKH.DataPropertyName = "MAKH";
            this.cotMAKH.HeaderText = "Mã KH";
            this.cotMAKH.Name = "cotMAKH";
            this.cotMAKH.ReadOnly = true;
            this.cotMAKH.Width = 90;
            // 
            // cotTENKH
            // 
            this.cotTENKH.DataPropertyName = "TENKH";
            this.cotTENKH.HeaderText = "Tên KH";
            this.cotTENKH.Name = "cotTENKH";
            this.cotTENKH.ReadOnly = true;
            this.cotTENKH.Width = 120;
            // 
            // cotGIOITINH
            // 
            this.cotGIOITINH.DataPropertyName = "GIOITINH";
            this.cotGIOITINH.HeaderText = "Giới Tính";
            this.cotGIOITINH.Name = "cotGIOITINH";
            this.cotGIOITINH.ReadOnly = true;
            // 
            // cotDC_HIENTAI
            // 
            this.cotDC_HIENTAI.DataPropertyName = "DC_HIENTAI";
            this.cotDC_HIENTAI.HeaderText = "Địa Chỉ";
            this.cotDC_HIENTAI.Name = "cotDC_HIENTAI";
            this.cotDC_HIENTAI.ReadOnly = true;
            this.cotDC_HIENTAI.Width = 130;
            // 
            // cotHKTT
            // 
            this.cotHKTT.DataPropertyName = "HKTT";
            this.cotHKTT.HeaderText = "Hộ Khẩu TT";
            this.cotHKTT.Name = "cotHKTT";
            this.cotHKTT.ReadOnly = true;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "Ngày Sinh";
            this.NGAYSINH.Name = "NGAYSINH";
            // 
            // SCMND
            // 
            this.SCMND.DataPropertyName = "SCMND";
            this.SCMND.HeaderText = "Số CMND";
            this.SCMND.Name = "SCMND";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_hkttru);
            this.groupBox1.Controls.Add(this.cbGioiTinh);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtMakh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(879, 108);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tra cứu ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(517, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 14);
            this.label4.TabIndex = 39;
            this.label4.Text = "Hộ khẩu thường trú";
            // 
            // txt_hkttru
            // 
            this.txt_hkttru.Location = new System.Drawing.Point(660, 38);
            this.txt_hkttru.Name = "txt_hkttru";
            this.txt_hkttru.Size = new System.Drawing.Size(195, 20);
            this.txt_hkttru.TabIndex = 4;
            this.txt_hkttru.TextChanged += new System.EventHandler(this.txt_hkttru_TextChanged);
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Location = new System.Drawing.Point(369, 38);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(121, 22);
            this.cbGioiTinh.TabIndex = 3;
            this.cbGioiTinh.SelectedIndexChanged += new System.EventHandler(this.cbGioiTinh_SelectedIndexChanged);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(660, 69);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(195, 20);
            this.txtDiaChi.TabIndex = 5;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(79, 66);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(196, 20);
            this.txtTenKH.TabIndex = 2;
            this.txtTenKH.TextChanged += new System.EventHandler(this.txtTenKH_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 14);
            this.label3.TabIndex = 27;
            this.label3.Text = "Giới tính";
            // 
            // TxtMakh
            // 
            this.TxtMakh.Location = new System.Drawing.Point(79, 38);
            this.TxtMakh.Name = "TxtMakh";
            this.TxtMakh.Size = new System.Drawing.Size(196, 20);
            this.TxtMakh.TabIndex = 1;
            this.TxtMakh.TextChanged += new System.EventHandler(this.TxtMakh_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 14);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên KH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(517, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 14);
            this.label6.TabIndex = 20;
            this.label6.Text = "Địa chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 14);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mã KH";
            // 
            // frmTraCuuKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(920, 491);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridViewKhachhang);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTraCuuKhachHang";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu thông tin khách hàng";
            this.Load += new System.EventHandler(this.frmTraCuuKhachHang_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhachhang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_TimMoiHH;
        private System.Windows.Forms.Button btn_ThoatHH;
        private System.Windows.Forms.DataGridView dataGridViewKhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotMAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotTENKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotGIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotDC_HIENTAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotHKTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SCMND;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_hkttru;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtMakh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;

    }
}