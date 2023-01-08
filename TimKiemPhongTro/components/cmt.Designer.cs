namespace TimKiemPhongTro.components
{
    partial class cmt
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
            this.txtCMT = new System.Windows.Forms.RichTextBox();
            this.lbNgDung = new System.Windows.Forms.Label();
            this.lbThoiGian = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCMT
            // 
            this.txtCMT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCMT.Location = new System.Drawing.Point(49, 22);
            this.txtCMT.Name = "txtCMT";
            this.txtCMT.ReadOnly = true;
            this.txtCMT.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtCMT.Size = new System.Drawing.Size(295, 76);
            this.txtCMT.TabIndex = 1;
            this.txtCMT.Text = "";
            // 
            // lbNgDung
            // 
            this.lbNgDung.AutoSize = true;
            this.lbNgDung.Location = new System.Drawing.Point(49, 3);
            this.lbNgDung.Name = "lbNgDung";
            this.lbNgDung.Size = new System.Drawing.Size(69, 16);
            this.lbNgDung.TabIndex = 2;
            this.lbNgDung.Text = "anhducbui";
            this.lbNgDung.Click += new System.EventHandler(this.lbNgDung_Click);
            // 
            // lbThoiGian
            // 
            this.lbThoiGian.AutoSize = true;
            this.lbThoiGian.Location = new System.Drawing.Point(167, 101);
            this.lbThoiGian.Name = "lbThoiGian";
            this.lbThoiGian.Size = new System.Drawing.Size(69, 16);
            this.lbThoiGian.TabIndex = 3;
            this.lbThoiGian.Text = "anhducbui";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TimKiemPhongTro.Properties.Resources.defaultuser;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbThoiGian);
            this.Controls.Add(this.lbNgDung);
            this.Controls.Add(this.txtCMT);
            this.Controls.Add(this.pictureBox1);
            this.Name = "cmt";
            this.Size = new System.Drawing.Size(355, 120);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox txtCMT;
        private System.Windows.Forms.Label lbNgDung;
        private System.Windows.Forms.Label lbThoiGian;
    }
}
