using CssValues = AngleSharp.Css.Values;

namespace Gui.Sharp.Dom
{
    public class TDiv : TElement
    {
        public override void PaintBody()
        {
            Canvas.FillRect(BoundingBox);
        }

        protected override void InitCss(AngleSharp.Dom.IElement htmlElement)
        {
            base.InitCss(htmlElement);

            if (Css.Width.Value == 0.0f)
            {
                Css.Width = new CssValues.Length(TScreen.Width, CssValues.Length.Unit.None);
            }
        }
    }
}
