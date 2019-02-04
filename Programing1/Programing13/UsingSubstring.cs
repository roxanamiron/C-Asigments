using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing13
{
    public class UsingSubstring
    {

        public void DetectHowManyTimes(string text)
        {
            Console.WriteLine("\nWrite a program that detects how many times a substring is "+
                "contained in the text. For example, let’s look for the substring \"in\" in the text:");

            string word = "in";
            int occurence = text.IndexOf(word);

            if (text.Contains(word))
            {

                Console.WriteLine("{0} was found in text {1} times",word,occurence-1);
            }
           
        }
    }
}
