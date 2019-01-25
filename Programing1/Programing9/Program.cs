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
            Console.WriteLine("Enter yourName: ");
            string yourName = Console.ReadLine();
            PrintName(yourName);

            //2.
            Console.WriteLine("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("c = ");
            int c = int.Parse(Console.ReadLine());
            var numbers = GetMax(GetMax(a, b), c);
            Console.WriteLine("The maximal numbers is : {0}", numbers);

            //3.
            Console.WriteLine("enter the number: ");
            int number = int.Parse(Console.ReadLine());
            var numberArray = number.ToString().Select(d => int.Parse(d.ToString())).ToArray();
            CheckTheNumber(numberArray);

            //4.
            int[] result = { 1, 3, 5, 1, 4, 9, 1 };
            var dict =  FindHowManyTimes(result);

            //5.
            Console.WriteLine("enter the length of array: ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the position of a number you want to check");
            int position = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("enter the element for array: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            CheckTheElement(position, array);

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
        static Dictionary<int,int> FindHowManyTimes(int[] array)
        {
            Console.WriteLine("\nWrite a method that finds how many times certain number " +
                "can be found in a given array. Write a program to test that the method works correctly.");
          
            int size = array.Length;

            var dict = new Dictionary<int, int>();

           foreach(var nr in array)
            {
                if(dict.ContainsKey(nr))
                {
                    dict[nr]++;
                }
                else
                {
                    dict.Add(nr,1);
                }
            }

           foreach(var element in dict)
            {
                Console.WriteLine("The number {0} apperce {1} times in array", element.Key,element.Value);
                 
            }
            return dict;
           
        }
        static void CheckTheElement(int position, int[] array)
        {
            Console.WriteLine("\n Write a method that checks whether an element, from a certain position"+
                "in an array is greater than its two neighbors. Test whether the method works correctly.");
            
            int index;

            for(index = 0; index < array.Length; index++)
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


    }
}
