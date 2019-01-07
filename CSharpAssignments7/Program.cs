using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments7
{
    static class Program
    {
        static Random randomSize = new Random();            

        static void Main(string[] args)
        {
            //7. Create a class named "Table". 
            // It must have a constructor, indicating the width and height of the board. It will have a method "ShowData"
            //which will write on the screen the width and that height of the table. Create an array containing 10 tables, 
            //with random sizes between 50 and 200 cm, and display all the data.

          
            WorkingWithArrays();
            Console.ReadLine();
        }

        private static void WorkingWithArrays()
        {
            Table[] array = new Table[10];

            for( int i = 0; i <= 9; i++)
            {
                var newTable = createTable();
                array[i] = newTable;
                array[i].ShowData();
            }            
        }

        private static Table createTable()
        {
            var wedth = randomSize.Next(50, 200);
            var height = randomSize.Next(50, 200);

            Table table = new Table(wedth,height);
            return table;

        }
    }
}
