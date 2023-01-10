namespace TimKiemPhongTro.components
{
    partial class searchbar
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
            this.cbLoaiBDS = new System.Windows.Forms.ComboBox();
            this.cbTinh = new System.Windows.Forms.ComboBox();
            this.cbGia = new System.Windows.Forms.ComboBox();
            this.cbDienTich = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new CustomButton.VBButton();
            this.SuspendLayout();
            // 
            // cbLoaiBDS
            // 
            this.cbLoaiBDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiBDS.ForeColor = System.Drawing.Color.DimGray;
            this.cbLoaiBDS.FormattingEnabled = true;
            this.cbLoaiBDS.Items.AddRange(new object[] {
            "Phòng trọ, nhà trọ",
            "Nhà thuê nguyên căn",
            "Cho thuê căn hộ",
            "Cho thuê căn hộ mini",
            "Cho thuê căn hộ dịch vụ",
            "Tìm người ở ghép",
            "Cho thuê mặt bằng"});
            this.cbLoaiBDS.Location = new System.Drawing.Point(16, 10);
            this.cbLoaiBDS.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.cbLoaiBDS.Name = "cbLoaiBDS";
            this.cbLoaiBDS.Size = new System.Drawing.Size(210, 28);
            this.cbLoaiBDS.TabIndex = 0;
            this.cbLoaiBDS.TabStop = false;
            this.cbLoaiBDS.Text = "Chọn loại bất động sản";
            // 
            // cbTinh
            // 
            this.cbTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTinh.ForeColor = System.Drawing.Color.DimGray;
            this.cbTinh.FormattingEnabled = true;
            this.cbTinh.Location = new System.Drawing.Point(239, 10);
            this.cbTinh.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.cbTinh.Name = "cbTinh";
            this.cbTinh.Size = new System.Drawing.Size(210, 28);
            this.cbTinh.TabIndex = 1;
            this.cbTinh.TabStop = false;
            this.cbTinh.Text = "Chọn địa chỉ";
            this.cbTinh.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbTinh_MouseClick);
            // 
            // cbGia
            // 
            this.cbGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGia.ForeColor = System.Drawing.Color.DimGray;
            this.cbGia.FormattingEnabled = true;
            this.cbGia.Items.AddRange(new object[] {
            "Dưới 1 triệu đồng",
            "Từ 1 - 2 triệu",
            "Từ 2 - 3 triệu ",
            "Từ 3 - 5 triệu ",
            "Từ 5 - 7 triệu ",
            "Từ 7 - 10 triệu ",
            "Từ 10 - 15 triệu",
            "Trên 15 triệu"});
            this.cbGia.Location = new System.Drawing.Point(462, 10);
            this.cbGia.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.cbGia.Name = "cbGia";
            this.cbGia.Size = new System.Drawing.Size(210, 28);
            this.cbGia.TabIndex = 2;
            this.cbGia.TabStop = false;
            this.cbGia.Text = "Chọn giá";
            // 
            // cbDienTich
            // 
            this.cbDienTich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDienTich.ForeColor = System.Drawing.Color.DimGray;
            this.cbDienTich.FormattingEnabled = true;
            this.cbDienTich.Items.AddRange(new object[] {
            "Dưới 20 m2",
            "Từ 20 - 30 m2",
            "Từ 30 - 50 m2",
            "Từ 50 - 70 m2",
            "Từ 70 - 90 m2",
            "Trên 90 m2"});
            this.cbDienTich.Location = new System.Drawing.Point(685, 10);
            this.cbDienTich.Name = "cbDienTich";
            this.cbDienTich.Size = new System.Drawing.Size(210, 28);
            this.cbDienTich.TabIndex = 3;
            this.cbDienTich.TabStop = false;
            this.cbDienTich.Text = "Chọn diện tích";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnTimKiem.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnTimKiem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTimKiem.BorderRadius = 5;
            this.btnTimKiem.BorderSize = 0;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(925, 10);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(190, 30);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "🔍Tìm kiếm";
            this.btnTimKiem.TextColor = System.Drawing.Color.White;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // searchbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(187)))), ((int)(((byte)(2)))));
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.cbDienTich);
            this.Controls.Add(this.cbGia);
            this.Controls.Add(this.cbTinh);
            this.Controls.Add(this.cbLoaiBDS);
            this.Name = "searchbar";
            this.Size = new System.Drawing.Size(1138, 52);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLoaiBDS;
        private System.Windows.Forms.ComboBox cbTinh;
        private System.Windows.Forms.ComboBox cbGia;
        private System.Windows.Forms.ComboBox cbDienTich;
        private CustomButton.VBButton btnTimKiem;
    }
}
