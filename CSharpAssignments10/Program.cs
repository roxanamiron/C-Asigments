using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments10
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Data structures
            //10.Implement a function to check if a sequence of opened and closed parenthesis is balanced, in other words, if each opened parenthesis corresponds
            //to one closed and they are also well nested.
            //For example:
            //(()()(())) OK
            //(((() ERROR

            Console.WriteLine("Enter brackets :");
            string input = Console.ReadLine();
            Console.WriteLine(" The input is {0} ", BalanceedParanthesis.Check(input) ? "OK" : "ERROR");

            Console.ReadLine();
        }

    }
}
