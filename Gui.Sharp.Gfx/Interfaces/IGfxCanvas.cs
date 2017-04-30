using OpenTK;

namespace Gui.Sharp.Gfx.Interfaces
{
    public interface IGfxCanvas
    {
        Point PenPos { get; set; }
        TBrush Brush { get; set; }
        TPen Pen { get; set; }
        float TextAntialias { get; set; }

        void DrawRect(int x, int y, int width, int height, int border);
        void DrawRect(Rectangle rect, int border);

        void FillRect(int x, int y, int width, int height);
        void FillRect(Rectangle rect);

        void MoveTo(int x, int y);
        void LineTo(int x, int y);
    }
}
