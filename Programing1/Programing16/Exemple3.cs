using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing16
{
    class Exemple3
    {
        //static void Main()

        //{
        //    //1.
        //    //List<int> primes = GetPrimes(200, 300);
        //    //foreach(var item in primes)
        //    //{
        //    //    Console.WriteLine("{0}",item);
        //    //}

        //    //2.
        //    //List<int> firstList = new List<int>();
        //    //firstList.Add(1);
        //    //firstList.Add(2);
        //    //firstList.Add(3);
        //    //firstList.Add(4);
        //    //firstList.Add(5);
        //    //Console.Write("firstList = ");
        //    //PrintList(firstList);

        //    //List<int> secondList = new List<int>();
        //    //secondList.Add(2);
        //    //secondList.Add(4);
        //    //secondList.Add(6);
        //    //Console.Write("secondList = ");
        //    //PrintList(secondList);

        //    //List<int> unionList = Union(firstList, secondList);
        //    //Console.Write("union = ");
        //    //PrintList(unionList);

        //    //List<int> intersectList =
        //    //    intersect(firstList, secondList);
        //    //Console.Write("intersect = ");
        //    //PrintList(intersectList);

        //    //3.
        //    //We are going to solve the problem in one more way: by using the method AddRange<T>(IEnumerable<T> collection) from the class List<T>:
        //    List<int> firstList = new List<int>();
        //    firstList.Add(1);
        //    firstList.Add(2);
        //    firstList.Add(3);
        //    firstList.Add(4);
        //    firstList.Add(5);
        //    Console.Write("firstList = ");
        //    PrintList(firstList);

        //    List<int> secondList = new List<int>();
        //    secondList.Add(2);
        //    secondList.Add(4);
        //    secondList.Add(6);
        //    Console.Write("secondList = ");
        //    PrintList(secondList);

        //    List<int> union = new List<int>();
        //    union.AddRange(firstList);
        //    for(int i=0; i < union.Count - 1; i++)
        //    {
        //        if (secondList.Contains(union[i]))
        //        {
        //            union.RemoveAt(i);
        //        }
        //    }
        //    union.AddRange(secondList);
        //    Console.WriteLine("union=");
        //    PrintList(union);

        //    List<int> intersect = new List<int>();
        //    intersect.AddRange(firstList);
        //    for(int i= 0; i < intersect.Count-1; i++)
        //    {
        //        if (!secondList.Contains(intersect[i]))
        //        {
        //            intersect.RemoveAt(i);
        //        }
        //    }
        //    Console.WriteLine("intersect=");
        //    PrintList(intersect);



        //    Console.ReadLine();
        //}

        static List<int> GetPrimes(int start, int end)
        {
            List<int> primeList = new List<int>();
            for(int num = start; num<=end;num++)
            {
                bool prime = true;
                double numSqrt = Math.Sqrt(num);
                for(int div = 2; div <= numSqrt; div++)
                {
                    if(num % 2 ==0)
                    {
                        prime = false;
                        break;
                    }
                }
                if(prime)
                {
                    primeList.Add(num);
                }
            }
            return primeList;
        }
        static List<int> Union(List<int> firstList, List<int> secondList)
        {
            List<int> union = new List<int>();
            union.AddRange(firstList);
            foreach(var item in secondList)
            {
                if(!union.Contains(item))
                {
                    union.Add(item);
                }
            }
            return union;
        }
        static List<int> intersect(List<int>firstList, List<int> secondList)
        {
            List<int> intersect = new List<int>();
            foreach(var item in firstList)
            {
                if (secondList.Contains(item))
                {
                    intersect.Add(item);
                }
            }
            return intersect;
        }
        static void PrintList(List<int> list)
        {
            Console.WriteLine("{"); 
            foreach(var item in list)
            {
                Console.WriteLine(item);
                Console.WriteLine(" ");
            }
            Console.WriteLine("}");
        }
    }
}
