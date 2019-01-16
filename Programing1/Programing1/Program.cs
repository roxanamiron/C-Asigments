using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing1
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
            PrintNumbers();
           
            Currentdate();
            
            SquareMethod();
            
            FirstMembers();
           
            PrintAndReadAge();

            Console.ReadLine();
        }

        public static void PrintNumbers()
        {
            Console.WriteLine("\nWrite a program that prints the following numbers on the console 1, 101, 1001, each on a new line.");
            Console.WriteLine("\n1\n\n101\n\n1001\n");
        }
        public static void Currentdate()
        {
            Console.WriteLine("\nWrite a program that prints on the console the current date and time.");
            var currentDate = DateTime.Now;
            Console.WriteLine("\n{0}", currentDate);
        }
        public static void SquareMethod()
        {
            Console.WriteLine("\nWrite a program that prints the square root of 12345.");
            int numb = 12345;
            //1.
            double squareRoot = Math.Sqrt(numb);
            Console.WriteLine("\n 1.the square root is : {0}", squareRoot);

            //2.
            var square = 1;
            int i = 0;
            while (true)
            {
                i = i + 1;
                square = (numb / square + square) / 2;
                if (i == numb + 1)
                {
                    break;
                }
            }
            Console.WriteLine("\n2.square = {0}", square);


        }
        public static void FirstMembers()
        {
            Console.WriteLine("\nWrite a program that prints the first 100 members of the sequence 2, -3, 4, -5, 6, -7, 8.");
            int[] array = { 2, -3, 4, -5, 6, -7, 8 };
            int numberPrint;
            for (int i = 2; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    numberPrint = i;
                }
                else
                {
                    numberPrint = i * (-1);
                }
                Console.WriteLine(numberPrint);
            }
            
        }
        public static void PrintAndReadAge()
        {
            Console.WriteLine("\nWrite a program that reads your age from the console and prints your age after 10 years.");
            int age = 33;
            
            Console.WriteLine("\nMy age is :{0} years old.",age);
            int oldAge = age + 10;
            Console.WriteLine("\n My age after 10 years old is:{0}",oldAge);


        }
    }
}
