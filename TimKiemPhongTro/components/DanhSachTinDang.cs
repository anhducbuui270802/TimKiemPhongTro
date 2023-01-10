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

            dt = sql.GetDataToTable("select * from BAIDANG where TrangThai = 1");
            foreach (DataRow dr in dt.Rows)
            {
                baidang bd = new baidang();
                function.setValueBaiDang(dr, ref bd);
                flowLayoutPanel1.Controls.Add(bd);
            }
            flowLayoutPanel1.Height = 270 * dt.Rows.Count + 50;
            this.Height = flowLayoutPanel1.Height + 150;
        }

        public DanhSachTinDang(DataTable dt) : this()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                baidang bd = new baidang();
                function.setValueBaiDang(dr, ref bd);
                flowLayoutPanel1.Controls.Add(bd);
            }
            flowLayoutPanel1.Height = 270 * dt.Rows.Count + 50;
            this.Height = flowLayoutPanel1.Height + 150;
        }


    }
}
