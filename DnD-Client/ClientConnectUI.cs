using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Networking;
using System.Net;

namespace DnD {
    public partial class ClientConnectUI : Form {
        public ClientConnectUI() {
            InitializeComponent();
        }

        private void connectBtn_Click(object sender, EventArgs e) {
            ClientNS.init(new IPEndPoint(IPAddress.Parse(ipBox.Text), 666));
            ClientUI win = new ClientUI();
            win.Show(this);
        }
    }
}
