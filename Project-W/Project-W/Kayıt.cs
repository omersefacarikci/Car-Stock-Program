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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Guna.UI2.WinForms;
namespace Project_W
{
    public partial class Kayıt : Form
    {
        public Kayıt()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ÖMER;Initial Catalog=GaleriYönetimSistemi2024;Integrated Security=True");
        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Kaydet();
        }
        public void Kaydet()
        {
            string[] resimadlari = new string[8];
            int x = 0;
            ARABA aRABA = new ARABA();
            aRABA.Marka = guna2TextBox1.Text;
            aRABA.Model = guna2TextBox2.Text;
            aRABA.Yıl = guna2TextBox3.Text;
            aRABA.Km = Convert.ToInt32 (guna2TextBox5.Text);
            aRABA.Motor = guna2TextBox6.Text;
            aRABA.Beygir = guna2TextBox7.Text;
            aRABA.Yakıt = guna2TextBox9.Text;
            aRABA.Vites = guna2TextBox10.Text;
            aRABA.Renk = guna2ComboBox1.SelectedItem.ToString();
            

            foreach (Control item in this.Controls)
            {
                if (item is PictureBox picture && picture.Image != null)
                {
                    string guidid = Guid.NewGuid().ToString();
                    string resimAdi = guidid.ToString();
                    string pathKAYDET = @"C:\Users\Ömer Sefa\Desktop\RESİM" + "\\" + $"{guidid}.jpg";

                    Bitmap bmp = new Bitmap(picture.Image);
                    bmp.Save(pathKAYDET, System.Drawing.Imaging.ImageFormat.Png);
                    resimadlari[x] = resimAdi;
                    x++;

                }

            }
            aRABA.AracResim1 = resimadlari[0].ToString();
            aRABA.AracResim2 = resimadlari[1].ToString();
            aRABA.AracResim3 = resimadlari[2].ToString();
            aRABA.AracResim4 = resimadlari[3].ToString();
            aRABA.AracResim5 = resimadlari[4].ToString();
            aRABA.AracResim6 = resimadlari[5].ToString();
            aRABA.AracResim7 = resimadlari[6].ToString();
            aRABA.AracResim8 = resimadlari[7].ToString();
            MessageBox.Show("Kayıt başarılı!");

            new SQLKayit().AracKayit(aRABA);
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyaları|*.png;*.jpg;*.jpeg;*.gif";
            openFileDialog.Title = "Bir Resim Seçin";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = openFileDialog.FileName;
                    Image image = Image.FromFile(path);

                    // `Form1`'deki `PictureBox`'ları bul
                    int index = 0;
                    foreach (Control item in this.Controls)
                    {
                        if (item is Guna2PictureBox pictureBox && pictureBox.Image == null)
                        {
                            pictureBox.Image = image;

                            index++;
                            break; // Bir tane `PictureBox`'a resim eklendi, çık

                        }
                       

                        if (index >= 8)
                        {
                            break;
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Resim türü desteklenmiyor: " + ex.Message, "RESİM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text = "";
            guna2TextBox2.Text = "";
            guna2TextBox3.Text = "";
            guna2TextBox5.Text = "";
            guna2TextBox6.Text = "";
            guna2TextBox7.Text = "";
            guna2ComboBox1.SelectedItem = "";
            guna2TextBox9.Text = "";
            guna2TextBox10.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa frm = new Anasayfa();
            frm.ShowDialog();
            this.Hide();
        }
    }

}
