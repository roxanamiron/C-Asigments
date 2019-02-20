using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing13
{
    public class ReverseTheWordsInASentence
    {
        public void ReverseMethod()
        {
            StringBuilder build = new StringBuilder();
            Console.WriteLine("Enter a sentence: ");
            string sentence = Console.ReadLine();
            Console.WriteLine("\nWrite a program that reverses the words in a given sentence without changing punctuation and spaces.");
           
           string[] array = sentence.Split(' ');
            for(int i = array.Length-1; i>= 0; i--)
            {
                build.Append(array[i]+ ' ');
            }

            Console.WriteLine(build);
        }
    }
}
