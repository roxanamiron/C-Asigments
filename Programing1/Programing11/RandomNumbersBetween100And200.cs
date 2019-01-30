using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing11
{
   public class RandomNumbersBetween100And200
    {
       
        Random rand = new Random();

        public RandomNumbersBetween100And200()
        {
            
        }
        
        public void PrintNumber()
        {
            for(int i= 1; i <= 10; i++)
            {
                var randNumber = rand.Next(100,200);              
                Console.WriteLine("the 10 random numbers are : {0}", randNumber);
            }
        }

    }
}
