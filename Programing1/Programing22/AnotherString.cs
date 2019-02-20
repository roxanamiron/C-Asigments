using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing22
{
   public static class AnotherString
    {
        public static StringBuilder CapitalizesAllLetters(this string sentence)
        {
            Console.WriteLine("\nWrite an extension method for the class String that capitalizes all letters, "+
                "which are the beginning of a word in a sentence in English. For example: "+
                "\"this iS a Sample sentence.\" should be converted to \"This Is A Sample Sentence.\".");

            return new StringBuilder(new CultureInfo("en-US",false).TextInfo.ToTitleCase(sentence));            
        }
    }
}
