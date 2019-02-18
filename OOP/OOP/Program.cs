using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            //1.
            School.School school = new School.School("George Enescu");

            School.Classes class1 = new School.Classes("A");

            School.Students[] student = new School.Students[]
            {
                new School.Students ("Roxana","Miron",1245),
                new School.Students ("Daniel","Moldovan",12569),
                new School.Students("Ovidiu","Nistor",14569)

            };
            School.Teachers[] teachers = new School.Teachers[]

            {
                new School.Teachers ("Emilian","Toader").AddCourses(new School.Courses ("Math",2,40)),
                new School.Teachers ("Emilia","Corin").AddCourses(new School.Courses("Literatura",2,45)),
                new School.Teachers("Cristian","Tanase").AddCourses(new School.Courses("fizica",2,15)),
                new School.Teachers("Savu","Alexandru").AddCourses(new School.Courses("chimie",2,10))
            };

            school.AddClass(class1);

            class1.AddStudent(student);
            class1.AddTeacher(teachers);

            class1.RemoveStudent(new School.Students("Ovidiu", "Nistor", 14569));
            class1.RemoveTeacher(new School.Teachers("Cristian", "Tanase"));

            school.RemoveClass(new School.Classes("A"));


            //2.
            Human.Worker worker = new Human.Worker("Costel", "tanase", 3, 7);
            worker.SalaryPerHour();

            Human.Student student0 = new Human.Student("Matei", "Dragos", 1);
            student0.ToString();

            //3.
            Console.WriteLine("\nInitialize an array of 10 students and sort them by mark in ascending order. Use the interface System.IComparable<T>.");
            var studentArray = new Human.Student[]
            {
                new Human.Student("Ovidiu", "Nistor",1),
                new Human.Student("Cristian", "Tanase",2),
                new Human.Student("Daniel","Moldovan",3),
                new Human.Student("Roxana","Miron",4),
                new Human.Student("Relu","Batinas",5),
                new Human.Student("Loredana","Caruntu",6),
                new Human.Student("Anca","Antal",7),
                new Human.Student("Radu","calin",8),
                new Human.Student("Motofelea"," Alex",9),
                new Human.Student("Luciana","Vulea",10)
            };
            var sort = studentArray.OrderBy(s => s.Mark);
            Console.WriteLine(string.Join("\n", sort));


            //4.
            Console.WriteLine("\n  Initialize an array of 10 workers and sort them by salary in descending order.");
            var workersArray = new Human.Worker[]
            {
                new Human.Worker("Palade","George",1.5,5),
                new Human.Worker("Costel","ghita",2.5,10),
                new Human.Worker("mircea","Sandu",2, 12),
                new Human.Worker("Florin","Petre",3,2),
                new Human.Worker("Zsolt","Balass",2.5,25),
                new Human.Worker("Vali","Moldovan",1.2,5),
                new Human.Worker("Ionut","Socaciu",1,1),
                new Human.Worker("Cristi","Mircea",0.5,35),
                new Human.Worker("Sandu","Jecan",2.6,10),
                new Human.Worker("Matei","nistor",3.2,7)
            };
            var sortWorker = workersArray.OrderByDescending(work => work.Salary);
            Console.WriteLine(string.Join("\n", sortWorker));

            //5.
            Console.WriteLine("\nImplement the following classes: Dog, Frog, Cat, Kitten and Tomcat. "+
                "All of them are animals (Animal). Animals are characterized by age, name and gender. "+
                "Each animal makes a sound (use a virtual method in the Animal class). Create an array "+
                "of different animals and print on the console their name, age and the corresponding "+
                "sound each one makes.");
            var animal = new animal.Animal[]
            {
                new animal.Cat("Daisy",1,OOP.animal.Gender.Female),
                new animal.Dog("Sasha",2,OOP.animal.Gender.Female),
                new animal.Frog("Oec",1,OOP.animal.Gender.Male),
                new animal.Kitten("Mitzi",3,OOP.animal.Gender.Male),
                new animal.Tomcat("Tom",4,OOP.animal.Gender.Male)
            };
           foreach(var item in animal)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();

        }
    }
}
