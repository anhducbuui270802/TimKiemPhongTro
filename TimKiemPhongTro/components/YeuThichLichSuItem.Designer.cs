namespace TimKiemPhongTro.components
{
    partial class YeuThichLichSuItem
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
            this.lbThoiGian = new System.Windows.Forms.Label();
            this.ptbDelete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // lbThoiGian
            // 
            this.lbThoiGian.AllowDrop = true;
            this.lbThoiGian.Location = new System.Drawing.Point(736, 18);
            this.lbThoiGian.Margin = new System.Windows.Forms.Padding(3, 40, 3, 0);
            this.lbThoiGian.Name = "lbThoiGian";
            this.lbThoiGian.Size = new System.Drawing.Size(144, 54);
            this.lbThoiGian.TabIndex = 1;
            this.lbThoiGian.Text = "12:12:12pm  27/12/2022";
            // 
            // ptbDelete
            // 
            this.ptbDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbDelete.Image = global::TimKiemPhongTro.Properties.Resources.delete;
            this.ptbDelete.Location = new System.Drawing.Point(739, 75);
            this.ptbDelete.Name = "ptbDelete";
            this.ptbDelete.Size = new System.Drawing.Size(70, 70);
            this.ptbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbDelete.TabIndex = 2;
            this.ptbDelete.TabStop = false;
            this.ptbDelete.Click += new System.EventHandler(this.ptbDelete_Click);
            // 
            // YeuThichLichSuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.ptbDelete);
            this.Controls.Add(this.lbThoiGian);
            this.Name = "YeuThichLichSuItem";
            this.Size = new System.Drawing.Size(896, 270);
            ((System.ComponentModel.ISupportInitialize)(this.ptbDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbThoiGian;
        private System.Windows.Forms.PictureBox ptbDelete;
    }
}
