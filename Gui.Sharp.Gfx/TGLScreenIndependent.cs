using Gui.Sharp.Gfx;
using OpenTK;

namespace Gui.Sharp
{
    public class TGLScreenIndependent : TScreen
    {
        public override void Create(int width, int height, Color clearColor)
        {
            GfxServer = new TGLServer(width, height, clearColor);
            Canvas = new TGLCanvas();

            base.Create(width, height, clearColor);
        }
    }
}
