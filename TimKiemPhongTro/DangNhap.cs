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

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string temp = "";
            temp = sql.GetFieldValues("select TenDangNhap from NGUOIDUNG where TenDangNhap = N'" + txtTenDangNhap.Text + "'");
        }
    }
}
