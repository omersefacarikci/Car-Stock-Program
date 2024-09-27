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
    public partial class Arabalar : Form
    {
        public Arabalar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=ÖMER;Initial Catalog=GaleriYönetimSistemi2024;Integrated Security=True");
        private void Arabalar_Load(object sender, EventArgs e)
        {
            frmliste.Controls.Clear();
            baglanti.Open();
            string sorgu = "select * from Arabalar";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ArabaListesi1 arax = new ArabaListesi1();
                arax.ID.Text = oku["ID"].ToString();
                arax.Marka.Text = oku["Marka"].ToString();
                arax.Model.Text = oku["Model"].ToString();
                arax.label1.Text = oku["Motor"].ToString();
                arax.label3.Text = oku["Km"].ToString();
                frmliste.Controls.Add(arax);
            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Anasayfa frm = new Anasayfa();
            frm.ShowDialog();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void aramayap_TextChanged(object sender, EventArgs e)
        {
            frmliste.Controls.Clear();
            baglanti.Open();
            SqlCommand search = new SqlCommand("select * from Arabalar Where Marka like '%"+aramayap.Text+"%' ", baglanti);
            SqlDataReader oku = search.ExecuteReader();
            while (oku.Read())
            {
                ArabaListesi1 arax = new ArabaListesi1();
                arax.ID.Text = oku["ID"].ToString();
                arax.Marka.Text = oku["Marka"].ToString();
                arax.Model.Text = oku["Model"].ToString();
                arax.label1.Text = oku["Motor"].ToString();
                frmliste.Controls.Add(arax);
            }
            baglanti.Close();
        }
    }
}