using Gui.Sharp.Gfx.Interfaces;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Gui.Sharp.Gfx
{
    public class TGLCanvas : IGfxCanvas
    {
        public PointF PenPos { get; set; }
        public TBrush Brush { get; set; }
        public TPen Pen { get; set; }
        public float TextAntialias { get; set; }

        public TGLCanvas()
        {
            PenPos = new PointF();
            Brush = new TBrush();
            Pen = new TPen();
        }

        public void DrawRect(float x, float y, float width, float height, int border)
        {
            for (int i = 0; i < border; i++)
            {
                MoveTo(x + width - i, y + i);
                LineTo(x + i, y + i);                   // top 
                LineTo(x + i, y + height - i);          // left	
                LineTo(x + width - i, y + height - i);  // bottom 
                LineTo(x + width - i, y + i);           // right 
            }
        }

        public void DrawRect(RectangleF rect, int border)
        {
            DrawRect(rect.X, rect.Y, rect.Width, rect.Height, border);
        }

        public void FillRect(int x, int y, int width, int height)
        {
            Color Color = Brush.Color;

            if (Color.A != default(byte))
            {
                GL.Enable(EnableCap.Blend);
                GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);
            }
            else
            {
                GL.Disable(EnableCap.Blend);
            }

            // Set the drawing color
            GL.Color4(Color.R, Color.G, Color.B, Color.A);

            // If our brush has any texture
            //if (Brush->GetTexture() != NULL)
            //{
            //    glEnable(GL_TEXTURE_2D);
            //    glBindTexture(GL_TEXTURE_2D, Brush->GetTexture()->GetTexId());

            //    glBegin(GL_QUADS);
            //    glTexCoord2f(Brush->GetTextureOffsetU(), Brush->GetTextureV());
            //    glVertex2i(Rect.left + X, Rect.top + Y);
            //    glTexCoord2f(Brush->GetTextureU(), Brush->GetTextureV());
            //    glVertex2i(Rect.left + X + CX, Rect.top + Y);
            //    glTexCoord2f(Brush->GetTextureU(), Brush->GetTextureOffsetV());
            //    glVertex2i(Rect.left + X + CX, Rect.top + Y + CY);
            //    glTexCoord2f(Brush->GetTextureOffsetU(), Brush->GetTextureOffsetV());
            //    glVertex2i(Rect.left + X, Rect.top + Y + CY);
            //    glEnd();

            //    glDisable(GL_TEXTURE_2D);
            //}
            //else
            {
                // We don't care about any texture or texture coordinates
                GL.Begin(PrimitiveType.Quads);
                GL.Vertex2(x, y);
                GL.Vertex2(x + width, y);
                GL.Vertex2(x + width, y + height);
                GL.Vertex2(x, y + height);
                GL.End();
            }
        }

        public void FillRect(Rectangle rect)
        {
            FillRect(rect.X, rect.Y, rect.Width, rect.Height);
        }

        public void MoveTo(float x, float y)
        {
            PenPos = new PointF(x, y);
        }

        public void LineTo(float x, float y)
        {
            Color Color = Pen.Color;

            // Transparency?
            if (Color.A != default(byte))
            {
                GL.Enable(EnableCap.Blend);
                GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);
            }
            else
            {
                GL.Disable(EnableCap.Blend);
            }

            // Disable texturing
            GL.Disable(EnableCap.Texture2D);

            // Set the drawing color
            GL.Color4(Color.R, Color.G, Color.B, Color.A);

            bool LineStipple = true;

            switch (Pen.Style)
            {
                case TPenStyle.psSolid:
                    LineStipple = false;
                    break;
                case TPenStyle.psDash:
                    GL.LineStipple(1, 0x0F0F);
                    break;
                case TPenStyle.psDot:
                    GL.LineStipple(1, 0x1111);
                    break;
                case TPenStyle.psDashDot:
                    GL.LineStipple(1, 0xFC30);
                    break;
                case TPenStyle.psDashDotDash:
                    GL.LineStipple(1, 0xF33C);
                    break;
                case TPenStyle.psDashDotDot:
                    GL.LineStipple(1, 0xF888);
                    break;
            }

            if (LineStipple == true)
                GL.Enable(EnableCap.LineStipple);

            GL.LineWidth(Pen.Width);

            GL.Begin(PrimitiveType.Lines);
            GL.Vertex2(PenPos.X, PenPos.Y);
            GL.Vertex2(x, y);
            GL.End();

            if (LineStipple == true)
                GL.Disable(EnableCap.LineStipple);

            MoveTo(x, y);
        }
    }
}
