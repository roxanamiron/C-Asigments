using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Programing13
{
   public class UsingRegularExpression
    {
        private static string str;       

        public void Display()
        {
            Console.WriteLine("\nWrite a program that reads a string from the console (20 characters maximum)"+
                "and if shorter complements it right with \" * \" to 20 characters.");

            StringBuilder builder = new StringBuilder(20);
            Console.WriteLine("\nEnter a string (20 character max): ");
            str = Console.ReadLine();

            if (str.Length <= 20)
            {
                builder.Append(str);               
                builder.Append('*', (20 - str.Length-1));
                Console.WriteLine("The string is shorter then 20 character: {0}",builder);
            }
           else if(str.Length > 20)
            {
                Console.WriteLine("The string is gretear then 20 character, please insert another! ");
                Console.WriteLine("\nEnter a string (20 character max): ");
            }
           else
            {
                Console.WriteLine(str);
            }           
        }
    }
}
