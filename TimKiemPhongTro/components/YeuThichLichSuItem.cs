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

        private bool yeutich = true;
        private string IdBai;

        public YeuThichLichSuItem(bool status, string id) : this()
        {
            yeutich = status;
            IdBai = id;
        }

        private string _time;
        //private baidang _baidang;

        [Category("Custom Props")]
        public string Time
        {
            get { return _time; }
            set { _time = value; lbThoiGian.Text = value; }
        }

        private void ptbDelete_Click(object sender, EventArgs e)
        {
            if (yeutich)
            {
                sql.RunSQL(
                    $"""
                    delete from YEUTHICH where IdBai = '{IdBai}' and IdNguoiDung = '{Var.user.ID}'
                    """
                    );
                var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
                trangchu.YeuThich_LichSu_Load("Danh sách bài đăng yêu thích", true);
            }
            else
            {
                sql.RunSQL(
                    $"""
                    delete from LICHSU where IdBai = '{IdBai}' and IdNguoiDung = '{Var.user.ID}'
                    """
                    );
                var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
                trangchu.YeuThich_LichSu_Load("Lịch sử xem", false);

            }
        }

        //[Category("Custom Props")]
        //public baidang BaiDang
        //{
        //    get { return _baidang; }
        //    set { _baidang = value; baidang = value; }
        //}

    }
}
