using Gui.Sharp.Css.Interfaces;
using Gui.Sharp.Gfx.Interfaces;
using System.Collections.Generic;

namespace Gui.Sharp.Dom.Interfaces
{
    public interface IElement
    {
        IList<IElement> Children { get; set; }
        ICssStyleDeclaration CssStyle { get; set; }
        IGfxCanvas Canvas { get; set; }

        void Paint();
    }
}
