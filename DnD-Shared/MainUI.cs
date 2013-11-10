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
    public partial class MainUI : Form {

        protected string adventureLog;
        protected DungeonMap DungeonMap;

        public MainUI() {
            InitializeComponent();
        }

        protected virtual void sendMsgButton_Click(object sender, EventArgs e) {
            //log the message, then clear the textbox.
            string msg = msgEntryBox.Text;
            logAdventure(msg, "World");
            msgEntryBox.Text = "";
        }

        public void logAdventure(string msg, string sender) {
            //append DM prefix and newline, then log it to the main string and textbox.
            msg = "[" + sender + "]: " + msg + "\n";
            adventureLog += msg;
            adventureLogBox.Text += msg;
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

        protected override void OnClosing(CancelEventArgs e) {
            base.OnClosing(e);
        }
    }
}
