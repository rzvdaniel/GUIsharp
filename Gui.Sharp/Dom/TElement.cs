using AngleSharp.Css.Values;
using AngleSharp.Extensions;
using AngleSharp.Services.Default;
using Gui.Sharp.Css;
using Gui.Sharp.Css.Interfaces;
using Gui.Sharp.Dom.Interfaces;
using Gui.Sharp.Gfx.Factories;
using Gui.Sharp.Gfx.Interfaces;
using OpenTK;
using System.Collections.Generic;

namespace Gui.Sharp.Dom
{
    public class TElement : IElement
    {
        public IGfxCanvas Canvas { get; set; }
        public IElement Parent { get; set; }
        public IList<IElement> Children { get; set; }
        public ICssStyleDeclaration CssStyle { get; set; }
        public RectangleF BoundingBox { get; private set; }

        public IElement PreviousSibling
        {
            get
            {
                if (Parent != null)
                {
                    var n = Parent.Children.Count;

                    for (var i = 1; i < n; i++)
                    {
                        if (ReferenceEquals(Parent.Children[i], this))
                        {
                            return Parent.Children[i - 1];
                        }
                    }
                }

                return null;
            }
        }

        public IElement NextSibling
        {
            get
            {
                if (Parent != null)
                {
                    var n = Parent.Children.Count - 1;

                    for (var i = 0; i < n; i++)
                    {
                        if (ReferenceEquals(Parent.Children[i], this))
                        {
                            return Parent.Children[i + 1];
                        }
                    }
                }

                return null;
            }
        }

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
                element.Parent = this;
                Children.Add(element);
            }
        }

        private void InitStyle(AngleSharp.Dom.Css.ICssStyleDeclaration cssStyle)
        {
            CssStyle = new TCssStyleDeclaration()
            {
                Width = GetLength(cssStyle.Width),
                Height = GetLength(cssStyle.Height),

                MaxWidth = GetLength(cssStyle.MaxWidth),
                MaxHeight = GetLength(cssStyle.MaxHeight),

                MinWidth = GetLength(cssStyle.MinWidth),
                MinHeight = GetLength(cssStyle.MinHeight),

                MarginTop = GetLength(cssStyle.MarginTop),
                MarginBottom = GetLength(cssStyle.MarginBottom),
                MarginLeft = GetLength(cssStyle.MarginLeft),
                MarginRight = GetLength(cssStyle.MarginRight),

                PaddingTop = GetLength(cssStyle.PaddingTop),
                PaddingBottom = GetLength(cssStyle.PaddingBottom),
                PaddingLeft = GetLength(cssStyle.PaddingLeft),
                PaddingRight = GetLength(cssStyle.PaddingRight),
            };
        }

        private Length GetLength(string cssValue)
        {
            Length.TryParse(cssValue, out Length length);

            return length;
        }

        public void ComputeBoundingBox()
        {
            foreach (var child in Children)
            {
                child.ComputeBoundingBox();
            }

            BoundingBox = new RectangleF()
            {
                X = Parent != null ? Parent.BoundingBox.X : 0.0f,
                Y = PreviousSibling != null ? PreviousSibling.BoundingBox.Bottom : 0.0f,
                Width = CssStyle.Width.Value,
                Height = CssStyle.Height.Value
            };
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
