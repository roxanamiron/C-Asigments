using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Human
{
   public class Human
    {
        public string FirstName { get; set; }
        public string LAstName { get; set; }

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LAstName = lastName;
        }
    }
}
