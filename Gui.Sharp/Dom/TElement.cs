using AngleSharp.Css.Values;
using AngleSharp.Extensions;
using AngleSharp.Services.Default;
using Gui.Sharp.Css;
using Gui.Sharp.Css.Interfaces;
using Gui.Sharp.Dom.Enums.Properties;
using Gui.Sharp.Dom.Interfaces;
using Gui.Sharp.Gfx.Factories;
using Gui.Sharp.Gfx.Interfaces;
using OpenTK;
using System.Collections.Generic;

namespace Gui.Sharp.Dom
{
    public abstract class TElement : IElement
    {
        #region Properties

        public IGfxCanvas Canvas { get; set; }
        public ICssStyleDeclaration CssStyle { get; set; }
        public RectangleF BoundingBox { get; private set; }

        #region Tree Navigation

        public IElement Parent { get; set; }
        public IList<IElement> Children { get; set; }
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

        #endregion

        #endregion

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

        public virtual void Paint()
        {
            foreach (var child in Children)
            {
                child.Paint();
            }
        }

        #region Protected Methods

        /// <summary>
        /// Default bounding box computing
        /// </summary>
        public virtual void ComputeBoundingBox()
        {
            foreach (var child in Children)
            {
                child.ComputeBoundingBox();
            }

            BoundingBox = CssStyle.Position == Position.Absolute ?
                ComputeAbsolutePosition() :
                ComputeRelativePosition();
        }

        #endregion

        #region Private Methods

        private RectangleF ComputeRelativePosition()
        {
            RectangleF boundingBox;

            var floatProperty = CssStyle.Float == Float.Inherit ? Parent.CssStyle.Float : CssStyle.Float;

            switch (floatProperty)
            {
                case Float.Left:
                    boundingBox = ComputeLeftFlow();
                    break;

                case Float.Right:
                    boundingBox = ComputeRightFlow();
                    break;

                default:
                    boundingBox = ComputeNormalFlow();
                    break;
            }

            return boundingBox;
        }

        /// <summary>
        /// Compute bounding box according with the normal flow
        /// </summary>
        /// <remarks>
        /// In the normal flow, each block element (div, p, h1, etc.) stacks on top of each other vertically, 
        /// from the top of the viewport down. Floated elements are first laid out according to the normal flow, 
        /// then taken out of the normal flow and sent as far to the right or left (depending on which value is applied) 
        /// of the parent element. In other words, they go from stacking on top of each other to sitting next to each other, 
        /// given that there is enough room in the parent element for each floated element to sit. 
        /// </remarks>
        /// <see cref="https://www.w3.org/TR/CSS21/visuren.html#normal-flow"/>
        /// <returns></returns>
        private RectangleF ComputeNormalFlow()
        {
            var boundingBox = new RectangleF()
            {
                X = Parent != null ? Parent.BoundingBox.X : 0.0f,
                Y = PreviousSibling != null ? PreviousSibling.BoundingBox.Bottom : 0.0f,
                Width = CssStyle.Width.Value,
                Height = CssStyle.Height.Value
            };

            return boundingBox;
        }

        private RectangleF ComputeLeftFlow()
        {
            var boundingBox = new RectangleF()
            {
                X = Parent != null ? Parent.BoundingBox.X : 0.0f,
                Y = PreviousSibling != null ? PreviousSibling.BoundingBox.Bottom : 0.0f,
                Width = CssStyle.Width.Value,
                Height = CssStyle.Height.Value
            };

            return boundingBox;
        }

        private RectangleF ComputeRightFlow()
        {
            var boundingBox = new RectangleF()
            {
                X = Parent != null ? Parent.BoundingBox.X : 0.0f,
                Y = PreviousSibling != null ? PreviousSibling.BoundingBox.Bottom : 0.0f,
                Width = CssStyle.Width.Value,
                Height = CssStyle.Height.Value
            };

            return boundingBox;
        }

        private RectangleF ComputeAbsolutePosition()
        {
            return new RectangleF();
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

                Float = cssStyle.Float,
            };
        }

        private Length GetLength(string cssValue)
        {
            Length.TryParse(cssValue, out Length length);

            return length;
        }

        #endregion
    }
}
