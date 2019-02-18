using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.School
{
    public class Students : People
    {
        public Students(string firstName, string lastName, int uniqueNumber) : base(firstName, lastName)
        {
            this.UniqueNumber = uniqueNumber;
        }
        public int UniqueNumber { get; set; }

        public override string ToString()
        {
            return string.Format("Student First name: {0}, Student Last Name: {1}, Unique Number: {2}", this.FirstName, this.LastName, this.UniqueNumber);
        }
    }
}
