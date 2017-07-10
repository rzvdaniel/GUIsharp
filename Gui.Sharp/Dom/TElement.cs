using AngleSharp.Extensions;
using AngleSharp.Services.Default;
using Gui.Sharp.Core.Extensions;
using Gui.Sharp.Css;
using Gui.Sharp.Css.Interfaces;
using Gui.Sharp.Dom.Enums.Properties;
using Gui.Sharp.Dom.Interfaces;
using Gui.Sharp.Gfx.Drawing;
using Gui.Sharp.Gfx.Factories;
using Gui.Sharp.Gfx.Interfaces;
using OpenTK;
using System.Collections.Generic;

namespace Gui.Sharp.Dom
{
    public abstract class TElement : IElement
    {
        #region Public Properties

        protected Color DefaultBackgroundColor { get; set; }
        protected Color DefaultBorderColor { get; set; }
        protected Color DefaultForegroundColor { get; set; }

        public IGfxCanvas Canvas { get; set; }
        public ICssStyleDeclaration CssStyle { get; set; }

        public RectangleF BoundingBox { get; set; }
        public PointF LeftFloatPosition;
        public PointF RightFloatPosition;

        #region Tree Navigation

        public IElement Parent { get; set; }
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

            DefaultBackgroundColor = new Color(255, 255, 255, 255);
            DefaultBorderColor = new Color(0, 0, 0, 255);
            DefaultForegroundColor = new Color(0, 0, 0, 255);
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
                ComputeBoundingBox(element);
                AddToFlowList(element);
            }
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

        #region Protected Methods

        protected virtual void InitStyle(AngleSharp.Dom.Css.ICssStyleDeclaration cssStyle)
        {
            CssStyle = new TCssStyleDeclaration()
            {
                Width = cssStyle.Width.GetLength(),
                Height = cssStyle.Height.GetLength(),

                MaxWidth = cssStyle.MaxWidth.GetLength(),
                MaxHeight = cssStyle.MaxHeight.GetLength(),

                MinWidth = cssStyle.MinWidth.GetLength(),
                MinHeight = cssStyle.MinHeight.GetLength(),

                MarginTop = cssStyle.MarginTop.GetLength(),
                MarginBottom = cssStyle.MarginBottom.GetLength(),
                MarginLeft = cssStyle.MarginLeft.GetLength(),
                MarginRight = cssStyle.MarginRight.GetLength(),

                PaddingTop = cssStyle.PaddingTop.GetLength(),
                PaddingBottom = cssStyle.PaddingBottom.GetLength(),
                PaddingLeft = cssStyle.PaddingLeft.GetLength(),
                PaddingRight = cssStyle.PaddingRight.GetLength(),

                Float = cssStyle.Float,

                BackgroundColor = cssStyle.BackgroundColor.TryGetColor(DefaultBackgroundColor),
                Color = cssStyle.Color.TryGetColor(DefaultForegroundColor)
            };

            Canvas.Pen.Color = CssStyle.Color;

            // TODO! Update Pen style
            Canvas.Pen.Style = TPenStyle.psSolid;

            Canvas.Brush.Color = CssStyle.BackgroundColor;
        }

        public string GetFloat()
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

        #endregion

        #region Private Methods

        private void ComputeBoundingBox(IElement element)
        {
            var box = new RectangleF();
            box.Width = element.CssStyle.Width.Value;
            box.Height = element.CssStyle.Height.Value;

            var childFloatAttribute = element.GetFloat();

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
            switch (element.GetFloat())
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

        #endregion
    }
}
