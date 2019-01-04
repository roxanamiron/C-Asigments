using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments11
{
    class Program
    {
        static void Main(string[] args)
        {
            //11.Create a program to allow the user to enter an unlimited amount of numbers.Also, they can enter the following commands:
            //"sum", to display the sum of all the numbers entered so far.
            //"view", to display all the numbers entered.
            //"end", to quit the program.
            //This is an execution sample:

            //Number or command ? 5
            //Number or command? 3
            //Number or command? view
            //Entered numbers:
            //5
            //3
            //Number or command ? 6
            //Number or command? sum
            //Sum = 14
            //Number or command ? -7
            //Number or command? End         

            string key;
          Console.WriteLine("Number or command( Sum , View, End)?");

            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Number or command( Sum , View, End)?");
            double y = Convert.ToDouble(Console.ReadLine());
            while (true)
            {                
                Console.WriteLine("Number or command( Sum , View, End)?");
                string command = Console.ReadLine();
                switch(command)
                {
                    case "sum":
                        Console.WriteLine($"Sum = {x+y}");
                        break;
                    case "view":
                        Console.WriteLine("entered numbers: ");
                        Console.WriteLine($"{x},{y}");
                        break;
                    case "End":
                        Environment.Exit(0);
                        break;
                }

            }
           
        }
    }
}
