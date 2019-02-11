using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing14
{
   public class TestSchool
    {
        public void TestSchoolFunctionality()
        {
            School school = new School("George Cosbuc");
            Classes cl1 = new Classes("A");
            Classes cl2 = new Classes("B");
            Classes cl3 = new Classes("C");

            Students st1 = new Students("Popovici Alex", 1);
            Students st2 = new Students("stamatian emanuel", 2);
            Students st3 = new Students("Corina", 3);
            Students st4 = new Students("Matei", 4);
            Students st5 = new Students("Anisoara", 5);

            Teacher tc1 = new Teacher("TeacherOne");
            Teacher tc2 = new Teacher("TeacherTwo");
            Teacher tc3 = new Teacher("TeacherThree");

            Disciplines d1 = new Disciplines("Math", 20, 180);
            Disciplines d2 = new Disciplines("enghlish", 10, 100);
            Disciplines d3 = new Disciplines("chemestry", 15, 80);
            Disciplines d4 = new Disciplines("French", 10, 50);

            school.AddClass(cl1);
            cl1.AddStudent(st1);
            cl1.AddStudent(st2);
            cl1.AddTeacher(tc1);
            cl1.AddTeacher(tc2);
            cl1.AddTeacher(tc3);
            
            school.AddClass(cl2);
            cl2.AddStudent(st3);
            cl2.AddStudent(st4);
            cl2.AddTeacher(tc1);
            cl2.AddTeacher(tc2);
            cl2.AddTeacher(tc3);

            school.AddClass(cl3);
            cl3.AddStudent(st4);
            cl3.AddStudent(st5);
            cl3.AddTeacher(tc1);
            cl3.AddTeacher(tc2);
            cl3.AddTeacher(tc3);


        }
    }
}
