using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Threading;
using System.Net;
using System.IO;

namespace YandereSimLauncher
{
    public partial class YandereLauncher : Form
    {
        //


        public YandereLauncher()
        {
            InitializeComponent();
            OnLoadImage();
            //networkChecker = new NewtworkChecker
        }

        private void OnLoadImage()
        {
            
        }


        private void btnGitHub_Click(object sender, EventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No disponile");
            }
        }

        private void VisitLink()
        {
            System.Diagnostics.Process.Start("https://github.com/snlionel90");
            //throw new NotImplementedException();
        }

        private void btnDeviantart_Click(object sender, EventArgs e)
        {
            
        }

        private void btnYoutube_Click(object sender, EventArgs e)
        {
        }

        private void btnInstagram_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            //Sincrome
            //WebClient wc= new WebClient();
            //wc.DownloadFile("", "");
            //MessageBox.Show("Donwloading Competed");

            //Asincrine
            if (!File.Exists("")) {
                WebClient wc = new WebClient();
                wc.DownloadFileCompleted += new AsyncCompletedEventHandler(Completo);
                wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                wc.DownloadFileAsync(new Uri(""), "");
            }   
        }
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e) 
        {

        }
        private void Completo(object sender, AsyncCompletedEventArgs e) 
        {

        }
    }
}

