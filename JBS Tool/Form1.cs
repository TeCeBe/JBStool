using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JBS_Tool
{
    public partial class Form1 : Form
    {
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
                System.Windows.Forms.MessageBox.Show("Nie można utworzyć folderu roboczego aplikacji. Funkcje takie jak pobieranie mogą nie działać prawidłowo. Spróbuj ponownie uruchamiając program z uprawnieniami administratora. Szczegóły: " + exc, "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { }
            winInfo.Text = "Twoja wersja systemu Windows: " + getOSInfo();
            if (isSupported == true)
            {
                supportInfo.Hide();
            }
            loadInterfaces();
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
            downloadWindow downloadWindowObject = new downloadWindow();
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
                System.Windows.Forms.MessageBox.Show("Wystąpił nieznany błąd: " + exc, "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                System.Windows.Forms.MessageBox.Show("Wystąpił nieznany błąd: " + exc, "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                System.Windows.Forms.MessageBox.Show("Wystąpił nieznany błąd: " + exc, "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            downloadWindow downloadWindowObject = new downloadWindow();
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
            about aboutObject = new about();
            aboutObject.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            serverMode serverModeObject = new serverMode();
            serverModeObject.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clientMode clientModeObject = new clientMode();
            clientModeObject.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (lbInterfaces.SelectedItem != null)
            {
                string interfaceName = lbInterfaces.SelectedItem.ToString();
                UpdateIPv4Settings(interfaceName, chkDhcp.Checked, txtIpAddress.Text, txtSubnetMask.Text, txtGateway.Text, txtDns.Text.Split(',').Select(dns => dns.Trim()).ToArray());
            }
        }

        private void loadInterfaces()
        {
            lbInterfaces.Items.Clear();
            var interfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (var ni in interfaces)
            {
                lbInterfaces.Items.Add(ni.Name);
            }
        }

        private void lbInterfaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbInterfaces.SelectedItem != null)
            {
                string interfaceName = lbInterfaces.SelectedItem.ToString();
                ShowIPv4Settings(interfaceName);
            }
        }


        private void ShowIPv4Settings(string interfaceName)
        {
            var networkInterface = NetworkInterface.GetAllNetworkInterfaces()
                                                   .FirstOrDefault(ni => ni.Name == interfaceName);

            if (networkInterface != null)
            {
                var ipProps = networkInterface.GetIPProperties().UnicastAddresses
                                               .FirstOrDefault(ip => ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);

                if (ipProps != null)
                {
                    txtIpAddress.Text = ipProps.Address.ToString();
                    txtSubnetMask.Text = ipProps.IPv4Mask.ToString();

                    var gateway = networkInterface.GetIPProperties().GatewayAddresses
                                                  .FirstOrDefault()?.Address.ToString();
                    txtGateway.Text = gateway;

                    var dnsAddresses = networkInterface.GetIPProperties().DnsAddresses
                                                       .Where(dns => dns.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                                                       .Select(dns => dns.ToString()).ToArray();
                    txtDns.Text = string.Join(", ", dnsAddresses);
                }

                // Check DHCP status
                chkDhcp.Checked = networkInterface.GetIPProperties().GetIPv4Properties().IsDhcpEnabled;
            }
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnDisableDhcp_Click(object sender, EventArgs e)
        {
            if (lbInterfaces.SelectedItem != null)
            {
                string interfaceName = lbInterfaces.SelectedItem.ToString();
                SaveCurrentIPv4Settings(interfaceName);
                UpdateIPv4Settings(interfaceName, false, txtIpAddress.Text, txtSubnetMask.Text, txtGateway.Text, txtDns.Text.Split(',').Select(dns => dns.Trim()).ToArray());
            }
        }

        private void btnDisableDhcpAndRemoveGateway_Click(object sender, EventArgs e)
        {
            if (lbInterfaces.SelectedItem != null)
            {
                string interfaceName = lbInterfaces.SelectedItem.ToString();
                SaveCurrentIPv4Settings(interfaceName);
                UpdateIPv4Settings(interfaceName, false, txtIpAddress.Text, txtSubnetMask.Text, string.Empty, txtDns.Text.Split(',').Select(dns => dns.Trim()).ToArray());
            }
        }

        private void SaveCurrentIPv4Settings(string interfaceName)
        {
            var networkInterface = NetworkInterface.GetAllNetworkInterfaces()
                                                   .FirstOrDefault(ni => ni.Name == interfaceName);

            if (networkInterface != null)
            {
                var ipProps = networkInterface.GetIPProperties().UnicastAddresses
                                               .FirstOrDefault(ip => ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);

                if (ipProps != null)
                {
                    txtIpAddress.Text = ipProps.Address.ToString();
                    txtSubnetMask.Text = ipProps.IPv4Mask.ToString();

                    var gateway = networkInterface.GetIPProperties().GatewayAddresses
                                                  .FirstOrDefault()?.Address.ToString();
                    txtGateway.Text = gateway;

                    var dnsAddresses = networkInterface.GetIPProperties().DnsAddresses
                                                       .Where(dns => dns.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                                                       .Select(dns => dns.ToString()).ToArray();
                    txtDns.Text = string.Join(", ", dnsAddresses);
                }
            }
        }

        private void UpdateIPv4Settings(string interfaceName, bool useDhcp, string newIp, string newSubnet, string newGateway, string[] newDns)
        {
            if (useDhcp)
            {
                ExecuteNetshCommand($"interface ip set address \"{interfaceName}\" dhcp");
                ExecuteNetshCommand($"interface ip set dns name=\"{interfaceName}\" dhcp");
            }
            else
            {
                ExecuteNetshCommand($"interface ip set address \"{interfaceName}\" static {newIp} {newSubnet} {newGateway}");
                ExecuteNetshCommand($"interface ip set dns name=\"{interfaceName}\" static {newDns[0]}");
                for (int i = 1; i < newDns.Length; i++)
                {
                    ExecuteNetshCommand($"interface ip add dns name=\"{interfaceName}\" {newDns[i]} index={i + 1}");
                }
            }
        }

        private void ExecuteNetshCommand(string command)
        {
            try
            {
                ProcessStartInfo processInfo = new ProcessStartInfo("netsh", command);
                processInfo.RedirectStandardError = true;
                processInfo.RedirectStandardOutput = true;
                processInfo.UseShellExecute = false;
                processInfo.CreateNoWindow = true;

                Process process = new Process();
                process.StartInfo = processInfo;
                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                process.WaitForExit();

                // Log the output and error
                log.Text += ($"Komenda: {command}") + Environment.NewLine;
                log.Text += ($"Odpowiedź: {output}") + Environment.NewLine;
                log.Text += ($"Błąd: {error}") + Environment.NewLine;
            }
            catch (Exception ex)
            {
                log.Text += ($"Wyjątek: {ex.Message}") + Environment.NewLine;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
