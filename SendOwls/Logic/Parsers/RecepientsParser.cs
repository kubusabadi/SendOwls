
using System.Globalization;
using System.IO;
using System.Collections.Generic;

namespace SendOwls.Logic.Parsers
{
    public class RecepientsParser
    {
        public List<string> Values { get; private set; }
        public RecepientsParser (string filePath)
        {
            Values = new List<string>();
            using (var reader = new StreamReader(filePath))
            {
                string textLine;
                while((textLine = reader.ReadLine()) != null)
                {
                    Values.Add(textLine);
                }
            }
        }
    }
}