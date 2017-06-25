using AngleSharp.Dom;
using OpenTK;

namespace Gui.Sharp.Dom
{
    public class TBody : TElement
    {
        public TBody(IElement htmlElement) : base(htmlElement)
        {
            var box = new RectangleF
            {
                X = 0.0f,
                Y = 0.0f,
                Width = CssStyle.Width.Value,
                Height = CssStyle.Height.Value
            };

            BoundingBox = box;

            ComputeBoundingBox();
        }

        public override void ComputeBoundingBox()
        {
            var box = new RectangleF
            {
                X = BoundingBox.X,
                Y = BoundingBox.Y,
                Width = BoundingBox.Width != 0.0f ? BoundingBox.Width : TScreen.Width,
                Height = BoundingBox.Height != 0.0f ? BoundingBox.Height : TScreen.Height,
            };

            BoundingBox = box;

            base.ComputeBoundingBox();
        }
    }
}
