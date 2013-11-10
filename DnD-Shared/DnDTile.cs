using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DnD {
    public abstract class DnDTile {
        public short x;
        public short y;

        public abstract void Draw(Graphics g);
    }
}
