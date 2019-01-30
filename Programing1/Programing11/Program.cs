using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing11
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            //Console.WriteLine("1.Write a program, which reads from the console a year and checks if it is a leap year.");
            //LeapOrOrdinaryYear years = new LeapOrOrdinaryYear();
            //int myYear = years.SayYear();
            //years.CheckYear(myYear);

            //2.
            //Console.WriteLine("\n2.Write a program, which generates and prints on the console 10 random numbers in the range [100, 200].");
            //RandomNumbersBetween100And200 randNumber = new RandomNumbersBetween100And200();          
            //randNumber.PrintNumber();

            //3.
            //Console.WriteLine("\n3.Write a program, which prints, on the console which day of the week is today.");
            //DayOfTheWeek todayIs = new DayOfTheWeek();
            //todayIs.PrintDay();

            //4.
            //Console.WriteLine("\n4.Write a program, which prints on the standard output the count of days, "+
            //    "hours, and minutes, which have passes since the computer is started until the moment of the "+
            //    "program execution. For the implementation use the class Environment.");

            //TimeSpan count = new TimeSpan(0, 0, 0, Environment.TickCount);
            //Console.WriteLine("\nThe time elapsed is {0} day(s), {1} hour(s) and {2} minute(s)",count.Days, count.Hours,count.Minutes);

            //5.
            //Console.WriteLine("\n5.Write a program which by given two sides finds the hypotenuse of a right triangle. "+
            //    "Implement entering of the lengths of the sides from the standard input, and for the calculation of the "+
            //    "hypotenuse use methods of the class Math.");
            //RightTriangle findHypotenuse = new RightTriangle();
            //findHypotenuse.FindHypotenuse();

            //6.
            Console.WriteLine("\nWrite a program which calculates the area of a triangle with the following given:" +
                              " -     three sides;" +
                              " -     side and the altitude to it;" +
                              " -     two sides and the angle between them in degrees.");
            AreaOfTriangle calculOne = new AreaOfTriangle();
            calculOne.AreaWith3Sides();
            calculOne.AreaWithOneSideAndAltitude();
            calculOne.AreaWithTwoSidesAndAngle();

            Console.ReadLine();
        }
    }
}
