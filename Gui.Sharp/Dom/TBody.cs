using CssValues = AngleSharp.Css.Values;

namespace Gui.Sharp.Dom
{
    public class TBody : TElement
    {
        public override void ComputeBoundingBox()
        {
            BoundingBox = new Rectangle
            {
                X = 0.0f,
                Y = 0.0f,
                Width = Css.Width.Value != 0.0f ? Css.Width.Value : TScreen.Width,
                Height = Css.Height.Value != 0.0f ? Css.Height.Value : TScreen.Height,
            };

            LeftFloatPosition = Point.Zero;
            RightFloatPosition = new Point(BoundingBox.Width, 0.0f);
        }

        protected override void InitCss(AngleSharp.Dom.IElement htmlElement)
        {
            base.InitCss(htmlElement);

            if (Css.Width.Value == 0.0f)
            {
                Css.Width = new CssValues.Length(TScreen.Width, CssValues.Length.Unit.None);
            }
        }

        public override void PaintText()
        {
            // Nothing to paint here
        }
    }
}
