﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimKiemPhongTro.components
{
    public partial class cmt : UserControl
    {
        public cmt()
        {
            InitializeComponent();
        }

        private string _ngdung;
        private string _cmt;
        private Image _image;
        private string _thoigian;
        private string _sdt;

        public string SDT
        {
            get { return _sdt; }
            set { _sdt = value; }
        }

        public string TenNguoiDung
        {
            get { return _ngdung; }
            set { _ngdung = value; lbNgDung.Text = value; }    
        }

        public string CMT
        {
            get { return _cmt; }    
            set { _cmt = value; txtCMT.Text = value; }    
        }

        public Image AVT
        {
            get { return _image; }
            set { _image = value; pictureBox1.Image = value; }
        }

        public string ThoiGian
        {
            get { return _thoigian; }
            set { _thoigian = value; lbThoiGian.Text = value; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($"""https://zalo.me/{SDT}""");
        }

        private void lbNgDung_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($"""https://zalo.me/{SDT}""");
        }
    }
}
