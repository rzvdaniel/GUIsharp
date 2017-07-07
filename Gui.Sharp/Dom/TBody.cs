using AngleSharp.Dom;
using AngleSharp.Dom.Html;
using AngleSharp.Services.Default;
using OpenTK;
using CssValues = AngleSharp.Css.Values;

namespace Gui.Sharp.Dom
{
    public class TBody : TElement
    {
        public override void ComputeBoundingBox()
        {
            var box = new RectangleF
            {
                X = 0.0f,
                Y = 0.0f,
                Width = CssStyle.Width.Value != 0.0f ? CssStyle.Width.Value : TScreen.Width,
                Height = CssStyle.Height.Value != 0.0f ? CssStyle.Height.Value : TScreen.Height,
            };

            BoundingBox = box;
        }

        protected override void InitStyle(AngleSharp.Dom.Css.ICssStyleDeclaration cssStyle)
        {
            base.InitStyle(cssStyle);

            if (CssStyle.Width.Value == 0.0f)
            {
                CssStyle.Width = new CssValues.Length(TScreen.Width, CssValues.Length.Unit.None);
            }
        }
    }
}
