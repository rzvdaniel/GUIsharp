using Gui.Sharp.Css.Interfaces;
using Gui.Sharp.Gfx.Interfaces;
using OpenTK;
using System.Collections.Generic;
using static Gui.Sharp.Dom.TElement;

namespace Gui.Sharp.Dom.Interfaces
{
    public interface IElement
    {
        IElement Parent { get; set; }
        IElement PreviousSibling { get; }
        IElement NextSibling { get; }
        IList<IElement> Children { get; set; }

        IGfxCanvas Canvas { get; set; }
        RectangleF BoundingBox { get; set; }
        ICssStyleDeclaration CssStyle { get; set; }

        void Parse(AngleSharp.Dom.IElement htmlElement);
        void Paint();
        void ComputeBoundingBox();
        string GetFloatAttribute();
    }
}
