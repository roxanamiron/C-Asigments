using System;

namespace Programing_6
{
    public class Loop
    {
       public void Method()
        {
            int counter = 0;
            // Execute the loop body while the loop condition holds
            while (counter <= 9)
            {
                // Print the counter value
                Console.WriteLine("Number : " + counter);
                // Increment the counter
                counter++;
            }
        }

      

        public void Sum()
        {
            //find the sum of the numbers from 1 to n.
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            int sum = 1;
            Console.Write("The sum 1");
            while (num < n)
            {
                num++;
                sum += num;
                Console.Write(" + " + num);
            }
            Console.WriteLine(" = " + sum);
        }
        public void CheckPrime()
        {
            Console.Write("Enter a positive number: ");
            int num = int.Parse(Console.ReadLine());
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(num);
            bool prime = true;
            while (prime && (divider <= maxDivider))
            {
                if (num % divider == 0)
                {
                    prime = false;
                }
                divider++;
            }
            Console.WriteLine("Prime? " + prime);
        }
        public void CalculateFactorial()
        {
            int n = int.Parse(Console.ReadLine());
            // "decimal" is the biggest C# type that can hold integer values
            decimal factorial = 1;
            // Perform an "infinite loop"
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
        }
        public void CalculateFactorial2()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            decimal factorial = 1;
            do
            {
                factorial *= n;
                n--;
            } while (n > 0);
            Console.WriteLine("n! = " + factorial);
        }
      public void FindTheProduct()
        {
            //find the product of all numbers in the range [n…m]. .
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());

            int num = n;
            long product = 1;
            do
            {
                product *= num;
                num++;
            } while (num <= m);

            Console.WriteLine("product[n...m] = " + product);
        }
        public void RaiseTheNumber()
        {
            //raises the number n to a power of m
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());
            decimal result = 1;
            for (int i = 0; i < m; i++)
            {
                result *= n;
            }
            Console.WriteLine("n^m = " + result);
        }
        public void Counter()
        {
            for (int small = 1, large = 10; small < large; small++, large--)
            {
                Console.WriteLine(small + " " + large);
            }
        }
        public void SummOfAllOdd()
        {
            //calculate the sum of all odd integers in the range [1…n], which are not divisible by 7 
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i += 2)
            {
                if (i % 7 == 0)
                {
                    continue;
                }
                sum += i;
            }
            Console.WriteLine("sum = " + sum);
        }
        public void PrintTriangle()
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
        }
        public void PrintPrime()
        {
            //prime number in the interval [n…m].
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());

            for (int num = n; num <= m; num++)
            {
                bool prime = true;
                int divider = 2;
                int maxDivider = (int)Math.Sqrt(num);
                while (divider <= maxDivider)
                {
                    if (num % divider == 0)
                    {
                        prime = false;
                        break;
                    }
                    divider++;
                }
                if (prime)
                {
                    Console.Write(" " + num);
                }
            }
        }
        public void CheckLuckyNumbers()
        {
            // find and print all four-digit numbers of the type ABCD, where: A+B = C+D (we call them lucky numbers).
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 0; b <= 9; b++)
                {
                    for (int c = 0; c <= 9; c++)
                    {
                        for (int d = 0; d <= 9; d++)
                        {
                            if ((a + b) == (c + d))
                            {
                                Console.WriteLine(
                                  " " + a + " " + b + " " + c + " " + d);
                            }
                        }
                    }
                }
            }
        }

        public void FindCombinations()
        {
            //find all possible combinations of the lottery game "6/49". We have to find and print all possible extracts of 6 different numbers, each of which is in the range [1…49].
            for (int i1 = 1; i1 <= 44; i1++)
            {
                for (int i2 = i1 + 1; i2 <= 45; i2++)
                {
                    for (int i3 = i2 + 1; i3 <= 46; i3++)
                    {
                        for (int i4 = i3 + 1; i4 <= 47; i4++)
                        {
                            for (int i5 = i4 + 1; i5 <= 48; i5++)
                            {
                                for (int i6 = i5 + 1; i6 <= 49; i6++)
                                {
                                    Console.WriteLine(i1 + " " + i2 + " " +
                                         i3 + " " + i4 + " " + i5 + " " + i6);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
