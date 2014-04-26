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
    public partial class Form1 : Form
    {
       
        public Form1(int id)
        {
            
            InitializeComponent();
            number.Text = id.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
                cn.ConnectionString = "server=.;database=ss;uid=sa;pwd=chq;";
            string sqlString = "select * from student1 where id =" + number.Text + "";
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sqlString;
            cmd.Connection = cn;
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                textBox1.Text = sdr["name"].ToString();
                textBox2.Text = sdr["total"].ToString();
                textBox3.Text = sdr["gold"].ToString();
                textBox4.Text = sdr["grade"].ToString();
                textBox5.Text = sdr["health"].ToString();
                textBox6.Text = sdr["moral"].ToString();
                textBox7.Text = sdr["honour"].ToString();
            }
        }

        private void number_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
