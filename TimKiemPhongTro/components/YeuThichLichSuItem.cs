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

        private int status = 0; //0 : bai hat yeu thich , 1: lich su xem , 2: bai da dang
        private string IdBai;
        private int trangthai;

        public YeuThichLichSuItem(int status, string id) : this()
        {
            this.trangthai = int.Parse(sql.GetFieldValues($"""select TrangThai from BAIDANG where IdBai = '{id}'"""));
            this.status = status;
            IdBai = id;

            if (status == 2)
            {
                if(trangthai == 1)
                {
                    ptbUnhide.Visible = true;
                }
                else
                {
                    ptbHiden.Visible = true;
                }

                DateTime ngayhethan = Convert.ToDateTime(sql.GetFieldValues($"""select ThoiGianHetHan from BAIDANG where IdBai = '{id}'"""));
                if(trangthai == 3 && ngayhethan < DateTime.Now && Var.user.Loai == 2)
                {
                    btnWarning.Visible = true;
                }    
            }
        }

        private string _time;

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
                DialogResult result = MessageBox.Show("Bạn có muốn xoá bái đăng", "Xoá bài đăng" , MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    sql.RunSQL(
                    $"""
                    delete from BAIDANG where IdBai = '{IdBai}'
                    """
                    );
                }
                var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
                if(Var.user.Loai ==2)
                { trangchu.YeuThich_LichSu_Load("Danh sách bài đã đăng", 2); }
                else if (Var.user.Loai ==3)
                { trangchu.QuanLyBai_Load(); }
            }
        }

        //trang thai = 1: hien thong tin 
        //trang thai = 2: an thong tin 
        //trang thai = 3: bai dang bi khoa boi admin
        private void ptbHiden_Click(object sender, EventArgs e)
        {
            if (Var.user.Loai == 2 && trangthai != 3)
            {
                sql.RunSQL($"""update BAIDANG set TrangThai = 1 where IdBai = '{IdBai}'""");
                ptbUnhide.Visible = true;
                ptbHiden.Visible = false;

            }
            else if (Var.user.Loai == 3)
            {
                sql.RunSQL($"""update BAIDANG set TrangThai = 1 where IdBai = '{IdBai}'""");
                ptbUnhide.Visible = true;
                ptbHiden.Visible = false;

            }
            
        }

        private void ptbUnhide_Click(object sender, EventArgs e)
        {
            if (Var.user.Loai == 2)
            {
                sql.RunSQL($"""update BAIDANG set TrangThai = 2 where IdBai = '{IdBai}'""");
                ptbUnhide.Visible = false;
                ptbHiden.Visible = true;
            }
            else if (Var.user.Loai == 3)
            {
                sql.RunSQL($"""update BAIDANG set TrangThai = 3 where IdBai = '{IdBai}'""");
                ptbUnhide.Visible = false;
                ptbHiden.Visible = true;
            }
           
        }

        private void btnWarning_Click(object sender, EventArgs e)
        {
            GiaHan gh = new GiaHan(IdBai);
            gh.ShowDialog();
        }
    }
}
