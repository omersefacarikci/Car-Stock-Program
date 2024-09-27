using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Project_W
{
    public class SQLKayit
    {
        SqlConnection con = new SqlConnection(@"Data Source=ÖMER;Initial Catalog=GaleriYönetimSistemi2024;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader rdr;
         
        public void AracKayit(ARABA araba)
        {
            cmd = new SqlCommand("insert into Arabalar (Marka,Model,Yıl,Km,Motor,Beygir,Yakıt,Vites,Renk,AracResim1,AracResim2,AracResim3,AracResim4,AracResim5,AracResim6,AracResim7,AracResim8) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17)", con);
            cmd.Parameters.AddWithValue("@p1", araba.Marka);
            cmd.Parameters.AddWithValue("@p2", araba.Model);
            cmd.Parameters.AddWithValue("@p3", araba.Yıl);
            cmd.Parameters.AddWithValue("@p4", araba.Km);
            cmd.Parameters.AddWithValue("@p5", araba.Motor);
            cmd.Parameters.AddWithValue("@p6", araba.Beygir);
            cmd.Parameters.AddWithValue("@p7", araba.Yakıt);
            cmd.Parameters.AddWithValue("@p8", araba.Vites);
            cmd.Parameters.AddWithValue("@p9", araba.Renk);
            cmd.Parameters.AddWithValue("@p10", araba.AracResim1);
            cmd.Parameters.AddWithValue("@p11", araba.AracResim2);
            cmd.Parameters.AddWithValue("@p12", araba.AracResim3);
            cmd.Parameters.AddWithValue("@p13", araba.AracResim4);
            cmd.Parameters.AddWithValue("@p14", araba.AracResim5);
            cmd.Parameters.AddWithValue("@p15", araba.AracResim6);
            cmd.Parameters.AddWithValue("@p16", araba.AracResim7);
            cmd.Parameters.AddWithValue("@p17", araba.AracResim8);

            
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
