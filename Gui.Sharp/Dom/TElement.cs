using AngleSharp.Css.Values;
using AngleSharp.Dom;
using AngleSharp.Dom.Css;
using AngleSharp.Extensions;
using Gui.Sharp.Dom.Interfaces;
using AngleSharp.Services.Default;
using System.Collections.Generic;
using Gui.Sharp.Css.Interfaces;
using Gui.Sharp.Css;

namespace Gui.Sharp.Dom
{
    public class TElement : ITElement
    {
        public IList<ITElement> Children { get; set; }
        public ITCssStyleDeclaration CssStyle { get; set; }

        public TElement() {}

        public TElement(IElement htmlElement)
        {
            var cssStyle = htmlElement.ComputeCurrentStyle();
            InitStyle(cssStyle);

            Children = new List<ITElement>();
            var elementFactory = new TElementFactory();

            foreach (var child in htmlElement.Children)
            {
                var element = elementFactory.Create(child);

                Children.Add(element);
            }
        }

        private void InitStyle(ICssStyleDeclaration cssStyle)
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
    }
}
