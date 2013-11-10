using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DnD {
    public partial class MonsterStatsPane : Form {

        private MainUI ParentUI;
        private Monster Monster;

        public MonsterStatsPane(MainUI parent, Monster m) {
            InitializeComponent();

            ParentUI = parent;
            Monster = m;

            updateStats();
        }

        public void updateStats() {
            hp.Text = Monster.HP.ToString();
            level.Text = Monster.Level.ToString();

            monsterNameLabel.Text = Monster.Name + " the " + Monster.Race;

            str.Text = Monster.Str.ToString();
            con.Text = Monster.Con.ToString();
            dex.Text = Monster.Dex.ToString();
            wis.Text = Monster.Wis.ToString();
            intel.Text = Monster.Int.ToString();
            cha.Text = Monster.Cha.ToString();

            ac.Text = Monster.Ac.ToString();
            fort.Text = Monster.Fort.ToString();
            reflex.Text = Monster.Ref.ToString();
            will.Text = Monster.Will.ToString();

            spd.Text = Monster.Spd.ToString();
        }

        private void monsterinput_TextChanged(object sender, EventArgs e) {
            if (monsterinput.Text == "\n") { monsterinput.Text = ""; }
        }

        private void monstersend_Click(object sender, EventArgs e) {
            string msg = monstersend.Text;
            ParentUI.logAdventure(msg, this.Name);
        }
    }
}
