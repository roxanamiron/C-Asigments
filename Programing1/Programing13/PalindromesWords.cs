using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing13
{
    public class PalindromesWords
    {

        public void ExtractPalindrom()
        {
            Console.WriteLine("\nWrite a program that extracts from a text all words which are palindromes, such as \"ABBA\", \"lamal\", \"exe\".");

            Console.WriteLine("\nInput a text with palindrome words");
            string someText = Console.ReadLine();

            List<string> list = new List<string>(someText.Split(' '));

            string result = " ";

            for(int i= 0; i < list.Count; i++)
            {
                string word = ReverseText(list[i]);

                if(list[i] == word)
                {
                    result = word;
                    Console.WriteLine(result);
                }
            }
            
        }

        private string ReverseText(string someText)
        {
            StringBuilder build = new StringBuilder();
            for(int i = someText.Length-1; i >= 0 ; i--)
            {
                build.Append(someText[i]);
            }
            return build.ToString();
        }
    }
}
