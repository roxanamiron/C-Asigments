using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing11
{
    public class AreaOfTriangle
    {
        public double firstSide;
        public double secondSide;
        public double thirdSide;
        public double altitude;
        public double angle;
        public double area;
        public double perimeter;


        public void AreaWith3Sides()
        {
            Console.WriteLine("\nInput the first side: ");
            firstSide = double.Parse(Console.ReadLine());
            Console.WriteLine("\nInput the second side: ");
            secondSide = double.Parse(Console.ReadLine());
            Console.WriteLine("\nInput the third side: ");
            thirdSide = double.Parse(Console.ReadLine());

            perimeter = (firstSide + secondSide + thirdSide) / 2;

            area = Math.Sqrt(perimeter * ((perimeter - firstSide) * (perimeter - secondSide) * (perimeter - thirdSide)));
            Console.WriteLine("The Area for the triangle is : {0}", area);
        }
        public void AreaWithOneSideAndAltitude()
        {
            Console.WriteLine("\nInput the first side: ");
            firstSide = double.Parse(Console.ReadLine());
            Console.WriteLine("\nInput the altitude: ");
            altitude = double.Parse(Console.ReadLine());

            area = (firstSide * altitude) / 2;
            Console.WriteLine("the are for this triangle is : {0}", area);
        }

        public void AreaWithTwoSidesAndAngle()
        {
            Console.WriteLine("\nInput the second side: ");
            secondSide = double.Parse(Console.ReadLine());
            Console.WriteLine("\nInput the third side: ");
            thirdSide = double.Parse(Console.ReadLine());
            Console.WriteLine("\nInput the angle: ");
            angle = double.Parse(Console.ReadLine());

            var sin = Math.Sin(angle);
            area = ((secondSide * thirdSide) / 2)*sin;
            Console.WriteLine("The area for this one is : {0}",area);
        }

    }
}
