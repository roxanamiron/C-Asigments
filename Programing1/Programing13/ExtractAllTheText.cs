using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Programing13
{
    public class ExtractAllTheText
    {
        public void ExtractAll()
        {
            Console.WriteLine("\nWrite a program that extracts all the text without any tags and attribute values from an HTML document.");

            //read in html file
            string html = File.ReadAllText("document.html");

            //get the text from the html file
          
            Console.WriteLine(GetBody(html));

        }
        private string GetBody(string html)
        {
            return Regex.Replace(html, "<(.|\\n)*?>",string.Empty);

        }
    }
}
