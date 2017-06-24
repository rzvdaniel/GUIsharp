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

        private LinkedList<IElement> _normalFlowChildren;
        private LinkedList<IElement> _leftFlowChildren;
        private LinkedList<IElement> _rightFlowChildren;
        private LinkedList<IElement> _absoluteFlowChildren;

        #endregion

        public TElement() {}

        public TElement(AngleSharp.Dom.IElement htmlElement)
        {
            _normalFlowChildren = new LinkedList<IElement>();
            _leftFlowChildren = new LinkedList<IElement>();
            _rightFlowChildren = new LinkedList<IElement>();
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
                    _leftFlowChildren.AddLast(element);
                    break;

                case Float.Right:
                    _rightFlowChildren.AddLast(element);
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

            foreach (var leftChild in _leftFlowChildren)
            {
                leftChild.Paint();
            }

            foreach (var rightChild in _rightFlowChildren)
            {
                rightChild.Paint();
            }
        }

        #region Protected Methods

        /// <summary>
        /// Default bounding box computing
        /// </summary>
        public virtual void ComputeBoundingBox()
        {
            ComputeNormalFlow();
            ComputeFloatFlow();
            ComputeAbsoluteFlow();
        }

        #endregion

        #region Private Methods

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
        private void ComputeNormalFlow()
        {
            for (var child = _normalFlowChildren.First; child != null; child = child.Next)
            {
                child.Value.BoundingBox = new RectangleF()
                {
                    X = child.Value.Parent.BoundingBox.Left,
                    Y = child.Previous != null ?
                        child.Previous.Value.BoundingBox.Bottom :
                        child.Value.Parent.BoundingBox.Top,
                    Width = child.Value.CssStyle.Width.Value,
                    Height = child.Value.CssStyle.Height.Value
                };

                child.Value.ComputeBoundingBox();
            }
        }

        private void ComputeFloatFlow()
        {
            for (var child = _leftFlowChildren.First; child != null; child = child.Next)
            {
                var box = new RectangleF();

                if(child.Previous != null)
                {
                    box.X = child.Previous.Value.BoundingBox.Right;
                }
                else
                {
                    box.X = child.Value.Parent.BoundingBox.Left;
                }

                if(child.Previous != null)
                {
                    box.Y = child.Previous.Value.BoundingBox.Top;
                }
                else
                {
                    if (child.Value.PreviousSibling != null)
                    {
                        box.Y = child.Value.PreviousSibling.FloatProperty != Float.None ?
                                child.Value.PreviousSibling.BoundingBox.Top :
                                child.Value.PreviousSibling.BoundingBox.Bottom;
                    }
                    else
                    {
                        box.Y = child.Value.Parent.BoundingBox.Top;
                    }
                }

                box.Width = child.Value.CssStyle.Width.Value;
                box.Height = child.Value.CssStyle.Height.Value;

                child.Value.BoundingBox = box;
                child.Value.ComputeBoundingBox();
            }

            for (var child = _rightFlowChildren.First; child != null; child = child.Next)
            {
                var box = new RectangleF();

                if (child.Previous != null)
                {
                    box.X = child.Previous.Value.BoundingBox.Left - child.Value.CssStyle.Width.Value;
                }
                else
                {
                    box.X = child.Value.Parent.BoundingBox.Right - child.Value.CssStyle.Width.Value;
                }

                if (child.Previous != null)
                {
                    box.Y = child.Previous.Value.BoundingBox.Top;
                }
                else
                {
                    if (child.Value.PreviousSibling != null)
                    {
                        box.Y = child.Value.PreviousSibling.FloatProperty != Float.None ?
                                child.Value.PreviousSibling.BoundingBox.Top :
                                child.Value.PreviousSibling.BoundingBox.Bottom;
                    }
                    else
                    {
                        box.Y = child.Value.Parent.BoundingBox.Top;
                    }
                }

                box.Width = child.Value.CssStyle.Width.Value;
                box.Height = child.Value.CssStyle.Height.Value;

                child.Value.BoundingBox = box;
                child.Value.ComputeBoundingBox();
            }
        }

        private void ComputeAbsoluteFlow()
        {
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
