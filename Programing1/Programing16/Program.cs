using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing16
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            SequenceOfPositiveNumbers calculate = new SequenceOfPositiveNumbers();
            calculate.PrintTheSumAndAverage();

            //2.
            ReverseOrder reverOrder = new ReverseOrder();
            reverOrder.ReadNumbers();

            //3.
            SortedNumbers sorted = new SortedNumbers();
            sorted.ReadNumbers();

            //4.
            LongestSubsequenceOfEqualNumbers findLongest = new LongestSubsequenceOfEqualNumbers();
            findLongest.FindTheLogest();

            //5.
            NegativeNumbers removeNegative = new NegativeNumbers();
            removeNegative.RemoveNegativeNumbers();

            //6.
            OddNumbers removeOdd = new OddNumbers();
            removeOdd.RemoveOddTimes();

            //7.
            NumbersOccurences occurence = new NumbersOccurences();
            occurence.FindOccurence();

            //8.
            MajorantOfAnArray majorant = new MajorantOfAnArray();
            majorant.FindMajorant();

            //9.
            UsingQueue print = new UsingQueue();
            print.Print50Elements();

            //10.
            ShortestSubsequence shortest = new ShortestSubsequence();
            shortest.FindShortestSubsequence();

            //11.
            Console.WriteLine("\nImplement the data structure dynamic doubly linked list (DoublyLinkedList<T>) – list," +
                "the elements of which have pointers both to the next and the previous elements. Implement the operations" +
                "for adding, removing and searching for an element, as well as inserting an element at a given index, " +
                "retrieving an element by a given index and a method, which returns an array with the elements of the list.");
            DoublyLinkedList<string> element = new DoublyLinkedList<string>();
            element.Add("bread");
            element.Add("juice");
            element.Add("milk");
            element.Add("fruits");
            element.Remove("fruits");
            element.Insert("Milka", 2);

            //12.
            Console.WriteLine("\nCreate a DynamicStack<T> class to implement dynamically a stack " +
                "(like a linked list, where each element knows its previous element and the stack " +
                "knows its last element). Add methods for all commonly used operations like Push()," +
                "Pop(), Peek(), Clear() and Count.");
            DynamicStack<int> stack = new DynamicStack<int>();
            stack.Push(3);
            stack.Push(5);
            stack.Push(7);
            stack.Pop();
            stack.Peek();
            stack.Display();

            //13.
            Console.WriteLine("\nImplement the data structure \"Deque\". This is a specific list-like structure, " +
                "similar to stack and queue, allowing to add elements at the beginning and at the end of the structure." +
                "Implement the operations for adding and removing elements, as well as clearing the deque. If an " +
                "operation is invalid, throw an appropriate exception.");
            Deque<int> el = new Deque<int>();
            el.Enqueue(3);
            el.Enqueue(4);
            el.Dequeue();
            el.Peek();

            //14.
            CircularQueue<int> exe = new CircularQueue<int>();
            exe.Add(3);
            exe.Add(4);
            exe.Add(5);
            exe.Add(55);
            exe.Add(12);


            Console.ReadLine();

        }
    }
}
