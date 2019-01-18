using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Programing4
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            Console.WriteLine("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("c = ");
            int c = int.Parse(Console.ReadLine());
            Read(a, b, c);

            //2.
            Console.WriteLine("\nRadius = ");
            var rad = int.Parse(Console.ReadLine());
            ReadRadius(rad);

            //3.
            ReadInfo();

            //4.
           PrintNumbers();

            //5.
            PrintNumbers2(a,b);

            //6.
            PrintGreater(a, b);

            //7.
             PrintSumOfTHeNumbers();

            //8.
           PrintGreater2();

            //9.
             PrintN();

            //10.
            PrintInRange();

            //11.
           PrintFibonacci();

            //12.
            PrintSum();
            Console.ReadLine();
        }
        static void Read(int a, int b, int c)
        {
            Console.WriteLine("\nWrite a program that reads from the console three numbers of type int and prints their sum.");
            var sum = a + b + c;
            Console.WriteLine("\nThe sum = {0}", sum);

        }
        static void ReadRadius(int rad)
        {
            Console.WriteLine("\nWrite a program that reads from the console the radius \"r\" of a circle and prints its perimeter and area.");

            double pi = Math.PI;
            var area = pi * (rad * rad);
            var perimeter = ((2 * pi) * rad);
            Console.WriteLine("the area is ={0:F2}", area);
            Console.WriteLine("the perimeter is ={0:F2}", perimeter);

        }
        static void ReadInfo()
        {
            Console.WriteLine("\nA given company has name, address, phone number, fax number, web site and manager. " +
                "The manager has name, surname and phone number. Write a program that reads information about the " +
                "company and its manager and then prints it on the console.");

            Console.WriteLine("Enter the company name: ");
            string companyName = Console.ReadLine();
            Console.WriteLine("Enter the adress : ");
            string adress = Console.ReadLine();
            Console.WriteLine("Enter the phone Number  with prefix: ");
            int phoneNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fax Number with prefix : ");
            int faxNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the webSite: ");
            string webSite = Console.ReadLine();
            Console.Write("Enter the manager First name: ");
            string managerFirstName = Console.ReadLine();
            Console.Write("Enter the manager Last name: ");
            string managerLastName = Console.ReadLine();
            Console.Write("Enter the manager Age: ");
            byte managerAge = byte.Parse(Console.ReadLine());
            Console.Write("Enter the manager Phone number: ");
            int managerPhoneNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInformation abuot company...");
            Console.WriteLine("Firm: Name - {0}, Address - {1}, Number - {2:(0###) ### ###}, Fax - {3:(0###) ### ###}, Website - {4}", companyName, adress, phoneNumber, faxNumber, webSite);
            Console.WriteLine("\nInformation about manager...");
            Console.WriteLine("First name: {0}, Last name: {1}, Age: {2}, Phone number: {3:000-000-0000}", managerFirstName, managerLastName, managerAge, managerPhoneNumber);
        }
        static void PrintNumbers()
        {
            Console.WriteLine("\n Write a program that prints three numbers in three virtual columns on the console. " +
                "Each column should have a width of 10 characters and the numbers should be left aligned. " +
                "The first number should be an integer in hexadecimal; the second should be fractional positive; and the third – a negative fraction. " +
                "The last two numbers have to be rounded to the second decimal place.");

            Console.WriteLine("    " + "  HexaNumber  " + "   Pos. Fract   " + "   Neg. Fract   " + "    ");
            Console.WriteLine("    " + "  {0:x}         " + "   |{0:10:f2}|     " + "   |{0:-10:f2}|    " + "    ", 236, 7.575, -1.856);

        }
        static void PrintNumbers2(int a, int b)
        {
            Console.WriteLine("\nWrite a program that reads from the console two integer numbers (int) and prints how many numbers " +
                "between them exist, such that the remainder of their division by 5 is 0. Example: in the range (14, 25)" +
                "there are 3 such numbers: 15, 20 and 25.");
            int printNumber = 0;



            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                    printNumber++;
                }

                Console.WriteLine("\nThe numbers between a and b are {0} ", printNumber);
            }

        }
        static void PrintGreater(int a, int b)
        {
            Console.WriteLine("\nWrite a program that reads two numbers from the console and prints the greater of them. " +
                "Solve the problem without using conditional statements.");

            Console.WriteLine("The greater between {0} and {1} is {2} ", a, b, Math.Max(a, b));
        }
        static void PrintSumOfTHeNumbers()
        {
            Console.WriteLine("\nWrite a program that reads five integer numbers and prints their sum. " +
                "If an invalid number is entered the program should prompt the user to enter another number.");

            int n1, n2, n3, n4, n5;
            bool parseSucced = false;

            do
            {
                Console.WriteLine("n1 = ");
                parseSucced = Int32.TryParse(Console.ReadLine(), out n1);
                Console.WriteLine(parseSucced);

            } while (!parseSucced);

            do
            {
                Console.WriteLine("n2 = ");
                parseSucced = Int32.TryParse(Console.ReadLine(), out n2);
                Console.WriteLine(parseSucced);
            } while (!parseSucced);

            do
            {
                Console.WriteLine("n3 = ");
                parseSucced = Int32.TryParse(Console.ReadLine(), out n3);
                Console.WriteLine(parseSucced);
            } while (!parseSucced);

            do
            {
                Console.WriteLine("n4 = ");
                parseSucced = Int32.TryParse(Console.ReadLine(), out n4);
            } while (!parseSucced);

            do
            {
                Console.WriteLine("n5 = ");
                parseSucced = Int32.TryParse(Console.ReadLine(), out n5);
            } while (!parseSucced);


            var sum = n1 + n2 + n3 + n4 + n5;

            Console.WriteLine("\nSum = {0}", sum);
        }
        static void PrintGreater2()
        {
            Console.WriteLine("\n Write a program that reads five numbers from the console and prints the greatest of them.");
            Console.WriteLine("\nInput 5 numbers: ");
            Console.WriteLine(" n1 = ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" n2 = ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" n3 = ");
            int n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" n4 = ");
            int n4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" n5 = ");
            int n5 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2 && n1 > n3 && n1 > n4 && n1 > n5)
                Console.WriteLine("{0} is the biggest.", n1);
            if (n2 > n1 && n2 > n3 && n2 > n4 && n2 > n5)
                Console.WriteLine("{0} is the biggest.", n2);
            if (n3 > n1 && n3 > n2 && n3 > n4 && n1 > n5)
                Console.WriteLine("{0} is the biggest.", n3);
            if (n4 > n1 && n4 > n2 && n4 > n3 && n4 > n5)
                Console.WriteLine("{0} is the biggest.", n4);
            if (n5 > n1 && n5 > n2 && n5 > n3 && n5 > n4)
                Console.WriteLine("{0} is the biggest.", n5);
        }
        static void PrintN()
        {
            Console.WriteLine("\nWrite a program that reads an integer number n from the console. After that reads n numbers from the console and prints their sum.");
            Console.WriteLine("How many numbers do you want to enter: ");

            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Input {0} number: ", i + 1);
                int number = Convert.ToInt32(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);
        }
        static void PrintInRange()
        {
            Console.WriteLine("\n Write a program that reads an integer number n from the console and prints all " +
                "numbers in the range [1…n], each on a separate line.");
            Console.WriteLine("How many numbers do you want to enter: ");
            int n = Convert.ToInt32(Console.ReadLine());
            var range = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Input {0} number: ", i + 1);
                int number = Convert.ToInt32(Console.ReadLine());
                range[i] = number;
                Console.WriteLine("value in index {0}:\t{1}", i, number);

            }

        }
        static void PrintFibonacci()
        {
            Console.WriteLine("\nWrite a program that prints on the console the first 100 numbers " +
                "in the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …");

            int firstNr = 0;
            int secondNr = 1;
            var result = 0;

            for (int i = 1; i < 101; i++)
            {
                result = firstNr + secondNr;
                firstNr = secondNr;
                secondNr = result;
                Console.WriteLine(result);
            }
        }
        static void PrintSum()
        {
            Console.WriteLine("\n  Write a program that calculates the sum (with precision of 0.001) "+
                "of the following sequence: 1 + 1/2 - 1/3 + 1/4 - 1/5 + …");
            double sum = 0;
            double n = 1;
            for(double i = 2; i <= 100; i++)
            {
                sum += (n / i);
            }

            Console.WriteLine("sum = {0:F3}",sum);
        }
    }

}
