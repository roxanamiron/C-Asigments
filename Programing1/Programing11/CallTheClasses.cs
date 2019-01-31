using CreatingAndUsingObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing11
{
   public class CallTheClasses
    {
        public void CallTheMethods()
        {
            Cat firstCat = new Cat();
            firstCat.Name = "Tomy";
            firstCat.SayMiau();

            Cat secondCat = new Cat("Sheba", "Brown");
            secondCat.SayMiau();
            Console.WriteLine("Cat {0} is {1}", secondCat.Name, secondCat.Color);

            Cat myCat = new Cat();
            myCat.Name = "Alfred";
            Console.WriteLine("My cat name is {0}", myCat.Name);
            myCat.SayMiau();


            Cat cat1 = new Cat();
            cat1.SayMiau();
            Console.WriteLine("The color of cat {0} is {1}", cat1.Name, cat1.Color);

            Cat cat2 = new Cat("Johny", "brown");
            cat2.SayMiau();
            Console.WriteLine("The color of cat {0} is {1}", cat2.Name, cat2.Color);

            Console.WriteLine("Sequence[1...3]: {0}, {1}, {2}", Sequence.NextValue(), Sequence.NextValue(), Sequence.NextValue());
        }
    }
}
