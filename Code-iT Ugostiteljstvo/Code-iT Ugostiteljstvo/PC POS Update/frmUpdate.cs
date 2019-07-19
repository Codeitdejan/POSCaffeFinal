using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Drawing.Drawing2D;
using System.Diagnostics;
using System.Threading;

namespace PC_POS_Update {
    public partial class frmUpdate : Form
    {
        public frmUpdate()
        {
            InitializeComponent();
        }
        bool status;
        private void frmUpdate_Load(object sender, EventArgs e)
        {
            this.Paint += new PaintEventHandler(Form1_Paint);
            bgWorker1.RunWorkerAsync();
        }

        void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics c = e.Graphics;
            Brush bG = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Color.AliceBlue, Color.LightSlateGray, 250);
            c.FillRectangle(bG, 0, 0, Width, Height);
        }

        private void bgWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            Process[] pArry = Process.GetProcesses();

            foreach (Process p in pArry)
            {
                string s = p.ProcessName;
                //s = s.ToLower();
                if (s.CompareTo("PC POS") == 0)
                {
                    p.Kill();
                }
            }


            string sUrlToDnldFile;
            sUrlToDnldFile = "http://www.pc1.hr/caffe/update/PC POS.exe";


            try
            {
                Uri url = new Uri(sUrlToDnldFile);
                string sFileSavePath = "";
                string sFileName = Path.GetFileName(url.LocalPath);

                sFileSavePath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\PC POS.exe";

                System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(url);

                System.Net.HttpWebResponse response = (System.Net.HttpWebResponse)request.GetResponse();


                response.Close();

                // gets the size of the file in bytes

                long iSize = response.ContentLength;



                // keeps track of the total bytes downloaded so we can update the progress bar

                long iRunningByteTotal = 0;

                WebClient client = new WebClient();

                Stream strRemote = client.OpenRead(url);

                FileStream strLocal = new FileStream(sFileSavePath, FileMode.Create, FileAccess.Write, FileShare.None);

                int iByteSize = 0;

                byte[] byteBuffer = new byte[1024];

                while ((iByteSize = strRemote.Read(byteBuffer, 0, byteBuffer.Length)) > 0)
                {

                    // write the bytes to the file system at the file path specified

                    strLocal.Write(byteBuffer, 0, iByteSize);

                    iRunningByteTotal += iByteSize;


                    // calculate the progress out of a base "100"

                    double dIndex = (double)(iRunningByteTotal);

                    double dTotal = (double)iSize;

                    double dProgressPercentage = (dIndex / dTotal);

                    int iProgressPercentage = (int)(dProgressPercentage * 100);


                    // update the progress bar

                    bgWorker1.ReportProgress(iProgressPercentage);

                }

                strRemote.Close();

                status = true;

            }
            catch (Exception exM)
            {

                //Show if any error Occured

                MessageBox.Show("Error: " + exM.Message);

                status = false;

            }

        }

        private void bgWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

    }
}

