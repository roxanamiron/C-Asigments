using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing5
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
           // ExchangeValues();
            //2.
           // PrintSigns();
            //3.
           // FindTheBiggest();
            //4.
           // Sort();
            //5.
            //ShowTheDigit();
            //6.

            Console.ReadLine();
        }
        static void ExchangeValues()
        {
            Console.WriteLine("\nWrite an if-statement that takes two integer variables and exchanges " +
                "their values if the first one is greater than the second one.");
            int a = 4;
            int b = 10;
            if (a > b)
            {
                Console.WriteLine(a = b);
            }
            else
            {
                Console.WriteLine(b = a);
            }
        }
        static void PrintSigns()
        {
            Console.WriteLine("\n Write a program that shows the sign (+ or -) of the product " +
                "of three real numbers, without calculating it. Use a sequence of if operators.");
            char sign = ' ';


            int a = 6;
            int b = -7;
            int c = 3;
            if (a > 0)
            {
                Console.WriteLine("+{0}", a);
            }
            else
            {
                Console.WriteLine("{0}", a);
            }
            if (b > 0)
            {
                Console.WriteLine("+{0}", b);
            }
            else
            {
                Console.WriteLine("{0}", b);
            }
            if (c > 0)
            {
                Console.WriteLine("+{0}", c);
            }
            else
            {
                Console.WriteLine("{0}", c);
            }

        }
        static void FindTheBiggest()
        {
            Console.WriteLine("\nWrite a program that finds the biggest of three integers, using nested if statements.");
            int a = 6;
            int b = 25;
            int c = 38;

            if ((a > b) && (a > c))
            {
                Console.WriteLine("The biggest numbers is {0}", a);
            }
            if ((b > a) && (b > c))
            {
                Console.WriteLine("The biggest numbers is {0}", b);
            }
            if ((c > a) && (c > b))
            {
                Console.WriteLine("The biggest numbers is {0}", c);
            }
        }
        static void Sort()
        {
            Console.WriteLine("\nSort 3 real numbers in descending order. Use nested if statements.");
            int a = 20;
            int b = 15;
            int c = 98;

            if ((a > b) && (a > c))
            {
                if (b > c)
                {
                    Console.WriteLine("{0},{1},{2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{0},{1},{2}", a, c, b);
                }
            }
            else if ((b > a) && (b > c))
            {
                if (a > c)
                {
                    Console.WriteLine("{0},{1},{2}", b, a, c);
                }
                else
                {
                    Console.WriteLine("{0},{1},{2}", b, c, a);
                }
            }
            else if ((c > b) && (c > b))
            {
                if (a > b)
                {
                    Console.WriteLine("{0},{1},{2}", c, a, b);
                }
                else
                {
                    Console.WriteLine("{0},{1},{2}", c, b, a);
                }
            }

        }
        static void ShowTheDigit()
        {
            Console.WriteLine("\nWrite a program that asks for a digit (0-9), and depending on the input," +
                "shows the digit as a word (in English). Use a switch statement.");
            int n = 0;
            if(n < 10)
            {
                Console.WriteLine("input a digit: ");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 0:
                        Console.WriteLine("zero");
                        break;
                    case 1:
                        Console.WriteLine("One");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 3:
                        Console.WriteLine("Tree");
                        break;
                    case 4:
                        Console.WriteLine("four");
                        break;
                    case 5:
                        Console.WriteLine("five");
                        break;
                    case 6:
                        Console.WriteLine("six");
                        break;
                    case 7:
                        Console.WriteLine("seven");
                        break;
                    case 8:
                        Console.WriteLine("eight");
                        break;
                    case 9:
                        Console.WriteLine("nine");
                        break;
               }
                Console.WriteLine(n);
            }
        }
        static void GetCoefficients()
        {
            Console.WriteLine("\nWrite a program that gets the coefficients a, b and c of a quadratic equation: ax2 + bx + c," +
                "calculates and prints its real roots(if they exist). Quadratic equations may have 0, 1 or 2 real roots.");

        }
    }
}
