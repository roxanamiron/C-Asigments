using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing7
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            CreateArray();
            //2.
            CheckIfAreEqual();
            //3.
             Compare2Arrays();
            //4.
             FindMaxim();
            //8.
            Sorting();

            Console.ReadLine();
        }
        static void CreateArray()
        {
            Console.WriteLine("\nWrite a program, which creates an array of 20 elements of type integer "+
                "and initializes each of the elements with a value equals to the index of the element multiplied"+
                "by 5. Print the elements to the console.");
            int[] array = new int[20];

            for(int index =0; index < array.Length; index++)
            {
                array[index] = index * 5;
                Console.WriteLine("Element[{0}] = {1}",index,array[index]);
            }

        }
        static void CheckIfAreEqual()
        {
            Console.WriteLine("\nWrite a program, which reads two arrays from the console and checks "+
                "whether they are equal (two arrays are equal when they are of equal length and all of "+
                "their elements, which have the same index, are equal).");
            Console.WriteLine("Length of arrays = ");
            int length1 = int.Parse(Console.ReadLine());
            int length2 = int.Parse(Console.ReadLine());
            bool symetric = true;

            int[] array1 = new int[length1];
            int[] array2 = new int[length2];

            for(int index = 0; index < length1; index ++)
            {
                array1[index] = int.Parse(Console.ReadLine());
                Console.WriteLine("Element[{0}] = {1}", index, array1[index]);
            }
            for (int index = 0; index < length2; index++)
            {
                array2[index] = int.Parse(Console.ReadLine());
                Console.WriteLine("Element[{0}] = {1}", index, array2[index]);
            }

            for(int i = 0; i < length1/2; i++)
            {
                for(int j = 0; j< length2/2; j++)
                {
                    if((array1[i] != array1[length1 - i - 1]) && (array2[j] != array2[length2 - j - 1]))
                    {
                        symetric = false;
                        break;
                    }
                }
                Console.WriteLine("Are the 2 arrays equals ? {0}", symetric);
            }
        }
        static void Compare2Arrays()
        {
            Console.WriteLine("\nWrite a program, which compares two arrays of type char lexicographically "+
                "(character by character) and checks, which one is first in the lexicographical order.");

            char[] array1 = { 'c', 'd', 'e', 'f' };
            char[] array2 = { 'k', 'z', 't', 's' };

            foreach(var ch in array1)
            {
                foreach(var letter in array2)
                {
                    if(ch < letter)
                    {
                        Console.WriteLine("Array1 is first in the lexicographical order");
                    }
                    else
                    {
                        Console.WriteLine("Array2 is first in the lexicographical order");
                    }
                }
            }
        }
        static void FindMaxim()
        {
            Console.WriteLine("\n Write a program, which finds the maximal sequence of consecutive"+
                "equal elements in an array. E.g.: {1, 1, 2, 3, 2, 2, 2, 1} -> {2, 2, 2}.");
            int[] arr = { 1, 1, 2, 3, 2, 2, 2, 1 };
            int start = 0;
            int length = 0;
            int bestStart = 0;
            int bestLength = int.MinValue;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if ((i == 0) || (arr[i] != arr[i - 1]))
                {
                    start = i;
                }
                if (arr[start] == arr[start + 1])
                {
                    length++;
                    if (length > bestLength)
                    {
                        bestLength = length;
                        bestStart = start;
                    }
                }
                else
                {
                    length = 0;
                }
            }
            Console.Write("The best sequence is :");
            for (int i = bestStart; i < bestLength + bestStart; i++)
            {
                Console.Write(" " + arr[i]);
            }
        }
        static void Sorting()
        {
            Console.WriteLine("\nSorting an array means to arrange its elements in an increasing (or decreasing) order."+
                "Write a program, which sorts an array using the algorithm \"selection sort\".");

            int[] array = { 2, 5, 1, 3, 4 };
            int smalest = 0;
            int greater = 0;

            //sort decreasing
            for (int i = 0; i < array.Length-1;i++)
            {
                smalest = i;
                for(int index = i+1; index < array.Length; index++)
                {
                    if (array[index] < array[smalest])
                    {
                        smalest = index;
                    }
                }
                if(array[smalest] != i)
                {
                    var temporary = array[i];
                    array[i] = array[smalest];
                    array[smalest] = temporary;
                }              
                
            }
            foreach (var element in array)
            {
                Console.WriteLine("Elements in decreasing order: ");
                Console.WriteLine(element + " ");
            }

            //sort increasing
            for (int i = 0; i < array.Length - 1; i++)
            {
                greater = i;
                for (int index = i + 1; index < array.Length; index++)
                {
                    if (array[index] > array[greater])
                    {
                        greater = index;
                    }
                }
                if (array[greater] != i)
                {
                    var temporary = array[i];
                    array[i] = array[greater];
                    array[greater] = temporary;
                }

            }
            foreach (var element in array)
            {
                Console.WriteLine("Elements in increasing order: ");

                Console.WriteLine(element + " ");
            }

        }

    }
}
