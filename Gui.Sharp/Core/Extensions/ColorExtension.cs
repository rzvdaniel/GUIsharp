using OpenTK;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Gui.Sharp.Core.Extensions
{
    public static class ColorExtension
    {
        private const int FullAlpha = 255;
        private const char CommaSeparator = ',';

        public static Color TryGetColor(this string rgbaColor, Color defaultColor)
        {
            Color color = defaultColor;

            if (!string.IsNullOrEmpty(rgbaColor))
            {
                var separators = new Char[] { CommaSeparator };
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
