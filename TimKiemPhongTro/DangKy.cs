using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TimKiemPhongTro
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        public static string _avtpath = "resource/icon/dangnhapicon.png";
        public static string _zalopath = "resource/icon/zalo-icon.png";

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void ptbAvt_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "png files (*.png)|*png|jpg files (*.jpg)|*jpg|All files (*.*)|*.*";
            open.Multiselect = false;
            open.InitialDirectory = "D:\\UIT\\Nam3_Ky1\\c#\\TimKiemPhongTro\\TimKiemPhongTro\\bin\\Debug\\resource\\icon";
            if (open.ShowDialog() == DialogResult.OK)
            {
                _avtpath = open.FileName;
                ptbAvt.Image = Image.FromFile(_avtpath);
            }
        }

        private void ptbZalo_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "png files (*.png)|*png|jpg files (*.jpg)|*jpg|All files (*.*)|*.*";
            open.Multiselect = false;
            open.InitialDirectory = "D:\\UIT\\Nam3_Ky1\\c#\\TimKiemPhongTro\\TimKiemPhongTro\\bin\\Debug\\resource\\icon";
            if (open.ShowDialog() == DialogResult.OK)
            {
                _zalopath = open.FileName;
                ptbZalo.Image = Image.FromFile(_zalopath);
            }
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            int loai = 1;
            if (rdoTimKiem.Checked) loai = 1;
            if (rdoChinhChu.Checked) loai = 2;
            string temp = "";
            temp = sql.GetFieldValues("select TenDangNhap from NGUOIDUNG where TenDangNhap = N'" + txtTenDangNhap.Text + "'");
            if (temp == "")
            {
                sql.RunSQL("insert into NGUOIDUNG values ('" + function.getId("ND") + "',N'" + txtHoTen.Text.Trim() + "', N'" + txtTenDangNhap.Text.Trim() + "','" + txtMK.Text.Trim() + "','" + txtSDT.Text.Trim() + "'," + loai.ToString() + ",N'" + _avtpath + "',N'" + _zalopath + "')");
                System.Windows.MessageBox.Show("Tạo thành công");
            }

            else
            {
                System.Windows.MessageBox.Show("Tên đăng nhập đã tồn tại,\n vui lòng nhập tên khác");
            }


        }
    }
}
