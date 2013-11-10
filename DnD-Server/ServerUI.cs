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

        private string adventureLog;

        public ServerUI() {
            InitializeComponent();

            Monster dragon = new Monster("Agararhag", "Dragon", 7, 15);
            
            MonsterTreeNode testnode = new MonsterTreeNode(dragon);
            monsterList.NodeMouseDoubleClick += (object sender, TreeNodeMouseClickEventArgs e) => {
                MonsterStatsPane pane = ((MonsterTreeNode)e.Node).Monster.GetPane(this);
                pane.Show();
            };

            this.monsterList.Nodes.Add(testnode);
        }

        private void sendMsgButton_Click(object sender, EventArgs e) {
            //log the message, then clear the textbox.
            string msg = msgEntryBox.Text;
            logAdventure(msg, "DM");
            msgEntryBox.Text = "";
        }

        public void logAdventure(string msg, string sender) {
            //append DM prefix and newline, then log it to the main string and textbox.
            msg = "[" + sender + "]: " + msg + "\n";
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

        protected override void OnClosing(CancelEventArgs e) {
            foreach (MonsterTreeNode m in this.monsterList.Nodes) {
                m.Monster.Dispose();
            }
            base.OnClosing(e);
        }
    }
}
