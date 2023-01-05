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
        public static DataTable dt = new DataTable();

        public DanhSachTinDang()
        {

            InitializeComponent();

            //for (int i = 0; i < 5; i++)
            //{
            //    baidang bd = new baidang();
            //    //bd.Title = "Bai dang thu " + i.ToString();
            //    //bd.GiaPhong = "2";
            //    //bd.DienTich = "20m2";
            //    //bd.DiaChi = "KTX khu B, Phường Linh Trung, Thành Phố Thủ Đức";
            //    //bd.SDT = "01628907601";
            //    //bd.ImgNguoiDung = Image.FromFile("resource\\icon\\defaultuser.jpeg");
            //    //bd.ImgPhong = Image.FromFile("resource\\icon\\image.png");
            //    flowLayoutPanel1.Controls.Add(bd);
            //}

            dt = sql.GetDataToTable("select * from BAIDANG");
            foreach (DataRow dr in dt.Rows)
            {
                baidang bd = new baidang();
                bd.Title = dr["TieuDe"].ToString().ToUpper();
                bd.GiaPhong = dr["GiaPhong"].ToString();
                bd.DienTich = dr["DienTich"].ToString() + "m2";
                bd.DiaChi = dr["Quan"].ToString() + ", " + dr["Tinh"].ToString();
                bd.MoTa = dr["MoTa"].ToString();
                bd.ImgPhong = Image.FromFile(dr["HinhAnh"].ToString());
                bd.TenNguoiDung = dr["IdNguoiDang"].ToString();
                string id = dr["IdNguoiDang"].ToString();
                bd.TenNguoiDung = sql.GetFieldValues("select HoTen from NGUOIDUNG where IdNguoiDung = '" + id + "'");
                bd.ImgNguoiDung = Image.FromFile(sql.GetFieldValues("select Avt from NGUOIDUNG where IdNguoiDung = '" + id + "'"));
                bd.SDT = sql.GetFieldValues("select SDT from NGUOIDUNG where IdNguoiDung = '" + id + "'");
                flowLayoutPanel1.Controls.Add(bd);

            }

            flowLayoutPanel1.Height = 270 * 5 + 50;
            this.Height = flowLayoutPanel1.Height + 150;
        }
    }
}
