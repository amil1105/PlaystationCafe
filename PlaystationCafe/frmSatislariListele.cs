using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaystationCafe
{
    public partial class frmSatislariListele : Form
    {
        public frmSatislariListele()
        {
            InitializeComponent();
        }

        private void frmSatislariListele_Load(object sender, EventArgs e)
        {
            btnGeriAl.Visible = false;
            labelTarih.Text = DateTime.Now.ToShortDateString();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DateTime tarih1 = dateTimePicker1.Value;
            DateTime tarih2 = dateTimePicker2.Value;
            string sorgu = "select * from tblsatis";
            Veritabani.Listele(dataGridView1, sorgu);
            hesapla();
            btnSil.Visible = false;




        }

        private void btnGeriAl_Click(object sender, EventArgs e)
        {

            int masaID = int.Parse(dataGridView1.CurrentRow.Cells["MasaID"].Value.ToString());
            int KullaniciID = int.Parse(dataGridView1.CurrentRow.Cells["KullaniciID"].Value.ToString());
            string masa = "MASA-" + masaID;
            string acilisTuru = dataGridView1.CurrentRow.Cells["AcilisTuru"].Value.ToString();
            DateTime baslangic = DateTime.Parse(dataGridView1.CurrentRow.Cells["BaslangicSaati"].Value.ToString());
            DateTime tarih = DateTime.Parse(dataGridView1.CurrentRow.Cells["Tarih"].Value.ToString());

            string sql = "insert into tblsepet(MasaID,Masa,AcilisTuru,Baslangic,Tarih) values( " +
                " '" + masaID + "','" + masa + "','" + acilisTuru + "',@Baslangic,@Tarih)";

            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@Baslangic", baslangic);
            cmd.Parameters.AddWithValue("@Tarih", tarih);
            Veritabani.ESG(cmd, sql);
            ///////////////////////////////////
            int satisID = int.Parse(dataGridView1.CurrentRow.Cells["SatisID"].Value.ToString());
            string sql2 = "delete from tblsatis where SatisID='" + satisID + "'";
            SqlCommand cmd2 = new SqlCommand();
            Veritabani.ESG(cmd2, sql2);


            this.Close();
            FrmSatis frm = (FrmSatis)Application.OpenForms["FrmSatis"];
            frm.Yenile();
        }

        private void btnAramaYap_Click(object sender, EventArgs e)
        {
            Veritabani veri = new Veritabani();
            string sql;
            DateTime from = dateTimePicker1.Value;
            DateTime to = dateTimePicker2.Value;

            sql = "SELECT * FROM tblsatis WHERE Tarih between '" + from.ToString("yyyy.MM.dd HH:mm:ss") + "'AND '" + to.ToString("yyyy.MM.dd HH:mm:ss") + "'";
            Veritabani.Listele(dataGridView1, sql);
            hesapla();
        }

        private void hesapla()
        {
            double price=0;
            double total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                
               price= double.Parse(row.Cells["Tutar"].Value.ToString());
                    total += price;
                int SatisSayisi = dataGridView1.RowCount;
                labelSatisSayisi.Text = "Satış Sayısı = " + SatisSayisi;

            }
            labelTutar.Text = "Toplam Tutar = " + total.ToString() + " TL";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnGeriAl.Visible = true;
            btnSil.Visible = true;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            string sorgu = "delete from TBLSatis where SatisID='" + satir.Cells["SatisID"].Value.ToString() + "'";
            SqlCommand cmd = new SqlCommand();
            Veritabani.ESG(cmd, sorgu);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            string sorgu1 = "select * from tblsatis";
            Veritabani.Listele(dataGridView1, sorgu1);
            hesapla();

            btnSil.Visible = false;
        }
    }
}
