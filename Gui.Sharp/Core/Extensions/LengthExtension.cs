using AngleSharp.Css.Values;

namespace Gui.Sharp.Core.Extensions
{
    public static class LengthExtension
    {
        public static Length GetLength(this string cssValue)
        {
            Length.TryParse(cssValue, out Length length);

            return length;
        }
    }
}
