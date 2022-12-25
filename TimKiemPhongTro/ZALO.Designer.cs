namespace TimKiemPhongTro
{
    partial class ZALO
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
            this.lbTenNguoiDung = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.QR = new System.Windows.Forms.PictureBox();
            this.avt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.QR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avt)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTenNguoiDung
            // 
            this.lbTenNguoiDung.AutoSize = true;
            this.lbTenNguoiDung.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNguoiDung.Location = new System.Drawing.Point(252, 47);
            this.lbTenNguoiDung.Name = "lbTenNguoiDung";
            this.lbTenNguoiDung.Size = new System.Drawing.Size(197, 49);
            this.lbTenNguoiDung.TabIndex = 1;
            this.lbTenNguoiDung.Text = "Anhducbui";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(657, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mở Zalo, bấm quét QR để quét và xem trên điện thoại";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QR
            // 
            this.QR.Image = global::TimKiemPhongTro.Properties.Resources.qrzalo;
            this.QR.Location = new System.Drawing.Point(657, 47);
            this.QR.Name = "QR";
            this.QR.Size = new System.Drawing.Size(200, 200);
            this.QR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.QR.TabIndex = 2;
            this.QR.TabStop = false;
            // 
            // avt
            // 
            this.avt.Image = global::TimKiemPhongTro.Properties.Resources.defaultuser;
            this.avt.Location = new System.Drawing.Point(46, 47);
            this.avt.Name = "avt";
            this.avt.Size = new System.Drawing.Size(200, 200);
            this.avt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avt.TabIndex = 0;
            this.avt.TabStop = false;
            // 
            // ZALO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 325);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QR);
            this.Controls.Add(this.lbTenNguoiDung);
            this.Controls.Add(this.avt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ZALO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Người dùng";
            ((System.ComponentModel.ISupportInitialize)(this.QR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox avt;
        private System.Windows.Forms.Label lbTenNguoiDung;
        private System.Windows.Forms.PictureBox QR;
        private System.Windows.Forms.Label label1;
    }
}