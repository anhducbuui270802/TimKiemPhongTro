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
    public partial class binhluan : UserControl
    {
        public binhluan()
        {
            InitializeComponent();
        }
        private string IdBai;

        public binhluan(string IdBai) : this()
        {
            this.IdBai = IdBai;
            if (Var.user.ID != null)
            {
                ptbAvt.Image = Image.FromFile(Var.user.AVT);
            }



        }
        private void binhluan_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            DataTable dt = sql.GetDataToTable(
               $"""
                select * from BINHLUAN where IdBai = '{IdBai}'
                """
                );

            foreach (DataRow dr in dt.Rows)
            {
                cmt bl = new cmt();
                bl.AVT = Image.FromFile(sql.GetFieldValues($"""select Avt from NGUOIDUNG where IdNguoiDung = '{dr["IdNguoiDung"].ToString()}'"""));
                bl.TenNguoiDung = sql.GetFieldValues($"""select HoTen from NGUOIDUNG where IdNguoiDung = '{dr["IdNguoiDung"].ToString()}'""");
                bl.CMT = dr["CMT"].ToString();
                bl.ThoiGian = dr["ThoiGian"].ToString();
                flowLayoutPanel1.Controls.Add(bl);
            }
        }

        private void ptbSend_Click(object sender, EventArgs e)
        {
            if (Var.user.ID != null && txtCMT.Text != "")
            {
                sql.RunSQL($"""
                    insert into BINHLUAN values (
                    '{IdBai}',
                    '{Var.user.ID}',
                    N'{txtCMT.Text}',
                    '{DateTime.Now.ToString()}'
                    )
                    """);
            }
            txtCMT.Text = "";
            binhluan_Load(sender, e);


            //sql.RunSQL("delete from BINHLUAN");
        }
    }
}
