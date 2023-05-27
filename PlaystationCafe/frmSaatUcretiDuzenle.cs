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
    public partial class frmSaatUcretiDuzenle : Form
    {
        public frmSaatUcretiDuzenle()
        {
            InitializeComponent();
            yenile();
            btnSil.Visible = false;
        }

        private void yenile()
        {
            string sorgu = "select * from TBLSaatUcreti";
            Veritabani.Listele(dataGridView1, sorgu);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtSaatUcreti.Text != null && txtSaatUcreti.Text != null)
            {
                string sorgu = "insert into TBLSaatUcreti(SaatUcreti,UcretTuru,Aciklama) values (@SaatUcreti,@UcretTuru,@Aciklama)";
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@SaatUcreti", txtSaatUcreti.Text);
                cmd.Parameters.AddWithValue("@UcretTuru", txtUcretTuru.Text);
                if (txtAciklama.Text == null)
                {
                    cmd.Parameters.AddWithValue("@Aciklama", "Açıklama yapılmadı.");

                }
                else
                {
                    cmd.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);

                }
                Veritabani.ESG(cmd, sorgu);
                foreach (Control item in Controls)
                    if (item is TextBox) item.Text = "";
                MessageBox.Show("Saat Ücreti Ekledi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                yenile();
            }
            else
            {
                MessageBox.Show("Lütfen bilgileri boş bırakmayınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtID.Text != null)
            {
                string sorgu = "update TBLSaatUcreti set SaatUcreti=@SaatUcreti, UcretTuru=@UcretTuru,Aciklama=@Aciklama where SaatiUcretiID=@SaatiUcretiID";
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@SaatiUcretiID", int.Parse(txtID.Text.ToString()));
                cmd.Parameters.AddWithValue("@SaatUcreti", decimal.Parse(txtSaatUcreti.Text.ToString()));
                cmd.Parameters.AddWithValue("@UcretTuru", txtUcretTuru.Text.ToString());
                cmd.Parameters.AddWithValue("@Aciklama", txtAciklama.Text.ToString());
                
                Veritabani.ESG(cmd, sorgu);
                foreach (Control item in Controls)
                    if (item is TextBox) item.Text = "";
                MessageBox.Show("Saat Ücreti başarıyla Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtSaatUcreti.Text = satir.Cells[1].Value.ToString();
            txtUcretTuru.Text = satir.Cells[2].Value.ToString();
            txtAciklama.Text = satir.Cells[3].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            string sorgu = "delete from TBLSaatUcreti where SaatiUcretiID='" + satir.Cells["SaatiUcretiID"].Value.ToString() + "'";
            SqlCommand cmd = new SqlCommand();
           Veritabani.ESG(cmd, sorgu);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            btnSil.Visible = false;
            yenile();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmSaatUcretiDuzenle_Load(object sender, EventArgs e)
        {

        }
    }
}
