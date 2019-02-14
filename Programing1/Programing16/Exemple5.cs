//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Programing16
//{
//    class Exemple5
//    {
//        static void Main()
//        {
//            //1.
//            //    Queue<string> queue = new Queue<string>();
//            //    queue.Enqueue("message 1");
//            //    queue.Enqueue("message 2");
//            //    queue.Enqueue("message 3");
//            //    queue.Enqueue("message 4");
//            //    queue.Enqueue("message 5");

//            //    while(queue.Count > 0)
//            //    {
//            //        string msg = queue.Dequeue();
//            //        Console.WriteLine(msg);
//            //    }

//            //2.

//            int n = 3;
//            int p = 16;

//            Queue<int> que = new Queue<int>();
//            que.Enqueue(n);
//            int index = 0;
//            Console.WriteLine("S = ");
//            while (que.Count > 0)
//            {
//                index++;
//                int current = que.Dequeue();
//                Console.WriteLine(" " + current);
//                if (current == p)
//                {
//                    Console.WriteLine();
//                    Console.WriteLine("Index = " + index);
//                    return;
//                }
//                que.Enqueue(current + 1);
//                que.Enqueue(2 * current);
//            }

//            Console.ReadLine();
//        }
//    }
//}
