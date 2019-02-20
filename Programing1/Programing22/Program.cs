using Programing22;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing22
{
   public class Program
    {
        static void Main(string[] args)
        {
            //1.
            Console.WriteLine(new StringBuilder("0124569").Substring(4, 3));

            //2.
            Console.WriteLine("\n Implement the following extension methods for the classes, " +
                "implementing the interface IEnumerable<T>: Sum(), Min(), Max(), Average().");

            List<int> list = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i + 5);
            }

            Console.WriteLine("My elements are: ");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Sum: ");
            Console.WriteLine(list.Sum());

            Console.WriteLine("average: ");
            Console.WriteLine(list.Average());

            Console.WriteLine("Max");
            Console.WriteLine(list.Max());

            Console.WriteLine("Min");
            Console.WriteLine(list.Min());


            //3.
            Console.WriteLine("\nWrite a class Student with the following properties: first name, last name and age." +
                "Write a method that for a given array of students finds those, whose first name is before their " +
                "last one in alphabetical order. Use LINQ.");

            Student[] students = new Student[]
            {
                new Student() {FirstName="Silviu", LastName="Mindras", Age=18},
                new Student() {FirstName="Carmen", LastName="Trandafir", Age=24},
                new Student() {FirstName="Teodor", LastName="Zult", Age=23},
                new Student() {FirstName="Anca", LastName="Antal", Age=21},
                new Student() {FirstName="Bogdan", LastName="Cimpean", Age=19},
                new Student() {FirstName="Daniel", LastName="Moldovan", Age=22}

            };
            var orderedArray = students.OrderBy(x => x.FirstName);
            foreach (var item in orderedArray)
            {
                Console.WriteLine(item.FirstName);
            }

            ////4.
            Console.WriteLine("Create a LINQ query that finds the first and the last name of all students," +
                "aged between 18 and 24 years including. Use the class Student from the previous exercise");
            var result = from student in students
                         orderby student.Age
                         select new { FirstName = student.FirstName, LastName = student.LastName, Age = student.Age };
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            //5.
            Console.WriteLine("\n By using the extension methods OrderBy(…) and ThenBy(…) with lambda expression, " +
                "sort a list of students by their first and last name in descending order. Rewrite the same " +
                "functionality using a LINQ query.");
            var result2 = students.OrderBy(x => x.FirstName).ThenByDescending(x => x.LastName);
            Console.WriteLine("Result using lambda expresion: ");
            foreach (var item in result2)
            {
                Console.WriteLine("first name : {0}, last name : {1}", item.FirstName, item.LastName);
            }

            var result3 = from student in students
                          orderby student.FirstName descending
                          orderby student.LastName
                          select new { FirstName = student.FirstName, LastName = student.LastName };
            Console.WriteLine("Result using linq: ");
            foreach (var item in result3)
            {
                Console.WriteLine(item);
            }

            //6.
            IEnumerable<int> numbers = Enumerable.Range(1, 40);
            Console.WriteLine("using lambda: ");
            Numbers.PrintNumbers(numbers.Where(x =>
            ((x % 7) == 0 && (x % 3) == 0)));

            Console.WriteLine("using linq: ");
            Numbers.PrintNumbers(from n in numbers
                                 where n % 21 == 0
                                 select n);

            //7.
            string sentence = "this iS a Sample sentence.";
            var newSentence = AnotherString.CapitalizesAllLetters(sentence);
            Console.WriteLine(newSentence);

            //8.        
            Console.WriteLine("\n Create a hash-table to hold a phone book: a set of person names and their phone numbers ."+
                "Fill enough random data (e.g. 50,000 key-value pairs). Measure how much time it takes to perform searching "+
                "by key in the hash-table using its native search capabilities, using the extension methods IEnumerable.Contains(…)"+
                "and IEnumerable.Where(…). ");   

            PhoneBook[] phoneBook = new PhoneBook[]
            {
                new PhoneBook {Name="Xpopescu", Phonenumber=0723456789 },
                new PhoneBook {Name="Alexandrescu", Phonenumber=023456963  },
                new PhoneBook {Name="Iliescu", Phonenumber=0233451245 },
                new PhoneBook {Name = "Moldovean", Phonenumber=0233789635 },
                new PhoneBook {Name="Miron", Phonenumber=0233741852 },
                new PhoneBook {Name="Badescu", Phonenumber=0233123654 }
            };
            HashSet<PhoneBook> set = new HashSet<PhoneBook>(phoneBook);
            foreach(var item in phoneBook)
            {
                set.Add(item);
            }

            DateTime start = DateTime.Now;
            PhoneBook keyForSearching = new PhoneBook()
            {
                Name = "Xpopescu",
                Phonenumber= 0723456789

            };
            for(int i = 0; i < 50000; i++)
            {
                bool found = set.Contains(keyForSearching);         
            }
            Console.WriteLine("HashSet: {0}",DateTime.Now-start);

            start = DateTime.Now;
            for(int i = 0; i< 50000; i++)
            {
                bool found = set.Where(p => p == keyForSearching).Count() > 0;
            }
            Console.WriteLine("where: {0}",DateTime.Now-start);

            Console.ReadLine();
        }
    }   
}
