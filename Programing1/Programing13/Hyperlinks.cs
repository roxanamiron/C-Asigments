using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Programing13
{
   public class Hyperlinks
    {
       
        private string text = "<p>Please visit <a href=\"https://softuni.bg\">our site</a> to choose a training "+
            "course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
        private string result;

        public void ReplaceTheText()
        {
            Console.WriteLine("\nWrite a program that replaces all hyperlinks in a HTML document consisting " +
           "of <a href=\"…\">…</a> and hyperlinks in \"forum\" style, which look like [URL=…]…[/URL].");
            StringBuilder build = new StringBuilder();
            result = text.Replace("<a href=\"", "[URL=").Replace("\">","]").Replace("</a>", "[/URL]");
            Console.WriteLine(result);
        }

    }
}
