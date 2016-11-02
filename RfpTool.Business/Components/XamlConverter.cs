using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace RfpTool.Business.Components
{
    public class XamlConverter
    {
        private string _xamlText;

        public XamlConverter(string xamlText)
        {
            _xamlText = xamlText;
        }

        public string ConvertToRtf()
        {
            var richTextBox = new RichTextBox();

            if (string.IsNullOrEmpty(_xamlText))
            {
                return "";
            }

            var textRange = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);

            using (var xamlMemoryStream = new MemoryStream())
            {
                using (var xamlStreamWriter = new StreamWriter(xamlMemoryStream))
                {
                    xamlStreamWriter.Write(_xamlText);
                    xamlStreamWriter.Flush();
                    xamlMemoryStream.Seek(0, SeekOrigin.Begin);
                    textRange.Load(xamlMemoryStream, DataFormats.Xaml);
                }
            }
            using (var rtfMemoryStream = new MemoryStream())
            {
                textRange = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
                textRange.Save(rtfMemoryStream, DataFormats.Rtf);
                rtfMemoryStream.Seek(0, SeekOrigin.Begin);
                using (var rtfStreamReader = new StreamReader(rtfMemoryStream))
                {
                    return rtfStreamReader.ReadToEnd();
                }
            }
        }
    }
}
