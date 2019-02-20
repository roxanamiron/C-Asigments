using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing14
{
    public class Disciplines
    {
        private string name;

        public string DisciplineName
        { get { return name; }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("disciplines name cannot be empthy");
                }
                this.disciplineName = value;
            }
        }
        public int NumberOfLessons
        {
            get { return nrOfLessons; }
            set
            {
                if(value < 1)
                {
                    throw new ArgumentNullException("the number of lessons cannot be 1");
                }
                this.nrOfLessons = value;
            }
        }
        public int NumberOfExercises
        {
            get { return nrOfExercises; }
            set
            {
                if(value < 1)
                {
                    throw new ArgumentNullException("The number of exercises cannont be 1");
                }
                this.nrOfExercises = value;
            }
        }

        private string disciplineName;
        private int nrOfLessons;
        private int nrOfExercises;

        public Disciplines(string disciplineName, int nrOfLessons, int nrOfExercises)
        {
            this.DisciplineName = disciplineName;
            this.NumberOfLessons = nrOfLessons;
            this.NumberOfExercises = nrOfExercises;
        }       

        public override string ToString()
        {
            return "\nDisciplines: " + DisciplineName + "\nNumber of lessons: " + NumberOfLessons + "\nNumber of exercises: " + NumberOfExercises;
        }
    }
}
