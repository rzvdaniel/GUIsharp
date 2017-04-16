using Gui.Sharp.Tests.Extensions;
using NUnit.Framework;

namespace Gui.Sharp.Tests.Dom
{
    [TestFixture]
    public class TDocumentTest
    {
        string source = @"
            <!DOCTYPE html>
            <html>
                <head>
                    <meta charset=""utf-8"" />
                    <title></title>
                    <style>
                        body
                        {
                            background-color: green !important;
                            width: 100%;
                        }
                    </style>
                </head>
                <body style=""background-color: red"">
                    <div>
                        <p>Hello</p>
                    </div>
                    <div>
                        <p>World!</p>
                    </div>
                </body>
            </html>";

        [Test]
        public void DocumentParseSuccess()
        {
            var document = source.ToHtmlDocument();

            Assert.IsTrue(document.Body.Children.Count == 2);
        }
    }
}
