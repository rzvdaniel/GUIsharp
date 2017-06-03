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
            var rect = new RectangleF(0, 0, CssStyle.Width.Value, CssStyle.Height.Value);
            Canvas.Pen.Color = Color.Black;
            Canvas.Pen.Style = TPenStyle.psSolid;
            Canvas.DrawRect(rect, 2);

            base.Paint();
        }
    }
}
