using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DnD {
    public class Player {
        public string Name { get; private set; }
        public string Race { get; private set; }
        public string Class { get; private set; }

        public int Level { get; private set; }
        public int Exp { get; private set; }
        public int HP { get; private set; }
        public int AP { get; private set; }

        public int Str { get; private set; }
        public int Con { get; private set; }
        public int Dex { get; private set; }
        public int Int { get; private set; }
        public int Wis { get; private set; }
        public int Cha { get; private set; }

        public int Ac { get; private set; }
        public int Fort { get; private set; }
        public int Ref { get; private set; }
        public int Will { get; private set; }

        public int Spd { get; private set; }

        public int D4;
        public int D6;
        public int D8a;
        public int D8b;
        public int D12;
        public int D20;

        private PlayerStatsPane pane;

        public Player(string name, string race, string plyrclass) {
            this.Name = name;
            this.Race = race;
            this.Class = plyrclass;
        }

        public PlayerStatsPane GetPane(ServerUI parent) {
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
