using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JBS_Tool
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private static async Task<string> GetServerVersionAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    return await client.GetStringAsync("https://kolejnaprzygode.pl/jbstool_version.txt");
                }
                catch (HttpRequestException e)
                {
                    MessageBox.Show("Wystąpił błąd podczas sprawdzania dostępności aktualizacji. Szczegóły: " + e, "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        private static bool IsUpdateAvailable(string localVersion, string serverVersion)
        {
            Version local = new Version(localVersion.Trim());
            Version server = new Version(serverVersion.Trim());

            return server.CompareTo(local) > 0;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://kolejnapzygode.pl/");
        }

        private async void checkVersionButton_Click(object sender, EventArgs e)
        {
            string serverVersion = await GetServerVersionAsync();

            if (serverVersion != null && IsUpdateAvailable("1.0", serverVersion))
            {
                versionOutput.Text = "Dostępna jest nowa wersja: " + serverVersion;
            }
            else
            {
                versionOutput.Text = "Masz najnowszą wersję aplikacji";
            }
        }
    }
}
