using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing12
{
   public class SquareRootOfInteger
    {
        private double number;
        public double square;
        public double PrintSquare()
        {
            Console.WriteLine("\n  Write a program that takes a positive integer from the console and prints the square "+
                "root of this integer. If the input is negative or invalid print \"Invalid Number\" in the console. In all cases print \"Good Bye\".");

            Console.WriteLine("\nInput a integer number : ");
            number = double.Parse(Console.ReadLine());


            try
            {
                if(number > 0)
                {
                    square = Math.Sqrt(number);
                    Console.WriteLine("the square number is {0}", square);
                }
            }
            catch(ArgumentOutOfRangeException excep)
            {
                if (number < 0) 
                {
                    Console.WriteLine("invalid number");
                    Console.WriteLine(excep.Message);
                }
            }
            finally
            {
                Console.WriteLine("Good Bye");

            }
            return square;
        }
    }
}
