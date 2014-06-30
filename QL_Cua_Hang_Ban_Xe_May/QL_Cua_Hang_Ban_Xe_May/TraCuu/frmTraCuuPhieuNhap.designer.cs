namespace QL_Cua_Hang_Ban_Xe_May
{
    partial class frmTraCuuPhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraCuuPhieuNhap));
            this.btn_thoat = new System.Windows.Forms.Button();
            this.dataGridViewTCPhieuNhap = new System.Windows.Forms.DataGridView();
            this.cotSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgc_maPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgc_donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgc_nhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThueNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_TCTenNSX = new System.Windows.Forms.TextBox();
            this.txt_TCTenXe = new System.Windows.Forms.TextBox();
            this.txt_TCTenNV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_TCGiaNhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTCPhieuNhap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_thoat
            // 
            this.btn_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Image")));
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_thoat.Location = new System.Drawing.Point(743, 19);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(80, 27);
            this.btn_thoat.TabIndex = 6;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // dataGridViewTCPhieuNhap
            // 
            this.dataGridViewTCPhieuNhap.AllowUserToAddRows = false;
            this.dataGridViewTCPhieuNhap.AllowUserToDeleteRows = false;
            this.dataGridViewTCPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTCPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cotSTT,
            this.MaNhap,
            this.dgc_maPhieuNhap,
            this.dgc_donGia,
            this.dgc_nhaCungCap,
            this.NgayNhap,
            this.SLNhap,
            this.ChucVu,
            this.ThueNhap});
            this.dataGridViewTCPhieuNhap.Location = new System.Drawing.Point(19, 140);
            this.dataGridViewTCPhieuNhap.Name = "dataGridViewTCPhieuNhap";
            this.dataGridViewTCPhieuNhap.ReadOnly = true;
            this.dataGridViewTCPhieuNhap.Size = new System.Drawing.Size(844, 288);
            this.dataGridViewTCPhieuNhap.TabIndex = 34;
            this.dataGridViewTCPhieuNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTCPhieuNhap_CellContentClick);
            // 
            // cotSTT
            // 
            this.cotSTT.HeaderText = "STT";
            this.cotSTT.Name = "cotSTT";
            this.cotSTT.ReadOnly = true;
            // 
            // MaNhap
            // 
            this.MaNhap.DataPropertyName = "MANHAP";
            this.MaNhap.HeaderText = "Mã phiếu nhập";
            this.MaNhap.Name = "MaNhap";
            this.MaNhap.ReadOnly = true;
            // 
            // dgc_maPhieuNhap
            // 
            this.dgc_maPhieuNhap.DataPropertyName = "TENNV";
            this.dgc_maPhieuNhap.HeaderText = "Tên nhân viên";
            this.dgc_maPhieuNhap.Name = "dgc_maPhieuNhap";
            this.dgc_maPhieuNhap.ReadOnly = true;
            // 
            // dgc_donGia
            // 
            this.dgc_donGia.DataPropertyName = "TENXE";
            this.dgc_donGia.HeaderText = "Tên xe";
            this.dgc_donGia.Name = "dgc_donGia";
            this.dgc_donGia.ReadOnly = true;
            // 
            // dgc_nhaCungCap
            // 
            this.dgc_nhaCungCap.DataPropertyName = "TENHCC";
            this.dgc_nhaCungCap.HeaderText = "Nhà sản xuất";
            this.dgc_nhaCungCap.Name = "dgc_nhaCungCap";
            this.dgc_nhaCungCap.ReadOnly = true;
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NGAYNHAP";
            this.NgayNhap.HeaderText = "Ngày nhập";
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.ReadOnly = true;
            // 
            // SLNhap
            // 
            this.SLNhap.DataPropertyName = "SLNHAP";
            this.SLNhap.HeaderText = "Số lượng nhập";
            this.SLNhap.Name = "SLNhap";
            this.SLNhap.ReadOnly = true;
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "GIANHAP";
            this.ChucVu.HeaderText = "Giá nhập";
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.ReadOnly = true;
            // 
            // ThueNhap
            // 
            this.ThueNhap.DataPropertyName = "THUENHAP";
            this.ThueNhap.HeaderText = "Thuế Nhập";
            this.ThueNhap.Name = "ThueNhap";
            this.ThueNhap.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_TCTenNSX);
            this.groupBox1.Controls.Add(this.txt_TCTenXe);
            this.groupBox1.Controls.Add(this.txt_TCTenNV);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_TCGiaNhap);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(19, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(844, 115);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tra Cứu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_TCTenNSX
            // 
            this.txt_TCTenNSX.Location = new System.Drawing.Point(595, 38);
            this.txt_TCTenNSX.Name = "txt_TCTenNSX";
            this.txt_TCTenNSX.Size = new System.Drawing.Size(219, 20);
            this.txt_TCTenNSX.TabIndex = 3;
            this.txt_TCTenNSX.TextChanged += new System.EventHandler(this.txt_TCTenNSX_TextChanged);
            // 
            // txt_TCTenXe
            // 
            this.txt_TCTenXe.Location = new System.Drawing.Point(139, 66);
            this.txt_TCTenXe.Name = "txt_TCTenXe";
            this.txt_TCTenXe.Size = new System.Drawing.Size(241, 20);
            this.txt_TCTenXe.TabIndex = 2;
            this.txt_TCTenXe.TextChanged += new System.EventHandler(this.txt_TCTenXe_TextChanged);
            // 
            // txt_TCTenNV
            // 
            this.txt_TCTenNV.Location = new System.Drawing.Point(139, 38);
            this.txt_TCTenNV.Name = "txt_TCTenNV";
            this.txt_TCTenNV.Size = new System.Drawing.Size(241, 20);
            this.txt_TCTenNV.TabIndex = 1;
            this.txt_TCTenNV.TextChanged += new System.EventHandler(this.txt_TCTenNV_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(463, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 14);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nhà sản xuất";
            // 
            // txt_TCGiaNhap
            // 
            this.txt_TCGiaNhap.Location = new System.Drawing.Point(595, 66);
            this.txt_TCGiaNhap.Name = "txt_TCGiaNhap";
            this.txt_TCGiaNhap.Size = new System.Drawing.Size(219, 20);
            this.txt_TCGiaNhap.TabIndex = 4;
            this.txt_TCGiaNhap.TextChanged += new System.EventHandler(this.txt_TCGiaNhap_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giá nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tên xe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên nhân viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btn_thoat);
            this.groupBox2.Location = new System.Drawing.Point(12, 435);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(851, 61);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tác vụ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(648, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tìm mới";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmTraCuuPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(885, 513);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridViewTCPhieuNhap);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTraCuuPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu phiếu nhập";
            this.Load += new System.EventHandler(this.frmTraCuuPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTCPhieuNhap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.DataGridView dataGridViewTCPhieuNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TCGiaNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_TCTenNSX;
        private System.Windows.Forms.TextBox txt_TCTenXe;
        private System.Windows.Forms.TextBox txt_TCTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgc_maPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgc_donGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgc_nhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThueNhap;
    }
}