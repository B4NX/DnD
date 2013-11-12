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
            BackgroundWorker serverconnection = new BackgroundWorker();
            serverconnection.DoWork += (object sender2, DoWorkEventArgs e2) => {
                status.Text = "Waiting for connection...";
                status.Refresh();   
                Networking.Server.Connect();
                status.Text = "Connected!";
            };
            serverconnection.RunWorkerAsync();

            ServerUI win = new ServerUI();
            win.Show(this);
        }
    }
}
