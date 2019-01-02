using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Create a program that asks the user for a string and:
            //-Replaces all spaces with underscores(storing the result in a new string)
            //-Removes leading spaces(storing the result in another string) 
            //-Removes trailing spaces(storing the result in another string) - NU INTALEG CE SPATII SA ELMIN!!
            //-Replaces all lowercase A by uppercase A(storing the result in another string)
            //The program must display all the strings it generates.

            StringMethod();
            Console.ReadLine();
        }

        static void StringMethod()
        {
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();

            string replaceSpaces = str.Replace(' ', '_');
            Console.WriteLine(replaceSpaces);

            Console.WriteLine(str.Trim());

            Console.WriteLine("Enter the same string with trailling spaces");
            string trailingSpacesString = Console.ReadLine();
            Console.WriteLine(trailingSpacesString.TrimEnd());

            string newString = str.Replace('a', 'A');
            Console.WriteLine(newString);


        }

    }
}
