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

        private int status = 0;
        private string IdBai;

        public YeuThichLichSuItem(int status, string id) : this()
        {
            this.status = status;
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
            if (status == 0)
            {
                sql.RunSQL(
                    $"""
                    delete from YEUTHICH where IdBai = '{IdBai}' and IdNguoiDung = '{Var.user.ID}'
                    """
                    );
                var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
                trangchu.YeuThich_LichSu_Load("Danh sách bài đăng yêu thích", 0);
            }
            else if(status == 1)
            {
                sql.RunSQL(
                    $"""
                    delete from LICHSU where IdBai = '{IdBai}' and IdNguoiDung = '{Var.user.ID}'
                    """
                    );
                var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
                trangchu.YeuThich_LichSu_Load("Lịch sử xem", 1);
            }
            else if (status == 2)
            {
                sql.RunSQL(
                    $"""
                    delete from BAIDANG where IdBai = '{IdBai}' and IdNguoiDang = '{Var.user.ID}'
                    """
                    );
                var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
                trangchu.YeuThich_LichSu_Load("Danh sách bài đã đăng", 2);
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
