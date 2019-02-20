using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing11
{
    public class DayOfTheWeek
    {
        public DateTime dayNumber;
        public DayOfWeek dayName;

        public DateTime DayNumber
        {
            get { return dayNumber; }
            set { dayNumber = value; }
        }
        public DayOfWeek DayName
        {
            get { return dayName; }
            set { dayName = value; }
        }
        public DayOfTheWeek()
        {

        }
        public void PrintDay()
        {
            dayNumber = DateTime.Today;
            dayName = dayNumber.DayOfWeek;
            Console.WriteLine("The day of the week for {0} is {1}", dayNumber, dayName);
        }
    }
}
