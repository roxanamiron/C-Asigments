using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing11
{
   public class LeapOrOrdinaryYear
    {
        public int year;

        public LeapOrOrdinaryYear()
        {
            
        }

        public int Year
        {
            get { return year; }
            set {  this.year = value; }
        }
        public int SayYear()
        {
            Console.WriteLine("Enter a year: ");
            this.year = int.Parse(Console.ReadLine());
            return this.year;
        }
        public void CheckYear(int year)
        {
            //if is leap the year is divizible with 4 and 400
            if((year % 4 == 0) || (year % 400 == 0))
            {
                Console.WriteLine("this is a leap year");
            }
            else
            {
                Console.WriteLine("this is an ordinary year");
            }
        }
    }
}
