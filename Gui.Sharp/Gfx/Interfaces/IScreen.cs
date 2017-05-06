using Gui.Sharp.Dom.Interfaces;
using OpenTK;

namespace Gui.Sharp.Gfx.Interfaces
{
    public interface IScreen
    {
        IGfxServer GfxServer { get; set; }
        IGfxCanvas Canvas { get; set; }
        IDocument Document { get; set; }

        void Create(int width, int height, Color clearColor, IDocument document);
        void Paint();
    }
}
