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
    public partial class frmKullaniciYonetim : Form
    {
        public frmKullaniciYonetim()
        {
            InitializeComponent();
        }

        private void frmKullaniciYonetim_Load(object sender, EventArgs e)
        {
            comboBoxGorevi.Items.Add("Kullanıcı");
            comboBoxGorevi.Items.Add("admin");
            btnSil.Visible = true;
            yenile();
        }

        private void yenile()
        {
            string sorgu = "select * from TBLKullanici";
            Veritabani.Listele(dataGridView1, sorgu);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            comboBoxGorevi.Text = "";
        }

        

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text != null && txtSifre.Text != null && comboBoxGorevi.Text != null && txtAdiSoyadi.Text != null)
            {
                string sorgu = "insert into TBLKullanici(AdiSoyadi,Telefon,Adres,Email,KullaniciAdi,Sifre,Gorevi,Tarih) values (@AdiSoyadi,@Telefon,@Adres,@Email,@KullaniciAdi,@Sifre,@Gorevi,@Tarih)";
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@AdiSoyadi", txtAdiSoyadi.Text);
                cmd.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                cmd.Parameters.AddWithValue("@Adres", txtAdres.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@KullaniciAdi", txtKullaniciAdi.Text);
                cmd.Parameters.AddWithValue("@Sifre", txtSifre.Text);
                cmd.Parameters.AddWithValue("@Gorevi", comboBoxGorevi.Text);
                cmd.Parameters.AddWithValue("@Tarih", DateTime.Now) ;

                Veritabani.ESG(cmd, sorgu);
                foreach (Control item in Controls)
                    if (item is TextBox) item.Text = "";
                MessageBox.Show("Kullanıcı Ekledi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                yenile();
            }
            else
            {
                MessageBox.Show("Lütfen bilgileri boş bırakmayınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSil.Visible = true;
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txtID.Text = satir.Cells[0].Value.ToString();
            txtAdiSoyadi.Text = satir.Cells[1].Value.ToString();
            txtTelefon.Text = satir.Cells[2].Value.ToString();
            txtAdres.Text = satir.Cells[3].Value.ToString();
            txtEmail.Text = satir.Cells[4].Value.ToString();
            txtKullaniciAdi.Text = satir.Cells[5].Value.ToString();
            txtSifre.Text = satir.Cells[6].Value.ToString();
            comboBoxGorevi.Text = satir.Cells[7].Value.ToString();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text != null && txtSifre.Text != null && comboBoxGorevi.Text != null && txtAdiSoyadi.Text != null)
            {
                string sorgu = "update TBLKullanici set AdiSoyadi=@AdiSoyadi, Telefon=@Telefon,Adres=@Adres,Email=@Email,KullaniciAdi=@KullaniciAdi,Sifre=@Sifre,Gorevi=@Gorevi,Tarih=@Tarih where KullaniciID=@KullaniciID";
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@KullaniciID", txtID.Text);
                cmd.Parameters.AddWithValue("@AdiSoyadi", txtAdiSoyadi.Text);
                cmd.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                cmd.Parameters.AddWithValue("@Adres", txtAdres.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@KullaniciAdi", txtKullaniciAdi.Text);
                cmd.Parameters.AddWithValue("@Sifre", txtSifre.Text);
                cmd.Parameters.AddWithValue("@Gorevi", comboBoxGorevi.Text);
                cmd.Parameters.AddWithValue("@Tarih", DateTime.Now);

                Veritabani.ESG(cmd, sorgu);
                foreach (Control item in Controls)
                    if (item is TextBox) item.Text = "";
                MessageBox.Show("Kullanıcı güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                yenile();
            }
            else
            {
                MessageBox.Show("Lütfen bilgileri boş bırakmayınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            string sorgu = "delete from TBLKullanici where KullaniciID='" + satir.Cells["KullaniciID"].Value.ToString() + "'";
            SqlCommand cmd = new SqlCommand();
            Veritabani.ESG(cmd, sorgu);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            
            yenile();
            btnSil.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtSifre.UseSystemPasswordChar = false;
            }
            else
            {
                txtSifre.UseSystemPasswordChar = true;

            }
        }
    }
}
