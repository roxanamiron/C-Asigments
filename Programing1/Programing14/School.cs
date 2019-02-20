using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing14
{
    public class School
    {
        public List<Classes> Classes
        {
            get { return new List<Classes>(this.classes); }
        }
        private List<Classes> classes;
        public List<Students> Students;
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("the scool's name connot be empthy");
                }
                this.name = value;
            }
        }
        public School(string name)
        {
            this.Name = name;
            this.classes = new List<Classes>();
        }
        public void AddClass(Classes someClasses)
        {
            this.classes.Add(someClasses);
        }

        public override string ToString()
        {
            StringBuilder build = new StringBuilder();
            build.AppendLine(string.Format(this.name));
            foreach (var classs in classes)

            {

                build.AppendLine(string.Format("{0}", classs));

            }
            return build.ToString();
        }
    }
}
