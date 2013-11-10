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
using System.Threading;

namespace DnD
{
    public partial class ClientUI : MainUI
    {
        public ClientUI()
        {
            InitializeComponent();

            DungeonMap = new DungeonMap(this);
            DungeonMap.Show(this);
            //Client.init(new System.Net.IPEndPoint(System.Net.IPAddress.Parse("192.168.20.144"),666));
            Thread update = new Thread(LogUpdate);
            update.Start();
        }

        protected override void sendMsgButton_Click(object sender, EventArgs e) {
            //log the message, then clear the textbox.
            string msg = msgEntryBox.Text;
            logAdventure(msg, "Player");
            msgEntryBox.Text = "";
        }

        public override void logAdventure(string msg, string sender) {
            //append DM prefix and newline, then log it to the main string and textbox.
            msg = "[" + sender + "]: " + msg + "\n";
            //Now send msg on to the server
            Client.writeQueue.Enqueue(Networking.Message.getLogMessage(msg));
            Debug.WriteLine(Client.writeQueue.Count);
        }
        public void LogUpdate() {
            while (true) {
                logClientAdventure();
            }
        }
        private void logClientAdventure() {
            if (Client.readQueue.Count != 0) {
                this.adventureLogBox.Text += Client.readQueue.Dequeue().ToString();
            }
        }
    }
}
