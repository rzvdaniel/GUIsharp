using OpenTK;

namespace Gui.Sharp.Gfx.Interfaces
{
    public interface IGfxServer
    {
        Color ClearColor { get; set; }
        int Width { get; set; }
        int Height { get; set; }

        void Begin();
	    void End();
	
	    void BeginScene();
	    void EndScene();
    }
}
