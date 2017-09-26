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
    public partial class GBMS : Form
    {
        static string ConStr = @"Server=162.105.17.225;Port=12346;userid=postgres;Password=123;Database=gbd";
        private NpgsqlConnection SqlConn = new NpgsqlConnection(ConStr);    

        public GBMS()
        {
            InitializeComponent();
        }
     
        //查询          
        public DataTable Select(string sqrstr)
        {
            NpgsqlDataAdapter sqldap = new NpgsqlDataAdapter(sqrstr, SqlConn);
            DataTable dt = new DataTable();         
            sqldap.Fill(dt);  
            
            return dt;
        }    
     
        //增删改          
        public int Update(string sqrstr)
        {
            SqlConn.Open();
            NpgsqlCommand SqlCommand = new NpgsqlCommand(sqrstr, SqlConn);
            int r = SqlCommand.ExecuteNonQuery();
            //执行查询并返回值，可以不返回值             
            SqlConn.Close();
            return r;   //r如果是1就是增删改成功
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();

            string o = this.cb_owner.Text;
            string c = this.cb_cate.Text;
            string s = this.cb_status.Text;
            string b = this.textBox1.Text;
            string sqr = "select * from gb where book " + (b != "" ? ("like '%" + b + "%'") : "is not null") + " and category " + (c != "" ? ("= '" + c + "'") : "is not null") +
                " and status " + (s != "" ? ("= '" + s + "'") : "is not null") + " and owner " + (o != "" ? ("like '%" + o + "%'") : "is not null");
            DataTable dt = Select(sqr);
            if (dt.Rows.Count != 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    this.dataGridView1.Rows.Add(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(),
                        dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString(), dt.Rows[i][6].ToString(), dt.Rows[i][7].ToString());
                }
            }
            else
            {
                MessageBox.Show("未查询到相关书目！");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("谢谢使用Geosoft图书管理系统！", "提示");
            this.Close();
        }

        private void bought_Click(object sender, EventArgs e)
        {
            bookModify dlg = new bookModify();
            dlg.ShowDialog();
        }

        private void modify_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                if (this.dataGridView1.Rows[i].Cells[8].EditedFormattedValue.ToString() == "True")
                {
                    if(this.dataGridView1.Rows[i].Cells["id"].Value.ToString() != "")
                    {
                        bookMD bm = new bookMD(this.dataGridView1.Rows[i].Cells["id"].Value.ToString());
                        bm.ShowDialog();
                        refreshAction();
                    }
                }
            }
        }

        private void GBMS_Load(object sender, EventArgs e)
        {
            DataTable dt = Select("select distinct owner from gb");
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    this.cb_owner.Items.Add(dt.Rows[i][0].ToString());
                }
            }

            this.cb_cate.Items.Add("");
            this.cb_cate.Items.Add("地理学");
            this.cb_cate.Items.Add("数学");
            this.cb_cate.Items.Add("计算机科学");
            this.cb_cate.Items.Add("英语");
            this.cb_cate.Items.Add("其他");

            this.cb_status.Items.Add("");
            this.cb_status.Items.Add("不可借");
            this.cb_status.Items.Add("可借");
            this.cb_status.Items.Add("申购中");

            this.dataGridView1.AllowUserToAddRows = false;
        }

        private void enter_Click(object sender, EventArgs e)
        {
            bookModify bm = new bookModify();
            bm.ShowDialog();
            refreshAction();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            refreshAction();
        }

        private void refreshAction()
        {
            this.dataGridView1.Rows.Clear();

            string o = this.cb_owner.Text;
            string c = this.cb_cate.Text;
            string s = this.cb_status.Text;
            string b = this.textBox1.Text;
            string sqr = "select * from gb where book " + (b != "" ? ("like '%" + b + "%'") : "is not null") + " and category " + (c != "" ? ("= '" + c + "'") : "is not null") +
                " and status " + (s != "" ? ("= '" + s + "'") : "is not null") + " and owner " + (o != "" ? ("like '%" + o + "%'") : "is not null");
            DataTable dt = Select(sqr);
            if (dt.Rows.Count != 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    this.dataGridView1.Rows.Add(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(),
                        dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString(), dt.Rows[i][6].ToString(), dt.Rows[i][7].ToString());
                }
            }
        }

    }
}
