using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaystationCafe
{
    public partial class frmKullanici : Form
    {
        public frmKullanici()
        {
            InitializeComponent();
            if (PlaystationCafe.Properties.Settings.Default.userName != string.Empty)
            {
                textBoxKadi.Text = Properties.Settings.Default.userName;
                textBoxKSifre.Text = Properties.Settings.Default.password;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {


            Kullanici.KullaniciGiris(textBoxKadi, textBoxKSifre);
            if (Kullanici.durum == true)
            {
                this.Hide();
                FrmSatis frm = new FrmSatis();
                frm.ShowDialog();
                if (checkBoxBeniHatirla.Checked)
                {

                    PlaystationCafe.Properties.Settings.Default.userName = textBoxKadi.Text;
                    PlaystationCafe.Properties.Settings.Default.password = textBoxKSifre.Text;
                    PlaystationCafe.Properties.Settings.Default.Save();
                }
                else
                {
                    PlaystationCafe.Properties.Settings.Default.userName = "";
                    PlaystationCafe.Properties.Settings.Default.password = "";
                    PlaystationCafe.Properties.Settings.Default.Save();
                }
            }
            else if (Kullanici.durum == false)
            {
                MessageBox.Show("Giriş Yapılmadı, Kullanıcı Adı veya Şifre Hatalı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void textBoxKadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnGiris.PerformClick();
            }
        }

        private void frmKullanici_Load(object sender, EventArgs e)
        {
            
        }

        private void textBoxKSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && e.KeyChar == '\'' || e.KeyChar == ' ')
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnGiris.PerformClick();
            }
        }

    }
}
