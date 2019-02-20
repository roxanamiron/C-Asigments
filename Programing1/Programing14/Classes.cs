using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing14
{
   public class Classes
    {
        public List<Teacher> NumberOfteachers
        {
            get { return new List<Teacher>(teachers); }
        }
        public List<Students> Students
        {
            get { return new List<Programing14.Students>(students); }
        }
        public string UniqueTextIdentifer
        {
            get { return className; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("Class identifier canmot be empthy");
                }
                this.className = value;
            }
        }       
        private string className;

        private List<Students> students;
        private List<Teacher> teachers;

        public Classes(string className)
        {
            this.UniqueTextIdentifer = className;
            this.students = new List<Students>();
            this.teachers = new List<Teacher>();
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }
        public void AddStudent(Students student)
        {
            this.students.Add(student);
        }        
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(string.Format("Class {0} , Student {1} ", this.NumberOfteachers, this.students.Count));
            for(int i = 0; i < this.students.Count;i++)
            {
                builder.AppendFormat("{0}", this.students[i]);
            }
            builder.AppendFormat("Teachers: {0}", this.teachers.Count);
            for(int i = 0; i < this.teachers.Count;i++)
            {
                builder.AppendLine(string.Format("{0}",this.teachers[i]));
            }
            return builder.ToString();
        }
    }
}
