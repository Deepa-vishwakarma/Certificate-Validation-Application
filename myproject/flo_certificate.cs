using FloSDK.Exceptions;
using FloSDK.Methods;
using MessagingToolkit.QRCode.Codec;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myproject
{
    public partial class flo_certificate : Form
    {
        public static string cert_no;
        public static string url;
        public static string connstr = ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;
        //Image img;
        public flo_certificate(string certno)
        {
            InitializeComponent();
            cert_no = certno;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void flo_certificate_Load(object sender, EventArgs e)
        {
            string username = ConfigurationManager.AppSettings.Get("username");
            string password = ConfigurationManager.AppSettings.Get("password");
            string wallet_url = ConfigurationManager.AppSettings.Get("wallet_url");
            string wallet_port = ConfigurationManager.AppSettings.Get("wallet_port");
            string transid = "";
            SqlConnection con = new SqlConnection(connstr);
            con.Open();
            SqlCommand cmd = new SqlCommand("select Trans_no from Flo_record where Certi_no=@certno", con);
            cmd.Parameters.Add(new SqlParameter("@certno", cert_no));
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                transid = reader["Trans_no"].ToString();
            }

            con.Close();


            RpcMethods rpc = new RpcMethods(username, password, wallet_url, wallet_port);

           
            try
            {
                JObject obj = JObject.Parse(rpc.GetRawTransaction(transid));

                if (string.IsNullOrEmpty(obj["error"].ToString()))
                {
                    string res = obj["result"]["floData"].ToString();
                    string[] data = res.Split('#');

                    string name = data[1].ToString();
                    string fname = data[2].ToString();
                    string reg = data[3].ToString();
                    string course = data[4].ToString();
                    string grade = data[5].ToString();
                    string percentage = data[6].ToString();
                    string doj = data[7].ToString();
                    string dop = data[8].ToString();
                    string cer_date = data[9].ToString();
                    string cert_num = data[10].ToString();

                     url = "https://testnet.flocha.in/tx/"+transid;

                    lblName.Text = name;
                    lblGuardian.Text = fname;
                    lblReg_no.Text = reg;
                    lblCourse.Text = course;
                    lblGrade.Text = grade;
                    lblPercent.Text = percentage;
                    lblJoin_Date.Text = doj;
                    lblCompilition_Date.Text = dop;
                    lblDate.Text = cer_date;
                    lblCertificate_no.Text = cert_num;
                    linklblUrl.Text = url;

                    linklblUrl.Visible = true;
                    QRCodeEncoder enc = new QRCodeEncoder();
                    //Bitmap qrcode = enc.Encode(url);
                    //QRpicbox.Image = qrcode as System.Drawing.Image;
                    Bitmap img;
                    enc.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H;
                    enc.QRCodeScale = 10;
                    img=enc.Encode(url);
                    QRpicbox.Image = img;
                }
                else
                {
                    MessageBox.Show("Get Transaction Error : " + obj["error"]);
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
                linklblUrl.Visible = false;
            }
        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var frm = Form.ActiveForm;
            using (var bmp = new Bitmap(frm.Width, frm.Height))
            {
                frm.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save(@"D:\floCertificate.png");
            }
            MessageBox.Show("image saved in D drive ");
        }

        private void linklblUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo(url);
            Process.Start(sInfo);
        }
    }
}
