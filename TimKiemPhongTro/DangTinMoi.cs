using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimKiemPhongTro.components;

namespace TimKiemPhongTro
{
    public partial class DangTinMoi : Form
    {
        public DangTinMoi()
        {
            InitializeComponent();
        }

        private void DangTinMoi_Load(object sender, EventArgs e)
        {
            NoiDungTin nd = new NoiDungTin();
           // nd.Dock = DockStyle.Top;
            flowLayoutPanel1.Controls.Add(nd);
        }
    }
}
