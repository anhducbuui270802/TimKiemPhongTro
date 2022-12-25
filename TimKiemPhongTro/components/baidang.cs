using System;
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
    public partial class baidang : UserControl
    {
        public baidang()
        {
            InitializeComponent();
        }

        private string _title;
        private string _giaphong;
        private string _dientich;
        private string _diachi;
        private string _tennguoidung;
        private string _mota;
        private string _sdt;
        private Image _img;
        private Image _imguser;


        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lbTitle.Text = value; }
        }

        [Category("Custom Props")]
        public string GiaPhong
        {
            get { return _giaphong; }
            set { _giaphong = value; lbGiaPhong.Text = value + " triệu/tháng"; }
        }

        [Category("Custom Props")]
        public string DienTich
        {
            get { return _dientich; }
            set { _dientich = value; lbDienTich.Text = value; }
        }

        [Category("Custom Props")]
        public string DiaChi
        {
            get { return _diachi; }
            set { _diachi = value; lbDiaChi.Text = value; }
        }

        [Category("Custom Props")]
        public string MoTa
        {
            get { return _mota; }
            set { _mota = value; rtbMoTa.Text = value; }
        }

        [Category("Custom Props")]
        public string TenNguoiDung
        {
            get { return _tennguoidung; }
            set { _tennguoidung = value; lbTenNguoiDang.Text = value; }
        }

        [Category("Custom Props")]
        public Image ImgPhong
        {
            get { return _img; }
            set { _img = value; ptbAnh.Image = value; }
        }

        [Category("Custom Props")]
        public Image ImgNguoiDung
        {
            get { return _imguser; }
            set { _imguser = value; ptbUser.Image = value; }
        }


        [Category("Custom Props")]
        public string SDT
        {
            get { return _sdt; }
            set { _sdt = value; btnsdt.Text = value; }
        }



        private void btnZalo_MouseHover(object sender, EventArgs e)
        {
            btnZalo.BackColor = Color.MediumSlateBlue;
            btnZalo.ForeColor = Color.White;
        }

        private void btnZalo_MouseLeave(object sender, EventArgs e)
        {
            btnZalo.BackColor = Color.White;
            btnZalo.ForeColor = Color.MediumSlateBlue;
        }

        private void ptbAnh_Click(object sender, EventArgs e)
        {
            var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
            trangchu.HienThiChiTiet();
        }

        private void lbTitle_Click(object sender, EventArgs e)
        {
            var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
            trangchu.HienThiChiTiet();
        }

        private void btnZalo_Click(object sender, EventArgs e)
        {
            ZALO zl = new ZALO();
            zl.ShowDialog();
        }
    }
}
