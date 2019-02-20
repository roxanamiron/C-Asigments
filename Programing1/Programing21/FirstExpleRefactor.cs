using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing21
{
    public class FirstExpleRefactor
    {
        public void RefactorMethod()
        {
            Console.WriteLine("\nTake the code from the first example in this chapter and refactor it to meet the quality standards discussed in this chapter.");
            int value = 010;
            int secondValue = 5;

            Console.WriteLine("Loop!");

            switch (value)
            {
                case 1:
                    int thirdValue = 5;
                    Console.WriteLine(thirdValue);
                    break;
                case 2:
                    secondValue = 0;
                    break;
                case 3:
                    Console.WriteLine("8 ");
                    break;
                default:
                    Console.WriteLine("Default: ");
                    {
                        Console.WriteLine("Hoho ");
                    }
                    for (int k = 0; k < secondValue; k++)
                    {
                        Console.WriteLine(k - 'f');
                    }
                    break;
            }
        }
    }
}
