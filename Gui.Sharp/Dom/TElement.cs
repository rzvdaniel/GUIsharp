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
        #region Public Properties

        public IGfxCanvas Canvas { get; set; }
        public ICssStyleDeclaration CssStyle { get; set; }
        public RectangleF BoundingBox { get; set; }
        
        public string FloatProperty
        {
            get
            {
                string floatProperty = string.Empty;

                if (CssStyle.Float == Float.Inherit && Parent != null)
                {
                    floatProperty = Parent.CssStyle.Float;
                }
                else
                {
                    floatProperty = CssStyle.Float;
                }

                if (string.IsNullOrEmpty(floatProperty))
                    floatProperty = Float.None;

                return floatProperty;
            }
        }

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

        #region Private Properties

        private PointF _floatLeftPosition;
        private PointF _floatRightPosition;
        private LinkedList<IElement> _normalFlowChildren;
        private LinkedList<IElement> _floatFlowChildren;
        private LinkedList<IElement> _absoluteFlowChildren;

        #endregion

        public TElement() {}

        public TElement(AngleSharp.Dom.IElement htmlElement)
        {
            _floatLeftPosition = new PointF();
            _floatRightPosition = new PointF(TScreen.Width, 0);
            _normalFlowChildren = new LinkedList<IElement>();
            _floatFlowChildren = new LinkedList<IElement>();
            _absoluteFlowChildren = new LinkedList<IElement>();

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
                AddToFlowList(element);
            }
        }

        private void AddToFlowList(IElement element)
        {
            switch (element.FloatProperty)
            {
                case Float.Left:
                case Float.Right:
                    _floatFlowChildren.AddLast(element);
                    break;

                case Float.None:
                    _normalFlowChildren.AddLast(element);
                    break;
            }

            //TODO! Take element's Position into consideration too.
        }

        public virtual void Paint()
        {
            foreach (var normalChild in _normalFlowChildren)
            {
                normalChild.Paint();
            }

            foreach (var floatChild in _floatFlowChildren)
            {
                floatChild.Paint();
            }

            foreach (var absoluteChild in _absoluteFlowChildren)
            {
                absoluteChild.Paint();
            }
        }

        #region Protected Methods

        /// <summary>
        /// Default bounding box computing
        /// </summary>
        public virtual void ComputeBoundingBox()
        {
            foreach(var child in Children)
            {
                var box = new RectangleF();
                box.Width = child.CssStyle.Width.Value;
                box.Height = child.CssStyle.Height.Value;

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
                if (child.FloatProperty == Float.None)
                {
                    _floatLeftPosition.X = 0.0f;

                    box.X = _floatLeftPosition.X;
                    box.Y = _floatLeftPosition.Y;

                    _floatLeftPosition.Y += box.Height;
                    _floatRightPosition.Y += box.Height;
                }
                else if (child.FloatProperty == Float.Left)
                {
                    box.X = _floatLeftPosition.X;
                    box.Y = _floatLeftPosition.Y;

                    _floatLeftPosition.X += box.Width;
                }
                else if (child.FloatProperty == Float.Right)
                {
                    box.X = _floatRightPosition.X - box.Width;
                    box.Y = _floatRightPosition.Y;

                    _floatRightPosition.X -= box.Width;
                }

                child.BoundingBox = box;
            }
        }

        #endregion

        #region Private Methods

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
