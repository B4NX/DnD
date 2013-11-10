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
        }

        private void reset_Click(object sender, EventArgs e) {
            this.DungeonMap.ResetMap();
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
