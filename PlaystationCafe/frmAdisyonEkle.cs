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
    public partial class frmAdisyonEkle : Form
    {
        public frmAdisyonEkle()
        {
            InitializeComponent();
        }

        private void frmAdisyonEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into TBLAdisyonlar(kategori,UrunAdi,fiyati) values (@kategori,@UrunAdi,@fiyati)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@kategori",txtKategori.Text);
            cmd.Parameters.AddWithValue("@UrunAdi", txtAdi.Text);
            cmd.Parameters.AddWithValue("@fiyati", txtFiyat.Text);
            Veritabani.ESG(cmd,sorgu);
            foreach (Control item in Controls)
                if (item is TextBox) item.Text = "";
            MessageBox.Show("Adisyon Ekledi!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
