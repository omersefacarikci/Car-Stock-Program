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
namespace Project_W
{
    public partial class Görüntüle : Form
    {
        public Görüntüle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ÖMER;Initial Catalog=GaleriYönetimSistemi2024;Integrated Security=True");
        public string idno = "";

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void Görüntüle_Load(object sender, EventArgs e)
        {
            string sorgu = "select * from Arabalar Where ID=@p1";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@p1", idno);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {

                string resimKlasoruYolu = @"C:\Users\Ömer Sefa\Desktop\RESİM\";

                
                string aracResim1Yolu = Path.Combine(resimKlasoruYolu, oku["AracResim1"].ToString() + ".jpg");
                string aracResim2Yolu = Path.Combine(resimKlasoruYolu, oku["AracResim2"].ToString() + ".jpg");
                string aracResim3Yolu = Path.Combine(resimKlasoruYolu, oku["AracResim3"].ToString() + ".jpg");
                string aracResim4Yolu = Path.Combine(resimKlasoruYolu, oku["AracResim4"].ToString() + ".jpg");
                string aracResim5Yolu = Path.Combine(resimKlasoruYolu, oku["AracResim5"].ToString() + ".jpg");
                string aracResim6Yolu = Path.Combine(resimKlasoruYolu, oku["AracResim6"].ToString() + ".jpg");
                string aracResim7Yolu = Path.Combine(resimKlasoruYolu, oku["AracResim7"].ToString() + ".jpg");
                string aracResim8Yolu = Path.Combine(resimKlasoruYolu, oku["AracResim8"].ToString() + ".jpg");

                guna2PictureBox1.ImageLocation = aracResim1Yolu;
                guna2PictureBox2.ImageLocation = aracResim2Yolu;
                guna2PictureBox3.ImageLocation = aracResim3Yolu;
                guna2PictureBox4.ImageLocation = aracResim4Yolu;
                guna2PictureBox5.ImageLocation = aracResim5Yolu;
                guna2PictureBox6.ImageLocation = aracResim6Yolu;
                guna2PictureBox7.ImageLocation = aracResim7Yolu;
                guna2PictureBox8.ImageLocation = aracResim8Yolu;
            
                label2.Text = oku["Marka"].ToString();
                label5.Text = oku["Model"].ToString();
                label6.Text = oku["Yıl"].ToString();
                label13.Text = oku["Km"].ToString();
                label14.Text = oku["Motor"].ToString();
                label15.Text = oku["Beygir"].ToString();
                label16.Text = oku["Yakıt"].ToString();
                label17.Text = oku["Vites"].ToString();
                label18.Text = oku["Renk"].ToString();
                

            }
            baglanti.Close();
        }
    }
}
