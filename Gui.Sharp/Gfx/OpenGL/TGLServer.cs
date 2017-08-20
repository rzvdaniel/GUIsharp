using Gui.Sharp.Gfx.Servers;
using OpenTK.Graphics.OpenGL;

namespace Gui.Sharp.Gfx.OpenGL
{
    public class TGLServer : TGfxServer
    {
        public override void Begin()
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.ClearColor(ClearColor.R, ClearColor.G, ClearColor.B, ClearColor.A);
            GL.Viewport(0, 0, Width, Height);

            // Always have filled polygons
            GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Fill);

            // "An optimum compromise that allows all primitives to be 
            // specified at integer positions, while still ensuring 
            // predictable rasterization, is to translate x and y by 0.375, 
            // as shown in the following code fragment. Such a translation 
            // keeps polygon and pixel image edges safely away from the 
            // centers of pixels, while moving line vertices close enough 
            // to the pixel centers." - Red Book

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(0, Width, Height, 0, -1, 1);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            GL.Translate(0.375, 0.375, 0.0);

            GL.Disable(EnableCap.Lighting);
            GL.Disable(EnableCap.Fog);
            GL.Disable(EnableCap.CullFace);
            GL.Disable(EnableCap.DepthTest);
            GL.Disable(EnableCap.Texture2D);
            GL.UseProgram(0);

            /*
            GL.Enable(GL_CLIP_PLANE0);
            GL.Enable(GL_CLIP_PLANE1);
            GL.Enable(GL_CLIP_PLANE2);
            GL.Enable(GL_CLIP_PLANE3); 
            */
        }

        public override void BeginScene()
        {
            // "An optimum compromise that allows all primitives to be 
            // specified at integer positions, while still ensuring 
            // predictable rasterization, is to translate x and y by 0.375, 
            // as shown in the following code fragment. Such a translation 
            // keeps polygon and pixel image edges safely away from the 
            // centers of pixels, while moving line vertices close enough 
            // to the pixel centers." - Red Book
            GL.Disable(EnableCap.Lighting);
            GL.Disable(EnableCap.Fog);
            GL.Disable(EnableCap.CullFace);
            GL.Disable(EnableCap.DepthTest);
            GL.Disable(EnableCap.Texture2D);

            /*
            glEnable(GL_CLIP_PLANE0);
            glEnable(GL_CLIP_PLANE1);
            glEnable(GL_CLIP_PLANE2);
            glEnable(GL_CLIP_PLANE3);
            */

            GL.Viewport(0, 0, Width, Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.PushMatrix();
            GL.LoadIdentity();
            GL.Ortho(0, Width, Height, 0, -1, 1);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.PushMatrix();
            GL.LoadIdentity();
            GL.Translate(0.375, 0.375, 0.0);
        }

        public override void End()
        {
            GL.Enable(EnableCap.Texture2D);

            /*
            glDisable(GL_CLIP_PLANE0);
	        glDisable(GL_CLIP_PLANE1);
	        glDisable(GL_CLIP_PLANE2);
	        glDisable(GL_CLIP_PLANE3);
	        */
        }

        public override void EndScene()
        {
            GL.MatrixMode(MatrixMode.Modelview);
            GL.PopMatrix();
            GL.MatrixMode(MatrixMode.Projection);
            GL.PopMatrix();

            /*
            glDisable(GL_CLIP_PLANE0);
            glDisable(GL_CLIP_PLANE1);
            glDisable(GL_CLIP_PLANE2);
            glDisable(GL_CLIP_PLANE3);
            */

            GL.Enable(EnableCap.Texture2D);
        }
    }
}
