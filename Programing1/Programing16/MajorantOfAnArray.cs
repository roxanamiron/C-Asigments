using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing16
{
   public class MajorantOfAnArray
    {
        int[] array = { 2, 2, 3, 3, 2, 3, 4, 3, 3 };

        public void FindMajorant()
        {
            Console.WriteLine("\nThe majorant of an array of size N is a value that occurs in it at least N/2 + 1 times."+
                "Write a program that finds the majorant of given array and prints it. If it does not exist, print "+
                "\"The majorant does not exist!\".");

            try
            {
                var majorant = array.GroupBy(x => x).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).First();

                Console.WriteLine(majorant);
            }
            catch(Exception ex)
            {
                Console.WriteLine("The majorant does not exist!" ,ex.Message);
            }
            


            
        }
    }
}
