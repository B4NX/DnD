using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DnD {
    public class PlayerTreeNode : TreeNode {
        public Player Player;

        public PlayerTreeNode(Player p) : base(p.Name) {
            Player = p;
        }
    }
}
