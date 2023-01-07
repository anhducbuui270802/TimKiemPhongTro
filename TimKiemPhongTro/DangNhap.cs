using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimKiemPhongTro
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }


        private void txtTenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string MK = "";
            MK = sql.GetFieldValues("select MK from NGUOIDUNG where TenDangNhap = N'" + txtTenDangNhap.Text + "'");
            if (MK != "")
            {
                if (MK == txtMK.Text)
                {
                    DataTable dt = sql.GetDataToTable("select * from NGUOIDUNG where TenDangNhap = N'" + txtTenDangNhap.Text + "'");
                    foreach (DataRow dr in dt.Rows)
                    {
                        Var.user.ID = dr["IdNguoiDung"].ToString();
                        Var.user.HoTen = dr["HoTen"].ToString();
                        Var.user.Tendangnhap = dr["TenDangNhap"].ToString();
                        Var.user.MK = dr["MK"].ToString();
                        Var.user.SDT = dr["SDT"].ToString();
                        Var.user.Loai = int.Parse(dr["Loai"].ToString());
                        Var.user.AVT = dr["Avt"].ToString();
                    }

                    DialogResult result = MessageBox.Show("Đăng nhập thành công!");
                    if (result == DialogResult.OK)
                    {
                        var trangchu = Application.OpenForms.OfType<TrangChu>().Single();
                        trangchu.SetVisible(true);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu");
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại");
            }
        }


    }
}
