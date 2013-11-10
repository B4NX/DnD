using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace DnD {
    public partial class ServerUI : Form {

        private static string adventureLog;

        public ServerUI() {
            InitializeComponent();
        }

        private void sendMsgButton_Click(object sender, EventArgs e) {
            //log the message, then clear the textbox.
            string msg = msgEntryBox.Text;
            logAdventure(msg);
            msgEntryBox.Text = "";
        }

        private void logAdventure(string msg) {
            //append DM prefix and newline, then log it to the main string and textbox.
            msg = "[DM]: " + msg + "\n";
            adventureLog += msg;
            adventureLogBox.Text += msg;
        }

        private string parseCommand(string msg) {
            string[] words = msg.Split(new char[] { ' ' });
            if (words[0] == "/whisper") {
                //check if second word is a player name
                //if so, send rest of the string to the player specified
            }

            //if (
            return msg;
        }

        private void msgEntryBox_KeyPress(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Enter) {
                if (Control.ModifierKeys != Keys.Control) {                    
                    sendMsgButton.PerformClick();
                }
            }
        }

        private void msgEntryBox_TextChanged(object sender, EventArgs e) {
            if (msgEntryBox.Text == "\n") { msgEntryBox.Text = "";  }
        }
    }
}
