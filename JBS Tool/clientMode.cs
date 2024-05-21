using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace JBS_Tool
{
    public partial class clientMode : Form
    {
        private TcpClient client;
        public clientMode()
        {
            InitializeComponent();
        }

        private async void serverWorker(String ip, int port)
        {
            try
            {
                while (true)
                {
                    client = new TcpClient(ip, port);
                    NetworkStream stream = client.GetStream();
                    byte[] data = new byte[256];
                    int bytes = await stream.ReadAsync(data, 0, data.Length);
                    String message = Encoding.ASCII.GetString(data, 0, bytes);
                    MessageBox.Show("Otrzymano wiadomość: " + message, "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
              
            }
            catch (Exception exc)
            {
                MessageBox.Show("Wystąpił błąd podczas łączenia z serwerem. Szczegóły: " + exc, "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serverWorker(ipBox.Text, 25064);
        }
    }
}
