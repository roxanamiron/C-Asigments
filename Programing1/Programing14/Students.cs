using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing14
{
   public class Students
    {
        public string StudentName { get; set; }
        public int UniqueNumber { get; set; }
        public Students(string studentName, int uniqueNumber)
        {
            this.StudentName = studentName;
            this.UniqueNumber = uniqueNumber;
        }
        public override string ToString()
        {
            return "\nId: " + UniqueNumber + "\nStudent Name: " + StudentName;
        }
    }
    
}
