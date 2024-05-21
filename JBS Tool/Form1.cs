using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace JBS_Tool
{
    public partial class Form1 : Form
    {
        downloadWindow downloadWindowObject = new downloadWindow();
        about aboutObject = new about();
        clientMode clientModeObject = new clientMode();
        serverMode serverModeObject = new serverMode();
        private bool isSupported = false;
        private bool isWin11 = false;


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string dirPath = @"JBStool";
                DirectoryInfo dir = Directory.CreateDirectory(dirPath);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Nie można utworzyć folderu roboczego aplikacji. Funkcje takie jak pobieranie mogą nie działać prawidłowo. Spróbuj ponownie uruchamiając program z uprawnieniami administratora. Szczegóły: " + exc, "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { }
            winInfo.Text = "Twoja wersja systemu Windows: " + getOSInfo();
            if (isSupported == true)
            {
                supportInfo.Hide();
            }
        }

        string getOSInfo()
        {
            OperatingSystem os = Environment.OSVersion;
            Version vs = os.Version;
            string operatingSystem = "";
            if (os.Platform == PlatformID.Win32Windows)
            {
                switch (vs.Minor)
                {
                    case 0:
                        {
                            operatingSystem = "95";
                            isSupported = false;
                        }
                        break;
                    case 10:
                        if (vs.Revision.ToString() == "2222A")
                        {
                            operatingSystem = "98SE";
                            isSupported = false;
                        }
                        else
                        {
                            operatingSystem = "98";
                            isSupported = false;
                        }
                        break;
                    case 90:
                        {
                            operatingSystem = "Me";
                            isSupported = false;
                        }
                        break;
                    default:
                        break;
                }
            }
            else if (os.Platform == PlatformID.Win32NT)
            {
                switch (vs.Major)
                {
                    case 3:
                        {
                            operatingSystem = "NT 3.51";
                            isSupported = false;
                        }
                        break;
                    case 4:
                        {
                            operatingSystem = "NT 4.0";
                            isSupported = false;
                        }
                        break;
                    case 5:
                        if (vs.Minor == 0)
                        {
                            operatingSystem = "2000";
                            isSupported = false;
                        }
                        else
                        {
                            operatingSystem = "XP";
                            isSupported = false;
                        }
                        break;
                    case 6:
                        if (vs.Minor == 0)
                        {
                            operatingSystem = "Vista";
                            isSupported = true;
                        }
                        else if (vs.Minor == 1)
                        {
                            operatingSystem = "7";
                            isSupported = true;
                        }
                        else if (vs.Minor == 2)
                        {
                            operatingSystem = "8";
                            isSupported = true;
                        }
                        else
                        {
                            operatingSystem = "8.1";
                            isSupported = true;

                        }
                        break;
                    case 10:
                        {
                            if (Environment.OSVersion.Version.Build >= 22000)
                            {
                                operatingSystem = "11";
                                isSupported = true;
                                isWin11 = true;
                            }
                            else
                            {
                                operatingSystem = "10";
                                isSupported = true;
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            if (operatingSystem != "")
            {
                operatingSystem = "Windows " + operatingSystem;
                if (os.ServicePack != "")
                {
                    operatingSystem += " " + os.ServicePack;
                }
            }
            return operatingSystem;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            downloadWindowObject.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Wystąpił nieznany błąd: " + exc, "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("control.exe");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Wystąpił nieznany błąd: " + exc, "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("ms-settings:system");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Wystąpił nieznany błąd: " + exc, "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string niniteSubUrl = "";
            foreach (object checkedProgram in niniteMainList.CheckedItems)
            {
                if (checkedProgram.ToString() == "Google Chrome")
                {
                    niniteSubUrl += "-chrome";
                }
                else if (checkedProgram.ToString() == "Mozilla Firefox")
                {
                    niniteSubUrl += "-firefox";
                }
                else if (checkedProgram.ToString() == "Opera")
                {
                    niniteSubUrl += "-opera";
                }
                else if (checkedProgram.ToString() == "Microsoft Edge")
                {
                    niniteSubUrl += "-edge";
                }
                else if (checkedProgram.ToString() == "7-Zip")
                {
                    niniteSubUrl += "-7zip";
                }
                else if (checkedProgram.ToString() == "VLC")
                {
                    niniteSubUrl += "-vlc";
                }
                else if (checkedProgram.ToString() == "LibreOffice")
                {
                    niniteSubUrl += "-libreoffice";
                }
                else if (checkedProgram.ToString() == "Foxit Reader")
                {
                    niniteSubUrl += "-foxit";
                }
            }
            string niniteMainUrl = "https://www.ninite.com/" + niniteSubUrl + "/ninite.exe";
            downloadWindowObject.downloadFile(niniteMainUrl, autorunNinite.Checked);
            downloadWindowObject.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i < niniteMainList.Items.Count; i++)
            {
                niniteMainList.SetItemChecked(i, true);
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            aboutObject.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            serverModeObject.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clientModeObject.Show();
        }
    }
}
