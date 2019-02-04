using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing13
{
    public class UsingSplit
    {
        int count = 0;
        
        
        public void SplitMethod(string text)
        {
            var result = string.Empty;
            Console.WriteLine("\nHow many backslashes you must specify as an argument to the method Split(…) in order to split the text by a backslash?");
            StringBuilder build = new StringBuilder();

            string[] txt = text.Split(' ');
            foreach(var t in txt)
            {
                count++;
                result = t + "\\";
                build.Append(result);
                Console.WriteLine(count);                
            }
            Console.WriteLine(build);
           
        }
    }
}
