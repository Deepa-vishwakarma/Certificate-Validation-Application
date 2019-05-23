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

namespace myproject
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {

           
                if (txtUser_Name.Text =="user366pi" && txtPassword.Text =="366pi")
                {
        
                      this.Hide();
                    menu m = new menu();
                    m.Show();
                }
                else if(txtUser_Name.Text == "" || txtPassword.Text == "")
                 {
                MessageBox.Show("Please fill the user name and password");
                 }
                
                else
                {
                   
                    MessageBox.Show("Not a valid user.", "Login", MessageBoxButtons.OK);
                    txtUser_Name.Text = "";
                    txtPassword.Text = "";
                }
            }
   
        private void login_form_Load(object sender, EventArgs e)
        {
            txtUser_Name.Focus();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
