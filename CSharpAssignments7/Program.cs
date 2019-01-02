using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments7
{
    class Program
    {
        static void Main(string[] args)
        {
            //7. Create a class named "Table". 
            // It must have a constructor, indicating the width and height of the board. It will have a method "ShowData"
            //which will write on the screen the width and that height of the table. Create an array containing 10 tables, 
            //with random sizes between 50 and 200 cm, and display all the data.

            WorkingWithOOP();
            WorkingWithArrays();
            Console.ReadLine();
        }

        private static void WorkingWithArrays()
        {
            int[] array = new int[10];
            Random randomSize = new Random();
            int no = randomSize.Next(50, 200);

            for( int i = 0; i <= 9; i++)
            {                
                array[i] = i;
            }

            foreach(int table in array)
            {
                Console.WriteLine(table);
            }
        }

        private static void WorkingWithOOP()
        {
            Table table = new Table();
            table.ShowData(45, 26);

        }
    }
}
