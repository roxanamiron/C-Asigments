using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing16
{
    public class Deque<T>
    {
        private LinkedList<T> elements = new LinkedList<T>();
        public int Count
        {
            get { return this.elements.Count; }
        }
        public void Enqueue(T value)
        {
            //insert the element at the end
            this.elements.AddFirst(value);
        }
        public T Peek()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }
            return this.elements.First.Value;
        }

        public T Dequeue()

        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            T value = this.elements.First.Value;
            this.elements.RemoveFirst();
            return value;
        }

        public void Clear()

        {
            this.elements.Clear();
        }
    }
}
    
