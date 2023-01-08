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
    public partial class XemTheoGia : UserControl
    {
        public XemTheoGia()
        {
            InitializeComponent();
        }

        private void lb7_10_Click(object sender, EventArgs e)
        {
            searchbar.setgia(5);
            //DanhSachTinDang.dt = sql.GetDataToTable("select * from BAIDANG where GiaPhong >= 7 and GiaPhong  <= 10");
            //var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
            //trangchu.LoadDanhSach(DanhSachTinDang.dt);
        }

        private void lb1_2_Click(object sender, EventArgs e)
        {
            searchbar.setgia(1);
            //DanhSachTinDang.dt = sql.GetDataToTable("select * from BAIDANG where GiaPhong >= 1 and GiaPhong  <= 2");
            //var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
            //trangchu.LoadDanhSach(DanhSachTinDang.dt);
        }

        private void lbDuoi1tr_Click(object sender, EventArgs e)
        {
            searchbar.setgia(0);
            //DanhSachTinDang.dt = sql.GetDataToTable("select * from BAIDANG where GiaPhong <= 1");
            //var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
            //trangchu.LoadDanhSach(DanhSachTinDang.dt);
        }

        private void lb2_3_Click(object sender, EventArgs e)
        {
            searchbar.setgia(2);
            //DanhSachTinDang.dt = sql.GetDataToTable("select * from BAIDANG where GiaPhong >= 2 and GiaPhong  <= 3");
            //var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
            //trangchu.LoadDanhSach(DanhSachTinDang.dt);
        }

        private void lb3_5_Click(object sender, EventArgs e)
        {
            searchbar.setgia(3);
            //DanhSachTinDang.dt = sql.GetDataToTable("select * from BAIDANG where GiaPhong >= 3 and GiaPhong  <= 5");
            //var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
            //trangchu.LoadDanhSach(DanhSachTinDang.dt);
        }

        private void lb5_7_Click(object sender, EventArgs e)
        {
            searchbar.setgia(4);
            //  DanhSachTinDang.dt = sql.GetDataToTable("select * from BAIDANG where GiaPhong >= 5 and GiaPhong  <= 7");
            //  var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
            //  trangchu.LoadDanhSach(DanhSachTinDang.dt);
        }

        private void lb10_15_Click(object sender, EventArgs e)
        {
            searchbar.setgia(6);
            //DanhSachTinDang.dt = sql.GetDataToTable("select * from BAIDANG where GiaPhong >= 10 and GiaPhong  <= 15");
            //var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
            //trangchu.LoadDanhSach(DanhSachTinDang.dt);
        }

        private void lbTren15_Click(object sender, EventArgs e)
        {
            searchbar.setgia(7);
            //DanhSachTinDang.dt = sql.GetDataToTable("select * from BAIDANG where GiaPhong >= 15 ");
            //var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
            //trangchu.LoadDanhSach(DanhSachTinDang.dt);
        }

    }
}
