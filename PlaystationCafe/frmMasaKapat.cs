using System;
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
    public partial class frmMasaKapat : Form
    {
        public frmMasaKapat()
        {
            InitializeComponent();
        }

        private void frmMasaKapat_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMasaKapat_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into TBLSatis(KullaniciID,MasaID,AcilisTuru,BaslangicSaati,BitisSaati,Sure,Tutar,Aciklama,Tarih)" +
                " values('" + Kullanici.KullaniciID + "','" + int.Parse(txtMasaID.Text) + "','" + txtAcilisTuru.Text + "',@Baslangic,@Bitis,@Sure,@Tutar,'Aciklama Yapilmadi',@Tarih)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@Baslangic",DateTime.Parse(txtBaslamaSaati.Text));
            cmd.Parameters.AddWithValue("@Bitis", DateTime.Parse(txtBitisSaati.Text));
            cmd.Parameters.AddWithValue("@Sure", decimal.Parse(txtSure.Text));
            cmd.Parameters.AddWithValue("@Tutar", decimal.Parse(txtTutar.Text));
            cmd.Parameters.AddWithValue("@Tarih", DateTime.Parse(txtTarih.Text));

            Veritabani.ESG(cmd, sorgu);
            FrmSatis frmSatis = (FrmSatis)Application.OpenForms["FrmSatis"];
            frmSatis.Yenile();
            this.Close();
        }


    }
}
