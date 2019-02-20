using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing16
{
   public class LongestSubsequenceOfEqualNumbers
    {
        List<int> list = new List<int> { 1, 9, 3, 10, 4, 20, 2 };
        private int start = 0;
        private int length = 1;

        public void FindTheLogest()
        {
            Console.WriteLine("\nWrite a method that finds the longest subsequence of equal numbers in a given "+
                "List<int> and returns the result as new List<int>. Write a program to test whether the method works correctly.");

            for (int currentIndex = 1, currentLength = 1; currentIndex < list.Count-1; currentIndex++)
            {
                if(list[currentIndex-1] == list[currentIndex])
                {
                    length++;
                }
                else
                {
                    start = currentIndex;
                    length = 1;
                }

                if(currentLength > start)
                {
                    start = currentLength;
                    length = currentIndex - currentLength - 1;
                }
            }
            Console.WriteLine(string.Join(" ",list.Skip(length).Take(start)));
        }
    }
}
