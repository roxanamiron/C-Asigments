using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments9
{
    public class Program
    {
        static void Main(string[] args)
        {
            //9. Create a project named "Tables2", based on the "Tables" project.
            //In it, create a class "CoffeeTable" that inherits from "Table". Its method “ShowData", besides writing the width and height, must display "(Coffee table)."
            //Create an array that contains 5 tables and 5 coffee tables.The tables must have random sizes between 50 and 200 cm, and the coffee tables from 40 to 120 cm.Show all their data.

            CoffeeTable coffeTable = new CoffeeTable();
            coffeTable.ShowData(45,25);
            coffeTable.CreateArray();

            Console.ReadLine(); 

        }
}
}
