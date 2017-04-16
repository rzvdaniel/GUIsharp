namespace Gui.Sharp.Dom.Interfaces
{
    public interface ITDocument
    {
        #region Properties

        ITElement Body { get; set; }

        #endregion

        #region Methods

        void Parse(string html);
        void Render();

        #endregion
    }
}