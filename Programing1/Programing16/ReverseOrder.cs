using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing16
{
   public class ReverseOrder
    {
        private string numb;
        Stack<int> stack = new Stack<int>();

        public void ReadNumbers()
        {
            Console.WriteLine("\nWrite a program, which reads from the console N integers and prints them in reversed order. Use the Stack<int> class.");
            Console.WriteLine("\nEnter a positive integer numbers : ");

            do
            {
                numb = Console.ReadLine();
                if (numb == "")
                    break;
                int number = Convert.ToInt32(numb);
                stack.Push(number);

            } while (numb != string.Empty);

            PrintInReverseOrder();
        }

        private void PrintInReverseOrder()
        {
           while(stack.Count > 0)
            {
                int printNumber = stack.Pop();
                Console.WriteLine(printNumber);
            }
        }
    }
}
