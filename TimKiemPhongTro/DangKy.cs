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

        private int status = 1; //  1 dang ky ; 2: sua thong tin
        public static string _avtpath = "resource/icon/dangnhapicon.png";

        public DangKy()
        {
            InitializeComponent();
        }

        public DangKy(int status) : this()
        {
            this.status = status;
            if(status == 1)
            {
                label1.Text = "Tạo tài khoản mới";
            }
            else if(status == 2)
            {
                label1.Text = "Cập nhật thông tin";
                btnTaoTaiKhoan.Text = "Cập nhật";
                panel1.Visible = false;
                txtHoTen.Text = Var.user.HoTen;
                txtTenDangNhap.Text = Var.user.Tendangnhap;
                txtSDT.Text = Var.user.SDT;
                txtEmail.Text = Var.user.Email;
                txtMK.Text = Var.user.MK;
                ptbAvt.Image = Image.FromFile(Var.user.AVT);
            }
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void ptbAvt_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All files (*.*)|*.*|png files (*.png)|*png|jpg files (*.jpg)|*jpg";
            open.Multiselect = false;
            
            open.InitialDirectory = Var.currentDir + "\\resource";
            if (open.ShowDialog() == DialogResult.OK)
            {
                _avtpath =  open.FileName.Replace(Var.currentDir + @"\", "").Replace(@"\","/");
                ptbAvt.Image = Image.FromFile(_avtpath);
            }
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            if (status == 1)
            {
                int loai = 1;
                if (rdoTimKiem.Checked) loai = 1;
                if (rdoChinhChu.Checked) loai = 2;
                string temp = "";
                temp = sql.GetFieldValues("select TenDangNhap from NGUOIDUNG where TenDangNhap = N'" + txtTenDangNhap.Text + "'");
                if (temp == "")
                {
                    //sql.RunSQL("insert into NGUOIDUNG values ('" + function.getId("ND") + "',N'" + txtHoTen.Text.Trim() + "', N'" + txtTenDangNhap.Text.Trim() + "','" + txtMK.Text.Trim() + "','" + txtSDT.Text.Trim() + "'," + loai.ToString() + ",N'" + _avtpath + "')");
                    sql.RunSQL(
                        $"""
                    insert into NGUOIDUNG values (
                    '{function.getId("ND")}',
                    N'{txtHoTen.Text.Trim()}',
                    N'{txtTenDangNhap.Text.Trim()}',
                    '{txtMK.Text.Trim()}',
                    '{txtSDT.Text.Trim()}',
                    '{txtEmail.Text.Trim()}',
                    {loai},
                    N'{_avtpath}'
                    )
                    """
                        );
                    System.Windows.MessageBox.Show("Tạo thành công");
                }

                else
                {
                    System.Windows.MessageBox.Show("Tên đăng nhập đã tồn tại,\n vui lòng nhập tên khác");
                }
            }

            else if (status == 2)
            {
                string temp = "";
                temp = sql.GetFieldValues("select TenDangNhap from NGUOIDUNG where TenDangNhap = N'" + txtTenDangNhap.Text + "' and TenDangNhap != N'" + Var.user.Tendangnhap + "'" );
                if (temp == "")
                {
                    sql.RunSQL(
                        $"""
                        update NGUOIDUNG set 
                        HoTen = N'{txtHoTen.Text}',
                        TenDangNhap = N'{txtTenDangNhap.Text}',
                        MK = '{txtMK.Text}',
                        SDT = '{txtSDT.Text}',
                        Email = '{txtEmail.Text}',
                        Avt = N'{_avtpath}'
                        where IdNguoiDung = '{Var.user.ID}'
                        """
                        );
                    System.Windows.MessageBox.Show("Cập nhật thành công");
                }

                else
                {
                    System.Windows.MessageBox.Show("Tên đăng nhập đã tồn tại,\n vui lòng nhập tên khác");
                }
            }


        }
    }
}
