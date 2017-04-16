namespace Gui.Sharp.Dom.Interfaces
{
    public interface ITDocument
    {
        void Parse(string html);
        void Render();
    }
}