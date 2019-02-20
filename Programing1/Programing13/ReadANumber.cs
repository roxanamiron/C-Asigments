using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing13
{
    public class ReadANumber
    {
        private static int number;
        public void ConvertNumber()
        {
            Console.WriteLine("\n Write a program that reads a number from console and prints it in "+
                "15-character field, aligned right in several ways: as a decimal number, hexadecimal "+
                "number, percentage, currency and exponential (scientific) notation.");

            Console.WriteLine("Enter a positive number: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDecimal number: {0:00} ; \nHexadecimal number: {0:x}\nPercentage:{0:P}\nCurrence:{0:C2}\nExponential:{0:E2}",number);
        }
    }
}
