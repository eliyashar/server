using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace AMCV1
{
    public partial class ControlForm : Form
    {
        public ControlForm()
        {
            InitializeComponent();
            clients = new List<Client>();
            
        }

        private void button_runClient_Click(object sender, EventArgs e)
        {
            Client c = new Client(6666);
            c.Show();
            clients.Add(c);
            
            
        }

        private void button_runServer_Click(object sender, EventArgs e)
        {
            Server s = new Server();
            s.Show();
            
        }

        public List<Client> clients { get; set; }

        private void button_openvlc_Click(object sender, EventArgs e)
        {
            VlcPlayer vlc = new VlcPlayer();
            vlc.Show();
        }
    }
}
