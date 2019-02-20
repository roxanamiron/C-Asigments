using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing13
{
    public class EcryptAString
    {
        private static string text;
        private static List<string> chiperCode = new List<string>();
        private static List<string> chiperCode2 = new List<string>();
        private static List<string> code = new List<string>();

        public void ConvertString()
        {
            Console.WriteLine("\n Write a program that encrypts a text by applying XOR (excluding or) "+
                "operation between the given source characters and given cipher code. The encryption should "+
                "be done by applying XOR between the first letter of the text and the first letter of the code, "+
                "the second letter of the text and the second letter of the code, etc. until the last letter of "+
                "the code, then goes back to the first letter of the code and the next letter of the text. Print "+
                "the result as a series of Unicode escape characters \\xxxx.");

           
            byte[] bytes = Encoding.ASCII.GetBytes(text);
            
            foreach(var chr in bytes)
            {
                if(chiperCode.Count == 2)
                {
                    chiperCode2.Add(Convert.ToString(chr, 2));
                }
                else
                {
                    chiperCode.Add(Convert.ToString(chr, 2));

                }

            }
        }
        public void Display()
        {
            Console.WriteLine("Enter a text: ");
            text = Console.ReadLine();
            ConvertString();
            byte[] bytes = new byte[] { };
            var newString = Swap(chiperCode, chiperCode2);
            int bitValue = 1;
            int result = 0;
            for(int i = newString.Count - 1; i >= 0; i-- )
            {
                int numb = Convert.ToInt32(newString[i]);
                result += numb * bitValue;
                bitValue *= 2;  
            }
            Console.WriteLine((char)result);
        }

        private List<string> Swap(List<string> chiperCode, List<string> chiperCode2)
        {
            string newString = string.Empty;
            foreach(var x in chiperCode)
            {
                foreach(var y in chiperCode2)
                {
                    if( x != y)
                    {
                        code.Add("0");
                    }
                    else
                    {
                        code.Add("1");
                    }
                }
            }
            return code;
        }
    }
}
