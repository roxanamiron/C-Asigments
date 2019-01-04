using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments6
{
    class Program
    {
        static void Main(string[] args)
        {
            //OOP
            //6. Create a class "Encrypter" to encrypt and decrypt text.
            //It will have a "Encrypt" method, which will receive a string and return another string.It will be a static method,
            //so that we do not need to create any object of type "Encrypter".
            //There will be also a "Decrypt" method.
            //In this first approach, the encryption method will be a very simple one: to encrypt we will add 1 to each character,
            //so that "Hola" would become "Ipmb", and to decrypt we would subtract 1 to each character.
            //An example of use might be
            //string newText = Encrypter.Encrypt("Hola");

            Encrypter.Encrypt("Hola");


        }
    }
}
