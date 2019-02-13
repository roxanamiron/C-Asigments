using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing16
{
    public class SortedNumbers
    {
        private string numb;
        List<int> list = new List<int>();
        int[] array = new int[] { };

        public void ReadNumbers()
        {
            Console.WriteLine("\n  Write a program that reads from the console a sequence of positive integer numbers."+
                "The sequence ends when an empty line is entered. Print the sequence sorted in ascending order.");

            Console.WriteLine("\nEnter a positive integer numbers : ");

            do
            {
                numb = Console.ReadLine();
                if (numb == "")
                    break;
                int number = Convert.ToInt32(numb);
                list.Add(number);

            } while (numb != string.Empty);

            SortAscendingOrder(list);
        }

        private void SortAscendingOrder(List<int> listNumbers)
        {
            int smallest = 0;

            int[] array = listNumbers.ToArray();

            for (int i = 0; i < array.Length - 1; i++)
            {
                smallest = i;
                for (int index = i + 1; index < array.Length; index++)
                {
                    if (array[index] < array[smallest])
                    {
                        smallest = index;
                    }
                }
                if (array[smallest] != i)
                {
                    var temporary = array[i];
                    array[i] = array[smallest];
                    array[smallest] = temporary;
                }
            }
            foreach (var nr in array)
            {
                Console.WriteLine("Numbers in decreasing order: ");
                Console.WriteLine(nr + " ");
            }
        }
    }
}
