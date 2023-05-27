using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaystationCafe
{
    internal class Kullanici
    {
        public static int KullaniciID = 0;
        public static string Gorevi = "";
        public static bool durum = false;

        


        public static SqlDataReader KullaniciGiris(TextBox Adi, TextBox Sifre)
        {
            Veritabani.baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from TBLKullanici where KullaniciAdi='" + Adi.Text + "' and Sifre='" + Sifre.Text + "'",Veritabani.baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                durum = true;
                KullaniciID = int.Parse(dr["KullaniciID"].ToString());
                Gorevi = dr["Gorevi"].ToString();
            }
            else
            {
                durum=false;
            }
            Veritabani.baglanti.Close();
            return dr;
        }
    }
}
