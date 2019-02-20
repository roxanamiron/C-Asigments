using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing13
{
    public class UpperCaseLetters
    {
         static string text;
         public static string result;

        public void ModifiesTheCasing(string text)
        {
            Console.WriteLine("\nA text is given. Write a program that modifies the casing of letters "+
                "to uppercase at all places in the text surrounded by <upcase> and </upcase> tags. Tags cannot be nested.");

            StringBuilder builder = new StringBuilder();
            string keyword1 = "<upcase>";
            string keyword2 = "</upcase>";
           if(builder != null)
            {
                int start = text.IndexOf(keyword1);
                int ends = text.IndexOf(keyword2);

                string lowerLetters1 = text.Substring(start, ends - start + 9);
                string upperLetters1 = text.Substring(start + 8, ends - start - 8).ToUpper();

                string newline1 = text.Replace(lowerLetters1, upperLetters1);

                int start2 = newline1.IndexOf(keyword1);
                int ends2 = newline1.IndexOf(keyword2);
                string lowerLetters2 = newline1.Substring(start2, ends2 - start2 + 8);
                string upperLetters2 = newline1.Substring(start2 + 8, ends2 - start2 - 8).ToUpper();

                result = newline1.Replace(lowerLetters2, upperLetters2);
            }
         
            Console.WriteLine(result);



        }
    }
}
