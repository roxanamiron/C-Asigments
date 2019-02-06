using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Programing13
{
    public class ExtractAllDates
    {
        private string text = "I was born at 14.06.1980. My sister was born at 3.7.1984. "+
            "In 5/1999 I graduated my high school. The law says (see section 7.3.12) that "+
            "we are allowed to do this (section 7.4.2.9).";
        private string format = "dd.MM.yyyy";

        public void ExtractDate()
        {
            Console.WriteLine("\nWrite a program that extracts from a text all dates written in "+
                "format DD.MM.YYYY and prints them on the console in the standard format for Canada.");
            //\d{2}  -  Match two decimal digits zero or one time.
            string pattern = @"\d{2}.\d{2}.\d{4}";
            foreach (var item in Regex.Matches(text,pattern))
            {
                string extract = Convert.ToString(item);
                DateTime date = DateTime.ParseExact(extract, format, CultureInfo.InvariantCulture);
                Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA")));
            }
        }
    }
}
