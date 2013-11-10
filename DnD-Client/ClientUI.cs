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

namespace DnD
{
    public partial class ClientUI : MainUI
    {
        public ClientUI()
        {
            InitializeComponent();

            DungeonMap = new DungeonMap(this);
            DungeonMap.Show(this);
        }

        protected override void sendMsgButton_Click(object sender, EventArgs e) {     
            //log the message, then clear the textbox.
            string msg = msgEntryBox.Text;
            logAdventure(msg, "Player");
            msgEntryBox.Text = "";
        }
    }
}
