using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Geosoft_Book_Management_System
{
    public partial class bookMD : Form
    {
        static string ConStr = @"Server=162.105.17.225;Port=5432;userid=postgres;Password=51186;Database=gbd";
        private NpgsqlConnection SqlConn = new NpgsqlConnection(ConStr);
        private string bookid;
        public bookMD(string bid)
        {
            InitializeComponent();

            this.bookid = bid;

            this.cb_status.Items.Add("可借");
            this.cb_status.Items.Add("不可借");

            this.cb_cate.Items.Add("地理学");
            this.cb_cate.Items.Add("数学");
            this.cb_cate.Items.Add("计算机科学");
            this.cb_cate.Items.Add("英语");
            this.cb_cate.Items.Add("其他");

            string sqr = "select * from gb where bid = '" + bid + "'";
            NpgsqlDataAdapter sqldap = new NpgsqlDataAdapter(sqr, SqlConn);
            DataTable dt = new DataTable();
            sqldap.Fill(dt);
            if (dt != null)
            {
                this.txt_book.Text = dt.Rows[0][1].ToString();
                this.txt_author.Text = dt.Rows[0][2].ToString();
                this.txt_publisher.Text = dt.Rows[0][3].ToString();
                this.txt_year.Text = dt.Rows[0][4].ToString();
                this.cb_cate.Text = dt.Rows[0][5].ToString();
                this.txt_owner.Text = dt.Rows[0][6].ToString();
                this.cb_status.Text = dt.Rows[0][7].ToString();
            }
            
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConn.Open();
            string sqrstr = "delete from gb where bid = '" + this.bookid + "'";
            NpgsqlCommand SqlCommand = new NpgsqlCommand(sqrstr, SqlConn);
            int r = SqlCommand.ExecuteNonQuery();
                        
            SqlConn.Close();
            if (r == 1)  //r如果是1为成功
            {
                MessageBox.Show("删除成功！");
                this.Close();
            }
        }

        private void modify_Click(object sender, EventArgs e)
        {
            SqlConn.Open();
            string sqrstr = "delete from gb where bid = '" + this.bookid + "'";
            NpgsqlCommand SqlCommand1 = new NpgsqlCommand(sqrstr, SqlConn);
            int r1 = SqlCommand1.ExecuteNonQuery();


            string o = this.txt_owner.Text;
            string c = this.cb_cate.Text;
            string s = this.cb_status.Text;
            string b = this.txt_book.Text;
            string p = this.txt_publisher.Text;
            string y = this.txt_year.Text;
            string a = this.txt_author.Text;

            if (o == "" || c == "" || b == "" || p == "" || y == "" || a == "")
            {
                MessageBox.Show("信息需全部填写！", "错误");
                SqlConn.Close();
                return;
            }

            if (!yearValid(y))
            {
                MessageBox.Show("输入年份无效！", "错误");
                this.txt_year.Text = "";
                SqlConn.Close();
                return;
            }

            string qstr = "INSERT INTO gb VALUES ('" + bookid + "','" + b + "','" + a + "','" + p + "','" + y + "','" + c + "','" +
                o + "','" + s + "')";

            NpgsqlCommand SqlCommand = new NpgsqlCommand(qstr, SqlConn);
            int r = SqlCommand.ExecuteNonQuery();
            SqlConn.Close();

            if (r == 1 && r1 == 1)  //r如果是1为成功
            {
                MessageBox.Show("修改成功！");
            }
        }

        private bool yearValid(string s)
        {
            if (!isNum(s))
            {
                return false;
            }
            if (s.Length != 4)
            {
                return false;
            }

            int m = Convert.ToInt16(s);
            if (m < 1)
            {
                return false;
            }

            return true;
        }

        private bool isNum(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                byte tempByte = Convert.ToByte(s[i]);
                if ((tempByte < 48 || tempByte > 57))
                {
                    return false;
                }
            }
            return true;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
