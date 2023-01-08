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
    public partial class XemTheoDienTich : UserControl
    {
        public XemTheoDienTich()
        {
            InitializeComponent();
        }

        private void lbDuoi20m_Click(object sender, EventArgs e)
        {
            searchbar.setdientich(0);
            //DanhSachTinDang.dt =  sql.GetDataToTable("select * from BAIDANG where DienTich <= 20");
            //var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
            //trangchu.LoadDanhSach(DanhSachTinDang.dt);
        }

        private void lb20_30_Click(object sender, EventArgs e)
        {
            searchbar.setdientich(1);
            //DanhSachTinDang.dt =  sql.GetDataToTable("select * from BAIDANG where DienTich >= 20 and DienTich <= 30");
            //var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
            //trangchu.LoadDanhSach(DanhSachTinDang.dt);
        }

        private void lb30_50_Click(object sender, EventArgs e)
        {
            searchbar.setdientich(2);
            //DanhSachTinDang.dt =  sql.GetDataToTable("select * from BAIDANG where DienTich >= 30 and DienTich <= 50");
            //var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
            //trangchu.LoadDanhSach(DanhSachTinDang.dt);
        }

        private void lb50_70_Click(object sender, EventArgs e)
        {
            searchbar.setdientich(3);
            //DanhSachTinDang.dt =  sql.GetDataToTable("select * from BAIDANG where DienTich >= 50 and DienTich <= 70");
            //var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
            //trangchu.LoadDanhSach(DanhSachTinDang.dt);
        }

        private void lb70_90_Click(object sender, EventArgs e)
        {
            searchbar.setdientich(4);
            //DanhSachTinDang.dt =  sql.GetDataToTable("select * from BAIDANG where DienTich >= 70 and DienTich <= 90");
            //var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
            //trangchu.LoadDanhSach(DanhSachTinDang.dt);
        }

        private void lbTren90m_Click(object sender, EventArgs e)
        {
            searchbar.setdientich(5);
            // DanhSachTinDang.dt =  sql.GetDataToTable("select * from BAIDANG where DienTich >= 90");
            // var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
            // trangchu.LoadDanhSach(DanhSachTinDang.dt);
        }
    }
}
