namespace TimKiemPhongTro.components
{
    partial class baidang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbDienTich = new System.Windows.Forms.Label();
            this.lbGiaPhong = new System.Windows.Forms.Label();
            this.rtbMoTa = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnZalo = new CustomButton.VBButton();
            this.btnsdt = new CustomButton.VBButton();
            this.lbTenNguoiDang = new System.Windows.Forms.Label();
            this.ptbUser = new System.Windows.Forms.PictureBox();
            this.ptbAnh = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AllowDrop = true;
            this.lbTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(289, 5);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(438, 53);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "CHO THUÊ PHÒNG TRỌ CHÍNH CHỦ, AN NINH, QUẬN 1";
            this.lbTitle.Click += new System.EventHandler(this.lbTitle_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbDiaChi);
            this.panel1.Controls.Add(this.lbDienTich);
            this.panel1.Controls.Add(this.lbGiaPhong);
            this.panel1.Location = new System.Drawing.Point(293, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 28);
            this.panel1.TabIndex = 2;
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.Location = new System.Drawing.Point(285, 0);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbDiaChi.Size = new System.Drawing.Size(139, 20);
            this.lbDiaChi.TabIndex = 2;
            this.lbDiaChi.Text = "Quận 1, tp.HCM";
            // 
            // lbDienTich
            // 
            this.lbDienTich.AutoSize = true;
            this.lbDienTich.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbDienTich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDienTich.Location = new System.Drawing.Point(115, 0);
            this.lbDienTich.Name = "lbDienTich";
            this.lbDienTich.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbDienTich.Size = new System.Drawing.Size(60, 20);
            this.lbDienTich.TabIndex = 1;
            this.lbDienTich.Text = "20m2";
            // 
            // lbGiaPhong
            // 
            this.lbGiaPhong.AutoSize = true;
            this.lbGiaPhong.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbGiaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(199)))), ((int)(((byte)(132)))));
            this.lbGiaPhong.Location = new System.Drawing.Point(0, 0);
            this.lbGiaPhong.Name = "lbGiaPhong";
            this.lbGiaPhong.Size = new System.Drawing.Size(115, 20);
            this.lbGiaPhong.TabIndex = 0;
            this.lbGiaPhong.Text = "2.7 triệu/tháng";
            // 
            // rtbMoTa
            // 
            this.rtbMoTa.BackColor = System.Drawing.Color.PapayaWhip;
            this.rtbMoTa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMoTa.Location = new System.Drawing.Point(297, 92);
            this.rtbMoTa.Name = "rtbMoTa";
            this.rtbMoTa.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbMoTa.Size = new System.Drawing.Size(420, 122);
            this.rtbMoTa.TabIndex = 3;
            this.rtbMoTa.Text = "Mô tả về phòng cho thuê\nmô tả ít nhất 4 dòng\ncó thể viết trong file txt rồi đọc v" +
    "ào\n";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnZalo);
            this.panel2.Controls.Add(this.btnsdt);
            this.panel2.Controls.Add(this.lbTenNguoiDang);
            this.panel2.Controls.Add(this.ptbUser);
            this.panel2.Location = new System.Drawing.Point(289, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 45);
            this.panel2.TabIndex = 4;
            // 
            // btnZalo
            // 
            this.btnZalo.BackColor = System.Drawing.Color.Transparent;
            this.btnZalo.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnZalo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnZalo.BorderRadius = 10;
            this.btnZalo.BorderSize = 2;
            this.btnZalo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZalo.FlatAppearance.BorderSize = 0;
            this.btnZalo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZalo.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnZalo.Location = new System.Drawing.Point(358, 9);
            this.btnZalo.Name = "btnZalo";
            this.btnZalo.Size = new System.Drawing.Size(70, 30);
            this.btnZalo.TabIndex = 3;
            this.btnZalo.Text = "ZALO\r\n";
            this.btnZalo.TextColor = System.Drawing.Color.MediumSlateBlue;
            this.btnZalo.UseVisualStyleBackColor = false;
            this.btnZalo.MouseHover += new System.EventHandler(this.btnZalo_MouseHover);
            // 
            // btnsdt
            // 
            this.btnsdt.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnsdt.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnsdt.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnsdt.BorderRadius = 10;
            this.btnsdt.BorderSize = 0;
            this.btnsdt.FlatAppearance.BorderSize = 0;
            this.btnsdt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsdt.ForeColor = System.Drawing.Color.White;
            this.btnsdt.Location = new System.Drawing.Point(246, 9);
            this.btnsdt.Name = "btnsdt";
            this.btnsdt.Size = new System.Drawing.Size(106, 30);
            this.btnsdt.TabIndex = 2;
            this.btnsdt.Text = "0384970459";
            this.btnsdt.TextColor = System.Drawing.Color.White;
            this.btnsdt.UseVisualStyleBackColor = false;
            // 
            // lbTenNguoiDang
            // 
            this.lbTenNguoiDang.AutoSize = true;
            this.lbTenNguoiDang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNguoiDang.Location = new System.Drawing.Point(51, 13);
            this.lbTenNguoiDang.Name = "lbTenNguoiDang";
            this.lbTenNguoiDang.Size = new System.Drawing.Size(85, 20);
            this.lbTenNguoiDang.TabIndex = 1;
            this.lbTenNguoiDang.Text = "anhducbui";
            // 
            // ptbUser
            // 
            this.ptbUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptbUser.Image = global::TimKiemPhongTro.Properties.Resources.defaultuser;
            this.ptbUser.Location = new System.Drawing.Point(0, 0);
            this.ptbUser.Name = "ptbUser";
            this.ptbUser.Size = new System.Drawing.Size(45, 45);
            this.ptbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbUser.TabIndex = 0;
            this.ptbUser.TabStop = false;
            // 
            // ptbAnh
            // 
            this.ptbAnh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbAnh.Image = global::TimKiemPhongTro.Properties.Resources.image;
            this.ptbAnh.Location = new System.Drawing.Point(3, 5);
            this.ptbAnh.Name = "ptbAnh";
            this.ptbAnh.Size = new System.Drawing.Size(280, 260);
            this.ptbAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAnh.TabIndex = 0;
            this.ptbAnh.TabStop = false;
            this.ptbAnh.Click += new System.EventHandler(this.ptbAnh_Click);
            // 
            // baidang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.rtbMoTa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.ptbAnh);
            this.Name = "baidang";
            this.Size = new System.Drawing.Size(730, 270);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbAnh;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbDienTich;
        private System.Windows.Forms.Label lbGiaPhong;
        private System.Windows.Forms.RichTextBox rtbMoTa;
        private System.Windows.Forms.Panel panel2;
        private CustomButton.VBButton btnsdt;
        private System.Windows.Forms.Label lbTenNguoiDang;
        private System.Windows.Forms.PictureBox ptbUser;
        private CustomButton.VBButton btnZalo;
    }
}
