namespace QL_Cua_Hang_Ban_Xe_May
{
    partial class frmTraCuuHangCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraCuuHangCungCap));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_TimMoiNCC = new System.Windows.Forms.Button();
            this.btn_ThoatNCC = new System.Windows.Forms.Button();
            this.txtTCMaNCC = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txtTCTenNCC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTCNhaCungCap = new System.Windows.Forms.DataGridView();
            this.cotSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgc_maPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgc_ngayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgc_nhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTCNhaCungCap)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_TimMoiNCC);
            this.groupBox2.Controls.Add(this.btn_ThoatNCC);
            this.groupBox2.Location = new System.Drawing.Point(16, 355);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(664, 57);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tác vụ";
            // 
            // btn_TimMoiNCC
            // 
            this.btn_TimMoiNCC.Image = ((System.Drawing.Image)(resources.GetObject("btn_TimMoiNCC.Image")));
            this.btn_TimMoiNCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimMoiNCC.Location = new System.Drawing.Point(470, 19);
            this.btn_TimMoiNCC.Name = "btn_TimMoiNCC";
            this.btn_TimMoiNCC.Size = new System.Drawing.Size(80, 27);
            this.btn_TimMoiNCC.TabIndex = 4;
            this.btn_TimMoiNCC.Text = "Tìm mới";
            this.btn_TimMoiNCC.UseVisualStyleBackColor = false;
            this.btn_TimMoiNCC.Click += new System.EventHandler(this.btn_TimMoiNCC_Click);
            // 
            // btn_ThoatNCC
            // 
            this.btn_ThoatNCC.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThoatNCC.Image")));
            this.btn_ThoatNCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThoatNCC.Location = new System.Drawing.Point(564, 19);
            this.btn_ThoatNCC.Name = "btn_ThoatNCC";
            this.btn_ThoatNCC.Size = new System.Drawing.Size(80, 27);
            this.btn_ThoatNCC.TabIndex = 5;
            this.btn_ThoatNCC.Text = "Thoát";
            this.btn_ThoatNCC.UseVisualStyleBackColor = false;
            this.btn_ThoatNCC.Click += new System.EventHandler(this.btn_ThoatNCC_Click);
            // 
            // txtTCMaNCC
            // 
            this.txtTCMaNCC.Location = new System.Drawing.Point(164, 39);
            this.txtTCMaNCC.Name = "txtTCMaNCC";
            this.txtTCMaNCC.Size = new System.Drawing.Size(166, 20);
            this.txtTCMaNCC.TabIndex = 1;
            this.txtTCMaNCC.TextChanged += new System.EventHandler(this.txtTCMaNCC_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_diachi);
            this.groupBox1.Controls.Add(this.txtTCMaNCC);
            this.groupBox1.Controls.Add(this.txtTCTenNCC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 109);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(436, 39);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(207, 20);
            this.txt_diachi.TabIndex = 3;
            this.txt_diachi.TextChanged += new System.EventHandler(this.txt_diachi_TextChanged);
            // 
            // txtTCTenNCC
            // 
            this.txtTCTenNCC.Location = new System.Drawing.Point(164, 65);
            this.txtTCTenNCC.Name = "txtTCTenNCC";
            this.txtTCTenNCC.Size = new System.Drawing.Size(166, 20);
            this.txtTCTenNCC.TabIndex = 2;
            this.txtTCTenNCC.TextChanged += new System.EventHandler(this.txtTCTenNCC_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên nhà cung cấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "Địa chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 14);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã nhà cung cấp";
            // 
            // dataGridViewTCNhaCungCap
            // 
            this.dataGridViewTCNhaCungCap.AllowUserToAddRows = false;
            this.dataGridViewTCNhaCungCap.AllowUserToDeleteRows = false;
            this.dataGridViewTCNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTCNhaCungCap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cotSTT,
            this.dgc_maPhieuNhap,
            this.dgc_ngayNhap,
            this.dgc_nhanVien});
            this.dataGridViewTCNhaCungCap.Location = new System.Drawing.Point(17, 132);
            this.dataGridViewTCNhaCungCap.Name = "dataGridViewTCNhaCungCap";
            this.dataGridViewTCNhaCungCap.ReadOnly = true;
            this.dataGridViewTCNhaCungCap.Size = new System.Drawing.Size(663, 207);
            this.dataGridViewTCNhaCungCap.TabIndex = 37;
            // 
            // cotSTT
            // 
            this.cotSTT.HeaderText = "STT";
            this.cotSTT.Name = "cotSTT";
            this.cotSTT.ReadOnly = true;
            this.cotSTT.Width = 50;
            // 
            // dgc_maPhieuNhap
            // 
            this.dgc_maPhieuNhap.DataPropertyName = "MAHCC";
            this.dgc_maPhieuNhap.HeaderText = "Mã HCC";
            this.dgc_maPhieuNhap.Name = "dgc_maPhieuNhap";
            this.dgc_maPhieuNhap.ReadOnly = true;
            // 
            // dgc_ngayNhap
            // 
            this.dgc_ngayNhap.DataPropertyName = "TENHCC";
            this.dgc_ngayNhap.HeaderText = "Tên HCC";
            this.dgc_ngayNhap.Name = "dgc_ngayNhap";
            this.dgc_ngayNhap.ReadOnly = true;
            this.dgc_ngayNhap.Width = 170;
            // 
            // dgc_nhanVien
            // 
            this.dgc_nhanVien.DataPropertyName = "DIACHI";
            this.dgc_nhanVien.HeaderText = "Địa Chỉ";
            this.dgc_nhanVien.Name = "dgc_nhanVien";
            this.dgc_nhanVien.ReadOnly = true;
            this.dgc_nhanVien.Width = 300;
            // 
            // frmTraCuuHangCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(698, 429);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewTCNhaCungCap);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTraCuuHangCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu thông tin hãng cung cấp";
            this.Load += new System.EventHandler(this.frmTraCuuHangCungCap_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTCNhaCungCap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_TimMoiNCC;
        private System.Windows.Forms.Button btn_ThoatNCC;
        private System.Windows.Forms.TextBox txtTCMaNCC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTCTenNCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewTCNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgc_maPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgc_ngayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgc_nhanVien;
        private System.Windows.Forms.TextBox txt_diachi;

    }
}