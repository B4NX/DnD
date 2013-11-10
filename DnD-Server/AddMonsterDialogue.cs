using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DnD {
    public partial class AddMonsterDialogue : Form {

        public Monster Result;
        public Point Location;

        public AddMonsterDialogue() {
            InitializeComponent();
        }

        public Monster GetMonster() {
            Monster m = new Monster(Location, name.Text, race.Text, Int16.Parse(level.Text), Int16.Parse(hp.Text));
            m.Str = Int16.Parse(str.Text);
            m.Dex = Int16.Parse(dex.Text);
            m.Wis = Int16.Parse(wis.Text);
            m.Con = Int16.Parse(con.Text);
            m.Int = Int16.Parse(Int.Text);
            m.Cha = Int16.Parse(cha.Text);
            m.Ac = Int16.Parse(ac.Text);
            m.Fort = Int16.Parse(fort.Text);
            m.Ref = Int16.Parse(Ref.Text);
            m.Will = Int16.Parse(will.Text);
            m.Spd = Int16.Parse(spd.Text);
            return m;
        }

        private void number_Validating(object sender, CancelEventArgs e) {
            short num;
            if (!Int16.TryParse(((MaskedTextBox)sender).Text, out num)) {
                e.Cancel = true;
            }
        }

        private void okayBtn_Click(object sender, EventArgs e) {
            this.Result = GetMonster();
        }
    }
}
