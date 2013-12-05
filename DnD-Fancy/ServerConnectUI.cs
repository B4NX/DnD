using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using SharpGLass;
using SharpGLass.GUI;
using DnD.Properties;

namespace DnD
{
    public class ServerConnectUI : World
    {
        public ServerConnectUI() : base() { }

        public override void Load()
        {
            base.Load();

            //this.BackgroundColor = Color.Black;

            Entity title = new Entity(new PointF(0, -100), new Size(512, 250), new Texture(Resources.Logo));
            title.Parallax = new PointF(0, 0);
            this.Add(title);

            GUITextField portBox = new GUITextField(new PointF(0, 90), new Size(300, 30), " ");
            portBox.InitTexture();
            portBox.TextColor = Color.White;
            this.Add(portBox);

            GUIButton start = new GUIButton(new Size(150, 30), "Start Server");
            start.BackgroundColor = Color.Crimson;
            start.TextColor = Color.DarkRed;
            start.Y = 140;
            this.Add(start);
            start.Pressed += (object sender, EventArgs e) =>
            {
                GV.Engine.SetWorld(new ServerUI());
            };

            portBox.OnEnter += (object sender, EventArgs e) => {
                start.SetState(ButtonState.Pressed);
            };
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
