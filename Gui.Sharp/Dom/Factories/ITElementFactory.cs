using AngleSharp.Dom;
using Gui.Sharp.Dom.Interfaces;

namespace Gui.Sharp.Dom.Factories
{
    interface ITElementFactory<T>
        where T : IElement
    {
        ITElement Create(IElement htmlElement);
    }
}
