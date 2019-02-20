using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing22
{
   public static class StringExtensions
    {
       public static StringBuilder Substring(this StringBuilder str, int length, int index)
        {
            Console.WriteLine("Implement an extension method Substring(int index, int length) "+
                "for the class StringBuilder that returns a new StringBuilder and has the same "+
                "functionality as the method Substring(…) of the class String.");

            return new StringBuilder(str.ToString(index, length));
        }
    }
}
