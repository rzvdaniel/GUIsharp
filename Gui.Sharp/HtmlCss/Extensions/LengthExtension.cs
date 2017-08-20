using AngleSharp.Css.Values;

namespace Gui.Sharp.HtmlCss.Extensions
{
    public static class LengthExtension
    {
        /// <summary>
        /// Converts a CSS value to Length format
        /// </summary>
        /// <remarks>
        /// The VSS value formats:
        /// Px, Em, Ex, Cm, Mm, In, Pt, Pc, Ch, Rem, Vw, Vh, Vmin, Vmax, Percent
        /// For a complete list of CSS value formats and their description, see Length.Unit.
        /// </remarks>
        /// <param name="cssValue">
        /// The CSS value to convert
        /// </param>
        /// <returns>
        /// The Length of the CSS value
        /// </returns>
        public static Length GetLength(this string cssValue)
        {
            Length.TryParse(cssValue, out Length length);

            return length;
        }
    }
}
