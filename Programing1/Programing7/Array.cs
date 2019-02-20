using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Programing7
{
   public class Array
    {
       public void M()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            // Get array size
            int length = array.Length;
            // Declare and create the reversed array
            int[] reversed = new int[length];

            // Initialize the reversed array
            for (int index = 0; index < length; index++)
            {
                reversed[length - index - 1] = array[index];
            }

            // Print the reversed array
            for (int index = 0; index < length; index++)
            {
                Console.Write(reversed[index] + " ");
            }
        }
        public void N()
        {
            Console.Write("Enter a positive integer: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            Console.WriteLine("Enter the values of the array:");

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            bool symmetric = true;
            for (int i = 0; i < array.Length / 2; i++)
            {
                if (array[i] != array[n - i - 1])
                {
                    symmetric = false;
                    break;
                }
            }

            Console.WriteLine("Is symmetric? {0}", symmetric);
        }
        public void C()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Output: ");

            for(int index = 0; index < array.Length; index++)
            {
                //doubling the number of array
                array[index] = 2 * array[index];
                Console.WriteLine(array[index] + " ");
            }
        }
        public void A()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            //iterate in reverse array and we [rint each element
            for (int index = array.Length-1; index >= 0; index--)
            {
                Console.WriteLine(array[index] + " " );
            }
        }
        public void D()
        {
            const int HEIGHT = 12;

            // Allocate the array in a triangle form
            long[][] triangle = new long[HEIGHT + 1][];

            for (int row = 0; row < HEIGHT; row++)
            {
                triangle[row] = new long[row + 1];
            }

            // Calculate the Pascal's triangle
            triangle[0][0] = 1;
            for (int row = 0; row < HEIGHT - 1; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    triangle[row + 1][col] += triangle[row][col];
                    triangle[row + 1][col + 1] += triangle[row][col];
                }
            }

            // Print the Pascal's triangle
            for (int row = 0; row < HEIGHT; row++)
            {
                Console.Write("".PadLeft((HEIGHT - row) * 2));
                for (int col = 0; col <= row; col++)
                {
                    Console.Write("{0,3} ", triangle[row][col]);
                }
                Console.WriteLine();
            }
        }
    }
}
