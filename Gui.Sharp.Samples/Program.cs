using Gui.Sharp.Gfx;
using OpenTK;
using System;
using System.IO;
using System.Text;

namespace Gui.Sharp.OpenTK
{
    public class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string html;
            string path = args.Length > 0 ? args[0] : string.Empty;
            string defaultPath = "..\\Gui.Sharp.Samples\\Resources\\Default.html";

            if(string.IsNullOrEmpty(path) || !File.Exists(path))
            {
                path = defaultPath;
            }
            
            var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                html = streamReader.ReadToEnd();
            }

            // We request 30 UpdateFrame events per second, and unlimited
            // RenderFrame events (as fast as the computer can handle).
            using (var game = new TGLGame(800, 600, GameWindowFlags.Default, html))
            {
                game.Run(30.0);
            }
        }
    }
}
