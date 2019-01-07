using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments6
{
  public static class Encrypter
    {
        private const string str1 = " Hola";

      public static void Encrypt(string str1)
        {
          
            byte[] bytes = Encoding.ASCII.GetBytes(str1);
            foreach (var c in bytes)
            {
                var result = c + 1;
                //Console.WriteLine(result);
                char character = (char)result;
                string newString = character.ToString();
                Console.WriteLine($"The new charcter after Encryp is : {newString}");

            }

        }
        

     public static void Decrypt(string str1)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(str1);
        foreach (var c in bytes)
        {
            var result = c - 1;
            char character = (char)result;
            string decriptstring = character.ToString();
                Console.WriteLine($"The new character after Decrypt Method is : {decriptstring}");
            }

        }
        
    }
}
