using Gui.Sharp.Dom;
using Gui.Sharp.Dom.Factories;
using Gui.Sharp.Dom.Interfaces;
using Gui.Sharp.Gfx.Factories;
using Gui.Sharp.Gfx.Interfaces;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Input;
using System;

namespace Gui.Sharp.Gfx
{
    public class TGLGame : GameWindow, IGfxGame
    {
        public IScreen Screen { get; set; }

        public TGLGame(int width, int height, GameWindowFlags windowFlags, string  htmlDocument)
            : base(width, height, GraphicsMode.Default, "Gui Sharp Tests", windowFlags)
        {
            var document = DomFactory.Create<IDocument>();
            document.Parse(htmlDocument);

            Screen = GfxFactory.Create<IScreen>();
            Screen.Create(width, height, Color.White, document);

            VSync = VSyncMode.On;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            if (Keyboard[Key.Escape])
                Exit();
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            Screen.Paint();

            SwapBuffers();
        }
    }
}
