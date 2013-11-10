using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DnD {
    public class Player : DnDTile {
        public string Name;
        public string Race;
        public string Class;

        public short Level;
        public short Exp;
        public short HP;
        public short AP;

        public short Str;
        public short Con;
        public short Dex;
        public short Int;
        public short Wis;
        public short Cha;

        public short Ac;
        public short Fort;
        public short Ref;
        public short Will;

        public short Spd;

        public short D4;
        public short D6;
        public short D8a;
        public short D8b;
        public short D12;
        public short D20;

        public Color Color;
        public Image Image;

        private PlayerStatsPane pane;

        public Player(string name, string race, string plyrclass) {
            this.Name = name;
            this.Race = race;
            this.Class = plyrclass;

            Random rand = new Random();
            int g = rand.Next(0, 255);
            this.Color = Color.FromArgb(rand.Next(0, 96), g, 255 - g);
        }

        public PlayerStatsPane GetPane(MainUI parent) {
            if (pane == null || pane.ParentForm != parent) {
                if (pane != null) { pane.Dispose(); }
                pane = new PlayerStatsPane(parent, this); 
            }
            return pane;
        }

        public void Dispose() {
            if (pane != null) { pane.Dispose(); }
        }
        public override void Draw(Graphics g) {
            if (this.Image == null) {
                g.FillEllipse(new SolidBrush(Color), DungeonMap.GRIDSIZE * x, DungeonMap.GRIDSIZE * y, DungeonMap.GRIDSIZE, DungeonMap.GRIDSIZE);
            }
            else {
                g.DrawImage(this.Image, this.x * DungeonMap.GRIDSIZE, this.y * DungeonMap.GRIDSIZE, DungeonMap.GRIDSIZE, DungeonMap.GRIDSIZE);
            }
        }
    }
}
