using OpenTK;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Gui.Sharp.Css.Extensions
{
    public static class RgbaColorExtension
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

            try
            {
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

                    var colorsCount = colorsOnly.Count();
                    if (colorsCount < 3 || colorsCount > 4)
                    {
                        return defaultColor;
                    }

                    var red = int.Parse(colorsOnly[0]);
                    var green = int.Parse(colorsOnly[1]);
                    var blue = int.Parse(colorsOnly[2]);

                    int alpha;
                    string alphaString = colorsOnly.Count() == 4 ? colorsOnly[3] : string.Empty;

                    if (string.IsNullOrEmpty(alphaString))
                    {
                        alpha = FullAlpha;
                    }
                    else
                    {
                        var tempAlpha = float.Parse(alphaString);
                        alpha = tempAlpha >= 0 && tempAlpha <= 1 ?
                            (int)Math.Ceiling(tempAlpha * 255) :
                            FullAlpha;
                    }                     

                    color = new Color(red, green, blue, alpha);
                }
            }
            catch (Exception ex)
            {
                // TODO! Should log the exception.
                return defaultColor;
            }

            return color;
        }
    }
}
