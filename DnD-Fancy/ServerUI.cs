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
        public override void Load()
        {
            base.Load();

            //this.BackgroundColor = Color.Black;

            //Entity title = new Entity(new PointF(0, -100), new Size(512, 250), new Texture(Resources.Logo));
            //title.Parallax = new PointF(0, 0);
            //this.Add(title);
        }

        public override void Update(OpenTK.FrameEventArgs e)
        {
            base.Update(e);
        }

        public override void Render(OpenTK.FrameEventArgs e)
        {
            base.Render(e);
        }
    }
}
