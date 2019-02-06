using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing13
{
   public class ListOfWords
    {

        public void PrintTheList()
        {
            Console.WriteLine("\nWrite a program that reads a list of words separated by commas "+
                "from the console and prints them in alphabetical order (after sorting).");

            Console.WriteLine("Enter a list of words, separated by commas: ");
            var list = Console.ReadLine().Split(',');
            var result = list.OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
