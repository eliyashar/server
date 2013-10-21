using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace AMCV1
{
    public partial class Client : Form
    {
        public Client(int _port)
        {
            InitializeComponent();
            port = _port;
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
            serverip = "192.168.1.102";
            sendMsg("--------------" + textBox_id.Text + "--------------" + eip + "--------------" + iip + "--------------" + port + "--------------");
            timer1.Start();
            lastText = "Client is up";
            richTextBox_clientConsole.Text = lastText;
           
        }

        private void sendMsg(string textToSend)
        {
            
            //---create a TCPClient object at the IP and port no.---
            TcpClient client = new TcpClient(serverip, port);
            NetworkStream nwStream = client.GetStream();
            byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(textToSend);

            //---send the text---
            Console.WriteLine("Sending : " + textToSend);
            nwStream.Write(bytesToSend, 0, bytesToSend.Length);

            //---read back the text---
            byte[] bytesToRead = new byte[client.ReceiveBufferSize];
            int bytesRead = nwStream.Read(bytesToRead, 0, client.ReceiveBufferSize);
            Console.WriteLine("Received : " + Encoding.ASCII.GetString(bytesToRead, 0, bytesRead));
            Console.ReadLine();
            client.Close();
        }



        public string eip { get; set; }
        public string iip { get; set; }

        public int port { get; set; }

        public string serverip { get; set; }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sendMsg("Hellow server: " + DateTime.Now.ToString());
        }

        private void richTextBox_clientConsole_TextChanged(object sender, EventArgs e)
        {
            string msg = richTextBox_clientConsole.Text.Replace(lastText, "");
            sendMsg(msg);
            lastText = richTextBox_clientConsole.Text;
        }

        public string lastText { get; set; }
    }
}
