using AngleSharp.Dom;
using Gui.Sharp.Dom;
using Gui.Sharp.Dom.Factories;
using Gui.Sharp.Dom.Interfaces;
using System;
using System.Collections.Generic;

namespace AngleSharp.Services.Default
{
    /// <summary>
    /// Provides string to HTMLElement instance creation mappings.
    /// </summary>
    public class TElementFactory : ITElementFactory<IElement>
    {
        private delegate ITElement Creator(IElement htmlElement);

        private readonly Dictionary<string, Creator> creators = new Dictionary<string, Creator>(StringComparer.OrdinalIgnoreCase)
        {
            { "HtmlBodyElement", (htmlElement) => new TBody(htmlElement) },
            { "HtmlDivElement", (htmlElement) => new TDiv(htmlElement) },
            { "HtmlParagraphElement", (htmlElement) => new TParagraph(htmlElement) },
        };

        public ITElement Create(IElement htmlElement)
        {
            var type = htmlElement.GetType();

            var creator = default(Creator);

            if (creators.TryGetValue(type.Name, out creator))
            {
                return creator(htmlElement);
            }

            return null;
        }
    }
}
