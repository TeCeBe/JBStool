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
            ToggleServerControls(false);
        }

        private void ToggleServerControls(bool isEnabled)
        {
            stopServerButton.Enabled = isEnabled;
            actionBox.Enabled = isEnabled;
            runServerButton.Enabled = !isEnabled;
        }

        private async void button11_Click(object sender, EventArgs e)
        {
            try
            {
                server.Start();
                ToggleServerControls(true);
                addLog("Serwer uruchomiony na porcie 25064.");
                isServerRunning = true;
                cancellationTokenSource = new CancellationTokenSource();
                await AcceptClients();
            }
            catch (Exception exc)
            {
                ToggleServerControls(false);
                addLog("Wystąpił błąd podczas uruchamiania serwera. Szczegóły: " + exc);
                MessageBox.Show("Wystąpił błąd podczas uruchamiania serwera. Szczegóły: " + exc, "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task AcceptClients()
        {
            while (isServerRunning)
            {
                try
                {
                    TcpClient client = await server.AcceptTcpClientAsync();
                    clients.Add(client);
                }
                catch (ObjectDisposedException)
                {
                    // Ignored during server shutdown
                }
                catch (Exception exc)
                {
                    addLog("Błąd przy przyjmowaniu nowego klienta: " + exc.Message);
                    MessageBox.Show("Błąd podczas przyjmowania nowego klienta: " + exc.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            StopServer();
        }

        private void StopServer()
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
                ToggleServerControls(false);
            }
            catch (Exception exc)
            {
                addLog("Wystąpił błąd podczas zatrzymywania serwera. Szczegóły: " + exc);
                MessageBox.Show("Wystąpił błąd podczas zatrzymywania serwera. Szczegóły: " + exc, "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addLog(String message)
        {
            logTextBox.Invoke((MethodInvoker)delegate
            {
                logTextBox.Text += "[" + DateTime.Now + "] " + message + Environment.NewLine;
            });
        }

        private async void sendMessage(String message)
        {
            if (!isServerRunning || clients.Count == 0)
            {
                MessageBox.Show("Brak aktywnego serwera lub klientów.", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

        private void serverMode_Load(object sender, EventArgs e)
        {
            ipTextBox.Text = GetLocalIPAddress();
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

        // Dodane metody obsługi zdarzeń (handler methods)
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Informacje o funkcjach...", "Pomoc", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dhcpButton_Click(object sender, EventArgs e)
        {
            sendMessage("dhcp");
            addLog("Wysłano komendę: Włącz DHCP.");
        }

        private void staticNoGwButton_Click(object sender, EventArgs e)
        {
            sendMessage("no_dhcp_gateway");
            addLog("Wysłano komendę: Ustaw statyczny adres bez bramy domyślnej.");
        }

        private void staticButton_Click(object sender, EventArgs e)
        {
            sendMessage("no_dhcp");
            addLog("Wysłano komendę: Wyłącz DHCP i ustaw statyczny adres.");
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            bool isChecked = checkBox1.Checked;
            shutdownButton.Enabled = isChecked;
            staticButton.Enabled = isChecked;
            staticNoGwButton.Enabled = isChecked;
            dhcpButton.Enabled = isChecked;
        }

        private void shutdownButton_Click(object sender, EventArgs e)
        {
            sendMessage("shutdown");
            addLog("Wysłano komendę: Wyłączenie komputera.");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            sendMessage(commandTextBox.Text);
            addLog("Wysłano polecenie: " + commandTextBox.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sendMessage("connection_test");
            addLog("Wysłano test połączenia.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sendMessage("close_browser");
            addLog("Zamknięto przeglądarkę.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sendMessage("open_browser " + uriTextBox.Text);
            addLog("Wysłano URI: " + uriTextBox.Text);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Informacje o trybie serwera...", "Pomoc", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
