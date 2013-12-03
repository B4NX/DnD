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
using Networking.Messages;

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
            update.Name = "Client Update";
            update.Start();
            Application.Idle += Application_Idle;
        }

        protected override void sendMsgButton_Click(object sender, EventArgs e) {
            //log the message, then clear the textbox.
            string msg = msgEntryBox.Text;
            logAdventure(msg, "Player");
            msgEntryBox.Text = "";
        }

        private void Application_Idle(object sender, EventArgs e) {
            if (readUIQueue.Count > 0) {
                string msg = readUIQueue.Dequeue();
                Debug.WriteLine("Something on the queue (len " + readUIQueue.Count + ")! it's " + msg + Environment.NewLine);
                adventureLog += msg;
                adventureLogBox.Text += msg;
            }
        }

        public override void logAdventure(string msg, string sender) {
            //append DM prefix and newline, then log it to the main string and textbox.
            msg = "[" + sender + "]: " + msg + Environment.NewLine;
            //Now send msg on to the server
            ClientNS.writeQueue.Enqueue(new LogMessage(msg));
            Debug.WriteLine(ClientNS.writeQueue.Count);
        }
        public void LogUpdate() {
            while (true) {
                logClientAdventure();
            }
        }
        private static Queue<string> readUIQueue = new Queue<string>();
        private void logClientAdventure() {
            if (ClientNS.readQueue.Count != 0) {
                Networking.Message m=ClientNS.readQueue.Dequeue();
                Debug.WriteLine("Received message from server: " + m.ToString() + Environment.NewLine);
                readUIQueue.Enqueue(m.ToString());
            }
        }

        private void ClientUI_FormClosed(object sender, FormClosedEventArgs e) {
            ClientNS.Close();
        }

    }
}
