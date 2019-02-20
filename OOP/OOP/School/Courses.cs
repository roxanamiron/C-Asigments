using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.School
{
   public class Courses
    {
        public string NameOfCourse { get; set; }
        public int CountOfClasses { get; set; }
        public int CountOfExercises { get; set; }
        public Courses(string disciplineName, int countOfClasses = 0, int countOfExercises=0)
        {
            this.NameOfCourse = disciplineName;
            this.CountOfClasses = countOfClasses;
            this.CountOfExercises = countOfExercises;
        }
        public override string ToString()
        {
            return string.Format("Name of the course: {0}, Number of class {1}, Number of exercises: {2}", this.NameOfCourse, this.CountOfClasses, this.CountOfExercises);
        }
    }
}
