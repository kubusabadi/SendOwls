
using System.IO;

namespace SendOwls.Logic.Parsers
{
    public class MailBodyParser
    {
        public string Body {get; private set;}

        public MailBodyParser(string filePath)
        {
            Body = "";
            using (var reader = new StreamReader(filePath))
            {
                string textLine;
                while((textLine = reader.ReadLine()) != null)
                {
                    Body += textLine + "\n";
                }
            }
        }

    }
}