using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace PlaystationCafe
{
    public partial class FrmSatis : Form
    {





        public FrmSatis()
        {
            InitializeComponent();
        }




        RadioButton radio;



        private void RadioButtonSeciliyeGore(object sender, EventArgs e)
        {
            radio = sender as RadioButton;
        }

        private void FrmSatis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'playstationCafeDataSet1.TBLSaatUcreti' table. You can move, or remove it, as needed.
            this.tBLSaatUcretiTableAdapter.Fill(this.playstationCafeDataSet1.TBLSaatUcreti);
            radioBtnSuresiz.Checked = true;
            Yenile();
            timer1.Start();
            comboBoxBosMasalar.Text = "";
            btnAyarlar.Visible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (Kullanici.Gorevi == "admin")
            {
                btnAyarlar.Visible = true;
            }
            Veritabani veri = new Veritabani();
           
        }

        public void Yenile()
        {
            Veritabani.SepetiListele(dataGridView1);
            

            Veritabani.ComboyaMasaGetir(comboBoxBosMasalar);
            //    foreach (Control item in Controls)
            //    {
            //        if (item is Button)
            //        {
            //            Veritabani.baglanti.Open();
            //            string sorgu2 = "select * from TBLMasa";
            //            SqlCommand komut = new SqlCommand(sorgu2, Veritabani.baglanti);
            //            SqlDataReader dr = komut.ExecuteReader();
            //            while (dr.Read())
            //            {

            //                if (dr["durumu"].ToString() == "BOŞ" && dr["Masalar"].ToString() == item.Text)
            //                {
            //                    item.BackColor = Color.LightGreen;

            //                }
            //                if (dr["durumu"].ToString() == "DOLU" && dr["Masalar"].ToString() == item.Text)
            //                {
            //                    item.BackColor = Color.Red;

            //                }
            //            }
            //            Veritabani.baglanti.Close();
            //        }

            //    }

        }

        private void btnMasaAC_Click(object sender, EventArgs e)
        {
            if (Kullanici.Gorevi == "admin")
            {

                if (!(comboBoxBosMasalar.Text.ToString() == ""))
                {
                    if (!radioButtonSecilen.Checked)
                    {
                        string sqlsorgu = "insert into TBLSepet(MasaID,Masa,Acilisturu,Baslangic,Tarih) " + "values('" + comboBoxBosMasalar.Text.Substring(5) + "','" + comboBoxBosMasalar.Text + "'" +
                                                 ",'" + radio.Text + "',@Baslangic,@Tarih)";
                        SqlCommand komut = new SqlCommand();


                        komut.Parameters.AddWithValue("@Baslangic", DateTime.Parse(DateTime.Now.ToString()));
                        komut.Parameters.AddWithValue("@Tarih", DateTime.Parse(DateTime.Now.ToString()));

                        Veritabani.ESG(komut, sqlsorgu);
                        MessageBox.Show(comboBoxBosMasalar.Text.Substring(5) + " nolu masa açıldı..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Yenile();
                        comboBoxBosMasalar.Text = "";
                        radioBtnSuresiz.Checked = true;
                    }
                    else if (radioButtonSecilen.Checked)
                    {
                        string sqlsorgu = "insert into TBLSepet(MasaID,Masa,Acilisturu,Baslangic,Tarih) " + "values('" + comboBoxBosMasalar.Text.Substring(5) + "','" + comboBoxBosMasalar.Text + "'" +
                             ",'" + txtSecileneGore.Text.ToString() + "',@Baslangic,@Tarih)";
                        SqlCommand komut = new SqlCommand();


                        komut.Parameters.AddWithValue("@Baslangic", DateTime.Parse(DateTime.Now.ToString()));
                        komut.Parameters.AddWithValue("@Tarih", DateTime.Parse(DateTime.Now.ToString()));

                        Veritabani.ESG(komut, sqlsorgu);
                        MessageBox.Show(comboBoxBosMasalar.Text.Substring(5) + " nolu masa açıldı..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Yenile();
                        comboBoxBosMasalar.Text = "";
                        radioBtnSuresiz.Checked = true;
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen boş masa seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                btnMasaAC.Enabled = false;
            }
        }

        private void FrmSatis_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {

                btnMasaDegis.Visible = true;
            }
            else
            {

                btnMasaDegis.Visible = false;
            }
            if (e.ColumnIndex == dataGridView1.Columns["MasaKapat"].Index)
            {

                if (dataGridView1.CurrentRow.Cells["sure"].Value != null)
                {
                    frmMasaKapat frm = new frmMasaKapat();
                    frm.txtID.Text = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                    frm.txtMasaID.Text = dataGridView1.CurrentRow.Cells["Masa_ID"].Value.ToString();
                    frm.txtMasa.Text = dataGridView1.CurrentRow.Cells["_masa"].Value.ToString();
                    frm.txtAcilisTuru.Text = dataGridView1.CurrentRow.Cells["AcilisTuru"].Value.ToString();
                    frm.txtBaslamaSaati.Text = dataGridView1.CurrentRow.Cells["BaslamaSaati"].Value.ToString();
                    frm.txtBitisSaati.Text = dataGridView1.CurrentRow.Cells["BitisSaati"].Value.ToString();
                    frm.txtSaatUcreti.Text = comboSaatUcreti.Text;
                    frm.txtSure.Text = dataGridView1.CurrentRow.Cells["sure"].Value.ToString();
                    frm.txtTutar.Text = dataGridView1.CurrentRow.Cells["Tutar"].Value.ToString();
                    frm.txtTarih.Text = dataGridView1.CurrentRow.Cells["_tarih"].Value.ToString();
                    frm.ShowDialog();
                    richTextBox1.Text = "";
                    btnMasaDegis.Visible = false;
                }
                else if (dataGridView1.CurrentRow.Cells["sure"].Value == null)
                {
                    MessageBox.Show("Önce Hesaplama Yapılmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (e.ColumnIndex == dataGridView1.Columns["Adisyon"].Index)
            {
                frmAdisyon frm = new frmAdisyon();
                frm.txtID.Text = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                frm.txtMasa.Text = dataGridView1.CurrentRow.Cells["_masa"].Value.ToString();








                frm.ShowDialog();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int sayac = 0;
        int sayac2 = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            sayac2++;
            Veritabani veri = new Veritabani();
            if (sayac2 > 10)
            {
                richTextBox1.Text = " ";
                sayac2 = 0;
            }
            if (sayac > 1)
            {

                if (comboSaatUcreti.Text != "")
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        DateTime BitisTarihi = DateTime.Now;


                        DateTime BaslangicTarihi = DateTime.Parse(dataGridView1.Rows[i].Cells["BaslamaSaati"].Value.ToString());
                        TimeSpan saatfarki = BitisTarihi - BaslangicTarihi;
                        double saatfarki2 = saatfarki.TotalMinutes;
                        dataGridView1.Rows[i].Cells["sure"].Value = saatfarki2.ToString("0");
                        double toplamtutar = ((saatfarki2 / 60) * double.Parse(comboSaatUcreti.Text) + veri.adisyon(int.Parse(dataGridView1.Rows[i].Cells["id"].Value.ToString())));

                        dataGridView1.Rows[i].Cells["Tutar"].Value = toplamtutar.ToString("0.0");
                        dataGridView1.Rows[i].Cells["BitisSaati"].Value = BitisTarihi;
                    }
                }

                if (comboSaatUcreti.Text == "")
                {
                    MessageBox.Show("Önce saat ücreti Belirtilmelidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMasaDegis_Click(object sender, EventArgs e)
        {
            int SepetID = int.Parse(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            int MasaID = int.Parse(dataGridView1.CurrentRow.Cells["Masa_ID"].Value.ToString());
            string Masa = dataGridView1.CurrentRow.Cells["_masa"].Value.ToString();

            if (Masa == comboBoxBosMasalar.Text.ToString() || comboBoxBosMasalar.Text.ToString() == "")
            {
                MessageBox.Show("Lütfen boş masa seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string sql = "update TBLSepet set MasaID='" + int.Parse(comboBoxBosMasalar.Text.Substring(5)) + "',Masa='" + comboBoxBosMasalar.Text + "' where SepetID='" + SepetID + "'";
                SqlCommand cmd = new SqlCommand();
                Veritabani.ESG(cmd, sql);
                /////////////////////////////////////
                string sql2 = "update TBLMasa set Durumu='BOŞ' where MasaID='" + MasaID + "'";
                SqlCommand cmd2 = new SqlCommand();
                Veritabani.ESG(cmd2, sql2);
                ////////////////////////////////////
                string sql3 = "update TBLMasa set Durumu = 'DOLU' where MasaID = '" + int.Parse(comboBoxBosMasalar.Text.Substring(5)) + "'";
                SqlCommand cmd3 = new SqlCommand();
                Veritabani.ESG(cmd3, sql3);
                Yenile();
                // MessageBox.Show("Masa Değiştirme başarılı.", "Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            btnMasaDegis.Visible=false;

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            MasaUyariGonder();
        }

        private void MasaUyariGonder()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells["sure"].Value != null)
                {
                    if (dataGridView1.Rows[i].Cells["AcilisTuru"].Value.ToString() != "Süresiz")
                    {
                        double sure = double.Parse(dataGridView1.Rows[i].Cells["sure"].Value.ToString());
                        double AcilisTuru = double.Parse(dataGridView1.Rows[i].Cells["AcilisTuru"].Value.ToString());
                        if ((AcilisTuru - sure) <= 0.5)
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                            string masaID = dataGridView1.Rows[i].Cells["Masa_ID"].Value.ToString();
                            string cumle = "MASA-" + masaID + " vakti bitdi.";
                            richTextBox1.Text = cumle;
                        }
                        if ((AcilisTuru - sure) == 5)
                        {
                            string masaID = dataGridView1.Rows[i].Cells["Masa_ID"].Value.ToString();
                            string cumle = "MASA-" + masaID + " vaktinin bitmesine son 5 dk";
                            richTextBox1.Text = cumle;
                        }

                    }
                }
            }
        }



        private void txtSecileneGore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnGeriAl_Click(object sender, EventArgs e)
        {
            frmSatislariListele frmSatislariListele = new frmSatislariListele();
            frmSatislariListele.btnGeriAl.Enabled = true;
            frmSatislariListele.ShowDialog();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            frmAyarlar frm = new frmAyarlar();
            frm.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }




    }
}

