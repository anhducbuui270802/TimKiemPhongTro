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
    public partial class DanhSachTinDang : UserControl
    {
        public DanhSachTinDang()
        {
            InitializeComponent();

            for(int i = 0; i < 5; i++)
            {
                baidang bd = new baidang();
                bd.Title = "Bai dang thu " + i.ToString();
                bd.GiaPhong = "2";
                bd.DienTich = "20m2";
                //bd.DiaChi = "KTX khu B, Phường Linh Trung, Thành Phố Thủ Đức";
                bd.SDT = "01628907601";
                bd.ImgNguoiDung = Image.FromFile("resource\\icon\\defaultuser.jpeg");
                bd.ImgPhong = Image.FromFile("resource\\icon\\image.png");
                flowLayoutPanel1.Controls.Add(bd);  
            }

            flowLayoutPanel1.Height = 270 * 5 + 50;
            this.Height = flowLayoutPanel1.Height + 150;
        }
    }
}
