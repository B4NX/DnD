using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DnD {
    public partial class ServerMap : DungeonMap {
        
        public ServerMap(MainUI parent) : base(parent) {
            InitializeComponent();

            contextMenu.ItemClicked += (object sender, ToolStripItemClickedEventArgs e) => {
                if (e.ClickedItem == addMonsterButton) {

                }
            };
        }

        protected override void mapPanel_MouseClick(object sender, MouseEventArgs e) {
            contextMenu.Show(Point.Add(Point.Subtract(e.Location, new Size(this.HorizontalScroll.Value, this.VerticalScroll.Value)), new Size(this.Left - this.ClientSize.Width / 2, this.Top - this.ClientSize.Height / 2)));
        }
    }
}
