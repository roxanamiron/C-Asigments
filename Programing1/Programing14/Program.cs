using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing14
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            //Console.WriteLine("\n  Define a class Student, which contains the following information about "+
            //    "students: full name, course, subject, university, e-mail and phone number.");
            //Student student = new Student();

            //2.
            //Console.WriteLine("\n Declare several constructors for the class Student, which have different "+
            //    "lists of parameters (for complete information about a student or part of it). Data, which has "+
            //    "no initial value to be initialized with null. Use nullable types for all non-mandatory data.");

            //Student student2 = new Student("\nLucian Ionescu", "Spiru Haret");
            //student2.Printinformation();
            //Student student3 = new Student("\nMircea Ionescu", 0745256423, "mirceaionescu@gmail.com");
            //student3.Printinformation();

            //3.
            //Console.WriteLine("\nAdd a static field for the class Student, which holds the number of created objects of this class.");
            //Console.WriteLine("Student counter is: " + Student.counter);

            //4.
            //Console.WriteLine("\nAdd a method in the class Student, which displays complete information about the student.");
            //Student student4 = new Student("\nFlaviu Popescu", "Engleza", " Literatura engleza", "Babes Bolyai", "flaviu@popescu.com", 0724789456);
            //student4.Printinformation();

            //5.
            //Console.WriteLine("\nModify the current source code of Student class so as to encapsulate the data in the class using properties.");

            //6.
            //Console.WriteLine("\n Write a class StudentTest, which has to test the functionality of the class Student.");
            //StudentTest testStudent = new StudentTest();
            //testStudent.TestFunctionality1();

            //7.
            //Console.WriteLine("\nAdd a static method in class StudentTest, which creates several objects "+
            //    "of type Student and store them in static fields. Create a static property of the class to "+
            //    "access them. Write a test program, which displays the information about them in the console.");
            //Console.WriteLine(StudentTest.GetValues());

            //8.
            //Console.WriteLine("\n Define a class, which contains information about a mobile phone: "+
            //    "model, manufacturer, price, owner, features of the battery (model, idle time and hours "+
            //    "talk) and features of the screen (size and colors).");
            //Phone phone = new Phone();

            //10.          
            //Console.WriteLine("\nTo the class of mobile phone in the previous two tasks, add a static field "+
            //    "nokiaN95, which stores information about mobile phone model Nokia N95. Add a method to the "+
            //    "same class, which displays information about this static field.");
            //Phone phone = new Phone();
            //phone.Display();

            //11.
            //Console.WriteLine("\nAdd an enumeration BatteryType, which contains the values for type of the "+
            //    "battery (Li-Ion, NiMH, NiCd, …) and use it as a new field for the class Battery.");
            //Battery battery = new Battery();
            //battery.Display();

            //12.
            //Console.WriteLine("\nAdd a method to the class Phone, which returns information about the object as a string.");
            //Phone phone2 = new Phone { Model = "Samsung Galaxy S9", Price = 3500 };
            //Console.WriteLine(phone2);

            //14.
            //Console.WriteLine("\n Write a class GSMTest, which has to test the functionality of class GSM. "+
            //    "Create few objects of the class and store them into an array. Display information about the "+
            //    "created objects. Display information about the static field nokiaN95.");
            //GsmTest gsm = new GsmTest();
            //gsm.TestFunctionality2();

            //15.
            //Console.WriteLine("\n  Create a class Call, which contains information about a call made via mobile phone. "+
            //    "It should contain information about date, time of start and duration of the call.");
            //Call call = new Call();

            //16.
            //Console.WriteLine("\nAdd a property for keeping a call history – CallHistory, which holds a list of call records.");

            //17.
            //Console.WriteLine("\nIn Phone class add methods for adding and deleting calls (Call) in the archive of "+
            //    "mobile phone calls. Add method, which deletes all calls from the archive.");
            //Phone phone4 = new Phone();
            //phone4.AddCall(DateTime.Now,5,10);
            //phone4.DeleteCall(5);
            //phone4.ClearHistory();


            //18.
            //Console.WriteLine("\n In GSM class, add a method that calculates the total amount of calls (Call) "+
            //    "from the archive of phone calls (CallHistory), as the price of a phone call is passed as a parameter to the method.");
            //Phone phone5 = new Phone();
            //phone5.TotalAmountOfCalls(0.20);

            //19.
            Console.WriteLine("\nCreate a class GSMCallHistoryTest, with which to test the functionality of the class GSM, "+
                "from task 12, as an object of type GSM. Then add to it a few phone calls (Call). Display information about "+
                "each phone call. Assuming that the price per minute is 0.37, calculate and display the total cost of all calls."+
                "Remove the longest conversation from archive with phone calls and calculate the total price for all calls again. "+
                "Finally, clear the archive.");



            Console.ReadLine();

        }
    }
}
