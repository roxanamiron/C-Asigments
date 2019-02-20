using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing13
{
   public class AnotherDate
    {
        private string format = "dd.MM.yyyy HH:mm:ss";
        private string date;
       

        public void ReadADate()
        {
            Console.WriteLine("\nWrite a program that reads the date and time entered in the format "+
                "\"day.month.year hour: minutes:seconds\" and prints the date and time after 6 hours and 30 minutes in the same format.");

            Console.WriteLine("\nEnter a date in format: day.month.year hour:minutes:seconds : ");
            date = Console.ReadLine();
            DateTime currentDate = DateTime.ParseExact(date, format, CultureInfo.InvariantCulture);

            DateTime laterDate = currentDate.AddHours(6.5);
            Console.WriteLine("the new time is: {0}",laterDate);

        }
    }
}
