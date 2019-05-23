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
using Newtonsoft.Json.Linq;
using FloSDK.Methods;
using FloSDK.Exceptions;

namespace myproject
{
    public partial class validation : Form
    {
        public static string connstr = ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;

        public validation()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        private void validation_Load(object sender, EventArgs e)
        {
            txtCertificate_no.Focus();
            con = new SqlConnection(connstr);
            con.Open();


            string username = ConfigurationManager.AppSettings.Get("username");
            string password = ConfigurationManager.AppSettings.Get("password");
            string wallet_url = ConfigurationManager.AppSettings.Get("wallet_url");
            string wallet_port = ConfigurationManager.AppSettings.Get("wallet_port");


            RpcMethods rpc = new RpcMethods(username, password, wallet_url, wallet_port);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (txtCertificate_no.Text==null)
            //{
            //    MessageBox.Show("Certificate no. is required");
            //}
            //else
            //{
                this.Hide();
                string certno = txtCertificate_no.Text;
                flo_certificate frm = new flo_certificate(certno);
                frm.Show();
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu m = new menu();
            m.Show ();
        }

        
    }
}
