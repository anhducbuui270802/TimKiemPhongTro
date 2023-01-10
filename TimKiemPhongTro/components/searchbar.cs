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
    public partial class searchbar : UserControl
    {
        public searchbar()
        {
            InitializeComponent();
        }

        public static string loaibds, tinh, quan, phuong, gia, dientich;
        public static StringBuilder diachi = new StringBuilder();
        
        public static bool flag = false;

        private void cbTinh_MouseClick(object sender, MouseEventArgs e)
        {
            ChonDiaChi chonDiaChi = new ChonDiaChi();
            chonDiaChi.ShowDialog();
        }

        private void query_search()
        {

            if (cbLoaiBDS.Text == "Chọn loại bất động sản")
            { loaibds = ""; }
            else
            {
                loaibds = "LoaiBDS = N'" + cbLoaiBDS.Text + "' and";
                flag = true;
            }

            if (cbGia.Text == "Chọn giá")
            { gia = ""; }
            else
            {
                switch (cbGia.SelectedIndex)
                {
                    case 0:
                        gia = "GiaPhong <= 1";
                        break;
                    case 1:
                        gia = "GiaPhong >= 1 and GiaPhong <= 2 and";
                        break;
                    case 2:
                        gia = "GiaPhong >= 2 and GiaPhong <= 3 and";
                        break;
                    case 3:
                        gia = "GiaPhong >= 3 and GiaPhong <= 5 and";
                        break;
                    case 4:
                        gia = "GiaPhong >= 5 and GiaPhong <= 7 and";
                        break;
                    case 5:
                        gia = "GiaPhong >= 7 and GiaPhong <= 10 and";
                        break;
                    case 6:
                        gia = "GiaPhong >= 10 and GiaPhong <= 15 and";
                        break;
                    case 7:
                        gia = "GiaPhong >= 15 and";
                        break;
                    default:
                        gia = $"""GiaPhong >= {int.Parse(cbGia.Text) - 10} and GiaPhong <= {int.Parse(cbGia.Text) + 10} and""";
                        break;
                }
                flag = true;
            }

            if (cbDienTich.Text == "Chọn diện tích")
            { dientich = ""; }
            else
            {
                switch (cbDienTich.SelectedIndex)
                {
                    case 0:
                        dientich = "DienTich <= 20 and";
                        break;
                    case 1:
                        dientich = "DienTich >= 20 and DienTich <= 30 and";
                        break;
                    case 2:
                        dientich = "DienTich >= 30 and DienTich <= 50 and";
                        break;
                    case 3:
                        dientich = "DienTich >= 50 and DienTich <= 70 and";
                        break;
                    case 4:
                        dientich = "DienTich >= 70 and DienTich <= 90 and";
                        break;
                    case 5:
                        dientich = "DienTich >= 90 and";
                        break;
                    default:
                        dientich = $"""DienTich >= {float.Parse(cbDienTich.Text) - 10} and DienTich <= {float.Parse(cbDienTich.Text) + 10} and""";
                        break;
                }
                flag = true;
            }
        }

        public static DataTable search()
        {
            if (flag)
            {
                string sql_statement =
                $"""
                select * from BAIDANG where {loaibds} {tinh} {quan} {phuong} {gia} {dientich} TrangThai = 1
                """;
                DanhSachTinDang.dt = sql.GetDataToTable(sql_statement);
            }
            else
            {
                string sql_statement =
                $"""
                select * from BAIDANG where TrangThai = 1
                """;
                DanhSachTinDang.dt = sql.GetDataToTable(sql_statement);
            }
            return DanhSachTinDang.dt;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            query_search();
            var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
            trangchu.LoadDanhSach(search());
        }

        public static void setgia(int index)
        {
            switch (index)
            {
                case 0:
                    gia = "GiaPhong <= 1 and";
                    break;
                case 1:
                    gia = "GiaPhong >= 1 and GiaPhong <= 2 and";
                    break;
                case 2:
                    gia = "GiaPhong >= 2 and GiaPhong <= 3 and";
                    break;
                case 3:
                    gia = "GiaPhong >= 3 and GiaPhong <= 5 and";
                    break;
                case 4:
                    gia = "GiaPhong >= 5 and GiaPhong <= 7 and";
                    break;
                case 5:
                    gia = "GiaPhong >= 7 and GiaPhong <= 10 and";
                    break;
                case 6:
                    gia = "GiaPhong >= 10 and GiaPhong <= 15 and";
                    break;
                case 7:
                    gia = "GiaPhong >= 15 and";
                    break;
               
            }
            flag = true;
            var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
            trangchu.LoadDanhSach(search());
        }

        public static void setdientich(int index)
        {

            switch (index)
            {
                case 0:
                    dientich = "DienTich <= 20 and";
                    break;
                case 1:
                    dientich = "DienTich >= 20 and DienTich <= 30 and";
                    break;
                case 2:
                    dientich = "DienTich >= 30 and DienTich <= 50 and";
                    break;
                case 3:
                    dientich = "DienTich >= 50 and DienTich <= 70 and";
                    break;
                case 4:
                    dientich = "DienTich >= 70 and DienTich <= 90 and";
                    break;
                case 5:
                    dientich = "DienTich >= 90 and";
                    break;
            }
            flag = true;
            var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
            trangchu.LoadDanhSach(search());
        }

        
    }
}
