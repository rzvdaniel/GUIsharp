using AngleSharp.Extensions;
using AngleSharp.Services.Default;
using Gui.Sharp.HtmlCss;
using Gui.Sharp.HtmlCss.Extensions;
using Gui.Sharp.HtmlCss.Interfaces;
using Gui.Sharp.Dom.Enums.Properties;
using Gui.Sharp.Dom.Extensions;
using Gui.Sharp.Dom.Interfaces;
using Gui.Sharp.Gfx.Factories;
using Gui.Sharp.Gfx.Interfaces;
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
        public IHtmlProperty HtmlProperty { get; set; }

        public string Text { get; set; }
        public Rectangle BoundingBox { get; set; }

        public Point LeftFloatPosition;
        public Point RightFloatPosition;

        #region Tree Navigation

        public IElement Parent { get; set; }
        public IList<IElement> Children { get; set; }

        #endregion

        #endregion

        #region Private Properties

        private IList<IElement> normalFlowChildren;
        private IList<IElement> floatFlowChildren;
        private IList<IElement> absoluteFlowChildren;

        #endregion

        public TElement()
        {
            normalFlowChildren = new List<IElement>();
            floatFlowChildren = new List<IElement>();
            absoluteFlowChildren = new List<IElement>();

            DefaultBackgroundColor = new Color(255, 255, 255, 255);
            DefaultBorderColor = new Color(0, 0, 0, 255);
            DefaultForegroundColor = new Color(0, 0, 0, 255);

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
                ComputeBoundingBox(element);
                AddToFlowList(element);
            }
        }

        public virtual void ComputeBoundingBox()
        {
            LeftFloatPosition = Point.Zero;
            RightFloatPosition = new Point(Parent.BoundingBox.Width, 0);
        }

        /// <summary>
        /// Renders element's children
        /// </summary>
        public virtual void PaintChildren()
        {
            foreach (var child in normalFlowChildren)
            {
                child.Paint();
            }

            foreach (var child in floatFlowChildren)
            {
                child.Paint();
            }

            foreach (var child in absoluteFlowChildren)
            {
                child.Paint();
            }
        }

        /// <summary>
        /// Renders element's body
        /// </summary>
        /// <remarks>
        /// Elements are responsible to render their own body.
        /// There is no default body painting.
        /// </remarks>
        public virtual void PaintBody() { }

        /// <summary>
        /// Renders element's text
        /// </summary>
        public virtual void PaintText()
        {
            if (!string.IsNullOrEmpty(Text))
            {
                Canvas.Print(Text, new Point(BoundingBox.Left, BoundingBox.Top));
            }
        }

        /// <summary>
        /// Paints element
        /// </summary>
        public void Paint()
        {
            PaintChildren();

            PaintBody();

            PaintText();
        }

        #region Protected Methods

        protected virtual void InitStyle(AngleSharp.Dom.Css.ICssStyleDeclaration style)
        {
            CssStyle = new TCssStyleDeclaration()
            {
                Width = style.Width.GetLength(),
                Height = style.Height.GetLength(),

                MaxWidth = style.MaxWidth.GetLength(),
                MaxHeight = style.MaxHeight.GetLength(),

                MinWidth = style.MinWidth.GetLength(),
                MinHeight = style.MinHeight.GetLength(),

                MarginTop = style.MarginTop.GetLength(),
                MarginBottom = style.MarginBottom.GetLength(),
                MarginLeft = style.MarginLeft.GetLength(),
                MarginRight = style.MarginRight.GetLength(),

                PaddingTop = style.PaddingTop.GetLength(),
                PaddingBottom = style.PaddingBottom.GetLength(),
                PaddingLeft = style.PaddingLeft.GetLength(),
                PaddingRight = style.PaddingRight.GetLength(),

                Float = style.Float,

                BackgroundColor = style.BackgroundColor.TryGetColor(DefaultBackgroundColor),
                Color = style.Color.TryGetColor(DefaultForegroundColor),

                FontFamily = style.FontFamily
            };

            Canvas.Initialize(CssStyle);
        }

        protected virtual void InitContent(AngleSharp.Dom.IElement htmlElement)
        {
            Text = htmlElement.Text();
        }

        #endregion

        #region Private Methods

        private void ComputeBoundingBox(IElement element)
        {
            var box = new Rectangle()
            {
                Width = element.CssStyle.Width.Value,
                Height = element.CssStyle.Height.Value
            };

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
                    normalFlowChildren.Add(element);
                    break;
                case Float.Left:
                case Float.Right:
                    floatFlowChildren.Add(element);
                    break;
            }

            //TODO! Take element's Position into consideration too.
        }

        #endregion
    }
}
