using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaystationCafe
{
    public partial class frmAyarlar : Form
    {
        public frmAyarlar()
        {
            InitializeComponent();
        }

        private void frmAyarlar_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  

        private void btnSatisRaporu_Click(object sender, EventArgs e)
        {
          
            frmSatislariListele frmSatislariListele = new frmSatislariListele();
            frmSatislariListele.btnGeriAl.Enabled = true;
            frmSatislariListele.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAdisyonEkle frm = new frmAdisyonEkle();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmAdisyonDuzenle frm = new frmAdisyonDuzenle();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmSaatUcretiDuzenle frm = new frmSaatUcretiDuzenle();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMasaDuzenle frm = new frmMasaDuzenle();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKullaniciYonetim frm = new frmKullaniciYonetim();
            frm.ShowDialog();
        }
    }
}
