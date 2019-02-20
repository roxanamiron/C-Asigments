using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing16
{
   public class UsingQueue
    {
        private int n = 2;
        Queue<int> queue = new Queue<int>();

        public void Print50Elements()
        {
            Console.WriteLine("\nUsing the Queue<T> class, write a program which by given N prints on the console the first 50 elements of the sequence.");
            List <int> list = new List<int>();
            queue.Enqueue(n);
            Console.WriteLine("S =");
           while(list.Count < 50)
            {
                int current = queue.Dequeue();
                Console.WriteLine(" " + current);
                list.Add(current);
                queue.Enqueue(current + 1);
                queue.Enqueue(2 * current+1);
                queue.Enqueue(current + 2);
            }
        }
    }
}
