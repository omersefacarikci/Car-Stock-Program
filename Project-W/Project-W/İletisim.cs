using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
namespace Project_W
{
    public partial class İletisim : Form
    {
        public İletisim()
        {
            InitializeComponent();
        }
        MailMessage eposta = new MailMessage();

        //void mailgonder()
        //{
        //    eposta.From = new MailAddress("wi6421280@gmail.com");
        //    eposta.To.Add(guna2TextBox1.Text.ToString());
        //    eposta.Subject = guna2TextBox2.Text.ToString();
        //    eposta.Body = guna2TextBox3.Text.ToString();

        //    SmtpClient smtp = new SmtpClient();
        //    smtp.Credentials = new System.Net.NetworkCredential("wi6421280","buraya epostamızın şifresi gelecek")
        //SmtpClient.Host = "smtp.live.com"; microsoftun host adresi smtp.gmail.com gmailin host adresi
        //smtp.EnabeSsl = true;
        //smtp.Port=587
        //SmtpClient.Send(eposta);
        //MessageBox.Show (MailGönderildi);
        //}
        private void gönder_Click(object sender, EventArgs e)
        {
            //mailgonder();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
