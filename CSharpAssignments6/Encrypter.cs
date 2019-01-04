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
            str1 = "Hola";
            foreach(var chr in str1)
            {
                var newString = chr + 1;
                newString = BitConverter.ToString(bytes);
                Console.WriteLine(newString);
            }
            

        }
        

        static void Decrypt()
        {

        }
        
    }
}
