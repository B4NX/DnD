using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using OpenTK;
using SharpGLass;

namespace DnD
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Engine Game = new Engine(new ServerConnectUI());
            Console.WriteLine(GV.Engine);
            Game.Run();
        }
    }
}
