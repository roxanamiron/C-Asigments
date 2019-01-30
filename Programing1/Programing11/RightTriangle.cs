using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing11
{
   public class RightTriangle
    {
        public void FindHypotenuse()
        {
            Console.WriteLine("\nInput the lengt of the first side: ");
            double firstSide = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the lengt of the second side: ");
            double secondSide = int.Parse(Console.ReadLine());

            
            double hypotenuse = Math.Sqrt((firstSide*firstSide) + (secondSide*secondSide));
            Console.WriteLine("\nThe hypotenuse of a right triangle is : {0}",hypotenuse);
        }
    }
}
