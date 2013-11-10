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
        private Point selectedTile = Point.Empty;

        public ServerMap(MainUI parent) : base(parent) {
            InitializeComponent();

            mapPanel.Paint += DrawSelectedTile;

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

        private void DrawSelectedTile(object sender, PaintEventArgs e) {
            if (selectedTile.X * GRIDSIZE > e.ClipRectangle.Left && selectedTile.X * GRIDSIZE < e.ClipRectangle.Right) {
                if (selectedTile.Y * GRIDSIZE > e.ClipRectangle.Top && selectedTile.Y * GRIDSIZE < e.ClipRectangle.Bottom) {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(64, 192, 220, 255)), selectedTile.X * GRIDSIZE, selectedTile.Y * GRIDSIZE, GRIDSIZE, GRIDSIZE);
                }
            }
        }

        protected override void mapPanel_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button != MouseButtons.Left) {
                contextMenu.Show(mapPanel.PointToScreen(e.Location));
            }
            else {
                selectedTile = new Point(e.X / GRIDSIZE, e.Y / GRIDSIZE);
                if (selectedTile != Point.Empty && selectedTile.X < 100 && selectedTile.Y < 100) {
                    setimage.Enabled = setcolor.Enabled = newmonster.Enabled = true;
                }
                mapPanel.Refresh();
            }
            lastClick = e.Location;
        }

        //Precondition: x and y are within Grid bounds
        public void AddMonster(Monster m) {
            this.Grid[m.x, m.y] = m;
            this.ParentUI.AddMonster(m);
            this.Refresh();
        }
        public void AddPlayer(Player p) {
            this.Grid[p.x, p.y] = p;
            this.Refresh();
        }

        public void ResetMap() {
            this.Grid = new DnDTile[100, 100];
        }

        private void newMonsterToolStripMenuItem_Click(object sender, EventArgs e) {
            AddMonsterDialogue amd = new AddMonsterDialogue();
            amd.SpawnPoint = selectedTile;
            amd.Show();
            amd.FormClosing += (object sender2, FormClosingEventArgs e2) => {
                this.AddMonster(amd.Result);
                e2.Cancel = false;
            };
        }

        private void setBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e) {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            mapPanel.BackColor = cd.Color;
        }

        private void setImageToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) {
            this.ResetMap();
            this.Refresh();
        }
    }
}
