using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing16
{
    public class CircularQueue<T>
    {
        private T[] elemets;
        private int count;

        public int Count
        {
            get { return this.count; }
        }
        private const int Capacity = 4;
        public CircularQueue(int capacity = Capacity)
        {
            this.elemets = new T[capacity];
            this.count = 0;
        }
        public void Add(T item)
        {
            GrowIfIsFull();
            if (this.elemets.Length == Capacity * 2)
            { 
                              
                this.elemets[this.count] = item;
            }
            this.elemets[this.count] = item;
            this.count++;
        }

        private void GrowIfIsFull()
        {
            if (this.count + 1 > this.elemets.Length)
            {
                Array.Resize(ref this.elemets, this.elemets.Length * 2);  
            }
        }
    }
}
