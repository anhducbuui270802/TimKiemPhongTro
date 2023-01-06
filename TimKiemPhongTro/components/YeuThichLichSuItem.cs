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
    public partial class YeuThichLichSuItem : UserControl
    {
        public YeuThichLichSuItem()
        {
            InitializeComponent();
        }

        //public YeuThichLichSuItem(baidang bd) : this ()
        //{
        //    baidang = bd;
        //}

        private string _time;
        //private baidang _baidang;

        [Category("Custom Props")]
        public string Time
        {
            get { return _time; }
            set { _time = value; lbThoiGian.Text = value; }
        }

        //[Category("Custom Props")]
        //public baidang BaiDang
        //{
        //    get { return _baidang; }
        //    set { _baidang = value; baidang = value; }
        //}

    }
}
