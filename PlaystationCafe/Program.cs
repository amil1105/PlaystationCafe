using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaystationCafe
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string connectionString="";

            if (!File.Exists("connectionString.txt"))
            {

                using (StreamWriter writer = new StreamWriter("connectionString.txt"))
                {
                    frmBaglantiYap frm = new frmBaglantiYap();
                    frm.ShowDialog();
                     connectionString = frm.Baglantistring();


                    writer.WriteLine(connectionString);
                }
            }
            else if (File.Exists("connectionString.txt"))
            {

                using (StreamReader reader = new StreamReader("connectionString.txt"))
                {
                     connectionString = reader.ReadLine();
                   

                }
            }

            Veritabani.baglanti = new SqlConnection(connectionString);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmKullanici());



        }
    }
}
