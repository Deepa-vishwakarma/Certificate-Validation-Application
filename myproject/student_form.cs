using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using FloSDK.Methods;
using FloSDK.Exceptions;
using Newtonsoft.Json.Linq;

namespace myproject
{
    public partial class student_form : Form
    {
        public static string  r;
        public static string connstr = ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;
       public student_form(string  reg)
        {
            r = reg;
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void student_form_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connstr);
            con.Open();
            //string cert = "PTRN005";
            //int count=0;

            lblReg_no.Text = r;
            lblIssueDate.Text = DateTime.Now.ToShortDateString();
           
            
            //count++;
            //label31.Text = cert + count.ToString();

            cmd = new SqlCommand("select Name,Fathers_name,Course,Grade,Marks,Date_j,Date_c from student where Reg_no = @rn", con);
            cmd.Parameters.Add(new SqlParameter("@rn", lblReg_no.Text));
            //cmd.Parameters.Add(new SqlParameter("@r", comboBox1.Text));
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                lblName.Text = (dr[0].ToString());
                lblGuardianName.Text = (dr[1].ToString());
                lblCourse.Text = (dr[2].ToString());
                lblGrade.Text = (dr[3].ToString());
                lblPercent.Text = (dr[4].ToString());
                DateTime dt = DateTime.Parse(dr[5].ToString());
                lblDoj.Text = (dt.ToString("dd-MM-yyyy"));
                dt = DateTime.Parse(dr[6].ToString());
                lblCompletion_Date.Text = (dt.ToString("dd-MM-yyyy"));               

            }
            lblCertificate_no.Text = DateTime.Now.ToString("ddMMyyyyhhmmss");

            con.Close();


            string username = ConfigurationManager.AppSettings.Get("username");
            string password = ConfigurationManager.AppSettings.Get("password");
            string wallet_url = ConfigurationManager.AppSettings.Get("wallet_url");
            string wallet_port = ConfigurationManager.AppSettings.Get("wallet_port");


            RpcMethods rpc = new RpcMethods(username, password, wallet_url, wallet_port);
            string tranid = "";
            string flodata = "deepacertproject#" + lblName.Text + "#" + lblGuardianName.Text + "#" + lblReg_no.Text + "#" + lblCourse.Text + "#" + lblGrade.Text + "#" + lblPercent.Text + "#" + lblDoj.Text + "#" + lblCompletion_Date.Text + "#" + lblIssueDate.Text+"#"+lblCertificate_no.Text ;
            try
            {
                JObject obj = JObject.Parse(rpc.SendToAddress("oXFZb6CJFfw5E46hLFwiMKdPt3LEUtuV4L", 0.01M, "Test comment", "Test Comment", false, false, 1, "UNSET", flodata));
               
                if (string.IsNullOrEmpty(obj["error"].ToString()))
                {
                    tranid = obj["result"].ToString();
                    con = new SqlConnection(connstr);
                    con.Open();
                    cmd = new SqlCommand("insert into Flo_record values(@r,@t,@c)", con);
                    cmd.Parameters.Add(new SqlParameter("@r", lblReg_no.Text));
                    cmd.Parameters.Add(new SqlParameter("@t", tranid));
                    cmd.Parameters.Add(new SqlParameter("@c", lblCertificate_no.Text));
                    cmd.ExecuteNonQuery();
                    con.Close();


                    Console.WriteLine("Transaction ID : " + obj["result"]);
                }
                else
                {
                    MessageBox.Show("Send Transaction Error : " + obj["error"]);
                }
            }
            catch (RpcInternalServerErrorException exception)
            {
                var errorCode = 0;
                var errorMessage = string.Empty;

                if (exception.RpcErrorCode.GetHashCode() != 0)
                {
                    errorCode = exception.RpcErrorCode.GetHashCode();
                    errorMessage = exception.RpcErrorCode.ToString();
                }

                Console.WriteLine("[Failed] {0} {1} {2}", exception.Message, errorCode != 0 ? "Error code: " + errorCode : string.Empty, !string.IsNullOrWhiteSpace(errorMessage) ? errorMessage : string.Empty);
                MessageBox.Show("Wallet Error Code : " + errorCode);
            }
            catch (Exception exception)
            {
                MessageBox.Show("[Failed]\n\nPlease check your configuration and make sure that the daemon is up and running and that it is synchronized. \n\nException: " + exception);
            }



        }

        private void label31_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = Form.ActiveForm;
            using (var bmp = new Bitmap(frm.Width, frm.Height))
            {
                frm.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height));
                string imgPath = @"D:\screenshot5.png";
                string imgBase64String = GetBase64StringForImage(imgPath);
                //bmp.Save(imgPath);
                string size = imgPath;
                MessageBox.Show("image size " + size);
            }
            MessageBox.Show("image saved in D drive ");
           
        }
       
           
            //Console.WriteLine(imgBase64String);
        
        protected static string GetBase64StringForImage(string imgPath)
        {
            byte[] imageBytes = System.IO.File.ReadAllBytes(imgPath);
            string base64String = Convert.ToBase64String(imageBytes);
            return base64String;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {
           
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void label13_Click_1(object sender, EventArgs e)
        {

        }
    }
}
