using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing14
{
    public class Student
    {
        
        public static int counter;


        public string FullName { get; set; }
        public string Course { get; set; }
        public string Subject { get; set; }
        public string University { get; set; }
        public string Email { get; set; }
        public int Phonenumber { get; set; }


        public Student()
        {
            Student.counter += 1;
        }

        public Student(string fullName, string course, string subject, string university, string email, int phoneNumber)
        {
            this.FullName = fullName;
            this.Course = course;
            this.Subject = subject;
            this.University = university;
            this.Email = email;
            this.Phonenumber = phoneNumber;

            Student.counter += 1;
        }
        public Student(string name, int phoneNumber, string email)
        {
            this.FullName = name;
            this.Email = email;
            this.Phonenumber = phoneNumber;           
        }
        public Student(string name, string university)
        {
            this.FullName = name;
            this.University = university;
        }
        public void Printinformation()
        {
            Console.WriteLine("\nFull Name: " + FullName + "\nUniversity :" + University + "\nCourse: " 
                + Course + "\nSubject: " + Subject + "\nPhone Number: " + Phonenumber + "\nE-mail: " + Email);
        }
       
    }
}
