using Gui.Sharp.Dom;
using Gui.Sharp.Gfx.Factories;
using Gui.Sharp.Gfx.Interfaces;

namespace Gui.Sharp.Gfx.OpenGL
{
    public class TGLScreenIndependent : TScreen
    {
        public override void Create(int width, int height, Color clearColor, string htmlDocument)
        {
            Canvas = GfxFactory.Create<IGfxCanvas>();
            GfxServer = GfxFactory.Create<IGfxServer>();
            GfxServer.Initialize(width, height, clearColor);

            base.Create(width, height, clearColor, htmlDocument);
        }
    }
}
