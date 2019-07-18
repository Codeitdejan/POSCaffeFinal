using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PCPOS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            if (!File.Exists("NeProvjeravjVisePrograma"))
            {
                try
                {
                    Process[] pro = Process.GetProcessesByName("PC POS");

                    if (pro.Count() > 1)
                    {
                        MessageBox.Show("Program je več upaljen. Potražite ga na alatnoj traci.");
                        return;
                    }

                    SkiniPotrebneStavke();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new Caffe.frmOdabirStolaCustom());
                //Application.Run(new Caffe.frmStoloviZaNaplatuCustom());

                Application.Run(new frmMenu());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #region FUNKCIJA SKIDA SA FTP-A NOVIJE DLL-OVE ZA POSTGRES

        /// <summary>
        /// FUNKCIJA SKIDA SA FTP-A NOVIJE DLL-OVE ZA POSTGRES
        /// </summary>
        private static void SkiniPotrebneStavke()
        {
            //bool moram_skidati = false;
            //PCPOS.Until.classDownloadFiles D = new Until.classDownloadFiles();
            //if (File.Exists("DBbackup\\VerzijaPostgres.txt"))
            //{
            //    string verzijaPG = File.ReadAllText("DBbackup\\VerzijaPostgres.txt");
            //    if (verzijaPG != "9.2")
            //    {
            //        moram_skidati = true;
            //    }
            //}
            //else
            //{
            //    moram_skidati = true;
            //}

            //if (moram_skidati)
            //{
            //    try
            //    {
            //        string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            //        if (!File.Exists("SkiniNovijeFajloveZaPostgres.exe"))
            //        {
            //            D.SkiniDatoteku("http://pc1.hr/caffe/update/ostalo/ftpbin/SkiniNovijeFajloveZaPostgres.doc", "SkiniNovijeFajloveZaPostgres.exe");
            //            MessageBox.Show("Aplikacija se mora ugasiti i skinuti neke dodatke za bazu podataka!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            //GC.Collect();
            //        }

            //        GC.Collect();
            //        Process proc = Process.Start(path + "\\SkiniNovijeFajloveZaPostgres.exe");
            //        //Application.Exit();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.ToString());
            //    }
            //}
        }

        #endregion FUNKCIJA SKIDA SA FTP-A NOVIJE DLL-OVE ZA POSTGRES
    }
}