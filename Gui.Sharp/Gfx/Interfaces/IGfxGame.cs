using Gui.Sharp.Dom.Interfaces;
using OpenTK;

namespace Gui.Sharp.Gfx.Interfaces
{
    public interface IGfxGame
    {
        IScreen Screen { get; set; }

        void Create(int width, int height, GameWindowFlags windowFlags, string htmlDocument);

        void Run();
        void Run(double updateRate);
        void Run(double updatesPerSecond, double framesPerSecond);
    }
}
