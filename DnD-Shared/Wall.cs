using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DnD {
    public class Wall : DnDTile {
        public Color Color;
        public Image Image;

        public Wall(short x, short y) : this(Color.White, x, y) { }
        public Wall(Color c, short x, short y) {
            Color = c;
            this.x = x;
            this.y = y;
        }
        public Wall(Image i, short x, short  y) {
            Image = i;
            this.x = x;
            this.y = y;
        }
        public override void Draw(Graphics g) {
            if (this.Image == null) {
                g.FillRectangle(new SolidBrush(Color), DungeonMap.GRIDSIZE * x, DungeonMap.GRIDSIZE * y, DungeonMap.GRIDSIZE, DungeonMap.GRIDSIZE);
            }
            else {
                g.DrawImage(this.Image, this.x * DungeonMap.GRIDSIZE, this.y * DungeonMap.GRIDSIZE, DungeonMap.GRIDSIZE, DungeonMap.GRIDSIZE);
            }
        }
    }
}
