using Gui.Sharp.Dom;
using Gui.Sharp.Dom.Factories;
using System;
using System.Collections.Generic;
using IElement = Gui.Sharp.Dom.Interfaces.IElement;

namespace AngleSharp.Services.Default
{
    /// <summary>
    /// Provides string to HTMLElement instance creation mappings.
    /// </summary>
    public class TElementFactory : ITElementFactory<Dom.IElement>
    {
        private delegate IElement Creator();

        private readonly Dictionary<string, Creator> creators = new Dictionary<string, Creator>(StringComparer.OrdinalIgnoreCase)
        {
            { "HtmlBodyElement", () => new TBody() },
            { "HtmlDivElement", () => new TDiv() },
            { "HtmlParagraphElement", () => new TParagraph() },
            { "HtmlSpanElement", () => new TSpan() },
        };

        public IElement Create(Dom.IElement htmlElement)
        {
            var type = htmlElement.GetType();

            var creator = default(Creator);

            if (creators.TryGetValue(type.Name, out creator))
            {
                return creator();
            }

            // Default to span element 
            creators.TryGetValue("HtmlSpanElement", out creator);
            return creator();
        }
    }
}
