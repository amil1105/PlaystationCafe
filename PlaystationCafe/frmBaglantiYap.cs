using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaystationCafe
{
    public partial class frmBaglantiYap : Form
    {
        public frmBaglantiYap()
        {
            InitializeComponent();
        }
        public static string baglantiString="";
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           baglantiString=txtString.Text.ToString();
            this.Close();
        }

        public string Baglantistring()
        {
            return baglantiString;
        }



        private void frmBaglantiYap_Load(object sender, EventArgs e)
        {
           
        }
    }
}
