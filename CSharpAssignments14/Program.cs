using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments14
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create a list with numbers from 1 to 100.
            // Display on console each of the above (please use linq expressions and not for or foreaches)
            // 1) First element
            //2) 5 - th element
            //3) All even numbers
            //4) First 10 elements
            //5) Elements from 80 - 90
            //6) All elements except the 10 - th



            IEnumerable<int> list = Enumerable.Range(1, 100);

            //foreach(int no in list)
            //{
            //    Console.WriteLine(no);
            //}

            var firstelement = list.First();
            Console.WriteLine($"First Element : {firstelement}");

            var fifthElement = list.Take(5).ToList();
            Console.WriteLine($"The 5-th elements {fifthElement}");

            var evenNumbers = list.Select(x => x % 2 == 0);
            foreach(var numb in evenNumbers)
            {
                Console.WriteLine(numb);
            }
            
            var firstTen = list.Take(10);
            Console.WriteLine($"First 10 numbers are :{firstTen}");

            var otherNumbers = from values in list
                               where (values >= 80 && values <= 90)
                               select new { ValuesBetween = values };
            var otherNumbers2 = list.LongCount(x => 80 >= 90);
            Console.WriteLine($"Elements from 80 - 90 : {otherNumbers}");


            var exeptElement = list.Take(list.Count() - 90);
            Console.WriteLine($"All elements except the 10 - th : {exeptElement}");



            Console.ReadLine();
        }

    }
}
