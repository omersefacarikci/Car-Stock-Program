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
using Guna.UI2.WinForms;
namespace Project_W
{
    public partial class ArabaListesi1 : UserControl
    {
        public ArabaListesi1()
        {
            InitializeComponent();

        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ÖMER;Initial Catalog=GaleriYönetimSistemi2024;Integrated Security=True");
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Görüntüle frm = new Görüntüle();
            frm.idno = ID.Text;
            frm.ShowDialog();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from Arabalar where ID=@p1", baglanti);
            sil.Parameters.AddWithValue("@p1", ID.Text);
            sil.ExecuteNonQuery();
            baglanti.Close();
            this.Hide();
            MessageBox.Show("Kayıt silindi.");
        }
    }

}
