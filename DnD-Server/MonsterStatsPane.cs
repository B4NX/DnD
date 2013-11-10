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
        public MonsterStatsPane() {
            InitializeComponent();
        }

        private void monsterinput_TextChanged(object sender, EventArgs e) {

        }

        private void monstersend_Click(object sender, EventArgs e) {
            string msg = monstersend.Text;
        }
    }
}
