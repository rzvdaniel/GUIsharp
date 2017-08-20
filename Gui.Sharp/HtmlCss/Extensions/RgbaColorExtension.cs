using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Gui.Sharp.HtmlCss.Extensions
{
    public static class RgbaColorExtension
    {
        private const float FullAlpha = 1.0f;
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

                    var red = byte.Parse(colorsOnly[0]) / (float)Byte.MaxValue;
                    var green = byte.Parse(colorsOnly[1]) / (float)Byte.MaxValue;
                    var blue = byte.Parse(colorsOnly[2]) / (float)Byte.MaxValue;

                    float alpha;
                    string alphaString = colorsOnly.Count() == 4 ? colorsOnly[3] : string.Empty;

                    if (string.IsNullOrEmpty(alphaString))
                    {
                        alpha = FullAlpha;
                    }
                    else
                    {
                        var tempAlpha = float.Parse(alphaString);
                        alpha = tempAlpha >= 0.0f && tempAlpha <= 1.0f ? tempAlpha : FullAlpha;
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
