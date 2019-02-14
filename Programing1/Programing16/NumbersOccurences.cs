using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing16
{
   public class NumbersOccurences
    {
        int[] array = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

        public void FindOccurence()
        {
            Console.WriteLine("\nWrite a program that finds in a given array of integers (in the range [0…1000]) how many times each of them occurs.");

            Dictionary<int, int> disctionary = new Dictionary<int, int>();

            disctionary = array.GroupBy(x => x).ToDictionary(p => p.Key, n => n.Count());

            foreach(var nr in disctionary)
            {
                Console.WriteLine(string.Format("{0} -> {1}",nr.Key,nr.Value));
            }
        }
    }
}
