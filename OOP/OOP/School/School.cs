using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.School
{
   public class School
    {
        private List<Classes> classes = new List<Classes>();

        public string SchoolName { get; set; }
        public School(string schoolName)
        {
            this.SchoolName = schoolName;
        }

        public School AddClass(params Classes[] classe)
        {
            foreach(var clss in classe)
            {
                this.classes.Add(clss);
            }
            return this;
        }
        public School RemoveClass(Classes classe)
        {
            this.classes.Remove(classe);
            return this;
        }
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine(string.Format("  SChool: ", this.SchoolName));
            if(this.classes.Count > 0)
            {
                info.AppendLine(string.Join(Environment.NewLine, this.classes));
            }
            else
            {
                info.AppendLine(" there are no classes in this school");
            }
            return info.ToString();
        }
    }
}
