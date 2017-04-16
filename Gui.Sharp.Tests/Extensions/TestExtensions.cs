using Gui.Sharp.Dom;
using Gui.Sharp.Dom.Interfaces;

namespace Gui.Sharp.Tests.Extensions
{
    public static class TestExtensions
    {
        public static ITDocument ToHtmlDocument(this string sourceCode)
        {
            var document = new TDocument();
            document.Parse(sourceCode);

            return document;
        }
    }
}
