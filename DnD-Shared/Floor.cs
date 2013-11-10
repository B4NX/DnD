using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DnD {
    public class Floor : IDnDTile {
        public Color Color;
        public Image Image;
        public short x;
        public short y;
        public Floor(short x, short y) {
            Color = Color.White;
            this.x = x; this.y = y;
        }
        public Floor(Color c, short x, short y) {
            Color = c;
            this.x = x; this.y = y;
        }
        public Floor(Image i, short x, short y) {
            Image = i;
            this.x = x; this.y = y;
        }

        public void Draw(Graphics g) {
            if (this.Image == null) {
                g.DrawRectangle(new Pen(new SolidBrush(Color.White)), DungeonMap.GRIDSIZE * x, DungeonMap.GRIDSIZE * y, DungeonMap.GRIDSIZE, DungeonMap.GRIDSIZE);
            }
            else {
                g.DrawImage(this.Image, this.x * DungeonMap.GRIDSIZE, this.y * DungeonMap.GRIDSIZE, DungeonMap.GRIDSIZE, DungeonMap.GRIDSIZE);
            }
        }
    }
}
