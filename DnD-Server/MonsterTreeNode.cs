using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DnD {
    public class MonsterTreeNode : TreeNode {
        public Monster Monster;

        public MonsterTreeNode(Monster m) : base(m.Name) {
            Monster = m;
        }
    }
}
