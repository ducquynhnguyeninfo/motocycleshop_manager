namespace QL_Cua_Hang_Ban_Xe_May.NguoiDung
{
    partial class N
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(N));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_tennhom = new System.Windows.Forms.TextBox();
            this.txt_manhom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewNguoiDung = new System.Windows.Forms.DataGridView();
            this.MANHOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNHOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_ThoatHH = new System.Windows.Forms.Button();
            this.btn_SuaHH = new System.Windows.Forms.Button();
            this.btn_LuuHH = new System.Windows.Forms.Button();
            this.btn_XoaHH = new System.Windows.Forms.Button();
            this.btn_ThemHH = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNguoiDung)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_tennhom);
            this.groupBox1.Controls.Add(this.txt_manhom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ";
            // 
            // txt_tennhom
            // 
            this.txt_tennhom.Location = new System.Drawing.Point(412, 36);
            this.txt_tennhom.Name = "txt_tennhom";
            this.txt_tennhom.Size = new System.Drawing.Size(196, 20);
            this.txt_tennhom.TabIndex = 34;
            // 
            // txt_manhom
            // 
            this.txt_manhom.Location = new System.Drawing.Point(100, 36);
            this.txt_manhom.Name = "txt_manhom";
            this.txt_manhom.Size = new System.Drawing.Size(196, 20);
            this.txt_manhom.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 32;
            this.label2.Text = "Tên Nhóm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 14);
            this.label1.TabIndex = 33;
            this.label1.Text = "Mã Nhóm";
            // 
            // dataGridViewNguoiDung
            // 
            this.dataGridViewNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANHOM,
            this.TENNHOM});
            this.dataGridViewNguoiDung.Location = new System.Drawing.Point(22, 120);
            this.dataGridViewNguoiDung.Name = "dataGridViewNguoiDung";
            this.dataGridViewNguoiDung.Size = new System.Drawing.Size(634, 133);
            this.dataGridViewNguoiDung.TabIndex = 14;
            this.dataGridViewNguoiDung.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNguoiDung_RowEnter);
            // 
            // MANHOM
            // 
            this.MANHOM.DataPropertyName = "MANHOM";
            this.MANHOM.HeaderText = "Mã Nhóm Người Dùng";
            this.MANHOM.Name = "MANHOM";
            this.MANHOM.ReadOnly = true;
            this.MANHOM.Width = 200;
            // 
            // TENNHOM
            // 
            this.TENNHOM.DataPropertyName = "TENNHOM";
            this.TENNHOM.HeaderText = "Tên Nhóm Người Dùng";
            this.TENNHOM.Name = "TENNHOM";
            this.TENNHOM.ReadOnly = true;
            this.TENNHOM.Width = 392;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_ThoatHH);
            this.groupBox3.Controls.Add(this.btn_SuaHH);
            this.groupBox3.Controls.Add(this.btn_LuuHH);
            this.groupBox3.Controls.Add(this.btn_XoaHH);
            this.groupBox3.Controls.Add(this.btn_ThemHH);
            this.groupBox3.Location = new System.Drawing.Point(22, 262);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(634, 60);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tác vụ";
            // 
            // btn_ThoatHH
            // 
            this.btn_ThoatHH.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThoatHH.Image")));
            this.btn_ThoatHH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThoatHH.Location = new System.Drawing.Point(528, 19);
            this.btn_ThoatHH.Name = "btn_ThoatHH";
            this.btn_ThoatHH.Size = new System.Drawing.Size(80, 27);
            this.btn_ThoatHH.TabIndex = 0;
            this.btn_ThoatHH.Text = "Thoát";
            this.btn_ThoatHH.UseVisualStyleBackColor = false;
            this.btn_ThoatHH.Click += new System.EventHandler(this.btn_ThoatHH_Click);
            // 
            // btn_SuaHH
            // 
            this.btn_SuaHH.Image = ((System.Drawing.Image)(resources.GetObject("btn_SuaHH.Image")));
            this.btn_SuaHH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SuaHH.Location = new System.Drawing.Point(343, 19);
            this.btn_SuaHH.Name = "btn_SuaHH";
            this.btn_SuaHH.Size = new System.Drawing.Size(80, 27);
            this.btn_SuaHH.TabIndex = 0;
            this.btn_SuaHH.Text = "Sửa";
            this.btn_SuaHH.UseVisualStyleBackColor = false;
            this.btn_SuaHH.Click += new System.EventHandler(this.btn_SuaHH_Click);
            // 
            // btn_LuuHH
            // 
            this.btn_LuuHH.Image = ((System.Drawing.Image)(resources.GetObject("btn_LuuHH.Image")));
            this.btn_LuuHH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LuuHH.Location = new System.Drawing.Point(435, 19);
            this.btn_LuuHH.Name = "btn_LuuHH";
            this.btn_LuuHH.Size = new System.Drawing.Size(80, 27);
            this.btn_LuuHH.TabIndex = 0;
            this.btn_LuuHH.Text = "Lưu";
            this.btn_LuuHH.UseVisualStyleBackColor = false;
            this.btn_LuuHH.Click += new System.EventHandler(this.btn_LuuHH_Click);
            // 
            // btn_XoaHH
            // 
            this.btn_XoaHH.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaHH.Image")));
            this.btn_XoaHH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaHH.Location = new System.Drawing.Point(250, 19);
            this.btn_XoaHH.Name = "btn_XoaHH";
            this.btn_XoaHH.Size = new System.Drawing.Size(80, 27);
            this.btn_XoaHH.TabIndex = 0;
            this.btn_XoaHH.Text = "Xóa";
            this.btn_XoaHH.UseVisualStyleBackColor = false;
            this.btn_XoaHH.Click += new System.EventHandler(this.btn_XoaHH_Click);
            // 
            // btn_ThemHH
            // 
            this.btn_ThemHH.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemHH.Image")));
            this.btn_ThemHH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThemHH.Location = new System.Drawing.Point(157, 19);
            this.btn_ThemHH.Name = "btn_ThemHH";
            this.btn_ThemHH.Size = new System.Drawing.Size(80, 27);
            this.btn_ThemHH.TabIndex = 0;
            this.btn_ThemHH.Text = "Thêm";
            this.btn_ThemHH.UseVisualStyleBackColor = false;
            this.btn_ThemHH.Click += new System.EventHandler(this.btn_ThemHH_Click);
            // 
            // N
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(678, 338);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridViewNguoiDung);
            this.Controls.Add(this.groupBox1);
            this.Name = "N";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhóm người dùng";
            this.Load += new System.EventHandler(this.frmNhomNguoiDung_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNguoiDung)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_tennhom;
        private System.Windows.Forms.TextBox txt_manhom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewNguoiDung;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_ThoatHH;
        private System.Windows.Forms.Button btn_SuaHH;
        private System.Windows.Forms.Button btn_LuuHH;
        private System.Windows.Forms.Button btn_XoaHH;
        private System.Windows.Forms.Button btn_ThemHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANHOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNHOM;
    }
}