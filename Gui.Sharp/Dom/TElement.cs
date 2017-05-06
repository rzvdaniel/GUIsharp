using AngleSharp.Css.Values;
using AngleSharp.Extensions;
using AngleSharp.Services.Default;
using Gui.Sharp.Css;
using Gui.Sharp.Gfx.Factories;
using Gui.Sharp.Gfx.Interfaces;
using System.Collections.Generic;
using ICssStyleDeclaration = Gui.Sharp.Css.Interfaces.ICssStyleDeclaration;
using IElement = Gui.Sharp.Dom.Interfaces.IElement;

namespace Gui.Sharp.Dom
{
    public class TElement : IElement
    {
        public IGfxCanvas Canvas { get; set; }
        public IList<IElement> Children { get; set; }
        public ICssStyleDeclaration CssStyle { get; set; }

        public TElement() {}

        public TElement(AngleSharp.Dom.IElement htmlElement)
        {
            Canvas = GfxFactory.Create<IGfxCanvas>();
            var cssStyle = htmlElement.ComputeCurrentStyle();

            InitStyle(cssStyle);

            Children = new List<IElement>();
            var elementFactory = new TElementFactory();

            foreach (var child in htmlElement.Children)
            {
                var element = elementFactory.Create(child);

                Children.Add(element);
            }
        }

        private void InitStyle(AngleSharp.Dom.Css.ICssStyleDeclaration cssStyle)
        {
            CssStyle = new TCssStyleDeclaration();

            CssStyle.Width = GetLength(cssStyle.Width);
            CssStyle.Height = GetLength(cssStyle.Height);
            CssStyle.MaxWidth = GetLength(cssStyle.MaxWidth);
            CssStyle.MaxHeight = GetLength(cssStyle.MaxHeight);
            CssStyle.MinWidth = GetLength(cssStyle.MinWidth);
            CssStyle.MinHeight = GetLength(cssStyle.MinHeight);
        }

        private Length GetLength(string cssValue)
        {
            Length length;
            Length.TryParse(cssValue, out length);

            return length;
        }

        public virtual void Paint()
        {
            foreach (var child in Children)
            {
                child.Paint();
            }
        }
    }
}
