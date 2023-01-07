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
            DanhSachTinDang.dt = sql.GetDataToTable("select * from BAIDANG where GiaPhong >= 7 and GiaPhong  <= 10");
            var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
            trangchu.LoadDanhSach(DanhSachTinDang.dt);
        }

        private void lb1_2_Click(object sender, EventArgs e)
        {
            DanhSachTinDang.dt = sql.GetDataToTable("select * from BAIDANG where GiaPhong >= 1 and GiaPhong  <= 2");
            var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
            trangchu.LoadDanhSach(DanhSachTinDang.dt);
        }

        private void lbDuoi1tr_Click(object sender, EventArgs e)
        {
            DanhSachTinDang.dt = sql.GetDataToTable("select * from BAIDANG where GiaPhong <= 1");
            var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
            trangchu.LoadDanhSach(DanhSachTinDang.dt);
        }

        private void lb2_3_Click(object sender, EventArgs e)
        {
            DanhSachTinDang.dt = sql.GetDataToTable("select * from BAIDANG where GiaPhong >= 2 and GiaPhong  <= 3");
            var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
            trangchu.LoadDanhSach(DanhSachTinDang.dt);
        }

        private void lb3_5_Click(object sender, EventArgs e)
        {
            DanhSachTinDang.dt = sql.GetDataToTable("select * from BAIDANG where GiaPhong >= 3 and GiaPhong  <= 5");
            var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
            trangchu.LoadDanhSach(DanhSachTinDang.dt);

        }

        private void lb5_7_Click(object sender, EventArgs e)
        {
            DanhSachTinDang.dt = sql.GetDataToTable("select * from BAIDANG where GiaPhong >= 5 and GiaPhong  <= 7");
            var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
            trangchu.LoadDanhSach(DanhSachTinDang.dt);

        }

        private void lb10_15_Click(object sender, EventArgs e)
        {
            DanhSachTinDang.dt = sql.GetDataToTable("select * from BAIDANG where GiaPhong >= 10 and GiaPhong  <= 15");
            var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
            trangchu.LoadDanhSach(DanhSachTinDang.dt);

        }

        private void lbTren15_Click(object sender, EventArgs e)
        {
            DanhSachTinDang.dt = sql.GetDataToTable("select * from BAIDANG where GiaPhong >= 15 ");
            var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
            trangchu.LoadDanhSach(DanhSachTinDang.dt);
        }

        //private void lbDuoi1tr_MouseHover(object sender, EventArgs e)
        //{
        //    lbDuoi1tr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    lbDuoi1tr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(187)))), ((int)(((byte)(2)))));
        //}

        //private void lb1_2_MouseHover(object sender, EventArgs e)
        //{
        //    lb1_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    lb1_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(187)))), ((int)(((byte)(2)))));
        //}

        //private void lb2_3_MouseHover(object sender, EventArgs e)
        //{
        //    lb2_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    lb2_3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(187)))), ((int)(((byte)(2)))));
        //}

        //private void lb3_5_MouseHover(object sender, EventArgs e)
        //{
        //    lb3_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    lb3_5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(187)))), ((int)(((byte)(2)))));
        //}

        //private void lb5_7_MouseHover(object sender, EventArgs e)
        //{
        //    lb5_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    lb5_7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(187)))), ((int)(((byte)(2)))));
        //}

        //private void lb7_10_MouseHover(object sender, EventArgs e)
        //{
        //    lb7_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    lb7_10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(187)))), ((int)(((byte)(2)))));
        //}

        //private void lb10_15_MouseHover(object sender, EventArgs e)
        //{
        //    lb10_15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    lb10_15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(187)))), ((int)(((byte)(2)))));
        //}

        //private void lbTren15_MouseHover(object sender, EventArgs e)
        //{
        //    lbTren15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    lbTren15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(187)))), ((int)(((byte)(2)))));
        //}
    }
}
