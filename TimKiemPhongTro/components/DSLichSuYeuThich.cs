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
    public partial class DSLichSuYeuThich : UserControl
    {
        public DSLichSuYeuThich()
        {
            InitializeComponent();
        }

        private int status = 0;
        public static DataTable dt = new DataTable();

        public DSLichSuYeuThich(string tilte, int status) : this()
        {
            lbTitle.Text = tilte;
            this.status = status;

            if (status == 0) // yeuthich
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
                        function.setValueBaiDang(dr, ref bd);
                        YeuThichLichSuItem yeuThichLichSuItem = new YeuThichLichSuItem(0, idbai);
                        yeuThichLichSuItem.Time = "";
                        yeuThichLichSuItem.Controls.Add(bd);
                        bd.Dock = DockStyle.Left;
                        flowLayoutPanel1.Controls.Add(yeuThichLichSuItem);
                    }
                }
                flowLayoutPanel1.Height = 270 * list.Count + 50;
                this.Height = flowLayoutPanel1.Height + 150;
            }
            else if (status == 1)  //lichsu
            {
                List<string> list = sql.GetFieldValuesList(
                    $"""
                        select IdBai from LICHSU where IdNguoiDung = '{Var.user.ID}'
                     """
                    );

                foreach (string idbai in list)
                {
                    dt = sql.GetDataToTable("select * from BAIDANG where IdBai = '" + idbai + "'");
                    foreach (DataRow dr in dt.Rows)
                    {
                        baidang bd = new baidang();
                        function.setValueBaiDang(dr, ref bd);
                        YeuThichLichSuItem yeuThichLichSuItem = new YeuThichLichSuItem(1, idbai);
                        yeuThichLichSuItem.Time = "Thời điểm xem gần nhất:\n" + sql.GetFieldValues("select ThoiGian from LICHSU where IdBai = '" + idbai + "'");
                        yeuThichLichSuItem.Controls.Add(bd);
                        bd.Dock = DockStyle.Left;
                        flowLayoutPanel1.Controls.Add(yeuThichLichSuItem);
                    }
                }
                flowLayoutPanel1.Height = 270 * list.Count + 50;
                this.Height = flowLayoutPanel1.Height + 150;
            }

            else if (status == 2) // baidadang
            {
                dt = sql.GetDataToTable("select * from BAIDANG where IdNguoiDang = '" + Var.user.ID + "'");
                foreach (DataRow dr in dt.Rows)
                {
                    baidang bd = new baidang();
                    function.setValueBaiDang(dr, ref bd);
                    YeuThichLichSuItem yeuThichLichSuItem = new YeuThichLichSuItem(2, dr["IdBai"].ToString());
                    yeuThichLichSuItem.Time = "Thời gian đăng:\n" + dr["ThoiGianDang"].ToString();
                    yeuThichLichSuItem.Controls.Add(bd);
                    bd.Dock = DockStyle.Left;
                    flowLayoutPanel1.Controls.Add(yeuThichLichSuItem);
                }
                flowLayoutPanel1.Height = 270 * dt.Rows.Count + 50;
                this.Height = flowLayoutPanel1.Height + 150;
            }
        }

        private void DSLichSuYeuThich_Load(object sender, EventArgs e)
        {

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
            if (status == 0)
            {
                sql.RunSQL("delete from YEUTHICH where IdNguoiDung = '" + Var.user.ID + "'");
            }
            else if (status == 1)
            {
                sql.RunSQL("delete from LICHSU where IdNguoiDung = '" + Var.user.ID + "'");
            }
        }

    }
}
