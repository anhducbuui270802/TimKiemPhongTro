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
            //DanhSachTinDang.dt = sql.GetDataToTable("select * from BAIDANG");
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

        public void SetVisibal(bool flag)
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
            DSLichSuYeuThich ds = new DSLichSuYeuThich();
            flowLayoutPanel1.Controls.Add(ds);
        }

        private void lvYeuThich_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            DSLichSuYeuThich ds = new DSLichSuYeuThich();
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


        public void HienThiChiTiet(baidang bd)
        {
            flowLayoutPanel1.Controls.Clear();
            ChuNha chunha = new ChuNha(bd);
            ChiTietBaiDang chitiet = new ChiTietBaiDang(bd);
            flowLayoutPanel1.Controls.Add(chitiet);
            flowLayoutPanel1.Controls.Add(chunha);

        }

        private void logo_Click(object sender, EventArgs e)
        {
            TrangChu_Load(sender, e);
        }



    }
}
