using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Programing13
{
    public class ExtractEmail
    {
        private string tet = "Please contact us by phone (+001 222 222 222) or by email at example@gmail.com "+
            "or at test.user@yahoo.co.uk. This is not email: test@test. This also: @gmail.com. Neither this: a@a.b.";

        public void Extract()
        {
            Console.WriteLine("\nWrite a program that extracts all e-mail addresses from a text. These are all "+
                "substrings that are limited on both sides by text end or separator between words and match the "+
                "shape <sender>@<host>…<domain>.");
            //  \w+  - Match one or more word characters.
            //  
            foreach (var item in Regex.Matches(tet, @"\w+@\w+\.\w+"))
            {
                Console.WriteLine(item);
            }
        }
    }
}
