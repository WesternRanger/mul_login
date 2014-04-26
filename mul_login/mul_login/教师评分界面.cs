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
    public partial class 教师评分界面 : Form
    {
        //SqlConnection cn = new SqlConnection();
       
        public 教师评分界面()
        {
            //cn.ConnectionString = "server=.;database=ss;uid=sa;pwd=chq;";
            InitializeComponent();
        }

        private void 教师评分界面_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = "server=.;database=ss;uid=sa;pwd=chq;";
                SqlCommand cmd = new SqlCommand();
                cn.Open();
                string sql =
"update student1 set grade=" + textBox1.Text + ",health=" + textBox2.Text + " ,moral=" + textBox3.Text + ",honour=" + textBox4.Text + ", total=" + textBox5.Text + ",gold='" + textBox6.Text + "'  where name='" + radioButton1.Text + "';";
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
               
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();//执行语句
                
                
                
                
                
                MessageBox.Show("提交数据成功！");
                cn.Close();
            }
            else if (radioButton2.Checked)
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = "server=.;database=ss;uid=sa;pwd=chq;";
                SqlCommand cmd = new SqlCommand();
                cn.Open();
                cmd.CommandText =
"update student1 set grade=" + textBox1.Text + ",health=" + textBox2.Text + " ,moral=" + textBox3.Text + ",honour=" + textBox4.Text + ", total=" + textBox5.Text + ",gold='" + textBox6.Text + "'  where name='" + radioButton2.Text + "';";
                cmd.CommandType = CommandType.Text;

                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("提交数据成功！");
                cn.Close();
            }
            else if (radioButton3.Checked)
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = "server=.;database=ss;uid=sa;pwd=chq;";
                SqlCommand cmd = new SqlCommand();
                cn.Open();
                cmd.CommandText =
"update student1 set grade=" + textBox1.Text + ",health=" + textBox2.Text + " ,moral=" + textBox3.Text + ",honour=" + textBox4.Text + ", total=" + textBox5.Text + ",gold='" + textBox6.Text + "'  where name='" + radioButton3.Text + "';";
                cmd.CommandType = CommandType.Text;

                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("提交数据成功！");
                cn.Close();
            }
            else if (radioButton4.Checked)
            {
                
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = "server=.;database=ss;uid=sa;pwd=chq;";
                SqlCommand cmd = new SqlCommand();
                cn.Open();
                cmd.CommandText =
"update student1 set grade=" + textBox1.Text + ",health=" + textBox2.Text + " ,moral=" + textBox3.Text + ",honour=" + textBox4.Text + ", total=" + textBox5.Text + ",gold='" + textBox6.Text + "'  where name='" + radioButton4.Text + "';";
                cmd.CommandType = CommandType.Text;
           
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("提交数据成功！");
                cn.Close();
            }
            else if (radioButton5.Checked)
            {
               
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = "server=.;database=ss;uid=sa;pwd=chq;";
                SqlCommand cmd = new SqlCommand();
                cn.Open();
                cmd.CommandText =
"update student1 set grade=" + textBox1.Text + ",health=" + textBox2.Text + " ,moral=" + textBox3.Text + ",honour=" + textBox4.Text + ", total=" + textBox5.Text + ",gold='" + textBox6.Text + "'  where name='" + radioButton5.Text + "';";
                cmd.CommandType = CommandType.Text;

                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("提交数据成功！");
                cn.Close();
            }
            else if (radioButton6.Checked)
            {
                string str = radioButton6.Text;
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = "server=.;database=ss;uid=sa;pwd=chq;";
                SqlCommand cmd = new SqlCommand();
                cn.Open();
                cmd.CommandText =
//"update student1 set grade=" + textBox1.Text + "，health=" + textBox2.Text + " ,moral=" + textBox3.Text + ",honour=" + textBox4.Text + ", total=" + textBox5.Text + ",gold='" + textBox6.Text + "'  where name='" + radioButton6.Text + "';";
                "update student1 set grade=" + textBox1.Text + ",health=" + textBox2.Text + " ,moral=" + textBox3.Text + ",honour=" + textBox4.Text + ", total=" + textBox5.Text + ",gold='" + textBox6.Text + "'  where name='" + radioButton6.Text + "';";
                cmd.CommandType = CommandType.Text;

                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("提交数据成功！");
                cn.Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
       
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int num3 = int.Parse(textBox3.Text);
            int num4 = int.Parse(textBox4.Text);
           
            int sum = num1 + num2 + num3 + num4;
            textBox5.Text = sum.ToString();

                      
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox5.Text);
            switch (a)
            {
                case 1:
                    textBox6.Text = "没有获得奖学金";
                    break;
                case 2:
                    textBox6.Text = "没有获得奖学金";
                    break;
                case 3:
                    textBox6.Text = "没有获得奖学金";
                    break;
                case 4:
                    textBox6.Text = "没有获得奖学金";
                    break;
                case 5:
                    textBox6.Text = "没有获得奖学金";
                    break;
                case 6:
                    textBox6.Text = "没有获得奖学金";
                    break;
                case 7:
                     textBox6.Text = "没有获得奖学金";
                     break;
                case 8:
                     textBox6.Text = "没有获得奖学金";
                     break;
                case 9:
                     textBox6.Text = "没有获得奖学金";
                     break;
                case 10:
                     textBox6.Text = "没有获得奖学金";
                     break;
                case 11:
                     textBox6.Text = "没有获得奖学金";
                     break;
                case 12:
                     textBox6.Text = "没有获得奖学金";
                    break;
                case 13:
                     textBox6.Text = "没有获得奖学金";
                     break;
                case 14:
                     textBox6.Text = "没有获得奖学金";
                     break;
                case 15:
                    textBox6.Text = "没有获得奖学金";
                    break;
                case 16:
                    textBox6.Text = "校二级";
                    break;
                case 17:
                    textBox6.Text = "校二级";
                    break;
                case 18:
                    textBox6.Text = "校一级";
                    break;
                case 19:
                    textBox6.Text = "校一级";
                    break;
                case 20:
                    textBox6.Text = "国家级";
                    break;
                default:
                    textBox6.Text = "输入分数有误！";
                    break;

            }
        }

        private void 教师评分界面_Activated(object sender, EventArgs e)
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
                textBox3.Focus();
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox4.Focus();
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button2.Focus();
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox5.Focus();
        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox6.Focus();
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.Focus();
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if(textBox5.Size!=null)
                button3.Focus();
        }

       
    }
}
