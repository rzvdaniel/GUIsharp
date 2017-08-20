using Gui.Sharp.Dom;
using Gui.Sharp.Gfx.Drawing;
using Gui.Sharp.HtmlCss.Interfaces;

namespace Gui.Sharp.Gfx.Interfaces
{
    public interface IGfxCanvas
    {
        void Initialize(ICssStyleDeclaration style);

        Point PenPos { get; set; }
        TBrush Brush { get; set; }
        TPen Pen { get; set; }
        TFont Font { get; set; }

        void DrawRect(float x, float y, float width, float height, int border);
        void DrawRect(Rectangle rect, int border);

        void FillRect(float x, float y, float width, float height);
        void FillRect(Rectangle rect);

        void MoveTo(float x, float y);
        void LineTo(float x, float y);

        void Print(string text, Point position);
    }
}
