using AngleSharp.Css.Values;
using AngleSharp.Dom.Html;
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
using System;

namespace Gui.Sharp.Dom
{
    public abstract class TElement : IElement
    {
        #region Public Properties

        public IGfxCanvas Canvas { get; set; }
        public ICssStyleDeclaration CssStyle { get; set; }

        public RectangleF BoundingBox { get; set; }
        public PointF LeftFloatPosition;
        public PointF RightFloatPosition;

        #region Tree Navigation

        public IElement Parent { get; set; }

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

        public IList<IElement> Children { get; set; }

        #endregion

        #endregion

        #region Private Properties

        private IList<IElement> _normalFlowChildren;
        private IList<IElement> _floatFlowChildren;
        private IList<IElement> _absoluteFlowChildren;


        #endregion

        public TElement()
        {
            _normalFlowChildren = new List<IElement>();
            _floatFlowChildren = new List<IElement>();
            _absoluteFlowChildren = new List<IElement>();

            Children = new List<IElement>();
            Canvas = GfxFactory.Create<IGfxCanvas>();
        }

        public void Parse(AngleSharp.Dom.IElement htmlElement)
        {
            InitStyle(htmlElement.ComputeCurrentStyle());

            ComputeBoundingBox();

            var elementFactory = new TElementFactory();

            foreach (AngleSharp.Dom.IElement htmlChild in htmlElement.Children)
            {
                var element = elementFactory.Create(htmlChild);
                element.Parent = this;
                element.Parse(htmlChild);

                Children.Add(element);
                ComputeChildBoundingBox(element);
                AddToFlowList(element);
            }
        }

        private void ComputeChildBoundingBox(IElement element)
        {
            var box = new RectangleF();
            box.Width = element.CssStyle.Width.Value;
            box.Height = element.CssStyle.Height.Value;

            var childFloatAttribute = element.GetFloatAttribute();

            if (childFloatAttribute == Float.None)
            {
                box.X = BoundingBox.Left;
                box.Y = LeftFloatPosition.Y;

                LeftFloatPosition.X = BoundingBox.Left;
                LeftFloatPosition.Y += box.Height;
                RightFloatPosition.Y += box.Height;
            }
            else if (childFloatAttribute == Float.Left)
            {
                box.X = LeftFloatPosition.X;
                box.Y = LeftFloatPosition.Y;

                LeftFloatPosition.X += box.Width;

                if (LeftFloatPosition.X + box.Width > BoundingBox.Width)
                {
                    LeftFloatPosition.X = BoundingBox.Left;
                    LeftFloatPosition.Y += box.Height;
                }
            }
            else if (childFloatAttribute == Float.Right)
            {
                box.X = RightFloatPosition.X - box.Width;
                box.Y = RightFloatPosition.Y;

                RightFloatPosition.X -= box.Width;

                if (RightFloatPosition.X < BoundingBox.Left)
                {
                    RightFloatPosition.X = BoundingBox.Width;
                    RightFloatPosition.Y += box.Height;
                }
            }

            element.BoundingBox = box;
        }

        private void AddToFlowList(IElement element)
        {
            switch (element.GetFloatAttribute())
            {
                case Float.None:
                    _normalFlowChildren.Add(element);
                    break;
                case Float.Left:
                case Float.Right:
                    _floatFlowChildren.Add(element);
                    break;
            }

            //TODO! Take element's Position into consideration too.
        }

        public virtual void ComputeBoundingBox()
        {
            LeftFloatPosition = PointF.Zero;
            RightFloatPosition = new PointF(Parent.BoundingBox.Width, 0.0f);
        }

        public virtual void Paint()
        {
            foreach (var child in _normalFlowChildren)
            {
                child.Paint();
            }

            foreach (var child in _floatFlowChildren)
            {
                child.Paint();
            }

            foreach (var child in _absoluteFlowChildren)
            {
                child.Paint();
            }
        }

        public string GetFloatAttribute()
        {
            string attribute = string.Empty;

            if (CssStyle.Float == Float.Inherit && Parent != null)
            {
                attribute = Parent.CssStyle.Float;
            }
            else
            {
                attribute = CssStyle.Float;
            }

            if (string.IsNullOrEmpty(attribute))
                attribute = Float.None;

            return attribute;
        }

        #region Protected Methods

        protected virtual void InitStyle(AngleSharp.Dom.Css.ICssStyleDeclaration cssStyle)
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

        #endregion

        #region Private Methods

        private Length GetLength(string cssValue)
        {
            Length.TryParse(cssValue, out Length length);

            return length;
        }

        #endregion
    }
}
