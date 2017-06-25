using Gui.Sharp.Dom;
using Gui.Sharp.Dom.Interfaces;
using OpenTK;

namespace Gui.Sharp.Gfx.OpenGL
{
    public class TGLScreenIndependent : TScreen
    {
        public override void Create(int width, int height, Color clearColor, string htmlDocument)
        {
            Canvas = new TGLCanvas();
            GfxServer = new TGLServer(width, height, clearColor);

            base.Create(width, height, clearColor, htmlDocument);
        }
    }
}
