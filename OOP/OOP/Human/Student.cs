using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Human
{
    public class Student : Human
    {
        public int Mark { get; set; }
        public Student(string firstName, string lastName,int mark) : base(firstName, lastName)
        {
            this.Mark = mark;
        }
        public override string ToString()
        {
            return string.Format("Student First Name: {0}, Student Last Name: {1}, Mark: {2}", this.FirstName, this.LAstName, this.Mark);
        }
    }
}
