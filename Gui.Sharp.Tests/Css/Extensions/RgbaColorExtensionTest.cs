using Gui.Sharp.Css.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenTK;

namespace Gui.Sharp.Tests.Css.Extensions
{
    [TestClass]
    public class RgbaColorExtensionTest
    {
        private Color DefaultBackgroundColor = new Color(255, 255, 255, 255);
        private Color DefaultForegroundColor = new Color(0, 0, 0, 255);

        [TestMethod]
        public void TryGetValidFormatColor()
        {
            // Valid rgba color
            var grayColor = new Color(60, 60, 60, 255);
            const string validGrayColor = "rgba(60, 60, 60, 1)";
            var color = validGrayColor.TryGetColor(DefaultBackgroundColor);
            Assert.IsTrue(color == grayColor);

            // Valid alpha (alpha is in range [0.0, 1.0]).
            int alpha = 128;
            const string validAlphaColor = "rgba(60, 60, 60, 0.5)";
            color = validAlphaColor.TryGetColor(DefaultBackgroundColor);
            Assert.IsTrue(color.A == alpha);

            // Valid rgb color
            var redColor = new Color(255, 0, 0, 0);
            const string validRedColor = "rgba(255, 0, 0, 0)";
            color = validRedColor.TryGetColor(DefaultForegroundColor);
            Assert.IsTrue(color == redColor);
        }

        [TestMethod]
        public void TryGetInvalidFormatColor()
        {
            // Invalid rgba color format
            const string invalidWhiteColor = "rgba(255, 255)";
            var color = invalidWhiteColor.TryGetColor(DefaultBackgroundColor);
            Assert.IsTrue(color == DefaultBackgroundColor);

            // Invalid alpha (alpha is not in range [0.0, 1.0])
            const string invalidAlphaColor = "rgba(60, 60, 60, 2.5)";
            color = invalidAlphaColor.TryGetColor(DefaultBackgroundColor);
            Assert.IsTrue(color.A == DefaultBackgroundColor.A);

            // Invalid rgb color format
            const string invalidBlackColor = "rgb(0)";
            color = invalidBlackColor.TryGetColor(DefaultForegroundColor);
            Assert.IsTrue(color == DefaultForegroundColor);
        }
    }
}
