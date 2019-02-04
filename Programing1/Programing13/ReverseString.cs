using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing13
{
    public class ReverseString
    {
        private static string original = "introduction";
        private static string reverse = ReverseS(original);
     

        public static string ReverseS(string original)
        {
            StringBuilder buider = new StringBuilder();
            for(int i = original.Length -1; i >= 0; i--)
            {
                buider.Append(original[i]);
            }
            return buider.ToString();           
        }
        public void Display()
        {
            Console.WriteLine("\n Write a program that reads a string, reverse it and prints it to the console. For example: \"introduction\" à \"noitcudortni\".");
            var result = ReverseS(original);
            Console.WriteLine(result);
        }
    }
}
