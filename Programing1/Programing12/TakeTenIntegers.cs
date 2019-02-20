using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing12
{
   public class TakeTenIntegers
    {
        public int ReadNumber(int start, int end)
        {
            int number;
            int count = 1;
        Console.WriteLine("\nWrite a method ReadNumber(int start, int end) that reads an integer from the console "+
                "in the range [start…end]. In case the input integer is not valid or it is not in the required range "+
                "throw appropriate exception. Using this method, write a program that takes 10 integers a1, a2, …, a10 such that 1 < a1 < … < a10 < 100.");

            Console.WriteLine("Input an integer number: ");
            number = int.Parse(Console.ReadLine());

          
                if ((number >= end) || (number < start) || (number < count))
                {
                    throw new ArgumentOutOfRangeException();
                }
                          
            return number;
        }
        public void Print()
        {
            Console.WriteLine("Input the start range");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the end range");
            int end = int.Parse(Console.ReadLine());           
            
            try
            {
                for(int i = 0; i<= 10; i++)
                {
                    Console.WriteLine("Enter number {0} in the range[{1}...{2}] : ", i, start, end);
                    var readNumber = ReadNumber(start, end);
                }
                Console.WriteLine("{0} {1}", start, end);
            }
            catch(FormatException)
            {
                Console.WriteLine("The number is not an integer");
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("the number is not in the range");
            }
        }
    }
}
