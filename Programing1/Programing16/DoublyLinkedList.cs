using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing16
{
    class DoublyLinkedList<T>
    {
        public class LinkedList
        {
            public T Element { get; set; }
            public LinkedList Next { get; set; }
            public LinkedList Previous { get; set; }
            

            public LinkedList(T element)
            {
                this.Element = element;
                Next = null;
            }
            public LinkedList(T element, LinkedList prev)
            {
                this.Element = element;
                prev.Next = this;
            }
        }


        private LinkedList first;
        private LinkedList last;
        private int count;
        public int Count { get; private set; }

        public DoublyLinkedList()
        {
            this.first = null;
            this.last = null;
            count = 0;
        }

        public void Add(T element)
        {
            if(first == null)
            {
                first = new LinkedList(element);
                last = first;
            }
            else
            {
                LinkedList newList = new LinkedList(element, this.last);
                last = newList;
            }
            this.Count++;
        }
        public int Remove(T element)
        {
            //search the element in the list
            int index = 0;
            LinkedList prev = null;
            LinkedList currentElement = this.first;

           while(currentElement != null)
            {
                if (object.Equals(currentElement.Element, element))
                {
                    break;
                }
                prev = currentElement;
                currentElement = currentElement.Next;
                index++;                
            }
            if(currentElement != null)
            {
                RemoveLinkedList(currentElement, last);
                return index;
            }
            else
                return -1;
        }
        public void RemoveLinkedList(LinkedList cuurent, LinkedList prev)
        {
            count--;
            if(count == 0)
            {
                this.first = null;
                this.last = null;
            }
            else if(prev == null)
            {
                this.first = cuurent.Next;
            }
            else
            {
                prev.Next = cuurent.Next;
            }
            if (object.Equals(this.last, cuurent))
            {
                this.last = prev;
            }
        }
        public void Insert(T element, int index)
        {
            LinkedList currentElement = this.first;
            LinkedList prev = null;
            int currentIndex = 0;

            if (index >= this.Count || index < 0)
            {
                throw new IndexOutOfRangeException("Invalid index" + index);
            }
            //find the element
            if(currentIndex < index)
            {
                prev = currentElement;
                currentElement = currentElement.Next;
                currentIndex++;
            }
            //add item
            Add(element);
           
        }        
    }
}
