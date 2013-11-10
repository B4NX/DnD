using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Networking;
using System.Net;
using System.Net.Sockets;

namespace DnD
{
    public partial class ClientUI : MainUI
    {
        public ClientUI()
        {
            InitializeComponent();

            DungeonMap = new DungeonMap(this);
            DungeonMap.Show(this);
            Client.init(new IPEndPoint(IPAddress.Parse("129.168.20.144"),666));
        }

        protected override void sendMsgButton_Click(object sender, EventArgs e) {     
            //log the message, then clear the textbox.
            string msg = msgEntryBox.Text;
            logAdventure(msg, "Player");
            msgEntryBox.Text = "";
            Client.sendString(msg);
        }

        public override void logAdventure(string msg, string sender) {
            //append DM prefix and newline, then log it to the main string and textbox.
            msg = "[" + sender + "]: " + msg + "\n";
            //Now send msg on to the server
            //HERE
        }
    }
}
