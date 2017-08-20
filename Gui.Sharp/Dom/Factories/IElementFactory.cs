using Gui.Sharp.Dom.Interfaces;

namespace Gui.Sharp.Dom.Factories
{
    interface IElementFactory<T>
        where T : AngleSharp.Dom.IElement
    {
        IElement Create(AngleSharp.Dom.IElement htmlElement);
    }
}
