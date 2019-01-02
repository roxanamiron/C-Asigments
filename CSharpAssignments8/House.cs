using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments8
{
    public class House
    {
        public string Area { get; set; } = "45";

        public House()
        {

        }
        public House(string area)
        {
            Area = area;
        }

         public virtual void ShowData(string area)
        {
            Console.WriteLine("I am a house, my area is {0} m2.",area);
        }
        void GetDoor()
        {

        }
    }

    public class Door : House
    {
        public string Color { get; set; }
        public Door()
        {

        }
        public Door(string color)
        {
            Color = color;
        }
        

        public override void ShowData(string color)
        {
            Console.WriteLine("I am door, my color is {0}.",color);
        }
    }
}
