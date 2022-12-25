namespace TimKiemPhongTro.components
{
    partial class DanhSachTinDang
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
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMoiNhat = new CustomButton.VBButton();
            this.btnMacDinh = new CustomButton.VBButton();
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
            this.lbTitle.Size = new System.Drawing.Size(730, 38);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Danh sách tin đăng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sắp xếp: ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 90);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(754, 200);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // btnMoiNhat
            // 
            this.btnMoiNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnMoiNhat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnMoiNhat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMoiNhat.BorderRadius = 10;
            this.btnMoiNhat.BorderSize = 0;
            this.btnMoiNhat.FlatAppearance.BorderSize = 0;
            this.btnMoiNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoiNhat.ForeColor = System.Drawing.Color.Black;
            this.btnMoiNhat.Location = new System.Drawing.Point(181, 41);
            this.btnMoiNhat.Name = "btnMoiNhat";
            this.btnMoiNhat.Size = new System.Drawing.Size(80, 30);
            this.btnMoiNhat.TabIndex = 5;
            this.btnMoiNhat.Text = "Mới nhất";
            this.btnMoiNhat.TextColor = System.Drawing.Color.Black;
            this.btnMoiNhat.UseVisualStyleBackColor = false;
            // 
            // btnMacDinh
            // 
            this.btnMacDinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnMacDinh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnMacDinh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMacDinh.BorderRadius = 10;
            this.btnMacDinh.BorderSize = 0;
            this.btnMacDinh.FlatAppearance.BorderSize = 0;
            this.btnMacDinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMacDinh.ForeColor = System.Drawing.Color.Black;
            this.btnMacDinh.Location = new System.Drawing.Point(85, 41);
            this.btnMacDinh.Name = "btnMacDinh";
            this.btnMacDinh.Size = new System.Drawing.Size(80, 30);
            this.btnMacDinh.TabIndex = 4;
            this.btnMacDinh.Text = "Mặc định";
            this.btnMacDinh.TextColor = System.Drawing.Color.Black;
            this.btnMacDinh.UseVisualStyleBackColor = false;
            // 
            // DanhSachTinDang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnMoiNhat);
            this.Controls.Add(this.btnMacDinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTitle);
            this.Name = "DanhSachTinDang";
            this.Size = new System.Drawing.Size(757, 293);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label label2;
        private CustomButton.VBButton btnMacDinh;
        private CustomButton.VBButton btnMoiNhat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
