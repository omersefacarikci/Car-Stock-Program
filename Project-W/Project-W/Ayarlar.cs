using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Net.WebRequestMethods;
using Guna.UI2.WinForms;
using System.Xml.Linq;
namespace Project_W
{
    public partial class Ayarlar : Form
    {
        public Ayarlar()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa frm = new Anasayfa();
            frm.ShowDialog();
            this.Hide();
        }

        private void Ayarlar_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenUrlGithub("https://github.com/OmerSefa2345");
        }
        void OpenUrlGithub(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {

                MessageBox.Show($"URL açılırken hata oluştu: {ex.Message}");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenUrlLinkedin("https://www.linkedin.com/in/%C3%B6mer-sefa-%C3%A7ar%C4%B1k%C3%A7%C4%B1/");
        }
        void OpenUrlLinkedin(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {

                MessageBox.Show($"URL açılırken hata oluştu: {ex.Message}");
            }
        }

        //private void pictureBox2_Click(object sender, EventArgs e)
        //{
        //    Anasayfa anasayfaForm = (Anasayfa)Application.OpenForms["Anasayfa"];

        //    if (anasayfaForm != null)
        //    {
        //        // Anasayfa formundaki PictureBox'tan resmi al
        //        pictureBox2.Image = anasayfaForm.pictureBox1.Image; // Anasayfa formundaki PictureBox'ı uygun şekilde belirtin
        //    }
        //}

        //private void pictureBox3_Click(object sender, EventArgs e)
        //{
        //    Anasayfa anasayfaForm = (Anasayfa)Application.OpenForms["Anasayfa"];

        //    if (anasayfaForm != null)
        //    {
        //        // Anasayfa formundaki PictureBox'tan resmi al
        //        pictureBox3.Image = anasayfaForm.pictureBox1.Image; // Anasayfa formundaki PictureBox'ı uygun şekilde belirtin
        //    }
        //}

        //private void pictureBox4_Click(object sender, EventArgs e)
        //{
        //    Anasayfa anasayfaForm = (Anasayfa)Application.OpenForms["Anasayfa"];

        //    if (anasayfaForm != null)
        //    {
        //        // Anasayfa formundaki PictureBox'tan resmi al
        //        pictureBox4.Image = anasayfaForm.pictureBox1.Image; // Anasayfa formundaki PictureBox'ı uygun şekilde belirtin
        //    }
        //}

        //private void pictureBox5_Click(object sender, EventArgs e)
        //{
        //    Anasayfa anasayfaForm = (Anasayfa)Application.OpenForms["Anasayfa"];

        //    if (anasayfaForm != null)
        //    {
        //        // Anasayfa formundaki PictureBox'tan resmi al
        //        pictureBox5.Image = anasayfaForm.pictureBox1.Image; // Anasayfa formundaki PictureBox'ı uygun şekilde belirtin
        //    }
        //}

        //private void pictureBox6_Click(object sender, EventArgs e)
        //{
        //    Anasayfa anasayfaForm = (Anasayfa)Application.OpenForms["Anasayfa"];

        //    if (anasayfaForm != null)
        //    {
        //        // Anasayfa formundaki PictureBox'tan resmi al
        //        pictureBox6.Image = anasayfaForm.pictureBox1.Image; // Anasayfa formundaki PictureBox'ı uygun şekilde belirtin
        //    }
        //}

        //private void pictureBox7_Click(object sender, EventArgs e)
        //{
        //    Anasayfa anasayfaForm = (Anasayfa)Application.OpenForms["Anasayfa"];

        //    if (anasayfaForm != null)
        //    {
        //        // Anasayfa formundaki PictureBox'tan resmi al
        //        pictureBox7.Image = anasayfaForm.pictureBox1.Image; // Anasayfa formundaki PictureBox'ı uygun şekilde belirtin
        //    }
        //}
    }
}
