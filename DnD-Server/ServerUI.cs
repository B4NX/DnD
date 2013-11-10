using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Networking;

namespace DnD {
    public partial class ServerUI : MainUI {
        public ServerUI() {
            InitializeComponent();

            DungeonMap = new ServerMap(this);
            DungeonMap.Show(this);

            Thread update = new Thread(LogUpdate);
            update.Start();
        }

        private void reset_Click(object sender, EventArgs e) {
            ((ServerMap)this.DungeonMap).ResetMap();
        }

        public override void logAdventure(string msg, string sender) {
            //append DM prefix and newline, then log it to the main string and textbox.
            msg = "[" + sender + "]: " + msg + Environment.NewLine;
            adventureLog += msg;
            adventureLogBox.Text += msg;
            Networking.Server.SendToAll(Networking.Message.ToByteArray(msg));
        }

        public void LogUpdate() {
            
        }

        protected override void sendMsgButton_Click(object sender, EventArgs e) {
            //log the message, then clear the textbox.
            string msg = msgEntryBox.Text;
            logAdventure(msg, "DM");
            msgEntryBox.Text = "";
        }

        protected string parseCommand(string msg) {
            string[] words = msg.Split(new char[] { ' ' });
            if (words[0] == "/whisper") {
                //check if second word is a player name
                //if so, send rest of the string to the player specified
            }

            //if (
            return msg;
        }
    }
}
