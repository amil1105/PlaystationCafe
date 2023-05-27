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
    public partial class frmAdisyon : Form
    {
        public frmAdisyon()
        {
            InitializeComponent();
        }

        private void frmAdisyon_Load(object sender, EventArgs e)
        {
            string sorgu = "select * from TBLAdisyonlar";
            Veritabani.Listele(dataGridView1, sorgu);
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Yenile();

        }
        double toplamAdisyon = 0;
        public void hesapla()
        {

            double price = 0;
            double total = 0;

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (dataGridView2.Rows.Count == 0)
                {
                    txtSiparisTutari.Text = "";
                }
                else if (dataGridView2.Rows.Count >= 1)
                {
                    price = double.Parse(row.Cells["Toplam"].Value.ToString());
                    total += price;
                    txtSiparisTutari.Text = "Sipariş Tutarı: " + total.ToString()+" TL";
                }
            }

        }




        private void Yenile()
        {
            string sorgu = "select * from TBLAdisyonSatis where SatisID like '%" + txtID.Text.ToString() + "%'";
            Veritabani.Listele(dataGridView2, sorgu);
            if (dataGridView2.RowCount < 1)
            {
                btnSil.Visible = false;
            }
            else
            {
                btnSil.Visible = true;
            }
            hesapla();

        }
        private void textBoxUrunAra_TextChanged(object sender, EventArgs e)
        {
            string sorgu = "select * from TBLAdisyonlar where UrunAdi like '%" + textBoxUrunAra.Text + "%'";

            Veritabani.Listele(dataGridView1, sorgu);
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            string urunAdi = dataGridView1.CurrentRow.Cells["UrunAdi"].Value.ToString();
            string fiyati = dataGridView1.CurrentRow.Cells["fiyati"].Value.ToString();
            string kategori = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            string adet = NumericAdetSayisi.Value.ToString();
            double toplam = double.Parse(adet) * double.Parse(fiyati);
            int adetSay = int.Parse(adet);
            if (adetSay >= 1)
            {
                string id = txtID.Text.ToString();
                string sorgu = "insert into TBLAdisyonSatis(SatisID,kategori,UrunAdi,fiyati,adet,Toplam) values(@SatisID,@kategori,@UrunAdi,@fiyati,@adet,@Toplam)";

                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@SatisID", int.Parse(id));
                cmd.Parameters.AddWithValue("@kategori", kategori);
                cmd.Parameters.AddWithValue("@UrunAdi", urunAdi);
                cmd.Parameters.AddWithValue("@fiyati", decimal.Parse(fiyati));
                cmd.Parameters.AddWithValue("@adet", int.Parse(adet));
                cmd.Parameters.AddWithValue("@toplam", decimal.Parse(toplam.ToString()));
                Veritabani.ESG(cmd, sorgu);
                Yenile();
                hesapla();
            }
            else
            {
                MessageBox.Show("Adet 0 dan büyük olmak zorunda.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            //dataGridView2.ClearSelection();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView2.CurrentRow;
            string sorgu = "delete from TBLAdisyonSatis where id='" + satir.Cells["_id"].Value.ToString() + "'";
            SqlCommand cmd = new SqlCommand();
            Veritabani.ESG(cmd, sorgu);
            Yenile();
            if (dataGridView2.Rows.Count == 0)
            {
                txtSiparisTutari.Text = "";
            }
            hesapla();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSil.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
