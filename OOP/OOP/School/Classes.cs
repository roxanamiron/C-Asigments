using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.School
{
   public class Classes
    {
        private List<Students> students = new List<Students>();
        private List<Teachers> teachers = new List<Teachers>();

        public string ClassName { get; set; }
        public Classes(string className)
        {
            this.ClassName = className;
        }
        public Classes AddTeacher(params Teachers[] teacher)
        {
            foreach(var person in teacher)
            {
                this.teachers.Add(person);
            }
            return this;
        }
        public Classes RemoveTeacher(Teachers teacher)
        {
            this.teachers.Remove(teacher);

            return this;
        }
        public Classes AddStudent(params Students[] student)
        {
            foreach(var child in student)
            {
                this.students.Add(child);
            }
            return this;
        }
        public Classes RemoveStudent(Students student)
        {
            this.students.Remove(student);

            return this;
        }
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();

            info.AppendLine(string.Format("\n  Class \"{0}\":", this.ClassName));

            if (this.teachers.Count > 0)
            {
                info.AppendLine("    Teachers: ");
                foreach (var teacher in this.teachers)
                {
                    info.AppendLine("      " + teacher);
                }

            }
            if(this.students.Count > 0)
            {
                info.AppendLine("   Students: ");
                foreach(var student in this.students)
                {
                    info.AppendLine("     " + student);
                }
            }
            return info.ToString();
        }
    }
}
