namespace Gui.Sharp.Gfx.Interfaces
{
    public interface IGfxServer
    {
        Color ClearColor { get; set; }
        int Width { get; set; }
        int Height { get; set; }

        void Initialize(int width, int height, Color clearColor);

        void Begin();
	    void End();
	
	    void BeginScene();
	    void EndScene();
    }
}
