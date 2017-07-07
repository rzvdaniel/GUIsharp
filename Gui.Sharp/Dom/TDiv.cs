using AngleSharp.Dom;
using CssValues = AngleSharp.Css.Values;
using Gui.Sharp.Gfx.Drawing;
using OpenTK;

namespace Gui.Sharp.Dom
{
    public class TDiv : TElement
    {
        public override void Paint()
        {
            base.Paint();

            Canvas.Pen.Color = Color.Black;
            Canvas.Pen.Style = TPenStyle.psSolid;
            Canvas.DrawRect(BoundingBox, 2);
        }

        protected override void InitStyle(AngleSharp.Dom.Css.ICssStyleDeclaration cssStyle)
        {
            base.InitStyle(cssStyle);

            if(CssStyle.Width.Value == 0.0f)
            {
                CssStyle.Width = new CssValues.Length(TScreen.Width, CssValues.Length.Unit.None);
            }
        }
    }
}
