using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.School
{
    public class Teachers : People
    {
        private List<Courses> courses = new List<Courses>();    
        public Teachers(string firstName, string lastName) : base(firstName, lastName)
        {

        }
        public Teachers AddCourses(params Courses[] discipline )
        {
            foreach(var item in discipline)
            {
                this.courses.Add(item);
            }
            return this;
        }
        public override string ToString()
        {
            return string.Format("Teacher First Name: {0}, Teacher Last Name: {1}, Disciple: {2}", this.FirstName, this.LastName, this.courses);
        }

    }
}
