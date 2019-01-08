using CSharpAssignments7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments9
{
    public class CoffeeTable : Table
    {
        Table table = new Table();
       
        
        public void ShowData(int width, int height)
        {
            table.ShowData();
            Console.WriteLine("Coffee table");
        }

        public void CreateArray()
        {
            int[] tableArray = new int[5];
            int[] coffeeTablesArray = new int[5];
            Random randomSize = new Random();
            //var randomTable = tableArray[randomSize.Next(50, 200)];
            //var randomCoffeTable = coffeeTablesArray[randomSize.Next(40, 120)];

            for(int i = 0; i<= 4; i++)
            {
                tableArray[i] = randomSize.Next(50, 200);
                
                coffeeTablesArray[i] = randomSize.Next(40, 120);
               
            }
            foreach (var table in tableArray)
                Console.WriteLine($"Show all the tables: {table} ");
            foreach (var coffeeTable in coffeeTablesArray)
                Console.WriteLine($"Show all the coffeeTables: {coffeeTable}");

        }
    }
}
