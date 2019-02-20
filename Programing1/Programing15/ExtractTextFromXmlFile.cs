using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Programing15
{
   public class ExtractTextFromXmlFile
    {
        private string file = @"xml.txt";
        StringBuilder builder = new StringBuilder();
        public void ExtractText()
        {
            using (StreamReader reader = new StreamReader(file))
            {
                //read charcter by charcter
                while(!reader.EndOfStream)
                {
                    string line = Regex.Replace(reader.ReadLine(), @"<[^>]*>", String.Empty).Trim();

                    if (line != "")
                    {
                        builder.AppendLine(line);
                    }
                }
                Console.WriteLine(builder);
            }
        }
    }
}
