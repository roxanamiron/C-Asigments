using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing16
{
   public class SequenceOfPositiveNumbers
    {
        private List<int> list = new List<int>();
        private int sum = 0;
        private double average = 0;
        private string numb;

        private void ReadTheNumbers()
        {
            Console.WriteLine("\nEnter a positive integer numbers : ");

            do
            {
                numb = Console.ReadLine();
                if (numb == "")
                    break;
                int number = Convert.ToInt32(numb);
                list.Add(number);

            } while (numb != string.Empty);

            CalculatetheNumbers(list);
        }

        private void CalculatetheNumbers(List<int> list)
        {
            int length = list.Count - 1;
            foreach(var nr in list)
            {
                sum += nr;
            }
            average = sum / length;
        }

        public void PrintTheSumAndAverage()
        {
            Console.WriteLine(" Write a program that reads from the console a sequence of positive integer numbers." +
                "The sequence ends when empty line is entered. Calculate and print the sum and the average of the " +
                "sequence. Keep the sequence in List<int>.");

            ReadTheNumbers();
            Console.WriteLine("Sum = {0} ", sum);
            Console.WriteLine("average = {0}", average);
        }
    }
}
