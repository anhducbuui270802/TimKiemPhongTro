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
        private List<string> listtinh = sql.GetFieldValuesList("select distinct Tinh from BAIDANG");
        private List<string> listquan;
        private List<string> listphuong;

        private void NoiDungTin_Load(object sender, EventArgs e)
        {
            txtThongTinLienHe.Text = Var.user.HoTen.ToString();
            txtSDT.Text = Var.user.SDT.ToString();
            rbNoiDungMoTa.Text = "viet noi dung tai day";
            listtinh = sql.GetFieldValuesList("select distinct Tinh from BAIDANG");
            foreach (string tinh in listtinh)
            {
                cbTinh.Items.Add(tinh);
            }

        }
        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            if (cbTinh.Text == "") MessageBox.Show("Bạn chưa nhập tỉnh");
            if (cbQuan.Text == "") MessageBox.Show("Bạn chưa nhập quận");
            if (cbPhuong.Text == "") MessageBox.Show("Bạn chưa nhập phường");
            if (cbDuongPho.Text == "") MessageBox.Show("Bạn chưa nhập đường phố");
            if (cbLoaiBDS.Text == "") MessageBox.Show("Bạn chưa chọn loại bất động sản");

            string sql_statement =
                $"""
                insert into BAIDANG values  (
                '{function.getId("BD")}', 
                '{Var.user.ID}',
                '{DateTime.Now.ToString()}' ,
                N'{cbTinh.Text}' ,
                N'{cbQuan.Text}', 
                N'{cbPhuong.Text}',
                N'{cbDuongPho.Text}',
                N'{txtSoNha.Text}',
                N'{cbLoaiBDS.Text}',
                N'{txtTieuDe.Text}',
                N'{rbNoiDungMoTa.Text}',
                {txtGia.Text} ,
                {numDientich.Value.ToString()},
                {1},
                '{dateTimePicker.Value.ToString()}',
                N'{_imagepath}'
                )
                """;
          
            sql.RunSQL(sql_statement);
            MessageBox.Show("Đã thêm bài đăng");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All files (*.*)|*.*|png files (*.png)|*png|jpg files (*.jpg)|*jpg";
            open.Multiselect = true;
            open.InitialDirectory = Var.currentDir + "\\resource";
            if (open.ShowDialog() == DialogResult.OK)
            {
                path = open.FileName.Replace(Var.currentDir + @"\", "").Replace(@"\", "/");
                _imagepath = path;
                pictureBox1.Image = Image.FromFile(path);
                Console.WriteLine(path);
            }
        }

        private void txtDiaChi_MouseLeave(object sender, EventArgs e)
        {
            txtDiaChi.Text = txtSoNha.Text + ", " + cbDuongPho.Text + ", " + cbPhuong.Text + ", " + cbQuan.Text + ", " + cbTinh.Text;

        }

        private void cbQuan_MouseHover(object sender, EventArgs e)
        {
            listquan = sql.GetFieldValuesList($"""select distinct Quan from BAIDANG where Tinh = N'{cbTinh.Text}' """);
            foreach (string quan in listquan)
            {
                cbQuan.Items.Add(quan);
            }
        }

        private void cbPhuong_MouseHover(object sender, EventArgs e)
        {
            listquan = sql.GetFieldValuesList($"""select distinct Phuong from BAIDANG where Tinh = N'{cbQuan.Text}' """);
            foreach (string phuong in listphuong)
            {
                cbPhuong.Items.Add(phuong);
            }
        }
    }
}
