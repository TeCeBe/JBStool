using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace JBS_Tool
{
    public partial class serverMode : Form
    {

        private List<TcpClient> clients = new List<TcpClient>();
        TcpListener server = new TcpListener(IPAddress.Any, 25064);
        public serverMode()
        {
            InitializeComponent();
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
                MessageBox.Show("Wystąpił błąd podczas wysyłania wiadomości. Szczegóły: " + exc, "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void button11_Click(object sender, EventArgs e)
        {
            try
            {
                
                server.Start();
                while (true)
                {
                    TcpClient client = await server.AcceptTcpClientAsync();
                    clients.Add(client);
                }


            }
            catch (Exception exc)
            {
                MessageBox.Show("Wystąpił błąd podczas uruchamiania serwera. Szczegóły: " + exc, "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            sendMessage("connection_test");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            server.Stop();
        }
    }
}
