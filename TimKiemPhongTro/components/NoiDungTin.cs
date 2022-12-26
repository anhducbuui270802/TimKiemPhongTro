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
    public partial class NoiDungTin : UserControl
    {
        public NoiDungTin()
        {
            InitializeComponent();
        }

        private void NoiDungTin_Load(object sender, EventArgs e)
        {
            txtDiaChi.Text = txtSoNha.Text + ", " + cbDuongPho.Text + ", " + cbPhuong.Text + ", " + cbQuan.Text + ", " + cbTinh.Text;
        }
        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            //NoiDungTin_Load(sender, e); 
            //sql.RunSQL("insert into BAIDANG values (" + Var.iduser + "," + ")");

            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "png files (*.png)|*png|jpg files (*.jpg)|*jpg|All files (*.*)|*.*";
            open.Multiselect = true;
            open.InitialDirectory = "D:\\UIT\\Nam3_Ky1\\c#\\TimKiemPhongTro\\TimKiemPhongTro\\bin\\Debug\\resource\\icon";
            if(open.ShowDialog() == DialogResult.OK)
            {
                path = open.FileName;
                pictureBox1.Image = Image.FromFile(path);
                //Console.WriteLine(path);
            }
        }
    }
}
