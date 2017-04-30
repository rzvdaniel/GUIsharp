using Gui.Sharp.Gfx;
using Gui.Sharp.Gfx.Interfaces;
using OpenTK;

namespace Gui.Sharp
{
    public abstract class TScreen
    {
        public TGfxServer GfxServer { get; set; }
        public IGfxCanvas Canvas { get; set; }

        public virtual void Create(int width, int height, Color clearColor)
        {
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

            // TODO! 
            // This is just a test to see some drawing on the screen. To be removed.

            var rect = new Rectangle(50, 50, 300, 200);
            Canvas.Pen.Color = Color.Black;
            Canvas.Pen.Style = TPenStyle.psSolid;
            Canvas.DrawRect(rect, 2);

            var rect2 = new Rectangle(200, 200, 200, 200);
            Canvas.Brush.Color = Color.Red;
            Canvas.Brush.Style = TBrushStyle.bsSolid;
            Canvas.FillRect(rect2);

            // TODO!
            // Do the control's drawing

            GfxServer.End();
        }
    }
}
