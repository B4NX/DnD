using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DnD {
    public class Player : IDnDTile {
        public string Name { get; private set; }
        public string Race { get; private set; }
        public string Class { get; private set; }

        public short Level { get; private set; }
        public short Exp { get; private set; }
        public short HP { get; private set; }
        public short AP { get; private set; }

        public short Str { get; private set; }
        public short Con { get; private set; }
        public short Dex { get; private set; }
        public short Int { get; private set; }
        public short Wis { get; private set; }
        public short Cha { get; private set; }

        public short Ac { get; private set; }
        public short Fort { get; private set; }
        public short Ref { get; private set; }
        public short Will { get; private set; }

        public short Spd { get; private set; }

        public short D4;
        public short D6;
        public short D8a;
        public short D8b;
        public short D12;
        public short D20;

        public Color Color;

        private PlayerStatsPane pane;
        public short x;
        public short y;

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
    }
}
