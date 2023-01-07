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
            DanhSachTinDang.dt =  sql.GetDataToTable("select * from BAIDANG where DienTich <= 20");
            var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
            trangchu.LoadDanhSach(DanhSachTinDang.dt);
        }

        private void lb20_30_Click(object sender, EventArgs e)
        {
            DanhSachTinDang.dt =  sql.GetDataToTable("select * from BAIDANG where DienTich >= 20 and DienTich <= 30");
            var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
            trangchu.LoadDanhSach(DanhSachTinDang.dt);
        }

        private void lb30_50_Click(object sender, EventArgs e)
        {
            DanhSachTinDang.dt =  sql.GetDataToTable("select * from BAIDANG where DienTich >= 30 and DienTich <= 50");
            var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
            trangchu.LoadDanhSach(DanhSachTinDang.dt);
        }

        private void lb50_70_Click(object sender, EventArgs e)
        {
            DanhSachTinDang.dt =  sql.GetDataToTable("select * from BAIDANG where DienTich >= 50 and DienTich <= 70");
            var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
            trangchu.LoadDanhSach(DanhSachTinDang.dt);
        }

        private void lb70_90_Click(object sender, EventArgs e)
        {
            DanhSachTinDang.dt =  sql.GetDataToTable("select * from BAIDANG where DienTich >= 70 and DienTich <= 90");
            var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
            trangchu.LoadDanhSach(DanhSachTinDang.dt);
        }

        private void lbTren90m_Click(object sender, EventArgs e)
        {
            DanhSachTinDang.dt =  sql.GetDataToTable("select * from BAIDANG where DienTich >= 90");
            var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
            trangchu.LoadDanhSach(DanhSachTinDang.dt);
        }

        //private void lbDuoi20m_MouseHover(object sender, EventArgs e)
        //{
        //    lbDuoi20m.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    lbDuoi20m.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(187)))), ((int)(((byte)(2)))));
        //}

        //private void lb20_30_MouseHover(object sender, EventArgs e)
        //{
        //    lb20_30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    lb20_30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(187)))), ((int)(((byte)(2)))));
        //}

        //private void lb30_50_MouseHover(object sender, EventArgs e)
        //{
        //    lb30_50.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    lb30_50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(187)))), ((int)(((byte)(2)))));
        //}

        //private void lb50_70_MouseHover(object sender, EventArgs e)
        //{
        //    lb50_70.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    lb50_70.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(187)))), ((int)(((byte)(2)))));
        //}

        //private void lb70_90_MouseHover(object sender, EventArgs e)
        //{
        //    lb70_90.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    lb70_90.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(187)))), ((int)(((byte)(2)))));

        //}

        //private void lbTren90m_MouseHover(object sender, EventArgs e)
        //{
        //    lbTren90m.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    lbTren90m.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(187)))), ((int)(((byte)(2)))));
        //}
    }
}
