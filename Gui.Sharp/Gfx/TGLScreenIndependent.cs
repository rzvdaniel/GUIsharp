using Gui.Sharp.Dom.Interfaces;
using Gui.Sharp.Gfx;
using OpenTK;

namespace Gui.Sharp
{
    public class TGLScreenIndependent : TScreen
    {
        public override void Create(int width, int height, Color clearColor, IDocument document)
        {
            Canvas = new TGLCanvas();
            GfxServer = new TGLServer(width, height, clearColor);

            base.Create(width, height, clearColor, document);
        }
    }
}
