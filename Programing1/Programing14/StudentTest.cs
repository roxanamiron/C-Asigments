using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing14
{
   public class StudentTest
    {
        static int objectNumber = 3;

        public int ObjectNumber
        {
            get { return objectNumber; }
            set { value = objectNumber; }
        }
        public void TestFunctionality1()
        {
            Student s1 = new Student("Popescu Alexandru", "Spiru Haret");
            s1.Printinformation();
            Student s2 = new Student("alexandru andries", "Babes Bolyai");
            s2.Printinformation();
           
        }

        static StudentTest()
        {
            StudentTest.objectNumber ++;
            
        } 
        public static int GetValues()
        {
            var listOfStudents = new List<Student>()
            {
                new Student ("Andreea mircea","Bogdan Voda"),
                new Student("Roxana Miron", "Babes Bolyai"),
                new Student("Daniel Moldovan","Spiru Haret")
            };
            return StudentTest.objectNumber;
        }
    }
}
