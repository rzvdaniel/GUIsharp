namespace Gui.Sharp.Dom.Interfaces
{
    public interface IDocument
    {
        #region Properties

        IElement Body { get; set; }

        #endregion

        #region Methods

        void Parse(string html);
        void Render();

        #endregion
    }
}