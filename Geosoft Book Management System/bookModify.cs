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
    public partial class bookModify : Form
    {
        static string ConStr = @"Server=162.105.17.225;Port=5432;userid=postgres;Password=51186;Database=gbd";
        private NpgsqlConnection SqlConn = new NpgsqlConnection(ConStr);    

        public bookModify()
        {
            InitializeComponent();
            this.cb_status.Items.Add("新增:可借");
            this.cb_status.Items.Add("新增:不可借");
            this.cb_status.Items.Add("申购");

            this.cb_cate.Items.Add("地理学");
            this.cb_cate.Items.Add("数学");
            this.cb_cate.Items.Add("计算机科学");
            this.cb_cate.Items.Add("英语");
            this.cb_cate.Items.Add("其他");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string o = this.txt_owner.Text;
            string c = this.cb_cate.Text;
            string s = this.cb_status.Text;
            string b = this.txt_book.Text;
            string p = this.txt_publisher.Text;
            string y = this.txt_year.Text;
            string a = this.txt_author.Text;

            if(o == "" || c == "" || b == "" || p == "" || y == "" || a == "")
            {
                MessageBox.Show("信息需全部填写！", "错误");
                return;
            }

            if (!yearValid(y))
            {
                MessageBox.Show("输入年份无效！", "错误");
                this.txt_year.Text = "";
                return;
            }

            //MessageBox.Show(s.Length.ToString());
            if(s.Length == 2)
            {
                s = "申购中";
            }
            else if(s.Length == 5)
            {
                s = "可借";
            }
            else if(s.Length == 6)
            {
                s = "不可借";
            }

            Guid u = System.Guid.NewGuid();
            string qstr = "INSERT INTO gb VALUES ('" + u + "','" + b + "','" + a + "','" + p + "','" + y + "','" + c + "','" +
                o + "','" + s + "')";
            
            SqlConn.Open();
            NpgsqlCommand SqlCommand = new NpgsqlCommand(qstr, SqlConn);
            int r = SqlCommand.ExecuteNonQuery();         
            SqlConn.Close();

            if (r == 1)  //r如果是1为成功
            {
                MessageBox.Show("提交成功！");
                this.Close();
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
    }
}
