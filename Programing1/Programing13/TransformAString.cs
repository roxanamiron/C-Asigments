using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Programing13
{
    public class TransformAString
    {
        private static string word;
        private static int convertedString;

        public void ConvertTheString()
        {
            Console.WriteLine("\nWrite a program that converts a given string into the form of array "+
                "of Unicode escape sequences in the format used in the C# language. "+
                "Sample input: \"Test\". Result: \"\u0054\u0065\u0073\u0074\".");

            Console.WriteLine("\nInsert a word: ");
            word = Console.ReadLine();
            for(int i= 0; i< word.Length; i++)
            {
                convertedString = word[i];
                Console.WriteLine("\\u{0:x4}\\",convertedString);
            }

        }
    }
}
