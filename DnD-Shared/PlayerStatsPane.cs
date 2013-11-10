using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DnD {
    public partial class PlayerStatsPane : Form {

        private MainUI ParentUI;
        private Player Player;

        public PlayerStatsPane(MainUI parent, Player p) {
            InitializeComponent();

            this.Player = p;
            this.ParentUI = parent;

            updateStats();
        }

        public void updateStats() {
            hp.Text = Player.HP.ToString();
            exp.Text = Player.Exp.ToString();
            level.Text = Player.Level.ToString();

            playerNameLabel.Text = Player.Name;

            str.Text = Player.Str.ToString();
            con.Text = Player.Con.ToString();
            dex.Text = Player.Dex.ToString();
            wis.Text = Player.Wis.ToString();
            intel.Text = Player.Int.ToString();
            cha.Text = Player.Cha.ToString();

            ac.Text = Player.Ac.ToString();
            fort.Text = Player.Fort.ToString();
            reflex.Text = Player.Ref.ToString();
            will.Text = Player.Will.ToString();

            spd.Text = Player.Spd.ToString();
        }

        private void skillsbtn_Click(object sender, EventArgs e) {
            Form f = new PlayerSkillsPane();
            f.Show();
        }
    }
}
