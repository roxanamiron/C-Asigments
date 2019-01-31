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
            //Console.WriteLine("\n6.Write a program which calculates the area of a triangle with the following given:" +
            //                  " -     three sides;" +
            //                  " -     side and the altitude to it;" +
            //                  " -     two sides and the angle between them in degrees.");
            //AreaOfTriangle calculOne = new AreaOfTriangle();
            //calculOne.AreaWith3Sides();
            //calculOne.AreaWithOneSideAndAltitude();
            //calculOne.AreaWithTwoSidesAndAngle();

            //7.
            //Console.WriteLine("\n7.Define your own namespace CreatingAndUsingObjects and place in it two classes "+
            //    "Cat and Sequence, which we used in the examples of the current chapter. Define one more namespace "+
            //    "and make a class, which calls the classes Cat and Sequence, in it.");
            //CallTheClasses callClasses = new CallTheClasses();
            //callClasses.CallTheMethods();

            //8.
            //Console.WriteLine("\n8.Write a program which creates 10 objects of type Cat, gives them names CatN, "+
            //    "where N is a unique serial number of the object, and in the end call the method SayMiau() for "+
            //    "each of them. For the implementation use the namespace CreatingAndUsingObjects.");

            //string name = "Cat";
            //for (int i = 1; i <= 10; i++)
            //{
            //    Cat cat = new Cat(name + Sequence.NextValue(), "Black");
            //    cat.SayMiau();
            //}

            //9.
            //Console.WriteLine("\n9.Write a program, which calculates the count of workdays between the current "+
            //    "date and another given date after the current (inclusive). Consider that workdays are all days from "+
            //    "Monday to Friday, which are not public holidays, except when Saturday is a working day. The program "+
            //    "should keep a list of predefined public holidays, as well as a list of predefined working Saturdays.");
            //CountOfDays count = new CountOfDays();
            //count.CalculateDays();

            //10
            //Console.WriteLine("\nYou are given a sequence of positive integer numbers given as string of numbers "+
            //    "separated by a space. Write a program, which calculates their sum. Example: \"43 68 9 23 318\" à 461.");
            //SequenceOfPositiveIntegerNumbers sum = new SequenceOfPositiveIntegerNumbers();
            //sum.CalculateSum();

            //11.
            //Console.WriteLine("\nWrite a program, which generates a random advertising message for some product. " +
            //    "The message has to consist of laudatory phrase, followed by a laudatory story, followed by author " +
            //    "(first and last name) and city, which are selected from predefined lists. For example, let’s have the following lists:");
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //RandomAdvertisingMessage message = new RandomAdvertisingMessage();
            //message.GetStrings();

            //12.
            Console.WriteLine("\nWrite a program, which calculates the value of a given numeral expression given as a string. The numeral expression consists of:" +
                "-real numbers, for example 5, 18.33, 3.14159, 12.6; " +
               " -arithmetic operations: +, -, *, / (with their standard priorities);" +
               " -mathematical functions: ln(x), sqrt(x), pow(x, y);" +
               "-brackets for changing the priorities of the operations: (and)." +
               " Note that the numeral expressions have priorities, for example the expression - 1 + 2 + 3 * 4 - 0.5 = (-1) + 2 + (3 * 4) - 0.5 = 12.5.)");
            Calculator calc = new Calculator();
            calc.Calculate();

            Console.ReadLine();
        }
    }
}
