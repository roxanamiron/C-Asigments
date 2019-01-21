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
            // GetCoefficients();
            //7.
            // FindTheGreats();
            //8.
            //MakeAChoise();
            //9.
            // FindSubset();
            //10.
            ApplieBonus();
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
            if (n < 10)
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
            double a = 2;
            double b = 7;
            double c = 3;
            double x, x1, x2, result;

            // x = [ -b +/- sqrt(b^2 - 4ac) ] / 2a
            double d = (b * b - 4 * a * c);
            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b + Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("Two Real Solutions: {0,8:f4} or  {1,8:f4}", x1, x2);
            }
            else if (d < 0)
            {
                d = -d;
                x = -b / (2 * a);
                result = Math.Sqrt(d) / (2 * a);
                Console.WriteLine("Two Imaginary Solutions: {0,8:f4} + {1,8:f4} i or {2,8:f4} + {3,8:f4} i", x, result, x, result);
            }
            else
            {
                x = (-b + Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("One Real Solution: {0,8:f4}", x);
            }




        }
        static void FindTheGreats()
        {
            Console.WriteLine("\n  Write a program that finds the greatest of given 5 numbers.");
            int a = 237;
            int b = 68;
            int c = 14;
            int d = 5;
            int e = 1107;

            if ((a > b) && (a > c) && (a > d) && (a > e))
            {
                Console.WriteLine("The biggest numbers is {0}", a);
            }
            if ((b > a) && (b > c) && (b > d) && (b > e))
            {
                Console.WriteLine("The biggest numbers is {0}", b);
            }
            if ((c > a) && (c > b) && (c > d) && (c > e))
            {
                Console.WriteLine("The biggest numbers is {0}", c);
            }
            if ((d > a) && (d > b) && (d > c) && (d > e))
            {
                Console.WriteLine("The biggest numbers is {0}", d);
            }
            if ((e > b) && (e > c) && (e > d) && (e > a))
            {
                Console.WriteLine("The biggest numbers is {0}", e);
            }
        }
        static void MakeAChoise()
        {
            Console.WriteLine("\nWrite a program that, depending on the user’s choice, inputs int, double or string variable. " +
                "If the variable is int or double, the program increases it by 1. If the variable is a string, the program appends \" * \" at the end." +
                "Print the result at the console. Use switch statement.");

            Console.WriteLine("Input an int(1), double(2) or a string(3): ");
            var input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("Input a int : ");
                    int input1 = int.Parse(Console.ReadLine());
                    var result1 = input1 + 1;
                    Console.WriteLine("Result  = {0}", result1);
                    break;
                case 2:
                    Console.WriteLine("Input a double : ");
                    double input2 = double.Parse(Console.ReadLine());
                    var result2 = input2 + 1;
                    Console.WriteLine("Result  = {0}", result2);
                    break;
                case 3:
                    Console.WriteLine("Input a string : ");
                    string input3 = Console.ReadLine();
                    var result3 = " * ";
                    Console.WriteLine("Result  = {0}", result3);
                    break;
                default:
                    Console.WriteLine("Input isn't right: ");
                    break;
            }
        }
        static void FindSubset()
        {
            Console.WriteLine("\nWe are given 5 integer numbers. Write a program that finds those subsets whose sum is 0. Examples:"+
                                "- If we are given the numbers { 3, -2, 1, 1, 8}, the sum of - 2, 1 and 1 is 0."+
                                "- If we are given the numbers { 3, 1, -7, 35, 22}, there are no subsets with sum 0.");

            Console.WriteLine("Input an integer: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input another integer: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Input another integer: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Input another integer: ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Input another integer: ");
            int e = int.Parse(Console.ReadLine());



            if (a + b == 0)
            {
                Console.WriteLine("{0} + {1} = 0",a,b);
            }
            if (a + c == 0)
            {
                Console.WriteLine("{0} + {1} = 0", a, c);
            }
            if (a + d == 0)
            {
                Console.WriteLine("{0} + {1} = 0", a, d);
            }
            if (a + e == 0)
            {
                Console.WriteLine("{0} + {1} = 0", a, e);
            }
            if (b + c == 0)
            {
                Console.WriteLine("{0} + {1} = 0", b,c);
            }
            if (b + d == 0)
            {
                Console.WriteLine("{0} + {1} = 0",b,d);
            }
            if (b + e == 0)
            {
                Console.WriteLine("{0} + {1} = 0", b, e);
            }
            if (c + d == 0)
            {
                Console.WriteLine("{0} + {1} = 0", c, d);
            }
            if (c + e == 0)
            {
                Console.WriteLine("{0} + {1} = 0", c, e);
            }
            if (d + e == 0)
            {
                Console.WriteLine("{0} + {1} = 0", d, e);
            }
            if (a + b + c == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, b,c);
            }
            if (a + b + d == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, b, d);
            }
            if (a + b + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, b, e);
            }
            if (a + c + d == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, c, d);
            }
            if (a + c + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, c, e);
            }
            if (a + d + b == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, d, b);
            }
            if (a + d + c == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, d, c);
            } 

            if (b + c + d == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", b, c, d);
            }
            if (b + d + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", b, d, e);
            }
            if (c + b + d == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", c, b, d);
            }
            if (c + d + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", e, d, e);
            }
            if (d + e + a == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", d, e, a);
            }
            if (d + a + b == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", d, a, b);
            }
            if (a + b + c + d == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, d);
            }
            if (a + b + c + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, e);
            }
            if (a + b + d + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, d, e);
            }
            if (a + c + b + d == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, c, b, d);
            }
            if (a + c + d + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, c, d, e);
            }
            else
            {
                Console.WriteLine("The numbers are not equal to zero");
            }
        }
        static void ApplieBonus()
        {
            Console.WriteLine("\nWrite a program that applies bonus points to given scores in the range [1…9] by the following rules:"+
                            "- If the score is between 1 and 3, the program multiplies it by 10."+
                            "- If the score is between 4 and 6, the program multiplies it by 100."+
                            "- If the score is between 7 and 9, the program multiplies it by 1000."+
                            "- If the score is 0 or more than 9, the program prints an error message.");


            Console.WriteLine("Enter the score: ");
            var score = int.Parse(Console.ReadLine());

            switch(score)
            {
                case 0:
                    Console.WriteLine("error message");
                    break;
                case 1:                   
                case 2:
                case 3:
                    Console.WriteLine(" If the score is between 1 and 3, the result is = {0}",score *10);
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine(" If the score is between 4 and 6, the result is = {0}", score * 100);
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine(" If the score is between 7 and 9, the result is = {0}", score * 1000);
                    break;
                case 10:
                    Console.WriteLine("error message");
                    break;
            }

        }
    }
}
