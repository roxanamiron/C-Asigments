using System;

namespace Programing16
{
    internal class DynamicStack<T>
    {
        private class LinkedList
        {
            public int data;
            public LinkedList link;
        }
        LinkedList top;
        public DynamicStack()
        {
            this.top = null;
        }
        //add method
        public void Push(int x)
        {
            LinkedList temporary = new LinkedList();

            //check if stack is full
            if (temporary == null)
            {
                return;
            }
            temporary.data = x;
            temporary.link = top;
            top = temporary;
        }
        public bool IsEmpty()
        {
            return top == null;
        }
        public int Peek()
        {
            if (!IsEmpty())
            {
                return top.data;
            }
            else
            {
                return -1;
            }
        }
        public void Pop()
        {
            //remov at the beging
            if (top == null)
            {
                return;
            }
            top = (top).link;
        }
        public void Display()
        {
            // check for stack underflow  
            if (top == null)
            {
                Console.Write("\nStack Underflow");
                return;
            }
            else
            {
                LinkedList temp = top;
                while (temp != null)
                {

                    // print node data  
                    Console.Write("{0}->", temp.data);

                    // assign temp link to temp  
                    temp = temp.link;
                }
            }
        }
    }
}