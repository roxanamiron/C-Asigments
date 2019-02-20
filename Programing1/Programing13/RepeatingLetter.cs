using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing13
{
    public class RepeatingLetter
    {
        public void TrimTheRepeatingLetter()
        {
            Console.WriteLine("\nWrite a program that reads a string from the console and replaces "+
                "every sequence of identical letters in it with a single letter (the repeating letter)."+
                "Example: \"aaaaabbbbbcdddeeeedssaa\" à \"abcdedsa\".");

            Console.WriteLine("\nEnter a string: ");
            string word = Console.ReadLine();
            var lisOfLetters = new List<char>();
            var chr = word[0];
            for(int i = 1; i < word.Length; i++)
            {
                char letter = word[i];
                if(chr != letter)
                {
                    lisOfLetters.Add(chr);
                    chr = letter;
                }
                if( i == word.Length -1)
                {
                    lisOfLetters.Add(letter);
                }
            }
            Console.WriteLine(string.Join("",lisOfLetters));

        }
    }
}
