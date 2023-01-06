namespace TimKiemPhongTro.components
{
    partial class DSLichSuYeuThich
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLamTrong = new CustomButton.VBButton();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.White;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(890, 38);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "Danh sách yêu thích";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 58);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(900, 253);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btnLamTrong
            // 
            this.btnLamTrong.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLamTrong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.btnLamTrong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.btnLamTrong.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLamTrong.BorderRadius = 10;
            this.btnLamTrong.BorderSize = 0;
            this.btnLamTrong.FlatAppearance.BorderSize = 0;
            this.btnLamTrong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamTrong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamTrong.ForeColor = System.Drawing.Color.White;
            this.btnLamTrong.Location = new System.Drawing.Point(312, 348);
            this.btnLamTrong.Name = "btnLamTrong";
            this.btnLamTrong.Size = new System.Drawing.Size(274, 40);
            this.btnLamTrong.TabIndex = 5;
            this.btnLamTrong.Text = "Làm trống danh sách";
            this.btnLamTrong.TextColor = System.Drawing.Color.White;
            this.btnLamTrong.UseVisualStyleBackColor = false;
            this.btnLamTrong.Click += new System.EventHandler(this.btnLamTrong_Click);
            // 
            // DSLichSuYeuThich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnLamTrong);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lbTitle);
            this.Name = "DSLichSuYeuThich";
            this.Size = new System.Drawing.Size(900, 403);
            this.Load += new System.EventHandler(this.DSLichSuYeuThich_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CustomButton.VBButton btnLamTrong;
    }
}
