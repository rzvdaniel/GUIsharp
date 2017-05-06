using Gui.Sharp.Gfx.Interfaces;
using OpenTK;

namespace Gui.Sharp.Gfx
{
    public abstract class TGfxServer : IGfxServer
    {
        public Color ClearColor { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public TGfxServer(int width, int height, Color clearColor)
        {
            Width = width;
            Height = height;
            ClearColor = clearColor;
        }

        public abstract void Begin();
        public abstract void End();

        public abstract void BeginScene();
        public abstract void EndScene();
    }
}
