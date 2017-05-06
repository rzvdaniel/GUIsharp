using IElement = Gui.Sharp.Dom.Interfaces.IElement;

namespace Gui.Sharp.Dom.Factories
{
    interface ITElementFactory<T>
        where T : AngleSharp.Dom.IElement
    {
        IElement Create(AngleSharp.Dom.IElement htmlElement);
    }
}
