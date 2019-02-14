using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing16
{
   public class OddNumbers
    {
        List<int> list = new List<int>{ 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

        public void RemoveOddTimes()
        {
            Console.WriteLine("\nWrite a program that removes from a given sequence all numbers that appear an odd count of times.");

            Dictionary<int, int> dict = new Dictionary<int, int>();

            dict = list.GroupBy(x => x).ToDictionary(p => p.Key, n => n.Count());

           var list2 = list.FindAll(n => dict[n] % 2 == 0);          

            Console.WriteLine(string.Join(" ",list2));
        }
    }
}
