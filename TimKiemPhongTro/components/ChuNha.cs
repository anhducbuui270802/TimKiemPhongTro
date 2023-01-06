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
    public partial class ChuNha : UserControl
    {
        public ChuNha()
        {
            InitializeComponent();
        }

        private string IdNguoiDang;
        private string IdBai;
        public ChuNha(baidang bd) : this()
        {
            ptbUser.Image = bd.ImgNguoiDung;
            btnSDT.Text = bd.SDT;
            IdNguoiDang = bd.IDNguoiDang;
            IdBai = bd.IDBai;
        }

        private void btnZalo_Click(object sender, EventArgs e)
        {
            ZALO zl = new ZALO();
            zl.ShowDialog();
        }

        private void btnYeuThich_Click(object sender, EventArgs e)
        {
            if(Var.user.ID == null)
            {
                MessageBox.Show("ban chua dang nhap");
            }
            else
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
