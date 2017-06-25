using Gui.Sharp.Css.Interfaces;
using Gui.Sharp.Gfx.Interfaces;
using OpenTK;
using System.Collections.Generic;

namespace Gui.Sharp.Dom.Interfaces
{
    public interface IElement
    {
        IList<IElement> Children { get; set; }
        IElement Parent { get; set; }
        IElement PreviousSibling { get; }
        IElement NextSibling { get; }

        IGfxCanvas Canvas { get; set; }
        RectangleF BoundingBox { get; set; }
        string FloatProperty { get; }

        ICssStyleDeclaration CssStyle { get; set; }

        void Paint();
        void ComputeBoundingBox();
    }
}
