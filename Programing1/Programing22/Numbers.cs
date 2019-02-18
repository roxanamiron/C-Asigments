using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing22
{
  public static class Numbers 
    {
        public static void PrintNumbers(this IEnumerable numbers)
        {
            Console.WriteLine("\n Write a program that prints to the console all numbers from a given array"+
                "(or list), that are multiples of 7 and 3 at the same time. Use the built-in extension methods"+
                "with lambda expressions and then rewrite the same using a LINQ query.");         

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
