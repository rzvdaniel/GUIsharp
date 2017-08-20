using Gui.Sharp.Gfx.Interfaces;
using Gui.Sharp.HtmlCss.Interfaces;
using System.Collections.Generic;

namespace Gui.Sharp.Dom.Interfaces
{
    public interface IElement
    {
        #region Properties

        IElement Parent { get; set; }
        IList<IElement> Children { get; set; }

        IGfxCanvas Canvas { get; set; }
        ICssStyleDeclaration CssStyle { get; set; }
        IHtmlProperty HtmlProperty { get; set; }

        Rectangle BoundingBox { get; set; }

        #endregion

        void Paint();
        void PaintChildren();
        void PaintText();
        void PaintBody();

        void Parse(AngleSharp.Dom.IElement htmlElement);
        void ComputeBoundingBox();
    }
}
