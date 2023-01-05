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
    public partial class searchbar : UserControl
    {
        public searchbar()
        {
            InitializeComponent();
        }

        private void find()
        {
            bool flag = false;

            if (cbLoaiBDS.Text == "Chọn loại bất động sản")
            { }
            else
            { 
                string loaibds = "LoaiBDS = " + cbLoaiBDS.Text;
                flag = true;
            }

            if(cbTinh.Text == "Chọn tỉnh thành")
            { }
            else
            {
                string tinh = "Tinh = " + cbTinh.Text;
                flag = true;
            }

            if(cbGia.Text == "Chọn giá")
            { }
            else
            {
                string gia = "GiaPhong = " + cbGia.Text;
                flag = true;
            }

            if (cbDienTich.Text == "Chọn diện tích")
            { }
            else
            {
                string dientich = "DienTich = " + cbDienTich.Text;
                flag = true;
            }
            

            if(flag)
            {
                string sql_statement =
                $"""
                select * from BAIDANG where 
                """;
            }
            else
            {
                string sql_statement =
                $"""
                select * from BAIDANG
                """;
            }
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }
    }
}
