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
    public partial class frmAdisyonDuzenle : Form
    {
        public frmAdisyonDuzenle()
        {
            InitializeComponent();
        }

        private void frmAdisyonDuzenle_Load(object sender, EventArgs e)
        {
            yenile();
            btnSil.Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text!=null&& txtFiyat.Text != null&& txtKategori.Text != null)
            {
                string sorgu = "insert into TBLAdisyonlar(kategori,UrunAdi,fiyati) values (@kategori,@UrunAdi,@fiyati)";
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@kategori", txtKategori.Text);
                cmd.Parameters.AddWithValue("@UrunAdi", txtAdi.Text);
                cmd.Parameters.AddWithValue("@fiyati", txtFiyat.Text);
                Veritabani.ESG(cmd, sorgu);
                foreach (Control item in Controls)
                    if (item is TextBox) item.Text = "";
                MessageBox.Show("Adisyon Ekledi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                yenile(); 
            }
            else
            {
                MessageBox.Show("Lütfen bilgileri boş bırakmayınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void yenile()
        {
            string sorgu = "select * from TBLAdisyonlar";
            Veritabani.Listele(dataGridView1, sorgu);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtID.Text != null)
            {
                string sorgu = "update TBLAdisyonlar set kategori=@kategori, UrunAdi=@UrunAdi,fiyati=@fiyati where SatisID=@SatisID";
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@SatisID", int.Parse(txtID.Text.ToString()));
                cmd.Parameters.AddWithValue("@kategori", txtKategori.Text.ToString());
                cmd.Parameters.AddWithValue("@UrunAdi", txtAdi.Text.ToString());
                cmd.Parameters.AddWithValue("@fiyati", decimal.Parse(txtFiyat.Text.ToString()));
                Veritabani.ESG(cmd, sorgu);
                foreach (Control item in Controls)
                    if (item is TextBox) item.Text = "";
                MessageBox.Show("Adisyon başarıyla Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                yenile(); 
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz bilgiye çift tıklayın...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSil.Visible = true;
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txtID.Text = satir.Cells[0].Value.ToString();
            txtKategori.Text = satir.Cells[1].Value.ToString();
            txtAdi.Text = satir.Cells[2].Value.ToString();
            txtFiyat.Text = satir.Cells[3].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            string sorgu = "delete from TBLAdisyonlar where SatisID='" + satir.Cells["SatisID"].Value.ToString() + "'";
            SqlCommand cmd = new SqlCommand();
            Veritabani.ESG(cmd, sorgu);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";

            yenile();
            btnSil.Visible = false;
        }


    }
}
