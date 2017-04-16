using Gui.Sharp.Css.Interfaces;
using System.Collections.Generic;

namespace Gui.Sharp.Dom.Interfaces
{
    public interface ITElement
    {
        IList<ITElement> Children { get; set; }
        ITCssStyleDeclaration CssStyle { get; set; }
    }
}
