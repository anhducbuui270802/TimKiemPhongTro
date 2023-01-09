namespace TimKiemPhongTro.components
{
    partial class binhluan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCMT = new System.Windows.Forms.RichTextBox();
            this.ptbSend = new System.Windows.Forms.PictureBox();
            this.ptbAvt = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvt)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.txtCMT);
            this.panel1.Controls.Add(this.ptbSend);
            this.panel1.Controls.Add(this.ptbAvt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 75);
            this.panel1.TabIndex = 0;
            // 
            // txtCMT
            // 
            this.txtCMT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCMT.Location = new System.Drawing.Point(49, 2);
            this.txtCMT.Name = "txtCMT";
            this.txtCMT.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtCMT.Size = new System.Drawing.Size(257, 70);
            this.txtCMT.TabIndex = 2;
            this.txtCMT.Text = "";
            // 
            // ptbSend
            // 
            this.ptbSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbSend.Image = global::TimKiemPhongTro.Properties.Resources.send_message;
            this.ptbSend.Location = new System.Drawing.Point(312, 3);
            this.ptbSend.Name = "ptbSend";
            this.ptbSend.Padding = new System.Windows.Forms.Padding(5);
            this.ptbSend.Size = new System.Drawing.Size(40, 40);
            this.ptbSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSend.TabIndex = 1;
            this.ptbSend.TabStop = false;
            this.ptbSend.Click += new System.EventHandler(this.ptbSend_Click);
            // 
            // ptbAvt
            // 
            this.ptbAvt.Image = global::TimKiemPhongTro.Properties.Resources.defaultuser;
            this.ptbAvt.Location = new System.Drawing.Point(3, 3);
            this.ptbAvt.Name = "ptbAvt";
            this.ptbAvt.Size = new System.Drawing.Size(40, 40);
            this.ptbAvt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAvt.TabIndex = 0;
            this.ptbAvt.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(187)))), ((int)(((byte)(2)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label1.Location = new System.Drawing.Point(0, 10);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label1.Size = new System.Drawing.Size(355, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bình luận";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(187)))), ((int)(((byte)(2)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 133);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(355, 494);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 10);
            this.panel2.TabIndex = 3;
            // 
            // binhluan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(187)))), ((int)(((byte)(2)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.Name = "binhluan";
            this.Size = new System.Drawing.Size(355, 630);
            this.Load += new System.EventHandler(this.binhluan_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtCMT;
        private System.Windows.Forms.PictureBox ptbSend;
        private System.Windows.Forms.PictureBox ptbAvt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
    }
}
