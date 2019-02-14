using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing16
{
   public class NegativeNumbers
    {
        List<int> list = new List<int>{ 19, -10, 12, -6, -3, 34, -2, 5 };
        

        public void RemoveNegativeNumbers()
        {
            Console.WriteLine("\nWrite a program, which removes all negative numbers from a sequence.");

            for(int i= 0; i< list.Count-1; i++)
            {
                if(list[i] < 0)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine(string.Join(" ",list));
        }
    }
}
