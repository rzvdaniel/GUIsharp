using Gui.Sharp.Gfx.Drawing;
using OpenTK;

namespace Gui.Sharp.Gfx.Interfaces
{
    public interface IGfxCanvas
    {
        PointF PenPos { get; set; }
        TBrush Brush { get; set; }
        TPen Pen { get; set; }
        float TextAntialias { get; set; }

        void DrawRect(float x, float y, float width, float height, int border);
        void DrawRect(RectangleF rect, int border);

        void FillRect(float x, float y, float width, float height);
        void FillRect(RectangleF rect);

        void MoveTo(float x, float y);
        void LineTo(float x, float y);
    }
}
