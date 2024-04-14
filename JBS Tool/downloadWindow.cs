using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace JBS_Tool
{
    public partial class downloadWindow : Form
    {
        WebClient webClient = new WebClient();
        string urlCache = "";
        public downloadWindow()
        {
            InitializeComponent();
        }

        public void downloadFile(string url, bool autorun)
        {
            urlCache = url;
            autorunCheckbox.Checked = autorun;
            currentStatus.Text = "Rozpoczynam pobieranie";
            currentLinkLabel.Text = "Link: " + url; 
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(fileDownloaded);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(fileProgressChanged);
            try
            {
                webClient.DownloadFileAsync(new Uri(url), @"JBStool\ninite.exe");
                currentStatus.Text = "Pobieranie...";
                cancelButton.Enabled = true;
                retryButton.Enabled = false;
                runButton.Enabled = false;
            }
            catch (Exception exc)
            {

                currentProgressBar.Value = 0;
                currentProgressLabel.Text = "Postęp: wstrzymano w wyniku błędu (0%)";
                currentStatus.Text = "Wystąpił błąd. Sprawdź połączenie sieciowe.";
                cancelButton.Enabled = false;
                retryButton.Enabled = true;
                runButton.Enabled = false;
            }
            
        }

        void fileDownloaded(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                currentStatus.Text = "Pobrano pomyślnie";
                cancelButton.Enabled = false;
                retryButton.Enabled = false;
                runButton.Enabled = true;
                if (autorunCheckbox.Checked)
                {
                    try
                    {
                        Process.Start(@"JBStool\ninite.exe");

                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Wystąpił błąd: " + exc, "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
            else if (e.Cancelled)
                {
                    currentProgressBar.Value = 0;
                    currentProgressLabel.Text = "Postęp: 0%";
                    currentStatus.Text = "Anulowano";
                    cancelButton.Enabled = false;
                    retryButton.Enabled = true;
                    runButton.Enabled = false;
                }
                else
            {
                currentProgressBar.Value = 0;
                currentProgressLabel.Text = "Postęp: wstrzymano w wyniku błędu (0%)";
                currentStatus.Text = "Wystąpił błąd. Sprawdź połączenie sieciowe.";
                cancelButton.Enabled = false;
                retryButton.Enabled = true;
                runButton.Enabled = false;
            }
            
        }

        void fileProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            currentProgressBar.Value = e.ProgressPercentage;
            currentProgressLabel.Text = "Postęp: " + e.ProgressPercentage + "%";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            downloadFile(urlCache, autorunCheckbox.Checked);
        }

        private void button1_Click(object sender, EventArgs e) => webClient.CancelAsync();

        private void runButton_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"JBStool\ninite.exe");

            }
            catch (Exception exc)
            {
                MessageBox.Show("Wystąpił błąd: " + exc, "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
