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

        ServerUI ParentUI;

        public object[,] Grid;
        public const int GRIDSIZE = 20;

        public Pen pen = new Pen(Color.Black);

        public DungeonMap(ServerUI parent) {
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

            this.ClientSize = new Size(361, 361);

            //Scroll to the middle of the map
            using (Control c = new Control() { Parent = this, Height = 1, Top = this.ClientSize.Height / 2 + (GRIDSIZE * 50), Width = 1, Left = this.ClientSize.Width / 2 + (GRIDSIZE * 50) }) {
                this.ScrollControlIntoView(c);
            }
            mapPanel.Left = -1000;
            mapPanel.Top = -1000;
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

        public void ResetMap() {
            this.Grid = new object[100, 100];
        }

        public Point ConvertToGrid(Point p) {
            return new Point(p.X / GRIDSIZE, p.Y / GRIDSIZE);
        }

        private void mapPanel_MouseClick(object sender, MouseEventArgs e) {
            contextMenu.Show(Point.Add(Point.Subtract(e.Location, new Size(this.HorizontalScroll.Value, this.VerticalScroll.Value)), new Size(this.Left - this.ClientSize.Width / 2, this.Top - this.ClientSize.Height / 2)));
        }
    }
}
