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

        private void DSLichSuYeuThich_Load(object sender, EventArgs e)
        {
            for(int i = 0; i< 10;i++)
            {
                YeuThichLichSuItem item = new YeuThichLichSuItem();
                flowLayoutPanel1.Controls.Add(item);
            }

            flowLayoutPanel1.Height = 11 * 270;
            this.Height = flowLayoutPanel1.Height;
        }

        private string _title;
        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lbTitle.Text = value; }
        }
     
    }
}
