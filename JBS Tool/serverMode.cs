using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JBS_Tool
{
    public partial class serverMode : Form
    {
        private List<TcpClient> clients = new List<TcpClient>();
        private TcpListener server;
        private bool isServerRunning = false;
        private CancellationTokenSource cancellationTokenSource;

        public serverMode()
        {
            InitializeComponent();
            server = new TcpListener(IPAddress.Any, 25064);
        }

        private async void sendMessage(String message)
        {
            try
            {
                foreach (TcpClient client in clients)
                {
                    NetworkStream stream = client.GetStream();
                    byte[] data = Encoding.ASCII.GetBytes(message);
                    await stream.WriteAsync(data, 0, data.Length);
                }
            }
            catch (Exception exc)
            {
                addLog("Wystąpił błąd podczas wysyłania wiadomości. Szczegóły: " + exc);
                MessageBox.Show("Wystąpił błąd podczas wysyłania wiadomości. Szczegóły: " + exc, "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addLog(String message)
        {
            logTextBox.Text += "[" + DateTime.Now + "] " + message + Environment.NewLine;
        }

        private async void button11_Click(object sender, EventArgs e)
        {
            try
            {
                server.Start();
                runServerButton.Enabled = false;
                stopServerButton.Enabled = true;
                actionBox.Enabled = true;
                addLog("Serwer uruchomiony na porcie 25064.");
                isServerRunning = true;
                cancellationTokenSource = new CancellationTokenSource();

                while (isServerRunning)
                {
                    try
                    {
                        var acceptTask = server.AcceptTcpClientAsync();
                        var completedTask = await Task.WhenAny(acceptTask, Task.Delay(Timeout.Infinite, cancellationTokenSource.Token));

                        if (completedTask == acceptTask)
                        {
                            TcpClient client = acceptTask.Result;
                            clients.Add(client);
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch (ObjectDisposedException)
                    {
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                isServerRunning = false;
                runServerButton.Enabled = true;
                stopServerButton.Enabled = false;
                actionBox.Enabled = false;
                addLog("Wystąpił błąd podczas uruchamiania serwera. Szczegóły: " + exc);
                MessageBox.Show("Wystąpił błąd podczas uruchamiania serwera. Szczegóły: " + exc, "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stopServerButton_Click(object sender, EventArgs e)
        {
            try
            {
                isServerRunning = false;
                cancellationTokenSource?.Cancel();
                server.Stop();
                foreach (var client in clients)
                {
                    client.Close();
                }
                clients.Clear();
                addLog("Serwer zatrzymany.");
                runServerButton.Enabled = true;
                stopServerButton.Enabled = false;
                actionBox.Enabled = false;
            }
            catch (Exception exc)
            {
                addLog("Wystąpił błąd podczas zatrzymywania serwera. Szczegóły: " + exc);
                MessageBox.Show("Wystąpił błąd podczas zatrzymywania serwera. Szczegóły: " + exc, "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            sendMessage("command");
            sendMessage(commandTextBox.Text);
            addLog("Wysłano komendę: " + commandTextBox.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            isServerRunning = false;
            server.Stop();
            runServerButton.Enabled = true;
            stopServerButton.Enabled = false;
            actionBox.Enabled = false;
        }

        private static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Brak lokalnego adresu IPv4 w interfejsie sieciowym.");
        }

        private void serverMode_Load(object sender, EventArgs e)
        {
            ipTextBox.Text = GetLocalIPAddress();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sendMessage("connection_test");
            addLog("Wysłano test połączenia.");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sendMessage("uri");
            sendMessage(uriTextBox.Text);
            addLog("Wysłano URI: " + uriTextBox.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sendMessage("close_browser");
            addLog("Zamknięto przeglądarkę.");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Aby korzystać z trybu serwera, uruchom go na komputerze, który ma być zdalnie sterowany. Następnie uruchom tryb klienta na komputerze, z którego chcesz sterować zdalnie. Wpisz adres IP komputera, na którym uruchomiono serwer, a następnie kliknij przycisk 'Połącz'.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Wyślij komendę wyłączenia komputera: wyłącza komputer zdalny. Używać ostrożnie." + Environment.NewLine + "Wyłącz DHCP i ustaw statyczny adres: wyłącza DHCP i ustawia adresację według DHCP, lecz zapisuje ją statycznie" + Environment.NewLine + "Ustaw statyczny adres bez komunikacji: wyłącza DHCP i ustawia adresację według DHCP, lecz zapisuje ją statycznie pomijając konfigurację bramy domyślnej" + Environment.NewLine + "Włącz DHCP: włącza DHCP" + Environment.NewLine + "Wszystkie akcje powyżej odbywają się na wszystkich interfejsach.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("Uwaga! Akcje wykonają się na wszystkich komputerach. Używaj rozważnie!", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                shutdownButton.Enabled = true;
                staticButton.Enabled = true;
                staticNoGwButton.Enabled = true;
                dhcpButton.Enabled = true;
            }
            else
            {
                shutdownButton.Enabled = false;
                staticButton.Enabled = false;
                staticNoGwButton.Enabled = false;
                dhcpButton.Enabled = false;
            }
        }

        private void shutdownButton_Click(object sender, EventArgs e)
        {
            sendMessage("shutdown");
            addLog("Wyłączono komputer.");
        }

        private void staticButton_Click(object sender, EventArgs e)
        {
            sendMessage("no_dhcp");
            addLog("Ustawiono statycznie adresację.");
        }

        private void staticNoGwButton_Click(object sender, EventArgs e)
        {
            sendMessage("no_dhcp_gateway");
            addLog("Ustawiono statycznie adresację bez bramy domyślnej.");
        }

        private void dhcpButton_Click(object sender, EventArgs e)
        {
            sendMessage("dhcp");
            addLog("Włączono DHCP.");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (saveLogDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveLogDialog.FileName, logTextBox.Text);
                addLog("Zapisano logi do pliku: " + saveLogDialog.FileName);
            }
        }
    }
}
