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
            // CreateArray();
            //2.
            // CheckIfAreEqual();
            //3.
            // Compare2Arrays();
            //4.
            FindMaxim();

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
            int value = 0;

            for(int i = 0; i < arr.Length; i ++)
            {
                for(int j = i+1; j < arr.Length -1; j++)
                {
                    if(arr[i] == arr[j])
                    {                        
                       value = arr[i];                       
                    }
                    else
                    {
                        break;
                    }
                }
                
            }

            //m=am bllocat aici putin...
        }

    }
}
