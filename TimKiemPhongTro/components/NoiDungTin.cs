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

        public static string _imagepath = "resource/icon/image.png";


        private void NoiDungTin_Load(object sender, EventArgs e)
        {
            txtDiaChi.Text = txtSoNha.Text + ", " + cbDuongPho.Text + ", " + cbPhuong.Text + ", " + cbQuan.Text + ", " + cbTinh.Text;
            txtThongTinLienHe.Text = Var.user.HoTen.ToString();
            txtSDT.Text = Var.user.SDT.ToString();
            rbNoiDungMoTa.Text = "viet noi dung tai day";
        }
        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            if (cbTinh.Text == "") MessageBox.Show("Bạn chưa nhập tỉnh");
            if (cbQuan.Text == "") MessageBox.Show("Bạn chưa nhập quận");
            if (cbPhuong.Text == "") MessageBox.Show("Bạn chưa nhập phường");
            if (cbDuongPho.Text == "") MessageBox.Show("Bạn chưa nhập đường phố");
            if (cbLoaiBDS.Text == "") MessageBox.Show("Bạn chưa chọn loại bất động sản");

            string sql_funtion =
                $"""
                insert into BAIDANG (IdBai, IdNguoiDang,ThoiGianDang, Tinh, Quan, Pho, SoNha, LoaiBDS, TieuDe, MoTa, GiaPhong, DienTich, HinhAnh) values  (
                '{function.getId("BD")}', 
                '{Var.user.ID}',
                '{DateTime.Now.ToString()}' ,
                N'{cbTinh.Text}' ,
                N'{cbDuongPho.Text}',
                N'{cbQuan.Text}', 
                N'{txtSoNha.Text}',
                N'{cbLoaiBDS.Text}',
                N'{txtTieuDe.Text}',
                N'{rbNoiDungMoTa.Text}',
                {txtGia.Text} ,
                {numDientich.Value.ToString()},
                N'{_imagepath}'
                )
                """;
          
            sql.RunSQL(sql_funtion);
            MessageBox.Show("Đã thêm bài đăng");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "png files (*.png)|*png|jpg files (*.jpg)|*jpg|All files (*.*)|*.*";
            open.Multiselect = true;
            open.InitialDirectory = "D:\\UIT\\Nam3_Ky1\\c#\\TimKiemPhongTro\\TimKiemPhongTro\\bin\\Debug\\resource\\icon";
            if (open.ShowDialog() == DialogResult.OK)
            {
                path = open.FileName;
                _imagepath = path;
                pictureBox1.Image = Image.FromFile(path);
                Console.WriteLine(path);
            }
        }
    }
}
