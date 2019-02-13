using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing16
{
   public class DynamicList<T>
    {
        //static void Main()
        //{
    //    DynamicList<string> shoppingList =
    //  new DynamicList<string>();
    //    shoppingList.Add("Milk");
    //        shoppingList.Remove("Milk"); // Empty list
    //        shoppingList.Add("Honey");
    //        shoppingList.Add("Olives");
    //        shoppingList.Add("Water");
    //        shoppingList[2] = "A lot of " + shoppingList[2];
    //        shoppingList.Add("Fruits");
    //        shoppingList.RemoveAt(0); // Removes "Honey" (first)
    //        shoppingList.RemoveAt(2); // Removes "Fruits" (last)
    //        shoppingList.Add(null);
    //        shoppingList.Add("Beer");
    //        shoppingList.Remove(null);
    //        Console.WriteLine("We need to buy:");
    //        for (int i = 0; i<shoppingList.Count; i++)
    //        {
    //            Console.WriteLine(" - " + shoppingList[i]);
    //        }
    //Console.WriteLine("Position of 'Beer' = {0}",
    //            shoppingList.IndexOf("Beer"));
    //        Console.WriteLine("Position of 'Water' = {0}",
    //            shoppingList.IndexOf("Water"));
    //        Console.WriteLine("Do we have to buy Bread? " +
    //            shoppingList.Contains("Bread"));
        //}
        private class ListNode
        {
            public T Element { get; set; }
            public ListNode NextNode { get; set; }

            public ListNode(T element)
            {
                this.Element = element;
                NextNode = null;
            }
            public ListNode(T element,ListNode prevNode)
            {
                this.Element = element;
                prevNode.NextNode = this;
            }
        }
        private ListNode head;
        private ListNode tail;
        private int count;

        public DynamicList()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }
        /// add element at the end of the list
        /// "item"-the element to be added
        /// 
        public void Add(T item)
        {
            if(this.head == null)
            {
                //we have an empthy list -> create a new head and tail
                this.head = new ListNode(item);
                this.tail = this.head;
            }
            else
            {
                //we have a non empthy list -> append the item after tail
                ListNode newNode = new ListNode(item, this.tail);
                this.tail = newNode;
            }
            this.count++;
        }
        /// <summary>Removes and returns element on the specified index
        /// </summary>
        /// <param name="index">The index of the element to be removed
        /// </param>
        /// <returns>The removed element</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// if the index is invalid</exception>
        /// 
        public T RemoveAt(int index)
        {
            if(index >= count || index < 0)
            {
                throw new IndexOutOfRangeException("Invalid index" + index);
            }
            //find the elemnt at the specified index
            int currentIndex = 0;
            ListNode cureentNode = this.head;
            ListNode prevNode = null;
            while(currentIndex < index)
            {
                prevNode = cureentNode;
                cureentNode = cureentNode.NextNode;
                currentIndex++;
            }

            //remove the found element from th list of nodes
            RemoveListNode(cureentNode, prevNode);

            //return the removed element
            return cureentNode.Element;
        }

        /// <summary>
        /// Remove the specified node from the list of nodes
        /// </summary>
        /// <param name="node">the node for removal</param>
        /// <param name="prevNode">the predecessor of node</param>
        /// 
        private void RemoveListNode(ListNode node, ListNode prevNode)
        {
            count--;
            if(count ==0)
            {
                //the list becomes empty -> remove head and tail
                this.head = null;
                this.tail = null;
            }
            else if(prevNode == null)
            {
                //the head node was removed -> update the head
                this.head = node.NextNode;
            }
            else
            {
                //redirect the pointers to skip the removed node
                prevNode.NextNode = node.NextNode;
            }

            //fix the tail in case it was removed
            if(object.ReferenceEquals(this.tail,node))
            {
                this.tail = prevNode;
            }
        }
        /// <summary>
        /// Removes the specified item and return its index.
        /// </summary>
        /// <param name="item">The item for removal</param>
        /// <returns>The index of the element or -1 if it does not exist</returns>
        public int Remove(T item)
        {
            // Find the element containing the searched item
            int currentIndex = 0;
            ListNode currentNode = this.head;
            ListNode prevNode = null;
            while (currentNode != null)
            {
                if (object.Equals(currentNode.Element, item))
                {
                    break;
                }
                prevNode = currentNode;
                currentNode = currentNode.NextNode;
                currentIndex++;
            }

            if (currentNode != null)
            {
                // The element is found in the list -> remove it
                RemoveListNode(currentNode, prevNode);
                return currentIndex;
            }
            else
            {
                // The element is not found in the list -> return -1
                return -1;
            }
        }
        /// <summary>Searches for given element in the list</summary>
        /// <param name="item">The item to be searched</param>
        /// <returns>
        /// The index of the first occurrence of the element
        /// in the list or -1 when it is not found
        /// </returns>
        public int IndexOf(T item)
        {
            int index = 0;
            ListNode currentNode = this.head;
            while (currentNode != null)
            {
                if (object.Equals(currentNode.Element, item))
                {
                    return index;
                }
                currentNode = currentNode.NextNode;
                index++;
            }
            return -1;
        }

        /// <summary>
        /// Checks if the specified element exists in the list
        /// </summary>
        /// <param name="item">The item to be checked</param>
        /// <returns>
        /// True if the element exists or false otherwise
        /// </returns>
        public bool Contains(T item)
        {
            int index = IndexOf(item);
            bool found = (index != -1);
            return found;
        }
        /// <summary>
        /// Gets or sets the element at the specified position
        /// </summary>
        /// <param name="index">
        /// The position of the element [0 … count-1]
        /// </param>
        /// <returns>The item at the specified index</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// When an invalid index is specified
        /// </exception>
        public T this[int index]
        {
            get
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        "Invalid index: " + index);
                }
                ListNode currentNode = this.head;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.NextNode;
                }
                return currentNode.Element;
            }
            set
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        "Invalid index: " + index);
                }
                ListNode currentNode = this.head;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.NextNode;
                }
                currentNode.Element = value;
            }
        }

        /// <summary>
        /// Gets the count of elements in the list
        /// </summary>
        public int Count
        {
            get
            {
                return this.count;
            }
        }

    }
}
