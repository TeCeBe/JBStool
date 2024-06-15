using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics; // Dodaj tę przestrzeń nazw

namespace JBS_Tool
{
    public partial class clientMode : Form
    {
        private TcpClient client;
        private NetworkStream stream;

        public clientMode()
        {
            InitializeComponent();
        }

        private async void serverWorker(String ip, int port)
        {
            client = new TcpClient();
            try
            {
                await client.ConnectAsync(ip, port); // Asynchroniczne połączenie
                stream = client.GetStream();
                UpdateStatus("połączony");

                while (true)
                {
                    byte[] data = new byte[256];
                    int bytes = await stream.ReadAsync(data, 0, data.Length);
                    if (bytes == 0) break; // Brak danych, serwer zamknięty

                    String message = Encoding.ASCII.GetString(data, 0, bytes);
                    ProcessCommand(message);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Wystąpił błąd podczas łączenia z serwerem. Szczegóły: " + exc, "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UpdateStatus("zatrzymany");
            }
            finally
            {
                client?.Close();
            }
        }


        private void ProcessCommand(string message)
        {
            this.Invoke((MethodInvoker)delegate
            {
                richTextBox1.AppendText("Otrzymano: " + message + "\n");
            });

            switch (message)
            {
                case "connection_test":
                    MessageBox.Show("Test połączenia zakończony sukcesem", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "shutdown":
                    ExecuteCommand("shutdown /s /t 0");
                    break;
                case "open_browser":
                    ExecuteCommand("start http://www.google.com");
                    break;
                case "close_browser":
                    ExecuteCommand("taskkill /IM chrome.exe /F"); // Assumes Chrome is the browser
                    break;
                case "dhcp":
                    ExecuteCommand("netsh interface ip set address \"Local Area Connection\" dhcp");
                    break;
                case "no_dhcp":
                    ExecuteCommand("netsh interface ip set address \"Local Area Connection\" static 192.168.1.101 255.255.255.0");
                    break;
                case "no_dhcp_gateway":
                    ExecuteCommand("netsh interface ip set address \"Local Area Connection\" static 192.168.1.101 255.255.255.0 none");
                    break;
                default:
                    MessageBox.Show("Nieznana komenda: " + message, "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void ExecuteCommand(string command)
        {
            Process.Start("cmd.exe", "/c " + command);
        }

        private void UpdateStatus(string status)
        {
            if (label3.InvokeRequired)
            {
                label3.Invoke(new Action<string>(UpdateStatus), status);
            }
            else
            {
                label3.Text = status;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serverWorker(ipBox.Text, 25064);
        }

        private void ipBox_TextChanged(object sender, EventArgs e)
        {
            // Opcjonalnie dodaj logikę zmiany IP
        }
    }
}
