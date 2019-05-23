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
    
    public partial class choose_reg_no : Form
    {
        public static string connstr = ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;
        public choose_reg_no()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        private void choose_reg_no_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connstr);
            con.Open();
            cmd = new SqlCommand("select Reg_no from student", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbBoxReg_no.Items.Add(dr[0].ToString());
            }
            cmbBoxReg_no.Text = "Select Reg_no";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select Reg_no from student where Reg_no=@r", con);
            cmd.Parameters.Add(new SqlParameter("@r", cmbBoxReg_no.Text));
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            
            if (cmbBoxReg_no.Text =="" )
            {
                MessageBox.Show("Registration no. is required");
            }
            else
            {
                this.Hide();
                student_form sf = new student_form(cmbBoxReg_no.Text);
                sf.Show();
            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu m = new menu();
            m.Show();
        }
    }
}
