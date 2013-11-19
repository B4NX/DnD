using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using SharpGLass;
using SharpGLass.GUI;

namespace DnD
{
    public class ServerUI : World
    {
        public ServerUI() : base() { }

        public override void Load()
        {
            base.Load();

            //this.BackgroundColor = Color.Black;

            GUILabel title = new GUILabel("D&D");
            title.Font = new Font(title.Font.FontFamily, 72);
            title.Y = -150;
            title.TextColor = Color.LightGray;
            this.Add(title);

            GUITextField portBox = new GUITextField(new PointF(0, 0), new Size(300, 30), " ");
            portBox.BackgroundColor = Color.DarkRed;
            portBox.ForegroundColor = Color.Crimson;
            portBox.TextColor = Color.FromArgb(255, 192, 192);
            portBox.InitTexture();
            this.Add(portBox);

            GUIButton start = new GUIButton(new Size(150, 30), "Start Server");
            start.BackgroundColor = Color.Crimson;
            start.TextColor = Color.DarkRed;
            start.Y = 100;
            this.Add(start);

        }

        public override void Update(OpenTK.FrameEventArgs e)
        {
            base.Update(e);
        }

        public override void Render(OpenTK.FrameEventArgs e) {
            base.Render(e);
        }
    }
}
