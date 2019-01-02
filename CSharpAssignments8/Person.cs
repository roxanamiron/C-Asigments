using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments8
{
    public class Person : House
    {
        public string Name { get; set; } 
        public Person()
        {

        }
        public Person(string name):base(name)
        {
            Name = name;
        }
        public override void ShowData(string name)
        {
            Console.WriteLine("{0} has a house",name);
            Door door = new Door();
            door.ShowData("green");

        }
    }
}
