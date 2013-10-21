using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using AxAXVLC;

namespace AMCV1
{
    public partial class VlcPlayer : Form
    {
        public VlcPlayer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vlc.addTarget(@"C:\Users\itaya\Dropbox\shared\Movies\20130413_175443.mp4", null, AXVLC.VLCPlaylistMode.VLCPlayListReplaceAndGo, 0);
            vlc.play();
        }
    }
}
