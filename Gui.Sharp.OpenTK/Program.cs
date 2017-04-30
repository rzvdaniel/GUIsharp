using Gui.Sharp.Gfx;
using OpenTK;
using System;

namespace Gui.Sharp.OpenTK
{
    public class Program
    {
        [STAThread]
        static void Main()
        {
            // We request 30 UpdateFrame events per second, and unlimited
            // RenderFrame events (as fast as the computer can handle).
            using (var game = new TGLGame(800, 600, GameWindowFlags.Default))
            {
                game.Run(30.0);
            }
        }
    }
}
