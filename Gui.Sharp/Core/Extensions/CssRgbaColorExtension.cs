using OpenTK;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Gui.Sharp.Core.Extensions
{
    public static class CssRgbaColorExtension
    {
        private const int FullAlpha = 255;
        private const char CommaSeparator = ',';

        /// <summary>
        /// Converts the rgb(a) string in OpenTK color format
        /// </summary>
        /// <remarks>
        /// The expeted string format:
        /// 1. rgba(r, g, b, a)
        /// 2. rgb(r, g, b)
        /// </remarks>
        /// <param name="rgbaColor">
        /// The CSS string rgb color
        /// </param>
        /// <param name="defaultColor">
        /// The default OpenTK color if string is invalid
        /// </param>
        /// <returns>
        /// The OpenTK color
        /// </returns>
        public static Color TryGetColor(this string rgbaColor, Color defaultColor)
        {
            Color color = defaultColor;

            if (!string.IsNullOrEmpty(rgbaColor))
            {
                var separators = new Char[] { CommaSeparator };

                /// How the regex works: https://stackoverflow.com/a/378447/778863
                /// \(      # Escaped parenthesis, means "starts with a '(' character"
                /// (       # Parentheses in a regex mean "put (capture) the stuff in between into the Groups array" 
                /// [^)]    # Any character that is not a ')' character
                /// *       # Zero or more occurrences of the aforementioned "non ')' char"
                /// )       # Close the capturing group
                ///\)
                
                var colorsOnly = Regex.Match(rgbaColor, @"\(([^)]*)\)").Groups[1].Value.Split(separators);

                var red = int.Parse(colorsOnly[0]);
                var green = int.Parse(colorsOnly[1]);
                var blue = int.Parse(colorsOnly[2]);

                string alphaString = colorsOnly.Count() == 4 ? colorsOnly[3] : string.Empty;

                var alpha = !string.IsNullOrEmpty(alphaString) ?
                    (int)Math.Ceiling(float.Parse(alphaString) * 255) :
                    FullAlpha;

                color = new Color(red, green, blue, alpha);
            }

            return color;
        }
    }
}
