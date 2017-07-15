using Gui.Sharp.Dom.Enums.Properties;
using Gui.Sharp.Dom.Interfaces;

namespace Gui.Sharp.Dom.Extensions
{
    public static class FloatPropertyExtension
    {
        public static string GetFloat(this IElement element)
        {
            string attribute = string.Empty;

            if (element.CssStyle.Float == Float.Inherit && element.Parent != null)
            {
                attribute = element.Parent.CssStyle.Float;
            }
            else
            {
                attribute = element.CssStyle.Float;
            }

            if (string.IsNullOrEmpty(attribute))
                attribute = Float.None;

            return attribute;
        }
    }
}
