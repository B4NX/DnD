using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DnD {
    public partial class ServerUI : MainUI {
        public ServerUI() {
            InitializeComponent();

            DungeonMap = new ServerMap(this);
            DungeonMap.Show(this);
        }

        private void reset_Click(object sender, EventArgs e) {
            ((ServerMap)this.DungeonMap).ResetMap();
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

        public void AddMonster(Monster m) {
            MonsterTreeNode n = new MonsterTreeNode(m);
            monsterList.Nodes.Add(n);
            monsterList.NodeMouseDoubleClick += (object sender, TreeNodeMouseClickEventArgs e) => {
                ((MonsterTreeNode)e.Node).Monster.GetPane(this).Show();
            };
        }
    }
}
