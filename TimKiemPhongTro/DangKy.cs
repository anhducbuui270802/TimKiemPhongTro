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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void ptbAvt_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "png files (*.png)|*png|jpg files (*.jpg)|*jpg|All files (*.*)|*.*";
            open.Multiselect = true;
            open.InitialDirectory = "D:\\UIT\\Nam3_Ky1\\c#\\TimKiemPhongTro\\TimKiemPhongTro\\bin\\Debug\\resource\\icon";
            if (open.ShowDialog() == DialogResult.OK)
            {
                path = open.FileName;
                ptbAvt.Image = Image.FromFile(path);
                //Console.WriteLine(path);
            }
        }

        private void ptbZalo_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "png files (*.png)|*png|jpg files (*.jpg)|*jpg|All files (*.*)|*.*";
            open.Multiselect = true;
            open.InitialDirectory = "D:\\UIT\\Nam3_Ky1\\c#\\TimKiemPhongTro\\TimKiemPhongTro\\bin\\Debug\\resource\\icon";
            if (open.ShowDialog() == DialogResult.OK)
            {
                path = open.FileName;
                ptbZalo.Image = Image.FromFile(path);
                //Console.WriteLine(path);
            }
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            //sql.RunSQL("insert into NGUOIDUNG values (" + function.getId("ND") + ",N'" + txtHoTen.Text + "'," + ")");
        }
    }
}
