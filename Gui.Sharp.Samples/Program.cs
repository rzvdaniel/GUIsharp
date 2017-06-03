using Gui.Sharp.Gfx.Factories;
using Gui.Sharp.Gfx.Interfaces;
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

            var game = GfxFactory.Create<IGfxGame>();
            game.Create(800, 600, GameWindowFlags.Default, html);
            game.Run(30.0);
        }
    }
}
