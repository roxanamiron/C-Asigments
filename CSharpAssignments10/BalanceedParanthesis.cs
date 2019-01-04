using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments10
{
   public static class BalanceedParanthesis
    {
       public static char[] openParanthesis = { '(', '[', '{' };
       public static char[] closeParanthesis = { ')', ']', '}' };

        public static bool Check(string paranthesis)
        {
            Stack<int> bracket = new Stack<int>();
            foreach(var chr in paranthesis)
            {
                int indexArray;
                if((indexArray = Array.IndexOf(openParanthesis,chr)) != -1)
                {
                    bracket.Push(indexArray);
                }
                else if((indexArray = Array.IndexOf(closeParanthesis,chr)) != -1)
                {
                    if (bracket.Count == 0 || bracket.Pop() != indexArray)
                        return false;
                }
            }
            return bracket.Count == 0;
        }
       
    }

}
