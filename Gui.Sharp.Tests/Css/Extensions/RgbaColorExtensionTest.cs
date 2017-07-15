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
            var grayColor = new Color(60, 60, 60, 255);
            const string validGrayColor = "rgba(60, 60, 60, 1)";
            var color = validGrayColor.TryGetColor(DefaultBackgroundColor);
            Assert.IsTrue(color == grayColor);

            var redColor = new Color(255, 0, 0, 0);
            const string validRedColor = "rgba(255, 0, 0, 0)";
            color = validRedColor.TryGetColor(DefaultForegroundColor);
            Assert.IsTrue(color == redColor);
        }

        [TestMethod]
        public void TryGetInvalidFormatColor()
        {
            const string invalidWhiteColor = "rgba(255, 255)";
            var color = invalidWhiteColor.TryGetColor(DefaultBackgroundColor);
            Assert.IsTrue(color == DefaultBackgroundColor);

            const string invalidBlackColor = "rgb(0)";
            color = invalidBlackColor.TryGetColor(DefaultForegroundColor);
            Assert.IsTrue(color == DefaultForegroundColor);
        }
    }
}
