using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.animal
{
   public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        private Gender Gender { get; set; }

        public Animal(string animalName, int age, Gender gender)
        {
            this.Name = animalName;
            this.Gender = gender;
            this.Age = age;
        }
        public abstract string Sound();
        public override string ToString()
        {
            return string.Format("animal Name: {0}, age: {1}, Gender: {2}, Sound: {3}", this.Name, this.Age, this.Gender,this.Sound());
        }

    }

}
