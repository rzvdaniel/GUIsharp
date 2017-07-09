using Gui.Sharp.Gfx.Factories;
using Gui.Sharp.Gfx.Interfaces;
using Gui.Sharp.Samples.IO;
using OpenTK;
using System;

namespace Gui.Sharp.OpenTK
{
    public class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string path = args.Length > 0 ? args[0] : string.Empty;

            var htmlReader = new HtmlReader();
            var html = htmlReader.Read(path);

            var game = GfxFactory.Create<IGfxGame>();
            game.Create(1200, 800, GameWindowFlags.Default, html);
            game.Run(30.0);
        }
    }
}
