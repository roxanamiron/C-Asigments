using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing14
{
   public class Teacher
    {
        public List<Disciplines> variatyOfDisciplines
        {
            get { return new List<Disciplines>(this.disciples); }
            
        }
        private string teacherName;
        private string name;
        private List<Disciplines> disciples;

        public Teacher(string name) 
        {
            this.disciples = new List<Disciplines>();
            this.teacherName = name;
        }     
        
        public void AddDisciples(Disciplines discipline)
        {
            this.disciples.Add(discipline);
        }
        private void DisplayDisciplenes()
        {
            foreach(var discipline in variatyOfDisciplines)
            {
                Console.WriteLine("\nDisciplines: " + discipline.DisciplineName + "\nNumber of lessons: " + discipline.NumberOfLessons + "\nNumber of exercises: " + discipline.NumberOfExercises);
            }
        }
    }
}
