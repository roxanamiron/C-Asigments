using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments6
{
  public static class Encrypter
    {   

      public static void Encrypt(string str1)
        {
            StringBuilder newString = new StringBuilder();
            str1 = "Hola";
          
            foreach(var chr in str1)
            {
                 newString = chr + 1;
                Console.WriteLine(newString);
            }

           
        }
        

        static void Decrypt()
        {

        }
        
    }
}
