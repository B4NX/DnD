using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DnD {
    public partial class DungeonMap : Form {

        protected MainUI ParentUI;

        public object[,] Grid;
        public const int GRIDSIZE = 20;

        public Pen pen = new Pen(Color.Black);
        protected DungeonMap() {
            InitializeComponent();
        }
        public DungeonMap(MainUI parent) {
            InitializeComponent();
            this.ParentUI = parent;
            this.Shown += (object sender, EventArgs e) => {
                this.Left = ParentUI.Left + ParentUI.Width;
                this.Top = ParentUI.Top + (ParentUI.Height - this.Height) / 2;
            };

            this.Grid = new object[100, 100];

            mapPanel.Width = GRIDSIZE * 100;
            mapPanel.Height = GRIDSIZE * 100;
            mapPanel.Paint += MakeGridSquares;
            mapPanel.Paint += DrawObjects;

            this.ClientSize = new Size(361, 361);

            //Scroll to the middle of the map
            using (Control c = new Control() { Parent = this, Height = 1, Top = this.ClientSize.Height / 2 + (GRIDSIZE * 50), Width = 1, Left = this.ClientSize.Width / 2 + (GRIDSIZE * 50) }) {
                this.ScrollControlIntoView(c);
            }
            mapPanel.Left = -1000;
            mapPanel.Top = -1000;
        }

        public void Update(object[,] grid) {
            this.Grid = grid;
        }
        public void Update(int x, int y, object obj) {
            this.Grid[x, y] = obj;
        }

        private void MakeGridSquares(object sender, PaintEventArgs e) {
            for (int x = 0; x < Grid.GetLength(0) * GRIDSIZE; x += GRIDSIZE) {
                if (x >= e.ClipRectangle.Left && x <= e.ClipRectangle.Right) {
                    e.Graphics.DrawLine(pen, new Point(x, e.ClipRectangle.Top), new Point(x, e.ClipRectangle.Bottom));
                }
            } 
            for (int y = 0; y < Grid.GetLength(1) * GRIDSIZE; y += GRIDSIZE) {
                if (y >= e.ClipRectangle.Top && y <= e.ClipRectangle.Bottom) {
                    e.Graphics.DrawLine(pen, new Point(e.ClipRectangle.Left, y), new Point(e.ClipRectangle.Right, y));
                }
            }
        }

        private void DrawObjects(object sender, PaintEventArgs e) {
            for (int x = (e.ClipRectangle.Left / GRIDSIZE); x < (e.ClipRectangle.Right / GRIDSIZE); ++x) {
                for (int y = (e.ClipRectangle.Top / GRIDSIZE); y < (e.ClipRectangle.Bottom / GRIDSIZE); ++y) {
                    if (Grid[x, y] != null) {
                        if (Grid[x, y] is Player) {
                            Player plr = (Player)Grid[x,y];
                            Brush b = new SolidBrush(plr.Color);
                            e.Graphics.FillEllipse(b, x * GRIDSIZE, y * GRIDSIZE, GRIDSIZE, GRIDSIZE);
                        }
                        else if (Grid[x, y] is Monster) {
                            Monster mtr = (Monster)Grid[x, y];
                            Brush b = new SolidBrush(mtr.Color);
                            e.Graphics.FillEllipse(b, x * GRIDSIZE, y * GRIDSIZE, GRIDSIZE, GRIDSIZE);
                        }
                    }
                }
            }
        }

        public Point PointToGrid(Point p) {
            return new Point(p.X / GRIDSIZE, p.Y / GRIDSIZE);
        }

        protected virtual void mapPanel_MouseClick(object sender, MouseEventArgs e) {

        }
    }
}
