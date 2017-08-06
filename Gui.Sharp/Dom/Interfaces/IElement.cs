using Gui.Sharp.Css.Interfaces;
using Gui.Sharp.Gfx.Interfaces;
using OpenTK;
using System.Collections.Generic;

namespace Gui.Sharp.Dom.Interfaces
{
    public interface IElement
    {
        IElement Parent { get; set; }
        IList<IElement> Children { get; set; }

        IGfxCanvas Canvas { get; set; }
        Rectangle BoundingBox { get; set; }
        ICssStyleDeclaration CssStyle { get; set; }

        void Paint();
        void Parse(AngleSharp.Dom.IElement htmlElement);
        void ComputeBoundingBox();
    }
}
