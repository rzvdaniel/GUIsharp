using Gui.Sharp.Gfx;
using OpenTK;
using System;
using System.IO;
using System.Text;

namespace Gui.Sharp.OpenTK
{
    public class Program
    {
        static string htmlDocument = @"
            <!DOCTYPE html>
            <html>
                <head>
                    <meta charset=""utf-8"" />
                    <title></title>
                    <style>
                        body
                        {
                            background-color: green !important;
                            width: 100%;
                        }

                        div
                        {
                            width:300px;
                            height: 200px;
                        }
                    </style>
                </head>
                <body style=""background-color: red"">
                    <div>
                        <p>Hello</p>
                    </div>
                    <div>
                        <p>World!</p>
                    </div>
                </body>
            </html>";

        [STAThread]
        static void Main(string[] args)
        {
            string html;
            string path = args.Length > 0 ? args[0] : string.Empty;

            if (string.IsNullOrEmpty(path))
            {
                html = htmlDocument;
            }
            else
            {
                var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);

                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    html = streamReader.ReadToEnd();
                }
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
