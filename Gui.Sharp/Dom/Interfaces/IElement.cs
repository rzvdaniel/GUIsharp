using Gui.Sharp.Gfx.Interfaces;
using Gui.Sharp.Dom.Interfaces;
using System.Collections.Generic;

namespace Gui.Sharp.Dom.Interfaces
{
    public interface IElement
    {
        #region Properties

        IElement Parent { get; set; }
        IList<IElement> Children { get; set; }

        IGfxCanvas Canvas { get; set; }
        IElementCss Css { get; set; }
        IElementHtml Html { get; set; }

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
