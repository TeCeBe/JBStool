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

        /*
         * w tym kodzie klient łączy się z serwerem i odbiera wiadomości
         * nalezy dopisac funkcjonalnosc, ktora zinterpretuje otrzymana wiadomosc i wykona akcje wg
         * informacji zawartych w servermode
         * wazne: nie mozna zmieniac kodu servermode 
         * wazne: przy teście połączenia musi pokazac sie okienko test, ktore potwierdzi poprawne polaczenie
         * zawiera juz implementację autozamykania i nie trzeba przy nic robić nic więcej
         * have fun :)
         */
    }
}
