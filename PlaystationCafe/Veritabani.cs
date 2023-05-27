using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaystationCafe
{
    internal class Veritabani
    {
        public static SqlConnection baglanti;

        public static DataTable SepetiListele(DataGridView gridView)
        {
            baglanti.Open();
            string sorgu = "select * from TBLSepet";
            SqlDataAdapter adtr = new SqlDataAdapter(sorgu, baglanti);
            DataTable tbl = new DataTable();
            adtr.Fill(tbl);
            gridView.DataSource = tbl;
            baglanti.Close();
            return tbl;
        }
        public static DataTable Listele(DataGridView gridView, string sorgu)
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter(sorgu, baglanti);
            DataTable tbl = new DataTable();
            adtr.Fill(tbl);
            gridView.DataSource = tbl;
            baglanti.Close();
            return tbl;
        }

        public double adisyon(int id)
        {
            try
            {
                baglanti.Open();


                baglanti.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }
            finally
            {

                if (baglanti.State != ConnectionState.Closed)
                {
                    baglanti.Close();
                }
            }
            baglanti.Open();
            double total = 0;
            string sql = "SELECT SUM(Toplam) as total FROM TBLAdisyonSatis WHERE SatisID LIKE '%" + id + "%'";
            SqlCommand cmd = new SqlCommand(sql, baglanti);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    if (!reader.IsDBNull(reader.GetOrdinal("total")))
                    {
                        total = Convert.ToDouble(reader["total"]);


                    }

                }
            }
            baglanti.Close();


            return total;
        }


        public static DataTable ComboyaMasaGetir(ComboBox combo)
        {
            baglanti.Open();
            string sorgu = "select * from TBLMasa where Durumu = 'BOŞ'";
            SqlDataAdapter adtr = new SqlDataAdapter(sorgu, baglanti);
            DataTable tbl = new DataTable();
            adtr.Fill(tbl);
            combo.DataSource = tbl;
            combo.DisplayMember = "Masalar";
            combo.ValueMember = "MasaID";
            baglanti.Close();
            return tbl;
        }
        public static DataTable ComboyaMasaGetir2(ComboBox combo)
        {
            baglanti.Open();
            string sorgu = "select * from TBLMasa";
            SqlDataAdapter adtr = new SqlDataAdapter(sorgu, baglanti);
            DataTable tbl = new DataTable();
            adtr.Fill(tbl);
            combo.DataSource = tbl;
            combo.DisplayMember = "Masalar";
            combo.ValueMember = "MasaID";
            baglanti.Close();
            return tbl;
        }
        public static DataTable listBoxMasaGetir(ListBox list)
        {
            baglanti.Open();
            string sorgu = "select * from TBLMasa";
            SqlDataAdapter adtr = new SqlDataAdapter(sorgu, baglanti);
            DataTable tbl = new DataTable();
            adtr.Fill(tbl);
            list.DataSource = tbl;
            list.DisplayMember = "Masalar";
            list.ValueMember = "MasaID";
            baglanti.Close();
            return tbl;
        }

        public static void ESG(SqlCommand command, string sorgu)
        {
            baglanti.Open();
            command.Connection = baglanti;
            command.CommandText = sorgu;
            command.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
