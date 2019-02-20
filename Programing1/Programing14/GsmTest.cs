using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing14
{
   public class GsmTest
    {
        public void TestFunctionality2()
        {
            Phone[] phone1 = new Phone[] {
                new Phone { Model = "Nokia 50", Price = 500 },
                new Phone { Manufacture = "Samsung", Model = "S7 Edge", Owner = "Roxana", Price = 2000 }
            };
           
            foreach(var item in phone1)
            {
                Console.WriteLine("the new objects: " + item);
            }
            Console.WriteLine("Information about the static field: " + Phone.nokiaN95);            
        }
    }
}
