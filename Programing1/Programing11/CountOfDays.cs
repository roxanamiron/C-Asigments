using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing11
{
    public class CountOfDays
    {
        int workingDays = 0;
        DateTime currentDay = DateTime.Now;
        DateTime givenDay;
        DateTime[] Holidays = new DateTime[]
        {
            new DateTime(2019,01,01),
            new DateTime(2019,01,02),
            new DateTime(2019,01,24),
            new DateTime(2019,04,26),
            new DateTime(2019,04,28),
            new DateTime(2019,04,29),
            new DateTime(2019,05,01),
            new DateTime(2019,06,01),
            new DateTime(2019,06,16),
            new DateTime(2019,06,17),
            new DateTime(2019,08,15),
            new DateTime(2019,11,30),
            new DateTime(2019,12,01),
            new DateTime(2019,12,25),
            new DateTime(2019,12,26),
        };

        DateTime[] workingSaturday = new DateTime[]
        {
            new DateTime(2019,03,26),
            new DateTime(2019,03,23),
            new DateTime(2019,07,27),
            new DateTime(2019,09,28),
            new DateTime(2019,12,07),
        };
        public void CalculateDays()
        {
            Console.WriteLine("Enter a given day for this year (ex:year,month,day) : ");
            givenDay = Convert.ToDateTime(Console.ReadLine());

            for(var day = givenDay.AddDays(1); day <= currentDay; day= day.AddDays(1))

            {
                if (!workingSaturday.Contains(day) && (day.DayOfWeek != DayOfWeek.Sunday) && !Holidays.Contains(day))
                {
                    workingDays++;
                }
            }
            
            Console.WriteLine("The count of workdays between the current date and another given date is {0} ", workingDays);
        }
    }
}
