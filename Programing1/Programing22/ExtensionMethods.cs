using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing22
{
   public static class ExtensionMethods
    {
        public static T Elements<T>(this IEnumerable<T> elements)
        {
            dynamic element = 1;
            if(elements.Count() == 0)
            {
                throw new ArgumentException("elements is empty");
            }
            foreach(var item in elements)
            {
                element *= item;
            }
            return element;
        }

        public static T Min<T>(this IEnumerable<T> elements)where T:IComparable<T>
        {
            if(elements.Count() == 0)
            {
                throw new ArgumentException("the elements is empty");
            }
            T min = elements.Last();
            foreach(var item in elements)
            {
                if(min.CompareTo(item) > 0)
                {
                    min = item;
                }                
            }
            return min;
        }
        public static T Max<T>(this IEnumerable<T> elements) where T : IComparable<T>
        {
            if(elements.Count()== 0)
            {
                throw new ArgumentException("the elements is empty");
            }
            T max = elements.Last();
            foreach (var item in elements)
            {
                if(max.CompareTo(item) < 0)
                {
                    max = item;
                }
            }
            return max;
        }
        public static T Sum<T>(this IEnumerable<T> elements)
        {
            if (elements.Count() == 0)
            {
                throw new ArgumentException("elements are empty");
            }
            T sum = (dynamic)0;
            foreach(var item in elements)
            {
                sum += (dynamic)item;
            }
            return sum;
        }
        public static decimal Average<T>(this IEnumerable<T> elements)where T:IComparable<T>
        {
            if (elements.Count() == 0)
            {
                throw new ArgumentException("elements is empty");
            }
            decimal result = 0.0m;
            result = elements.Aggregate(result,(x,y) => (dynamic) x+y)/elements.Count();
            return result;
        }
    }
}
