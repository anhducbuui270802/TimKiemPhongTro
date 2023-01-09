using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Navigation;

namespace TimKiemPhongTro
{
    internal class sql
    {
        public static SqlConnection Con;
        public static void Connect()
        {
            Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database.mdf;Integrated Security=True");

            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }
        public static void Disconnect()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
                Con.Dispose();
                Con = null;
            }
        }

        public static DataTable GetDataToTable(string sql)
        {
            DataTable table = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(sql, Con);
            dap.Fill(table);
            return table;
        }

        public static void RunSQL(string sql)
        {
            SqlCommand cmd = new SqlCommand(); ; //Đối tượng thuộc lớp SqlCommand
            cmd.Connection = Con; //Gán kết nối
            cmd.CommandText = sql; //Gán lệnh SQL
            try
            {
                cmd.ExecuteNonQuery(); //Thực hiện câu lệnh SQL
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();//Giải phóng bộ nhớ
            cmd = null;
        }

        public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            return ma;
        }

        public static List<string> GetFieldValuesList(string sql)
        {
            List<string> list = new List<string>();
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ma = reader.GetValue(0).ToString();
                list.Add(ma);
            }
            reader.Close();
            return list;
        }

    }

    public partial class User
    {
        private string _id;
        private string _hoten;
        private string _tendangnhap;
        private string _mk;
        private string _sdt;
        private int _loai;
        private string _avt;
        private string _email;

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string HoTen
        {
            get { return _hoten; }
            set { _hoten = value; }
        }

        public string Tendangnhap
        {
            get { return _tendangnhap; }
            set { _tendangnhap = value; }
        }

        public string MK
        {
            get { return _mk; }
            set { _mk = value; }
        }

        public string SDT
        {
            get { return _sdt; }
            set { _sdt = value; }
        }

        public int Loai
        {
            get { return _loai; }
            set { _loai = value; }
        }

        public string AVT
        {
            get { return _avt; }
            set { _avt = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
    }

    internal class Var
    {
        public static User user = new User();
        public static string currentDir = Environment.CurrentDirectory;
    }

    internal class function
    {
        //Hàm tạo khóa có dạng: TientoNgaythangnam_giophutgiay
        public static string getId(string tiento)
        {
            string key = tiento;
            string[] partsDay;
            partsDay = DateTime.Now.ToShortDateString().Split('/');
            //Ví dụ 07/08/2009
            string d = String.Format("{0}{1}{2}", partsDay[0], partsDay[1], partsDay[2]);
            key = key + d;
            string[] partsTime;
            partsTime = DateTime.Now.ToLongTimeString().Split(':');
            //Ví dụ 7:08:03 PM hoặc 7:08:03 AM\
            if (partsTime[2].Substring(3, 2) == "CH")
                partsTime[0] = ConvertTimeTo24(partsTime[0]);
            if (partsTime[2].Substring(3, 2) == "SA")
                if (partsTime[0].Length == 1)
                    partsTime[0] = "0" + partsTime[0];
            //Xóa ký tự trắng và PM hoặc AM
            partsTime[2] = partsTime[2].Remove(2, 3);
            string t;
            t = String.Format("{0}{1}{2}", partsTime[0], partsTime[1], partsTime[2]);
            key = key + t;

            return key;
        }

        //Chuyển đổi từ PM sang dạng 24h
        public static string ConvertTimeTo24(string hour)
        {
            string h = "";
            switch (hour)
            {
                case "01":
                    h = "13";
                    break;
                case "02":
                    h = "14";
                    break;
                case "03":
                    h = "15";
                    break;
                case "04":
                    h = "16";
                    break;
                case "05":
                    h = "17";
                    break;
                case "06":
                    h = "18";
                    break;
                case "07":
                    h = "19";
                    break;
                case "08":
                    h = "20";
                    break;
                case "09":
                    h = "21";
                    break;
                case "10":
                    h = "22";
                    break;
                case "11":
                    h = "23";
                    break;
                case "12":
                    h = "0";
                    break;
            }
            return h;
        }

        private static readonly string[] VietNamChar = new string[]
        {
        "aAeEoOuUiIdDyY",
        "áàạảãâấầậẩẫăắằặẳẵ",
        "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
        "éèẹẻẽêếềệểễ",
        "ÉÈẸẺẼÊẾỀỆỂỄ",
        "óòọỏõôốồộổỗơớờợởỡ",
        "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
        "úùụủũưứừựửữ",
        "ÚÙỤỦŨƯỨỪỰỬỮ",
        "íìịỉĩ",
        "ÍÌỊỈĨ",
        "đ",
        "Đ",
        "ýỳỵỷỹ",
        "ÝỲỴỶỸ"
        };
        public static string LocDau(string str)
        {
            //Thay thế và lọc dấu từng char      
            for (int i = 1; i < VietNamChar.Length; i++)
            {
                for (int j = 0; j < VietNamChar[i].Length; j++)
                    str = str.Replace(VietNamChar[i][j], VietNamChar[0][i - 1]);
            }
            return str;
        }

        public static void SendPasswordToMail(string sFrom, string sPass, string sTo, string sSubject, string sBody)
        {
            try
            {
                var client = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new System.Net.NetworkCredential(sFrom, sPass),
                    EnableSsl = true
                };
                var message = new System.Net.Mail.MailMessage(sFrom, sTo, sSubject, sBody);
                message.IsBodyHtml = true;
                client.Host = "smtp.gmail.com";
                client.Send(message);
                client.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
