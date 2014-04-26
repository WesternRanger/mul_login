using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace mul_login
{
    public partial class 学生登录 : Form
    {
        
        //public string name;
        public 学生登录()
        {
           
            InitializeComponent();
        }
        //public 学生查看成绩界面(string name) {
        //    this.name = name;
        //}
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("请输入学号！");
            else if (textBox2.Text == "")
                MessageBox.Show("请输入密码！");
            else
            {
                
                int spwd = int.Parse(textBox2.Text);
                int sid = int.Parse(textBox1.Text);   
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = "server=.;database=ss;uid=sa;pwd=chq;";
               
                string sqlString = "select * from student1 where id =" + sid + "and pwd="+spwd+"";
                
                SqlDataAdapter sda = new SqlDataAdapter(sqlString, cn);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("输入的学号或密码错误！");
                }

                
                else
                {
                        Form1 a = new Form1(sid);
                        a.Show();
                        this.Hide();
  
                }
                   
                }
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox2.Focus();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.Focus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        }

      
    }

