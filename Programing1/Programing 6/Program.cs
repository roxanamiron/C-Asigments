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
            //PrintNumbers();
            //2.
            // PrintNotDivizibile();
            //3.
            // PrintSmallestAndGreatest();
            //4.
            //PrintPossibilities();
            //5.
            //PrintSum();
            //6.
            // CalculateFactorial();
            //7.
            // CalculateFactorial2();
            //8.
            // CalculateCatalanNumbers();
            //9.
            //CalculateTheSum();
            //10.
            PrintMatrix();
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

            for(int i = 0; i <= counter; i++)
            {
                Console.WriteLine("Input number = ");
                int number = int.Parse(Console.ReadLine());
                if(i == 0)
                {
                    smallest = largest = number;
                }
                else
                {
                    if(smallest > number)
                    {
                        smallest = number;
                    }
                    if(largest < number)
                    {
                        largest = number;
                    }
                }
                Console.WriteLine("Smalest {0}, Largest {1}",smallest,largest);
            }
        }
        static void PrintPossibilities()
        {
            Console.WriteLine("\nWrite a program that prints all possible cards from a standard deck of cards, "+
                "without jokers (there are 52 cards: 4 suits of 13 cards).");

            //deci avem 52 de carti intr-un pachet de carti : numaratoarea incepe de la {1...14}
            //si avem 4 seturi de culori : inima - 1, romb = 2, trefla = 3, frunza = 4

            for(int cards = 2; cards <= 14; cards ++ )
            {
                for(int suits = 1; suits <= 4; suits ++)
                {
                    Console.WriteLine("Card {0}, Suits {1}", cards, suits);
                }
            }
        }
        static void PrintSum()
        {
            Console.WriteLine("\n Write a program that reads from the console number N and print the sum "+
                "of the first N members of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …");

            Console.WriteLine("n = " );
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
                Console.WriteLine("Sum = {0}",sum);
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

            for (int i = n; n > 1; n --)
            {
                if(k > 1)
                {
                    factorial1 *= k;
                    k--;
                }
               
                factorial2 *= n;
                Console.WriteLine("N! = {0}, K! = {1}", factorial2, factorial1);
                var result = factorial2/factorial1;
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
            Console.WriteLine("\nIn combinatorics, the Catalan numbers are calculated by the following formula: ..."+
                ", for n ≥ 0. Write a program that calculates the nth Catalan number by given n.");

            Console.WriteLine("n = ");
            int n = int.Parse(Console.ReadLine());
           int factorial1 = n + 1;
          int factorial2 = 2 * n;


           for(int i = factorial2; i > 0; i--)
            {
                factorial2 *= i;
            }
           for(int i = factorial1; i > 0; i--)
            {
                factorial1 *= i;
            }
           for(int i = n-1; i >0; i--)
            {
                n *= i;
            }
           var result = factorial2/ (factorial1 * n);
            Console.WriteLine(" Result = {0}", result);

        }
        static void CalculateTheSum()
        {
            Console.WriteLine("\n Write a program that for a given integers n and x, calculates the sum: "+
                " S = 1 + 1!/x + 2!/x2+...+n!/xn ");
            Console.WriteLine("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("x = ");
            int x = int.Parse(Console.ReadLine());
           int factorialN = 1;
            int powerX = 1;
            int sum = 0;

            for(int i = n; i > 0; i--)
            {
                if(x > 0)
                {
                    factorialN *= n;
                    powerX *= x  ;                    
                }
                sum += (factorialN/powerX);               
            }
            Console.WriteLine("Sum = {0}", sum);
        }
        static void PrintMatrix()
        {
            Console.WriteLine("\nWrite a program that reads from the console a positive integer "+
                "number N (N < 20) and prints a matrix of numbers as on the figures below:");
            Console.WriteLine("Input a positive integer < 20: ");
            int numb = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");


            for(int i = 1; i <= numb; i++)
            {               
                for(int j = i + 1; j <= numb +1; j ++)
                {
                    for(int z = j +1; z <= numb + 2; z++)
                    {
                        Console.WriteLine(i + " " + j + " " + z);
                        //Console.WriteLine(z);
                    }
                   // Console.WriteLine(" " + j);

                }
               // Console.WriteLine(" " + " " + i);
            }
        }
    }
}
