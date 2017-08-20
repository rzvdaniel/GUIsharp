using Gui.Sharp.Dom.Enums.Properties;
using Gui.Sharp.Dom.Interfaces;

namespace Gui.Sharp.Dom.Extensions
{
    public static class HtmlFloatExtension
    {
        public static string GetFloat(this IElement element)
        {
            string attribute = string.Empty;

            if (element.Css.Float == Float.Inherit && element.Parent != null)
            {
                attribute = element.Parent.Css.Float;
            }
            else
            {
                attribute = element.Css.Float;
            }

            if (string.IsNullOrEmpty(attribute))
                attribute = Float.None;

            return attribute;
        }
    }
}
