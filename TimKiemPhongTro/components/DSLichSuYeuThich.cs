﻿using System;
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
    public partial class DSLichSuYeuThich : UserControl
    {
        public DSLichSuYeuThich()
        {
            InitializeComponent();
        }

        public DSLichSuYeuThich(string tilte) : this()
        {
            lbTitle.Text = tilte;
        }

        public static DataTable dt = new DataTable();

        private void DSLichSuYeuThich_Load(object sender, EventArgs e)
        {
            List<string> list = sql.GetFieldValuesList(
                $"""
                select IdBai from YEUTHICH where IdNguoiDung = '{Var.user.ID}'
                """
                );

            foreach (string idbai in list)
            {
                dt = sql.GetDataToTable("select * from BAIDANG where IdBai = '" + idbai + "'");
                foreach (DataRow dr in dt.Rows)
                {
                    baidang bd = new baidang();
                    bd.Title = dr["TieuDe"].ToString().ToUpper();
                    bd.GiaPhong = dr["GiaPhong"].ToString();
                    bd.DienTich = dr["DienTich"].ToString() + "m2";
                    bd.DiaChi = dr["Quan"].ToString() + ", " + dr["Tinh"].ToString();
                    bd.MoTa = dr["MoTa"].ToString();
                    bd.ImgPhong = Image.FromFile(dr["HinhAnh"].ToString());
                    string id = dr["IdNguoiDang"].ToString();
                    bd.TenNguoiDung = sql.GetFieldValues("select HoTen from NGUOIDUNG where IdNguoiDung = '" + id + "'");
                    bd.ImgNguoiDung = Image.FromFile(sql.GetFieldValues("select Avt from NGUOIDUNG where IdNguoiDung = '" + id + "'"));
                    bd.SDT = sql.GetFieldValues("select SDT from NGUOIDUNG where IdNguoiDung = '" + id + "'");
                    bd.DiaChiChinhXac = dr["SoNha"].ToString() + ", " + dr["Pho"].ToString() + ", " + dr["Phuong"].ToString() + ", " + dr["Quan"].ToString() + ", " + dr["Tinh"].ToString();
                    bd.ThoiGian = dr["ThoiGianDang"].ToString();
                    bd.IDBai = dr["IdBai"].ToString();
                    bd.IDNguoiDang = id;
                    YeuThichLichSuItem yeuThichLichSuItem = new YeuThichLichSuItem();
                    yeuThichLichSuItem.Controls.Add(bd);
                    bd.Dock = DockStyle.Left;
                    flowLayoutPanel1.Controls.Add(yeuThichLichSuItem);
                }
            }

            flowLayoutPanel1.Height = 270 * list.Count + 50;
            this.Height = flowLayoutPanel1.Height + 150;
        }

        private string _title;
        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lbTitle.Text = value; }
        }

        private void btnLamTrong_Click(object sender, EventArgs e)
        {
            sql.RunSQL("delete from YEUTHICH");
        }
    }
}
