using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DnD
{
    public partial class ServerConnectUI : Form
    {
        public ServerConnectUI()
        {
            InitializeComponent();
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            status.Text = "Starting server...";
            Networking.Server.init(Int16.Parse(portBox.Text));
            System.Diagnostics.Debug.WriteLine("Server initialized.");
            Networking.Server.Connect();
            ServerUI win = new ServerUI();
            win.Show(this);
        }
    }
}
