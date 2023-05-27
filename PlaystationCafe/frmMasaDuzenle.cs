using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaystationCafe
{
    public partial class frmMasaDuzenle : Form
    {
        public frmMasaDuzenle()
        {
            InitializeComponent();
        }
        int MasaSayisi = 0;

        private void frmMasaDuzenle_Load(object sender, EventArgs e)
        {
            yenile();
            MasaSayisiniBul();
            
        }
        private void yenile()
        {
           
            Veritabani.listBoxMasaGetir(listBox1);
            
        }

        private void MasaSayisiniBul()
        {
            Veritabani.baglanti.Open();
            string sorgu = "SELECT MAX(MasaID) FROM TBLMasa";
            SqlCommand cmd = new SqlCommand(sorgu, Veritabani.baglanti);
            object value = cmd.ExecuteScalar();
            if (value != DBNull.Value)
            {
                MasaSayisi = Convert.ToInt32(value);
            }
            else
            {
                MasaSayisi = 0;
            }
            Veritabani.baglanti.Close();
            NumericMasaSayisi.Value = MasaSayisi;
        }

        private void DataSil()  // Veritabanı temizleme
        {
            string sorgu0 = "delete from TBLSatis";
            SqlCommand cmd0 = new SqlCommand();
            Veritabani.ESG(cmd0, sorgu0);


            string sorgu = "delete from TBLMasa"; 
            SqlCommand cmd = new SqlCommand();
            Veritabani.ESG(cmd, sorgu);

            string sorgu2 = "delete from TBLSepet"; 
            SqlCommand cmd2 = new SqlCommand();
            Veritabani.ESG(cmd2, sorgu2);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (MasaSayisi!=0)
            {
                DataSil();
            }

            //////////////////////////////////////
            ///
           
            for (int i = 1; i <= NumericMasaSayisi.Value; i++)
            {
                string sorgu2 = "insert into TBLMasa(MasaID,Masalar,Durumu,Aciklama) values(@MasaID,@Masalar,'BOŞ','YOK')";
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Parameters.AddWithValue("@MasaID", i);
                cmd2.Parameters.AddWithValue("@Masalar", "MASA-" + i);
                Veritabani.ESG(cmd2, sorgu2);
            }
            yenile();
            
            MessageBox.Show(NumericMasaSayisi.Value + " tane Masa oluşturuldu.");
            FrmSatis frmSatis = (FrmSatis)Application.OpenForms["FrmSatis"];
            frmSatis.Yenile();

        }
    }
}
