namespace QL_Cua_Hang_Ban_Xe_May
{
    partial class frmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMatKhau));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.matkhaunew2 = new System.Windows.Forms.TextBox();
            this.matkhaunew1 = new System.Windows.Forms.TextBox();
            this.matkhauold = new System.Windows.Forms.TextBox();
            this.ten_dnhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ngung = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.luu_mkhau = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.matkhaunew2);
            this.groupBox1.Controls.Add(this.matkhaunew1);
            this.groupBox1.Controls.Add(this.matkhauold);
            this.groupBox1.Controls.Add(this.ten_dnhap);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(17, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 220);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xác nhận thông tin";
            // 
            // matkhaunew2
            // 
            this.matkhaunew2.Location = new System.Drawing.Point(201, 157);
            this.matkhaunew2.Name = "matkhaunew2";
            this.matkhaunew2.Size = new System.Drawing.Size(253, 20);
            this.matkhaunew2.TabIndex = 4;
            this.matkhaunew2.UseSystemPasswordChar = true;
            // 
            // matkhaunew1
            // 
            this.matkhaunew1.Location = new System.Drawing.Point(201, 121);
            this.matkhaunew1.Name = "matkhaunew1";
            this.matkhaunew1.Size = new System.Drawing.Size(253, 20);
            this.matkhaunew1.TabIndex = 3;
            this.matkhaunew1.UseSystemPasswordChar = true;
            // 
            // matkhauold
            // 
            this.matkhauold.Location = new System.Drawing.Point(201, 85);
            this.matkhauold.Name = "matkhauold";
            this.matkhauold.Size = new System.Drawing.Size(253, 20);
            this.matkhauold.TabIndex = 2;
            this.matkhauold.UseSystemPasswordChar = true;
            // 
            // ten_dnhap
            // 
            this.ten_dnhap.Location = new System.Drawing.Point(201, 43);
            this.ten_dnhap.Name = "ten_dnhap";
            this.ten_dnhap.Size = new System.Drawing.Size(253, 20);
            this.ten_dnhap.TabIndex = 4;
            this.ten_dnhap.Tag = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gõ lại mật khẩu mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu hiện tại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu mới";
            // 
            // ngung
            // 
            this.ngung.Image = ((System.Drawing.Image)(resources.GetObject("ngung.Image")));
            this.ngung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ngung.Location = new System.Drawing.Point(187, 24);
            this.ngung.Name = "ngung";
            this.ngung.Size = new System.Drawing.Size(84, 27);
            this.ngung.TabIndex = 5;
            this.ngung.Text = "Quay lại";
            this.ngung.UseVisualStyleBackColor = false;
            this.ngung.Click += new System.EventHandler(this.ngung_Click);
            // 
            // thoat
            // 
            this.thoat.Image = ((System.Drawing.Image)(resources.GetObject("thoat.Image")));
            this.thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.thoat.Location = new System.Drawing.Point(378, 24);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(80, 27);
            this.thoat.TabIndex = 7;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = false;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // luu_mkhau
            // 
            this.luu_mkhau.Image = ((System.Drawing.Image)(resources.GetObject("luu_mkhau.Image")));
            this.luu_mkhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.luu_mkhau.Location = new System.Drawing.Point(285, 24);
            this.luu_mkhau.Name = "luu_mkhau";
            this.luu_mkhau.Size = new System.Drawing.Size(80, 27);
            this.luu_mkhau.TabIndex = 6;
            this.luu_mkhau.Text = "Lưu";
            this.luu_mkhau.UseVisualStyleBackColor = false;
            this.luu_mkhau.Click += new System.EventHandler(this.luu_mkhau_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ngung);
            this.groupBox2.Controls.Add(this.luu_mkhau);
            this.groupBox2.Controls.Add(this.thoat);
            this.groupBox2.Location = new System.Drawing.Point(17, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 68);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tác vụ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(519, 326);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu ";
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Button luu_mkhau;
        private System.Windows.Forms.TextBox matkhaunew2;
        private System.Windows.Forms.TextBox matkhaunew1;
        private System.Windows.Forms.TextBox matkhauold;
        private System.Windows.Forms.TextBox ten_dnhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ngung;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}