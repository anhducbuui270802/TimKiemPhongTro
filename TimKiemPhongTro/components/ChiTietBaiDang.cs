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
    public partial class ChiTietBaiDang : UserControl
    {
        public ChiTietBaiDang()
        {
            InitializeComponent();
        }

        public ChiTietBaiDang(baidang bd) : this ()
        {
            ptbHinhAnh.Image = bd.ImgPhong;
            lbTitle.Text = bd.Title;
            lbDiaChi.Text = bd.DiaChiChinhXac;
            lbGiaPhong.Text = bd.GiaPhong + " triệu/tháng";  
            lbDienTich.Text = bd.DienTich;
            lbThoiGian.Text = bd.ThoiGian;
            txtThongTinMoTa.Text = bd.MoTa;
            txtNguoiDang.Text = bd.TenNguoiDung;
            txtSDT.Text = bd.SDT;
            webBrowser.Navigate($"""https://google.com/maps?q={function.LocDau(lbDiaChi.Text)}""");
        }
    }
}
