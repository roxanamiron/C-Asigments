using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. https://www.codewars.com/kata/scramblies
            //Complete the function scramble(str1, str2) that returns true if a portion of str1 characters can be rearranged to match str2,
            //otherwise returns false.
            // Notes:
            //   Only lower case letters will be used(a-z). No punctuation or digits will be included.
            //Performance needs to be considered

            //Scramble("rkqodlw", "world");   
            UsingDisctionary();                    
            Console.ReadLine();
        }

        static void UsingDisctionary()
        {
            Console.WriteLine("\nFirst string str1: \n");
            Dictionary<string, int> str1 = new Dictionary<string, int>();
            str1.Add("n", 1);
            str1.Add("o", 1);
            str1.Add("t", 1);
            str1.Add("e", 1);
            str1.Add("s", 1);
            foreach(KeyValuePair<string,int> item in str1)
                Console.WriteLine("Letter {0} appers {1}",item.Key,item.Value);

            Console.WriteLine("\nSecond string str2: \n");
            Dictionary<string, int> str2 = new Dictionary<string, int>();
            str2.Add("t", 1);
            str2.Add("o", 1);
            str2.Add("n", 1);
            str2.Add("e", 1);
            str2.Add("s", 2);
            foreach (KeyValuePair<string, int> item in str2)
                Console.WriteLine("Letter {0} appers {1}", item.Key, item.Value);

            Console.WriteLine("\nCompare the two strings \n");
            foreach(var letter in str1.Keys)
            {
                if(str1[letter].Equals(str2[letter]))
                {
                    Console.WriteLine(letter);
                }
                else
                {
                    str1.Add(letter, 1);
                }
            }

        }






        static void Scramble(string str1, string str2)
        {
            foreach(char s in str1)
            {
                if (!Char.IsLetter(s))
                    Console.WriteLine("Only lower case letters will be used (a-z)");
            }
            foreach(char s in str2)
            {
                if (!Char.IsLetter(s))
                    Console.WriteLine("Only lower case letters will be used (a-z)");
            }
            
            Console.WriteLine("Compare the two strings");
            if (str1.ToLower().Contains(str2.ToLower()))
                Console.WriteLine($"scramble({str1},{str2}) == true");
            else
                Console.WriteLine($"scramble({str1},{str2}) == true");

        }
    }
}
