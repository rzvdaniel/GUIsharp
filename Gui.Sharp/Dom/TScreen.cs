using Gui.Sharp.Dom.Interfaces;
using Gui.Sharp.Gfx.Interfaces;
using OpenTK;

namespace Gui.Sharp.Dom
{
    public abstract class TScreen : IScreen
    {
        
        public IGfxServer GfxServer { get; set; }
        public IGfxCanvas Canvas { get; set; }
        public IDocument Document { get; set; }

        public virtual void Create(int width, int height, Color clearColor, IDocument document)
        {
            Document = document;

            // Create the canvas. Need a canvas for the screen. For example,
            // the screen render the mouse cursor. Because it render something, 
            // we need an already created Canvas. 
            // As you can see, this is a hack, because, normally, every
            // control create it's own canvas in TControl::Create(). But
            // we skip the base class initialization, so need to create the
            // canvas by hand.

            //Canvas = new TCanvas(this);

            //SetBounds(Rect.left, Rect.top, Rect.right, Rect.bottom);
        }

        public void Paint()
        {
            GfxServer.Begin();

            Document.Body.Paint();

            GfxServer.End();
        }
    }
}
