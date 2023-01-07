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
            sql.Connect();
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

        public void SetVisible(bool flag)
        {
            if(flag)
            {
                pnDangNhap.Visible = false;
                pnYeuThich.Visible = true;
                pnQuanLy.Visible = true;
            }
            else
            {
                pnDangNhap.Visible = true;
                pnYeuThich.Visible = false;
                pnQuanLy.Visible = false;
            }

        }

        private void btnDangTinMoi_Click(object sender, EventArgs e)
        {
            if (Var.user.ID != null)
            {
                DangTinMoi frm = new DangTinMoi();
                frm.ShowDialog();
            }
            else MessageBox.Show("Vui lòng đăng nhập trước khi đăng tin mới");
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
            DSLichSuYeuThich ds = new DSLichSuYeuThich("Danh sách bài đăng yêu thích", 0);
            flowLayoutPanel1.Controls.Add(ds);
        }

        private void lvYeuThich_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            DSLichSuYeuThich ds = new DSLichSuYeuThich("Danh sách bài đăng yêu thích", 0);
            flowLayoutPanel1.Controls.Add(ds);
        }

        public void YeuThich_LichSu_Load(string title, int status)
        {
            flowLayoutPanel1.Controls.Clear();
            DSLichSuYeuThich ds = new DSLichSuYeuThich(title, status);
            flowLayoutPanel1.Controls.Add(ds);
        }

        private void iconQuanLy_Click(object sender, EventArgs e)
        {
            if(panel5.Visible)
                panel5.Visible = false;
            else
                panel5.Visible = true;
        }

        private void lbQuanLy_Click(object sender, EventArgs e)
        {
            if (panel5.Visible)
                panel5.Visible = false;
            else
                panel5.Visible = true;
        }

        public void LoadDanhSach (DataTable dt)
        {
            DanhSachTinDang dsTinDang = new DanhSachTinDang(dt);
            searchbar search = new searchbar();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(search);
            flowLayoutPanel1.Controls.Add(dsTinDang);
            flowLayoutPanel1.Controls.Add(panel3);
        }


        public void HienThiChiTiet(baidang bd)
        {
            flowLayoutPanel1.Controls.Clear();
            ChuNha chunha = new ChuNha(bd);
            binhluan cmt = new binhluan(bd.IDBai);
            chunha.Dock = DockStyle.Top;
            cmt.Dock = DockStyle.Top;
            Panel p = new Panel();
            p.Size = new Size(355, 1000);
            p.Controls.Add(cmt);
            p.Controls.Add(chunha);
            ChiTietBaiDang chitiet = new ChiTietBaiDang(bd);
            flowLayoutPanel1.Controls.Add(chitiet);
            flowLayoutPanel1.Controls.Add(p);


        }

        private void logo_Click(object sender, EventArgs e)
        {
            TrangChu_Load(sender, e);
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            Var.user = new User();
            panel5.Visible = false;
            SetVisible(false);
            TrangChu_Load(sender, e);
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            DSLichSuYeuThich ds = new DSLichSuYeuThich("Lịch sử xem", 1);
            flowLayoutPanel1.Controls.Add(ds);
            panel5.Visible = false;
        }

        private void btnBaiDaDang_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            DSLichSuYeuThich ds = new DSLichSuYeuThich("Danh sách bài đã đăng", 2);
            flowLayoutPanel1.Controls.Add(ds);
            panel5.Visible = false;
        }
    }
}
