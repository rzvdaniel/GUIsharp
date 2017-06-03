using Gui.Sharp.Dom.Interfaces;
using OpenTK;

namespace Gui.Sharp.Gfx.Interfaces
{
    public interface IGfxGame
    {
        #region Properties

        IScreen Screen { get; set; }

        #endregion

        #region Methods

        void Run();
        void Run(double updateRate);
        void Run(double updatesPerSecond, double framesPerSecond);
        void Create(int width, int height, GameWindowFlags windowFlags, string htmlDocument);

        #endregion
    }
}
