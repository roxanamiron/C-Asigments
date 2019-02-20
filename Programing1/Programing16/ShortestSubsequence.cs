using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing16
{
   public class ShortestSubsequence
    {
        private int n = 5;
        private int m = 16;
        Queue<int> queue = new Queue<int>();

        public void FindShortestSubsequence()
        {
            Console.WriteLine("\nWrite a program, which finds the shortest subsequence from the operations, which starts with N and ends with M. Use queue.");
            queue.Enqueue(n);
            int index = 0;
            Console.WriteLine("Subsequence: ");
            while(queue.Count > 0)
            {
                index++;
                int current = queue.Dequeue();
                Console.WriteLine("->" + current);
                if (current == m)
                {
                    Console.WriteLine("Index =" + index);
                    return;
                }
                queue.Enqueue(current + 2);
                current = queue.Dequeue();
                Console.WriteLine("->" + current);
                queue.Enqueue(current + 1);
                current = queue.Dequeue();
                Console.WriteLine("->" + current);
                queue.Enqueue(current * 2);
            }
        }
    }
}
