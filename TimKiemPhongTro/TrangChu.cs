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

        private void TrangChu_Load(object sender, EventArgs e)
        {
            DanhSachTinDang dsTinDang = new DanhSachTinDang();
            searchbar search = new searchbar();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(search);
            flowLayoutPanel1.Controls.Add(dsTinDang);
            flowLayoutPanel1.Controls.Add(panel3);
        }

        private void btnDangTinMoi_Click(object sender, EventArgs e)
        {
            DangTinMoi frm = new DangTinMoi();
            frm.ShowDialog();
        }

        private void iconDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.ShowDialog();
        }

        private void lbDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.ShowDialog();
        }

        private void icconDangKy_Click(object sender, EventArgs e)
        {
            DangKy dk = new DangKy();
            dk.ShowDialog();
        }

        private void lbDangKy_Click(object sender, EventArgs e)
        {
            DangKy dk = new DangKy();
            dk.ShowDialog();
        }

        private void iconYeuThich_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
        }

        private void lvYeuThich_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
        }

        private void iconQuanLy_Click(object sender, EventArgs e)
        {

        }

        private void lbQuanLy_Click(object sender, EventArgs e)
        {

        }


        public void HienThiChiTiet()
        {
            flowLayoutPanel1.Controls.Clear();
            ChuNha chunha = new ChuNha();
            ChiTietBaiDang chitiet = new ChiTietBaiDang();
            flowLayoutPanel1.Controls.Add(chitiet);
            flowLayoutPanel1.Controls.Add(chunha);

        }

        private void logo_Click(object sender, EventArgs e)
        {
            TrangChu_Load(sender, e);
        }


    }
}
