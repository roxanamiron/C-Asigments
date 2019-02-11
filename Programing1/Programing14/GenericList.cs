using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing14
{
    public class GenericList<T> where T:IComparable,new()
    {
        private const int limitCapacity = 6;
        public int capacity;
        public int count=0;
        public T[] listArray;
       
        List<T> elements
        {
            get { return new List<T>(); }
            set
            {
                if(elements == null)
                {
                    throw new NullReferenceException("the list cannot be empthy");
                }
                this.elements = value;
            }
        }
        public int Capacity
        {
            get { return capacity; }
            set { this.capacity = value; }
        }
        public int Count
        {
            get { return count; }
            set { this.count = value; }
        }
        public GenericList()
        {
            this.Capacity = capacity;
            this.listArray = new T[capacity];
        }
        public void AddItem(T element)
        {
            int lenght = listArray.Length;
            T[] newlist = new T[lenght];

            if(count == this.listArray.Length)
            {
                for(int i =0; i<count; i++)
                {
                    newlist[i] = this.listArray[i];
                }                
            }
        }
        public int AccesAnItemByIndex(T element)
        {
            int index = 0;
            for(int i = 0; i< count; i++)
            {
                if (listArray[i].Equals(element))
                {
                    index = i;
                }
            }
            return index;

        }
        public void RemoveAnItemByIndex(int index)
        {
            Validate(index);
            var result = new T[count - 1];
            for(int i = 0; i < index; i++)
            {
                result[i] = listArray[i];
            }
        }

        private void Validate(int index)
        {
            if(index < 0)
            {
                throw new ArgumentNullException(string.Format("Invalid index : {0}.It`s out of range.", index));
            }
        }
    }
}
