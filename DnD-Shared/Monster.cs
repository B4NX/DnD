using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DnD {
    public class Monster : DnDTile {
        public string Name;
        public string Race;
        public short Level;
        public short HP;

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

        public byte D4;
        public byte D6;
        public byte D8a;
        public byte D8b;
        public byte D12;
        public byte D20;

        public Color Color;
        public Image Image;

        private MonsterStatsPane pane;

        public Monster(int x, int y, string name, string race, short level, short hp) {
            this.x = (short)x;
            this.y = (short)y;
            this.Name = name;
            this.Race = race;
            this.Level = level;
            this.HP = hp;

            Random rand = new Random();

            this.Color = Color.FromArgb(rand.Next(32, 255), rand.Next(0, 32), rand.Next(0, 32));
        }
        public Monster(Point p, string name, string race, short level, short hp) : this(p.X, p.Y, name, race, level, hp) {

        }

        public MonsterStatsPane GetPane(MainUI parent) {
            if (pane == null || pane.ParentForm != parent) {
                if (pane != null) { pane.Dispose(); }
                pane = new MonsterStatsPane(parent, this); 
            }
            return pane;
        }

        public override void Draw(Graphics g) {
            if (this.Image == null) {
                g.FillEllipse(new SolidBrush(Color), DungeonMap.GRIDSIZE * x, DungeonMap.GRIDSIZE * y, DungeonMap.GRIDSIZE, DungeonMap.GRIDSIZE);
            }
            else {
                g.DrawImage(this.Image, this.x * DungeonMap.GRIDSIZE, this.y * DungeonMap.GRIDSIZE, DungeonMap.GRIDSIZE, DungeonMap.GRIDSIZE);
            }
        }

        public void Dispose() {
            if (pane != null) { pane.Dispose(); }
        }
    }
}
