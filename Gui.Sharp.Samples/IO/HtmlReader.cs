using System.IO;
using System.Text;

namespace Gui.Sharp.Samples.IO
{
    public class HtmlReader
    {
        private const string DefaultPath = "..\\Gui.Sharp.Samples\\Resources\\Default.html";

        public string Read(string filePath)
        {
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            {
                filePath = DefaultPath;
            }

            var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                var html = streamReader.ReadToEnd();

                return html;
            }
        }
    }
}
