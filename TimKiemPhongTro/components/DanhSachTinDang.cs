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
                bd.DiaChiChinhXac = dr["SoNha"].ToString() + ", " + dr["Pho"].ToString() + ", " + dr["Phuong"].ToString() + ", " + dr["Quan"].ToString() + ", " + dr["Tinh"].ToString();
                bd.ThoiGian = dr["ThoiGianDang"].ToString();
                flowLayoutPanel1.Controls.Add(bd);

            }

            flowLayoutPanel1.Height = 270 * 5 + 50;
            this.Height = flowLayoutPanel1.Height + 150;
        }
    }
}
