using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DnD {
    public partial class ServerMap : DungeonMap {

        private Point lastClick;

        public ServerMap(MainUI parent) : base(parent) {
            InitializeComponent();

            contextMenu.ItemClicked += (object sender, ToolStripItemClickedEventArgs e) => {
                if (e.ClickedItem == addMonsterButton) {
                    AddMonsterDialogue amd = new AddMonsterDialogue();
                    amd.SpawnPoint = PointToGrid(lastClick);
                    amd.Show();
                    amd.FormClosing += (object sender2, FormClosingEventArgs e2) => {
                        this.AddMonster(amd.Result);
                        e2.Cancel = false;
                    };
                }
            };
        }

        protected override void mapPanel_MouseClick(object sender, MouseEventArgs e) {
            contextMenu.Show(mapPanel.PointToScreen(e.Location));
            lastClick = PointToClient(e.Location);
        }

        //Precondition: x and y are within Grid bounds
        public void AddMonster(Monster m) {
            this.Grid[m.x, m.y] = m;
        }
        public void ResetMap() {
            this.Grid = new object[100, 100];
        }
    }
}
