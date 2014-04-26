using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace mul_teacher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "server=.;database=ss;uid=sa;pwd=chq;";

            SqlCommand cmd = new SqlCommand();
            cn.Open();
            cmd.CommandText = "select name from teacher";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                comboBox1.Items.Add(sdr["name"]);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
