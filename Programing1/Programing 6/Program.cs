using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            PrintNumbers();
            //2.
            PrintNotDivizibile();
            //3.
            PrintSmallestAndGreatest();
            //4.
            PrintPossibilities();
            //5.
            PrintSum();
            //6.
            CalculateFactorial();
            //7.
             CalculateFactorial2();
            //8.
             CalculateCatalanNumbers();
            //9.
            CalculateTheSum();
            //10.
            PrintMatrix();
            //11.
            Calculate();
            //12.
            ConvertDecimalToBinary();
            //13.
            ConvertBinaryToDecimal();
            //14.
            ConvertDecimalToHexa();
            //15.
            ConvertHexaToDecimal();
            //16.
            PrintRandomOrder();
            //17.
            FindLCM();
          

            Console.ReadLine();
        }
        static void PrintNumbers()
        {
            Console.WriteLine("\nWrite a program that prints on the console the numbers from 1 to N. The number N should be read from the standard input.");

            Console.WriteLine("Input n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i + " ");
            }
        }
        static void PrintNotDivizibile()
        {
            Console.WriteLine("Write a program that prints on the console the numbers from 1 to N, " +
                "which are not divisible by 3 and 7 simultaneously. The number N should be read from the standard input.");

            Console.WriteLine("n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)

            {
                if (i % (3 * 7) != 0)
                    Console.WriteLine(i);
            }
        }
        static void PrintSmallestAndGreatest()
        {
            Console.WriteLine("\nWrite a program that reads from the console a series of integers and prints the smallest and largest of them.");
            Console.WriteLine("Counter = ");
            int counter = int.Parse(Console.ReadLine());
            int smallest = 0;
            int largest = 0;

            for (int i = 0; i <= counter; i++)
            {
                Console.WriteLine("Input number = ");
                int number = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    smallest = largest = number;
                }
                else
                {
                    if (smallest > number)
                    {
                        smallest = number;
                    }
                    if (largest < number)
                    {
                        largest = number;
                    }
                }
                Console.WriteLine("Smalest {0}, Largest {1}", smallest, largest);
            }
        }
        static void PrintPossibilities()
        {
            Console.WriteLine("\nWrite a program that prints all possible cards from a standard deck of cards, " +
                "without jokers (there are 52 cards: 4 suits of 13 cards).");

            //deci avem 52 de carti intr-un pachet de carti : numaratoarea incepe de la {1...14}
            //si avem 4 seturi de culori : inima - 1, romb = 2, trefla = 3, frunza = 4

            for (int cards = 2; cards <= 14; cards++)
            {
                for (int suits = 1; suits <= 4; suits++)
                {
                    Console.WriteLine("Card {0}, Suits {1}", cards, suits);
                }
            }
        }
        static void PrintSum()
        {
            Console.WriteLine("\n Write a program that reads from the console number N and print the sum " +
                "of the first N members of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …");

            Console.WriteLine("n = ");
            int n = int.Parse(Console.ReadLine());
            int result = 0;
            int firstNr = 1;
            int secondNr = 1;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                result = firstNr + secondNr;
                firstNr = secondNr;
                secondNr = result;
                sum += result;
                Console.WriteLine("Sum = {0}", sum);
            }


        }
        static void CalculateFactorial()
        {
            Console.WriteLine("\nWrite a program that calculates N!/K! for given N and K (1<K<N).");

            Console.WriteLine("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("k = ");
            int k = int.Parse(Console.ReadLine());
            int factorial1 = 1;
            int factorial2 = 1;

            for (int i = n; n > 1; n--)
            {
                if (k > 1)
                {
                    factorial1 *= k;
                    k--;
                }

                factorial2 *= n;
                Console.WriteLine("N! = {0}, K! = {1}", factorial2, factorial1);
                var result = factorial2 / factorial1;
                Console.WriteLine("N!/K! = {0}", result);
            }
        }
        static void CalculateFactorial2()
        {
            Console.WriteLine("\nWrite a program that calculates N!*K!/(N-K)! for given N and K (1<K<N).");

            Console.WriteLine("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("k = ");
            int k = int.Parse(Console.ReadLine());
            int factorial1 = 1;
            int factorial2 = 1;
            int factorial3 = 1;

            for (int i = n; n > 1; n--)
            {
                if (k > 1)
                {
                    factorial1 *= k;
                    k--;
                }

                factorial2 *= n;
                Console.WriteLine("N! = {0}, K! = {1}", factorial2, factorial1);
                factorial3 *= (n - k);
                var result = (factorial2 * factorial1) / factorial3;
                Console.WriteLine("N!*K!/(N-K)! = {0}", result);
            }
        }
        static void CalculateCatalanNumbers()
        {
            Console.WriteLine("\nIn combinatorics, the Catalan numbers are calculated by the following formula: ..." +
                ", for n ≥ 0. Write a program that calculates the nth Catalan number by given n.");

            Console.WriteLine("n = ");
            int n = int.Parse(Console.ReadLine());
            int factorial1 = n + 1;
            int factorial2 = 2 * n;


            for (int i = factorial2; i > 0; i--)
            {
                factorial2 *= i;
            }
            for (int i = factorial1; i > 0; i--)
            {
                factorial1 *= i;
            }
            for (int i = n - 1; i > 0; i--)
            {
                n *= i;
            }
            var result = factorial2 / (factorial1 * n);
            Console.WriteLine(" Result = {0}", result);

        }
        static void CalculateTheSum()
        {
            Console.WriteLine("\n Write a program that for a given integers n and x, calculates the sum: " +
                " S = 1 + 1!/x + 2!/x2+...+n!/xn ");
            Console.WriteLine("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("x = ");
            int x = int.Parse(Console.ReadLine());
            int factorialN = 1;
            int powerX = 1;
            int sum = 0;

            for (int i = n; i > 0; i--)
            {
                if (x > 0)
                {
                    factorialN *= n;
                    powerX *= x;
                }
                sum += (factorialN / powerX);
            }
            Console.WriteLine("Sum = {0}", sum);
        }
        static void PrintMatrix()
        {
            Console.WriteLine("\nWrite a program that reads from the console a positive integer " +
                "number N (N < 20) and prints a matrix of numbers as on the figures below:");
            Console.WriteLine("Input a positive integer < 20: ");
            int numb = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");


            for (int i = 1; i <= numb; i++)
            {
                for (int j = i; j <= numb + 1; j++)
                {

                    Console.WriteLine(j);

                }
                Console.WriteLine();
            }
        }
        static void Calculate()
        {
            Console.WriteLine("\nWrite a program that calculates with how many zeroes the factorial of a given number ends. Examples:" +
                                "N = 10->N! = 3628800-> 2,    N = 20->N! = 2432902008176640000-> 4");
            Console.WriteLine("n= ");
            int n = int.Parse(Console.ReadLine());
            var factorial = 1;
            var zeroes = 0;

            while (true)
            {
                if (n <= 1)
                {
                    break;
                }
                factorial *= n;
                n--;
            }
            Console.WriteLine("n! = " + factorial);

            while (factorial % 10 == 0) 
            {
                factorial /= 10;
                zeroes++;                
            }  

            Console.WriteLine("with {0} zeroes.", zeroes);
        }
        static void ConvertDecimalToBinary()
        {
            Console.WriteLine("\nWrite a program that converts a given number from decimal to binary notation (numeral system).");

            Console.WriteLine("Input a number = ");
            var n = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(n, 2);         

           
            Console.WriteLine("The decimal number {0} converted to binary notation is = {1}",n,binary);
        }
        static void ConvertBinaryToDecimal()
        {
            Console.WriteLine("\n Write a program that converts a given number from binary to decimal notation.");
            Console.WriteLine("input a binary number : ");
            string binary = Console.ReadLine();
            var n = Convert.ToInt32(binary, 2).ToString();

            Console.WriteLine("The bynary number {0} converted to decimal is = {1}", binary, n);
        }
        static void ConvertDecimalToHexa()
        {
            Console.WriteLine("\n Write a program that converts a given number from decimal to hexadecimal notation.");
            Console.WriteLine("Enter a decimal number : ");
            string numb = Console.ReadLine();
            var hex = Convert.ToInt32(numb,10);

            Console.WriteLine("hexadecimal notation {0:x}",hex);

        }
        static void ConvertHexaToDecimal()
        {
            Console.WriteLine("\nWrite a program that converts a given number from hexadecimal to decimal notation.");
            Console.WriteLine("enter a hexadecimal notation: ");
            string hexa = Console.ReadLine();
            string toDecimal = Convert.ToString(Convert.ToInt32(hexa, 16), 10);

            Console.WriteLine("decimal notation = " + toDecimal);
        }
        static void PrintRandomOrder()
        {
            Console.WriteLine("\nWrite a program that by a given integer N prints the numbers from 1 to N in random order.");

            Console.WriteLine(" n = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            var rand = new Random();
            int randNo = 1;

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }

            foreach(var number in arr)
            {
                randNo = rand.Next(1, n);
                var sec = arr[number];
                arr[number] = arr[randNo];
                arr[randNo] = sec;
                Console.WriteLine(arr[randNo]);
            }           
        }
        static void FindLCM()
        {
            Console.WriteLine("\nWrite a program that given two numbers finds their greatest common divisor "+
                "(GCD) and their least common multiple (LCM). You may use the formula LCM(a, b) = |a*b| / GCD(a, b).");

            Console.WriteLine(" a = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(" b = ");
            int b = int.Parse(Console.ReadLine());
            var multiple = (a*b);
       

            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }


                else
                {
                    b %= a;
                }
            }

            if (a == 0)
            {
                var LCM = multiple / b;
                Console.WriteLine("LCM =" + LCM);
            }
            else
            {
                var LCM = multiple / a;
                Console.WriteLine("LCM = " + LCM);
            }

        }
    }
}
