using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;

namespace TimKiemPhongTro.components
{
    public partial class ChuNha : UserControl
    {
        public ChuNha()
        {
            InitializeComponent();
        }

        private string IdNguoiDang;
        private string IdBai;
        private bool liked = true;

        public ChuNha(baidang bd) : this()
        {
            ptbUser.Image = bd.ImgNguoiDung;
            btnSDT.Text = bd.SDT;
            IdNguoiDang = bd.IDNguoiDang;
            IdBai = bd.IDBai;

           if (Var.user.ID != null)
            {
                string temp = sql.GetFieldValues("select IdBai from YEUTHICH where IdBai = N'" + IdBai + "' and IdNguoiDung = N'" + Var.user.ID + "'");

                if (temp == "")
                    liked = false;
                else
                    liked = true;

                if (liked)
                    ptbTim.Image = Image.FromFile("resource/icon/loved.png");
                else
                    ptbTim.Image = Image.FromFile("resource/icon/love.png");
            }
        }

        private void btnZalo_Click(object sender, EventArgs e)
        {
            ZALO zl = new ZALO();
            zl.ShowDialog();
        }

        private void btnYeuThich_Click(object sender, EventArgs e)
        {
            if (liked)
            {
                if (Var.user.ID != null)
                {
                    sql.RunSQL(
                        $"""
                       delete from YEUTHICH where IdNguoiDung = '{Var.user.ID}' and IdBai = '{IdBai}';
                       """
                        );
                }

                liked = false;
                ptbTim.Image = Image.FromFile("resource/icon/love.png");
            }
            else
            {
                if (Var.user.ID != null)
                {
                    sql.RunSQL(
                        $"""
                        insert into YEUTHICH (IdBai, IdNguoiDung) values (
                        '{IdBai}',
                        '{Var.user.ID}'
                        )
                        """
                        );
                }
                liked = true;
                ptbTim.Image = Image.FromFile("resource/icon/loved.png");
            }
        }

        private void ptbZalo_Click(object sender, EventArgs e)
        {
            btnZalo_Click(sender, e);
        }

        private void ptbTim_Click(object sender, EventArgs e)
        {
            btnYeuThich_Click(sender, e);
        }
    }
}
