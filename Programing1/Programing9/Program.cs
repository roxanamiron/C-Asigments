using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing9
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            //Console.WriteLine("Enter yourName: ");
            //string yourName = Console.ReadLine();
            //PrintName(yourName);

            ////2.
            //Console.WriteLine("a = ");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("b = ");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("c = ");
            //int c = int.Parse(Console.ReadLine());
            //var numbers = GetMax(GetMax(a, b), c);
            //Console.WriteLine("The maximal numbers is : {0}", numbers);

            ////3.
            //Console.WriteLine("enter the number: ");
            //int number = int.Parse(Console.ReadLine());
            //var numberArray = number.ToString().Select(d => int.Parse(d.ToString())).ToArray();
            //CheckTheNumber(numberArray);

            ////4.
            //int[] result = { 1, 3, 5, 1, 4, 9, 1 };
            //var dict =  FindHowManyTimes(result);

            ////5.
            //Console.WriteLine("enter the length of array: ");
            //int length = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter the position of a number you want to check");
            //int position = int.Parse(Console.ReadLine());
            //int[] array = new int[length];
            //for (int i = 0; i < length; i++)
            //{
            //    Console.WriteLine("enter the element for array: ");
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            //CheckTheElement(position, array);

            //6.
            //var position = ReturnThePosition(result);
            //Compare(position);


            //7.
            //Console.WriteLine("Enter an number: ");
            //int number = int.Parse(Console.ReadLine());
            //Reverse(number);

            //8.
            //Console.WriteLine("Enter the first very long positive integer number: ");
            //ulong first = ulong.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the second very long positive integer number: ");
            //ulong second = ulong.Parse(Console.ReadLine());
            //var firstArr = ReverseFirstArray(first);
            //var seccondArr = ReverseSecondArray(second);
            //CalculateTheSum(firstArr, seccondArr);

            //9.
            //Console.WriteLine("enter the length of array: ");
            //int length = int.Parse(Console.ReadLine());
            //int[] array = new int[length];
            //for (int i = 0; i < length; i++)
            //{
            //    Console.WriteLine("enter the element for array: ");
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            //SortingDescending(array);

            //10.
            //Console.WriteLine("Input a number between [1...100]");
            //int number = int.Parse(Console.ReadLine());
            //CalculateFactorial(number);

            //11.
            Console.WriteLine("\nWrite a program that solves the following tasks:" +
                       " - Put the digits from an integer number into a reversed order." +
                       " - Calculate the average of given sequence of numbers." +
                        "- Solve the linear equation a * x + b = 0." +
                        "Create appropriate methods for each of the above tasks." +
                        "Make the program show a text menu to the user.By choosing an option of that menu, " +
                        "the user will be able to choose which task to be invoked." +
                        "Perform validation of the input data:" +
                        "-The integer number must be a positive in the range[1…50, 000, 000]." +
                        "- The sequence of numbers cannot be empty." +
                        "- The coefficient a must be non - zero.) ");
            Console.WriteLine("Input an integer number");
            int number = int.Parse(Console.ReadLine());
            //ReverseNumber(number);
            Average(number);
            Console.ReadLine();

        }

        static void PrintName(string name)
        {
            Console.WriteLine("\nWrite a code that by given name prints on the console \"Hello, < name > !\" (for example: \"Hello, Peter!\"). ");

            Console.WriteLine("Hello, {0}!", name);
        }
        static int GetMax(int a, int b)
        {
            int maximal = a;
            if (b > maximal)
            {
                maximal = b;
            }
            return maximal;
        }
        static string GetDigitName(int name)
        {
            Console.WriteLine("\n Write a method that returns the English name of the last digit of a given number. Example: for 512 prints \"two\"; for 1024 à \"four\".");
            string digitName = string.Empty;
            switch (name)
            {
                case 0:
                    digitName = "Zero";
                    break;
                case 1:
                    digitName = "One";
                    break;
                case 2:
                    digitName = "Two";
                    break;
                case 3:
                    digitName = "Tree";
                    break;
                case 4:
                    digitName = "Four";
                    break;
                case 5:
                    digitName = "Five";
                    break;
                case 6:
                    digitName = "Six";
                    break;
                case 7:
                    digitName = "Seven";
                    break;
                case 8:
                    digitName = "Eight";
                    break;
                case 9:
                    digitName = "Nine";
                    break;
                default:
                    Console.WriteLine("Invalid digit");
                    return null;
            }

            return digitName;
        }
        static void CheckTheNumber(int[] digits)
        {
            foreach (var digit in digits)
            {
                if (digit == digits[digits.Length - 1])
                {
                    Console.WriteLine("The last digit is {0}", GetDigitName(digit));
                }
            }

        }
        static Dictionary<int, int> FindHowManyTimes(int[] array)
        {
            Console.WriteLine("\nWrite a method that finds how many times certain number " +
                "can be found in a given array. Write a program to test that the method works correctly.");

            int size = array.Length;

            var dict = new Dictionary<int, int>();

            foreach (var nr in array)
            {
                if (dict.ContainsKey(nr))
                {
                    dict[nr]++;
                }
                else
                {
                    dict.Add(nr, 1);
                }
            }

            foreach (var element in dict)
            {
                Console.WriteLine("The number {0} apperce {1} times in array", element.Key, element.Value);

            }
            return dict;

        }
        static void CheckTheElement(int position, int[] array)
        {
            Console.WriteLine("\n Write a method that checks whether an element, from a certain position" +
                "in an array is greater than its two neighbors. Test whether the method works correctly.");

            int index;

            for (index = 0; index < array.Length; index++)
            {
                if (index == position)
                {
                    if ((array[index] > array[index - 1]) && (array[index] > array[index + 1]))
                    {
                        Console.WriteLine("{0} is greter then its two neighbors", array[index]);
                    }
                    else
                    {
                        Console.WriteLine("Not greater then the neighbors");
                    }
                }
            }
        }
        static int ReturnThePosition(int[] array)
        {
            Console.WriteLine("\nWrite a method that returns the position of the first occurrence of an element from an array, " +
                "such that it is greater than its two neighbors simultaneously. Otherwise the result must be -1.");
            int position = 0;

            for (int i = 1; i < array.Length - 1; i++)
            {
                if ((array[i] > array[i - 1]) && (array[i] > array[i + 1]))
                {
                    position = array[i];
                    break;
                }
            }
            return position;
        }
        static void Compare(int position)
        {
            if (position == int.MinValue)
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine("{0} Greater than its two neighbors simultaneously", position);
            }

        }
        static void Reverse(int number)
        {
            Console.WriteLine("\n Write a method that prints the digits of a given decimal " +
                "number in a reversed order. For example 256, must be printed as 652.");
            int[] numberArray = number.ToString().Select(n => int.Parse(n.ToString())).ToArray();
            int length = numberArray.Length;
            int[] reverse = new int[length];
            var result = string.Empty;
            // Initialize the reversed array
            for (int index = 0; index < length; index++)
            {
                reverse[length - index - 1] = numberArray[index];
            }
            //print the reversed array
            for (int index = 0; index < length; index++)
            {
                Console.WriteLine("The reverse number is : {0}", reverse[index].ToString());
            }
        }
        static void CalculateTheSum(ulong[] n1, ulong[] n2)
        {
            Console.WriteLine("\nWrite a method that calculates the sum of two very long positive integer numbers. " +
                "The numbers are represented as array digits and the last digit (the ones) is stored in the array at " +
                "index 0. Make the method work for all numbers with length up to 10,000 digits.");
            ulong[] sum = new ulong[] { };
            int length1 = n1.Length;
            int lenght2 = n2.Length;
            ulong[] array = new ulong[length1];
            ulong result = 0;

            for (int i = 0; i < length1; i++)
            {
                for (int j = 0; j < lenght2; j++)
                {
                    result = n1[i] + n2[j];
                    if ((result > 9) && (i < length1 - 1) && (j < lenght2 - 1))
                    {
                        var div = result % 10;
                        array[i] = div;
                        n1[i + 1] += 1;
                    }
                    else if ((result > 9) && (n1[i] != n1[length1 - i - 1]) && (n2[j] != n2[lenght2 - j - 1]))
                    {
                        array[i] = result;
                    }
                    else
                    {
                        array[i] = result;
                    }
                    i++;

                }
                sum = array;
                break;
            }
            ulong[] reverseSum = sum.Reverse().ToArray();

            Console.WriteLine(string.Join("", reverseSum));


        }
        static ulong[] ReverseFirstArray(ulong n1)
        {
            ulong[] firstArr = new ulong[10000];
            firstArr = n1.ToString().Select(n => ulong.Parse(n.ToString())).ToArray();
            ulong[] reversed1 = new ulong[firstArr.Length];


            for (int index = 0; index < firstArr.Length; index++)
            {
                reversed1[firstArr.Length - index - 1] = firstArr[index];
            }

            return reversed1;

        }
        static ulong[] ReverseSecondArray(ulong n2)
        {
            ulong[] secondArr = new ulong[10000];
            secondArr = n2.ToString().Select(n => ulong.Parse(n.ToString())).ToArray();
            ulong[] reversed2 = new ulong[secondArr.Length];

            for (int index = 0; index < secondArr.Length; index++)
            {
                reversed2[secondArr.Length - index - 1] = secondArr[index];
            }
            return reversed2;
        }
        static int SortingDescending(int[] array)

        {
            int greater = 0;

            var sortArray = array.OrderByDescending(n => n).ToArray();

            greater = sortArray.Max();
            return greater;
        }
        static int CalculateFactorial(int n)
        {
            Console.WriteLine("\nWrite a program that calculates and prints the n! for any n in the range [1…100].");
            int factorial = 1;

            for (int i = 1; i <= 101; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
        static int ReverseNumber(int n)
        {
            int result = 0;
            while(n > 0)
            {
                result= result *10 + n % 10;
                n = n / 10;
            }
            return result;
        }
        static int Average(int n)
        {
            int[] array = n.ToString().Select(x => int.Parse(x.ToString())).ToArray();
            int sum = 0;
            for(int i = 0; i< array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
           
        }

    }
}
