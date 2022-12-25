using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimKiemPhongTro.components;

namespace TimKiemPhongTro
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
            DanhSachTinDang ds = new DanhSachTinDang();
            flowLayoutPanel1.Controls.Add(ds);
        }
    }
}
