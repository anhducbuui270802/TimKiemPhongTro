﻿namespace TimKiemPhongTro
{
    partial class DangNhap
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vbButton1 = new CustomButton.VBButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TimKiemPhongTro.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(131, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.ForeColor = System.Drawing.Color.DimGray;
            this.txtTenDangNhap.Location = new System.Drawing.Point(79, 217);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(245, 28);
            this.txtTenDangNhap.TabIndex = 1;
            // 
            // txtMK
            // 
            this.txtMK.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.ForeColor = System.Drawing.Color.DimGray;
            this.txtMK.Location = new System.Drawing.Point(79, 286);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(245, 28);
            this.txtMK.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(76, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(76, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu";
            // 
            // vbButton1
            // 
            this.vbButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.vbButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.vbButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton1.BorderRadius = 10;
            this.vbButton1.BorderSize = 0;
            this.vbButton1.FlatAppearance.BorderSize = 0;
            this.vbButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbButton1.ForeColor = System.Drawing.Color.White;
            this.vbButton1.Location = new System.Drawing.Point(131, 378);
            this.vbButton1.Name = "vbButton1";
            this.vbButton1.Size = new System.Drawing.Size(150, 40);
            this.vbButton1.TabIndex = 5;
            this.vbButton1.Text = "Đăng nhập";
            this.vbButton1.TextColor = System.Drawing.Color.White;
            this.vbButton1.UseVisualStyleBackColor = false;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 454);
            this.Controls.Add(this.vbButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhap";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CustomButton.VBButton vbButton1;
    }
}