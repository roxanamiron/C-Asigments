using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. https://www.codewars.com/kata/convert-pascalcase-string-into-snake-case
            //Complete the function/method so that it takes CamelCase string and returns the string in snake_case notation. 
            //Lowercase characters can be numbers. If method gets number, it should return string.

            string str = "test_controller";
            Console.WriteLine($"Convert snake_case notatiopn: {str} to CamelCase");
            string newString = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str).Replace('_',' ').Replace(" ",String.Empty);
            Console.WriteLine(newString);

            Console.ReadLine();
        }
    }
}
