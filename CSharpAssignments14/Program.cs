using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments14
{
    public class Program
    {
        static IEnumerable<int> list = Enumerable.Range(1, 100);
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

            //firstElement();

            //fifthElement();

            //evenNumbers();

            //firstTen();

            //otherNumbers();

            //elementsFrom11();

            //exeptElement();

            divideByTen();
           

            Console.ReadLine();
        }

        private static void divideByTen()
        {
            var result = list.FirstOrDefault(x => x % 10 == 0);

            Console.WriteLine("first element: {0}", result);
        }

        private static void elementsFrom11()
        {
            var list2 = list.Skip(10);
            foreach (var numb in list2)
            {
                Console.WriteLine(numb);
            }
        }

        static void firstElement()
        {

            var firstelement = list.First();

            //foreach (int no in firstelement)
            {
                Console.WriteLine("first element: {0}", firstelement);
            }
        }

        static void fifthElement()
        {
            var fifthElement = list.ElementAt(4);

            Console.WriteLine($"The 5-th elements {fifthElement}");


        }

        static void evenNumbers()
        {
            var evenNumbers = list.Where(x => x % 2 == 0);
            foreach (var numb in evenNumbers)
            {
                Console.WriteLine(numb);
            }
        }

        static void firstTen()
        {
            var firstTen = list.Take(10);
            foreach (var x in firstTen)
            {
                Console.WriteLine($"First 10 numbers are :{x}");
            }

        }

        static void otherNumbers()
        {
            var otherNumbers = list.Skip(79).Take(10);
            foreach (var other in otherNumbers)
            {
                Console.WriteLine($"Elements from 80 - 90 : {other}");
            }

        }

        static void exeptElement()
        {
            var list1 = list.Take(9).Union(list.Skip(10));
            
            //int[] no = { 10 };
            //IEnumerable<int> exeptElement = list.Except(no);
            foreach (var ex in list1)
            {
                Console.WriteLine($"All elements except the 10 - th : {ex}");
            }

        }
    }
}
