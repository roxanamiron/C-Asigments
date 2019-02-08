using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing14
{
    public class Phone
    {
        public static string nokiaN95;
        public string Model { get; set; }
        public string Manufacture { get; set; }
        public decimal Price { get; set; }
        public string Owner { get; set; }
        private Battery Battery { get; set; }
        private Screen Screen { get; set; }

        public List<Call> CallHistory = new List<Call>();
        public Phone()
        {            
            Phone.nokiaN95 = "Model Nokia 95";
        }
        public void Display()
        {
            Console.WriteLine("the model of the phone is " + Phone.nokiaN95);
        }
        public override string ToString()
        {
            return "Model: " + Model + " =" + " " + Price + " lei";
        }
        public void AddCall(DateTime date, int startTime, int duration)
        {
            Call call = new Call(date, startTime, duration);
            CallHistory.Add(call);
        }
        public void DeleteCall(int duration)
        {
            for(int i= 0; i < CallHistory.Count; i++)
            {
                if(CallHistory[i].Duration == duration)
                {
                    CallHistory.RemoveAt(i);
                    i--;
                }
            }
        }
        public void ClearHistory()
        {
            CallHistory.Clear();
        }
        public void TotalAmountOfCalls(decimal pricePerMinutes)
        {
           
            decimal wholeTime = 0;

            for(int i= 0; i < CallHistory.Count;i++)
            {
                wholeTime += CallHistory[i].Duration ;
            }
            decimal totalPrice = pricePerMinutes * (Math.Ceiling(wholeTime / 60));
            Console.WriteLine("total price = " + totalPrice);

        }

    }
}
