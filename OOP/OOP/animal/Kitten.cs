using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.animal
{
    public class Kitten : Animal
    {
        public Kitten(string animalName, int age, Gender gender) : base(animalName, age, gender)
        {
        }

        public override string Sound()
        {
            return ("Chiuauuu");
        }
    }
}
