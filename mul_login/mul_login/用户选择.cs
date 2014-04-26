using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mul_login
{
    public partial class 用户选择 : Form
    {
        public 用户选择()
        {
            InitializeComponent();
        }

        private void 用户选择_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            教师登录界面 form = new 教师登录界面();
            form.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            学生登录 form = new 学生登录();
            form.Show();
            this.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                教师登录界面 form = new 教师登录界面();
                form.Show();
                this.Hide();
            }
            else if (radioButton2.Checked)
            {
                学生登录 form = new 学生登录();
                form.Show();
                this.Hide();
            }
        }
    }
}
