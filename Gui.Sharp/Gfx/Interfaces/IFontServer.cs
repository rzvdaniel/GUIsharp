using Gui.Sharp.Dom;
using QuickFont;
using QuickFont.Configuration;
using System.Collections.Generic;

namespace Gui.Sharp.Gfx.Interfaces
{
    public interface IFontServer
    {
        IDictionary<string, QFont> DefaultFonts { get; }

        QFontBuilderConfiguration BuilderConfiguration { get; }

        void Initialize(int screenWidth, int screenHeight);

        void RenderText(string text, TFont font, Point position);
    }
}
