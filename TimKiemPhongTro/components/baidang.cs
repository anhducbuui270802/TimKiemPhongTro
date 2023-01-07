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
        private string _diachichinhxac;
        private string _thoigian;
        private string _tennguoidung;
        private string _mota;
        private string _sdt;
        private Image _img;
        private Image _imguser;
        private string _iduser;
        private string _idbai;



        [Category("Custom Props")]
        public string IDBai
        {
            get { return _idbai; }
            set { _idbai = value; }
        }

        [Category("Custom Props")]
        public string IDNguoiDang
        {
            get { return _iduser; }
            set { _iduser = value;}
        }

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

        [Category("Custom Props")]
        public string ThoiGian
        {
            get { return _thoigian; }
            set { _thoigian = value; }
        }

        [Category("Custom Props")]
        public string DiaChiChinhXac
        {
            get { return _diachichinhxac; }
            set { _diachichinhxac = value; }
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
            if (Var.user.ID != null)
            {
                string temp = sql.GetFieldValues(
                    $"""
                    select IdBai from LICHSU where IdBai = '{this.IDBai}' and IdNguoiDung = '{Var.user.ID}'
                    """
                    );
                if (temp != "")
                {
                    sql.RunSQL(
                        $"""
                        update LICHSU set ThoiGian = '{DateTime.Now.ToString()}' 
                        where IdBai = '{this.IDBai}' and IdNguoiDung = '{Var.user.ID}'
                        """
                        );
                }
                else
                {
                    sql.RunSQL(
                        $"""
                        insert into LICHSU values ('{this.IDBai}', '{Var.user.ID}','{DateTime.Now.ToString()}')
                        """
                        );
                }
            }
            var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
            trangchu.HienThiChiTiet(this);
        }

        private void lbTitle_Click(object sender, EventArgs e)
        {
           ptbAnh_Click(sender, e);
        }

        private void btnZalo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($"""https://zalo.me/{SDT}""");

        }
    }
}
