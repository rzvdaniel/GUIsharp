using Gui.Sharp.Dom.Interfaces;
using System;

namespace Gui.Sharp.Dom.Factories
{
    public class DomFactory
    {
        public static T Create<T>()
        {
            var name = typeof(T).Name;

            switch (name)
            {
                case "IDocument":
                    return (T)(IDocument)new TDocument();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
