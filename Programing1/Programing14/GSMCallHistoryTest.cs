using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing14
{
    public class GSMCallHistoryTest
    {
        public void TestFunctionality3()
        {
            Phone[] phn = new Phone[] {new Phone { Model="S7 edge", Manufacture= "Samsung", Price=2000},
            new Phone { Model="XS", Manufacture="Apple", Price = 3000 },
            new Phone { Model = "P20", Manufacture="Huawei", Price=1500 }};

            //return the object as a string
            foreach(var model in phn)
            {
                Console.WriteLine(model);
            }

            Console.WriteLine("information about the static field: " + Phone.nokiaN95);

            //callHistory test
            Phone phn2 = new Phone("iPhone X", "Apple", 3500, "Rares");

            //add call and print
            phn2.AddCall(DateTime.Now, 024578, 25);
            phn2.AddCall(DateTime.Now, 0245787942, 55);
            phn2.AddCall(DateTime.Now, 0854578, 05);

            phn2.PrintCall();
            //calculate total amount
            phn2.TotalAmountOfCalls(0.37m);
            //remove the longest conversation , calculate the total amount again and clear history
            phn2.DeleteCall(55);
            phn2.TotalAmountOfCalls(0.37m);
            phn2.ClearHistory();



        }
       
    }
}
