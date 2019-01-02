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

            Scramble("rkqodlw", "world");                                      
            Console.ReadLine();
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
