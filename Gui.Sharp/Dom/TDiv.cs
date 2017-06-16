using AngleSharp.Dom;
using Gui.Sharp.Gfx.Drawing;
using OpenTK;

namespace Gui.Sharp.Dom
{
    public class TDiv : TElement
    {
        public TDiv(IElement htmlElement) : base(htmlElement)
        {
        }

        public override void Paint()
        {
            base.Paint();

            Canvas.Pen.Color = Color.Black;
            Canvas.Pen.Style = TPenStyle.psSolid;
            Canvas.DrawRect(BoundingBox, 2);
        }
    }
}
