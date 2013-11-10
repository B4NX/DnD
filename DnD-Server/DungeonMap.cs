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

        public DungeonMap(ServerUI parent) {
            InitializeComponent();

            this.ParentUI = parent;
            this.Shown += (object sender, EventArgs e) => {
                this.Left = ParentUI.Left + ParentUI.Width;
                this.Top = ParentUI.Top + (ParentUI.Height - this.Height) / 2;
            };

            mapPanel.Paint += (object sender, PaintEventArgs e) => {
                for (int x = 0; x < Grid.GetLength(0); x++) {
                    if (x > e.ClipRectangle.Left && x < e.ClipRectangle.Right) {

                    }
                }
            };
        }

        public void MakeGridSquares() {
            Grid = new object[100, 100];
        }
    }
}
