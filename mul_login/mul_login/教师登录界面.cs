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
    public partial class 教师登录界面 : Form
    { 
        
        public 教师登录界面()
        {
            InitializeComponent();
        }

        private void 教师登录界面_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "server=.;database=ss;uid=sa;pwd=chq;";
            SqlCommand cmd = new SqlCommand();
            cn.Open();
            cmd.CommandText = "select name from teacher";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;
            cmd.ExecuteNonQuery();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                comboBox2.Items.Add(sdr["name"]);
            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = comboBox2.Text;
            string str2 = textBox1.Text;
            string str3 = textBox2.Text;
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "server=.;database=ss;uid=sa;pwd=chq;";

            string sql = "select * from teacher;";

            cn.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = sql;
            cmd.Connection = cn;
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {

                if (sdr.HasRows != false)
                {
                    教师评分界面 form = new 教师评分界面();
                    form.Show();
                    this.Visible = false;

                }
                else
                    MessageBox.Show("密码错误，请重新输入！！");
               
                
            }
            cn.Close();
        }
            
        

      



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void 教师登录界面_KeyDown(object sender, KeyEventArgs e)
        {



        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                comboBox2.Focus();
        }

       


        
        private void 教师登录界面_Activated_1(object sender, EventArgs e)
        {
            this.textBox2.Focus();
        }

        private void comboBox2_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox1.Focus();
        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.Focus();
        }

    }
}


