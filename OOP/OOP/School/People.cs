using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
   public class People
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public People(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public override string ToString()
        {
            return string.Format("first Name: {0}, Last Name: {1}", this.FirstName, this.LastName);
        }
    }
}
