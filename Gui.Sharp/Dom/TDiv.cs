using CssValues = AngleSharp.Css.Values;

namespace Gui.Sharp.Dom
{
    public class TDiv : TElement
    {
        public override void Paint()
        {
            base.Paint();

            Canvas.FillRect(BoundingBox);
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
