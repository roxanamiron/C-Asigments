using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing13
{
    public class AlphabeticalOrder
    {
      

        public void PrintAlphabeticalOrderAllLetters()
        {

            Console.WriteLine("\nWrite a program that reads a string from the console and prints in alphabetical "+
                "order all letters from the input string and how many times each one of them occurs in the string.");

            Console.WriteLine("Input a string: ");
            string word = Console.ReadLine();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            Dictionary<char, int> result = new Dictionary<char, int>();
            foreach (var letter in word)
            {
                if(!dict.ContainsKey(letter))
                {
                    dict.Add(letter, 1);
                    result = dict.Keys.OrderBy(l => l).ToDictionary(l => l, l => dict[l]);
                }
                else
                {
                    dict[letter] = dict[letter] + 1;
                    result = dict.Keys.OrderBy(l => l).ToDictionary(l => l, l => dict[l]);
                }         
            }
            Console.WriteLine("The letter {0} apperce: {1} ", result.Keys,result.Values);
        }

        public void PrintAlphabeticalOrderAllWords()
        {

            Console.WriteLine("\nWrite a program that reads a string from the console and prints in alphabetical order "+
                "all words from the input string and how many times each one of them occurs in the string.");

            int occurrence = 0;
            Console.WriteLine("Input a string: ");
            string sentence = Console.ReadLine();
            var dict2 = new Dictionary<string, int>();
            var result2 = new Dictionary<string, int>();
            var list = sentence.Split(' ');
            foreach(var word in list)
            {
                if (!list.Contains(word))
                {
                    dict2.Add(word, 1);
                    result2 = dict2.Keys.OrderBy(w => w).ToDictionary(w => w, w => dict2[w]);
                }
                else
                {
                    dict2[word] = dict2[word] +1;
                    result2 = dict2.Keys.OrderBy(w => w).ToDictionary(w => w, w => dict2[w]);
                }
            }
            
            
            Console.WriteLine("The word {0} apperce: {1} ",result2.Keys,result2.Values);
        }
    }
}
