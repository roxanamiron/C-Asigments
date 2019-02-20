using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing13
{
   public class DateTimeClass
    {
        string format = "dd.MM.yyyy";
        private string first;
        private string second;
        
        public void ReadDate()
        {
            Console.WriteLine("\nWrite a program that reads two dates entered in the format"+
                "\"day.month.year\" and calculates the number of days between them.");

            Console.WriteLine("\nEnter the first date in the format \"day.month.year\": ");
            first = Console.ReadLine();
            DateTime dateOne = DateTime.ParseExact(first, format, CultureInfo.InstalledUICulture);
            
            Console.WriteLine("\nEnter the second date in the format \"day.month.year\": ");
            second = Console.ReadLine();
            DateTime dateTwo = DateTime.ParseExact(second, format, CultureInfo.InstalledUICulture);
            double distance = (dateOne-dateTwo).TotalDays;
            
            Console.WriteLine("distance: {0} day(s)",distance);
        }
    }
}
