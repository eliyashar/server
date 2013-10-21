using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Data.OleDb;
using System.Net;

namespace AMCV1
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            port = 6666;
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    if (ip.ToString().StartsWith("192.")) iip = ip.ToString();
                    else eip = ip.ToString();
                }
            }
            textBox_eip.Text = eip;
            textBox_iip.Text = iip;
            textBox_port.Text = "" + port;
            textBox_id.Text = System.Net.Dns.GetHostName();
     
        }

        private void StartServer(Int32 port, string ip)
        {
            IPAddress localAddr = IPAddress.Parse(ip);

            // TcpListener server = new TcpListener(port);
            server = new TcpListener(localAddr, port);

            // Start listening for client requests.
            server.Start();
            //blocks until a client has connected to the server
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (button_start_stop.Text == "Stop")  // to make the server always on
            {
                // to connect with clients
                TcpClient client = server.AcceptTcpClient();
                //---get the incoming data through a network stream---
                NetworkStream nwStream = client.GetStream();
                byte[] buffer = new byte[client.ReceiveBufferSize];

                //---read incoming stream---
                int bytesRead = nwStream.Read(buffer, 0, client.ReceiveBufferSize);

                //---convert the data received into a string---
                string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                Console.WriteLine("Received : " + dataReceived);
                richTextBox_ServerConsole.AppendText(Environment.NewLine + "Received : " + dataReceived);

                //---write back the text to the client---
                Console.WriteLine("Sending back : " + dataReceived);
                nwStream.Write(buffer, 0, bytesRead);
                client.Close();
            }
            else
                server.Stop();
        }
        public TcpListener server { get; set; }

        private void button_start_stop_Click(object sender, EventArgs e)
        {
            if (button_start_stop.Text == "Stop")
            {
                richTextBox_ServerConsole.AppendText(Environment.NewLine + "Stopping...");
                button_start_stop.Text = "Start";
            }
            if (button_start_stop.Text == "Start")
            {
                button_start_stop.Text = "Stop";
                richTextBox_ServerConsole.AppendText(Environment.NewLine + "Starting..."); 
                StartServer(Convert.ToInt32(textBox_port.Text.Trim()), textBox_iip.Text.Trim());
                richTextBox_ServerConsole.AppendText(Environment.NewLine + "server started");
                
            }
        }

        public string eip { get; set; }

        public string iip { get; set; }

        public int port { get; set; }

    }
}
