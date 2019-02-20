using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing9
{
  public class Exemples
    {
        public void CalculateTheSum(decimal[] prices)
        {
            //Imagine we are in a bookstore and we want to calculate the amount of money we must pay for all the books we bought.
            //We will create a method that gets the prices of all the books as an array of type decimal[], and then returns the total amount we must pay:

            decimal totalAmunt = 0;
            foreach(decimal singleBookPrice in prices)
            {
                totalAmunt += singleBookPrice;
            }
            Console.WriteLine("The total amount for all the books is:" + totalAmunt);

        }
    }
}
