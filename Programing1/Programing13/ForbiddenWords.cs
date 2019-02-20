using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Programing13
{
    public class ForbiddenWords
    {
        private static string forbidden;
        private static string givenText;

        

        public void ReplaceTheForbidden()
        {
            Console.WriteLine("\nA string is given, composed of several \"forbidden\" words separated by commas. "+
                "Also a text is given, containing those words. Write a program that replaces the forbidden words with asterisks.");

            Console.WriteLine("\nEnter a sample string containing the forbidden words, separated by commas : ");
            forbidden = Console.ReadLine();

            string[] forbiddenList = forbidden.Split(',');
            StringBuilder build = new StringBuilder();
            Console.WriteLine("\nInput a text,containing forbidden words : ");
            givenText = Console.ReadLine();
            
            foreach(var forb in forbiddenList)
            {
                if(givenText.Contains(forb))
                {
                    build.Append('*', forb.Length);
                    givenText = givenText.Replace(forb,build.ToString());
                }
            }
            Console.WriteLine(givenText);
        }
    }
}
