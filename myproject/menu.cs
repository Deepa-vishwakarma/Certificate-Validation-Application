
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
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using iTextSharp.text;
//using iTextSharp.text.pdf;
using System.Diagnostics;
using MessagingToolkit.QRCode.Codec;

namespace myproject
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new_stud n = new new_stud();
            n.Show();

        }

        private void studentformToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            choose_reg_no ch = new choose_reg_no();
            ch.Show();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void validationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            validation n = new validation();
            n.Show();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{

        //        var frm = Form.ActiveForm;
        //        using (var bmp = new Bitmap(frm.Width, frm.Height))
        //        {
        //            frm.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
        //            bmp.Save(@"D:\screenshot.png");
        //        }

        //}
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    var frm = Form.ActiveForm;
        //    using (var bmp = new Bitmap(frm.Width, frm.Height))
        //    {
        //        frm.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height));
        //        MessageBox.Show("image size in pixel" + bmp.Size);

        //        string imgPath = @"D:\screenshot6.png";

        //        bmp.Save(imgPath);
        //        string imgBase64String = GetBase64StringForImage(imgPath);
        //        MessageBox.Show("image size" + imgBase64String.Length);

        //    }
        //    MessageBox.Show("image saved in D drive ");

        //}


        //Console.WriteLine(imgBase64String);

        //protected static string GetBase64StringForImage(string imgPath)
        //{
        //    byte[] imageBytes = System.IO.File.ReadAllBytes(imgPath);
        //    string base64String = Convert.ToBase64String(imageBytes);
        //    return base64String;
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{

            //using (System.IO.MemoryStream memoryStream = new System.IO.MemoryStream())
            //{
            //    Document document = new Document(PageSize.A4, 10, 10, 10, 10);

            //    PdfWriter writer = PdfWriter.GetInstance(document, memoryStream);
            //    document.Open();

            //    Chunk chunk = new Chunk("This is from chunk. ");
            //    document.Add(chunk);

            //    Phrase phrase = new Phrase("This is from Phrase.");
            //    document.Add(phrase);

            //    Paragraph para = new Paragraph("This is from paragraph.");
            //    document.Add(para);

            //   // string text = @ "you are successfully created PDF file.";
            //    Paragraph paragraph = new Paragraph();
            //    paragraph.SpacingBefore = 10;
            //    paragraph.SpacingAfter = 10;
            //    paragraph.Alignment = Element.ALIGN_LEFT;
            //    paragraph.Font = FontFactory.GetFont(FontFactory.HELVETICA, 12f, BaseColor.GREEN);
            //    //paragraph.Add(text);
            //    document.Add(paragraph);
                
            //    document.Close();
            //    byte[] bytes = memoryStream.ToArray();
            //    memoryStream.Close();
            //    //Response.Clear();
            //    //Response.ContentType = "application/pdf";

            //    //string pdfName = "User";
            //    //Response.AddHeader("Content-Disposition", "attachment; filename=" + pdfName + ".pdf");
            //    //Response.ContentType = "application/pdf";
            //    //Response.Buffer = true;
            //    //Response.Cache.SetCacheability(System.Web.HttpCacheability.NoCache);
            //    //Response.BinaryWrite(bytes);
            //    //Response.End();
            //    //Response.Close();
            
            //}
            // Create a new PDF document
        //    PdfDocument document = new PdfDocument();

        //    // Create an empty page
        //    PdfPage page = document.AddPage();

        //    // Get an XGraphics object for drawing
        //    XGraphics gfx = XGraphics.FromPdfPage(page);

        //    // Create a font
        //    XFont font = new XFont("Verdana", 20, XFontStyle.Bold);

        //    // Draw the text
        //    gfx.DrawString("Hello, World!", font, XBrushes.Black,
        //      new XRect(0, 0, page.Width, page.Height),
        //      XStringFormat.Center);

        //    // Save the document...
        //    string filename = @"D:\HelloWorld.pdf";
        //    document.Save(filename);
        //    // ...and start a viewer.
        //    Process.Start(filename);

        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    string yourcode = textBox1.Text;
        //    QRCodeEncoder enc = new QRCodeEncoder();
        //    Bitmap qrcode = enc.Encode(yourcode);
        //    pictureBox1.Image = qrcode as System.Drawing.Image;
        //}

        //private void pictureBox1_Click(object sender, EventArgs e)
        //{

        //}
    }
}

