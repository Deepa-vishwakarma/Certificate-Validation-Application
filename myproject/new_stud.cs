using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace myproject
{
    public partial class new_stud : Form
    {
        public static string connstr = ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public new_stud()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtFathers_Name.Text == "" || txtReg_no.Text == "" || txtCourse.Text == "" || txtDoj.Text == "" || txtDoj.Text == "" || txtCompletionDate.Text == "" || txtGrade.Text == "" || txtMarks.Text == "")
            {
                MessageBox.Show("all fields are required");
            }
            else
            {
                con = new SqlConnection(connstr);
                con.Open();
                cmd = new SqlCommand("insert into student values(@n,@f,@r,@c,@dj,@dc,@g,@m)", con);
                cmd.Parameters.Add(new SqlParameter("@n", txtName.Text));
                cmd.Parameters.Add(new SqlParameter("@f", txtFathers_Name.Text));
                cmd.Parameters.Add(new SqlParameter("@r", Convert.ToInt32(txtReg_no.Text)));
                cmd.Parameters.Add(new SqlParameter("@c", txtCourse.Text));
                cmd.Parameters.Add(new SqlParameter("@dj", txtDoj.Text));
                cmd.Parameters.Add(new SqlParameter("@dc", txtCompletionDate.Text));
                cmd.Parameters.Add(new SqlParameter("@g", txtGrade.Text));
                cmd.Parameters.Add(new SqlParameter("@m", Convert.ToDecimal(txtMarks.Text)));
                dr = cmd.ExecuteReader();

                MessageBox.Show("student details saved");
                this.Hide();
                menu m = new menu();
                m.Show();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void new_stud_Load(object sender, EventArgs e)
        {
            txtName.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu m = new menu();
            m.Show();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
