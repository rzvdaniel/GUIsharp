using Gui.Sharp.Dom;

namespace Gui.Sharp.Gfx.Interfaces
{
    public interface IFontServer
    {
        void Initialize(int screenWidth, int screenHeight);

        void RenderText(string text, TFont font, Point position);

        void RenderText(string text, TFont font, float x, float y);
    }
}
