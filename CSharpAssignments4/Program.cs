using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments4
{
   public class Program
    {
        static void Main(string[] args)
        {
            //4. https://www.codewars.com/kata/convert-pascalcase-string-into-snake-case
            //Complete the function/method so that it takes CamelCase string and returns the string in snake_case notation. 
            //Lowercase characters can be numbers. If method gets number, it should return string.

            string str = "test_controller";
            Console.WriteLine($"Convert snake_case notatiopn: {str} to CamelCase");
            //string newString = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str).Replace('_',' ').Replace(" ",String.Empty);
            str = Console.ReadLine();
            var finalResult = camelCase(str);
            
            
            Console.WriteLine(finalResult);

            Console.ReadLine();
        }

        public static string camelCase(string str)
        {
            ///extragem cuvintele
            ///parcurgem fiecare cuvand 
           

            var words = str.Split('_');
            var finalresult = new StringBuilder();

            foreach(var word in words)
            {
                var result = camelCaseWord(word);
                finalresult.Append(result);
            }
            return finalresult.ToString();
        }

 /////si parcurgem fiecare litera a cuvantului 
            /////verifcam daca e prima litera si facem UpperCase si o adaugam la rezultat
            //si daca nu e prima, o adaugam la resultat
        public static string camelCaseWord(string str)
        {
            var finalResult = new StringBuilder();
            var index = 0;
            foreach (var letter in str)
            {
                if(index == 0)
                {
                    var result = letter.ToString().ToUpper();
                    finalResult.Append(result);                    
                }
                else
                {
                    finalResult.Append(letter);
                }
                index++;
            }
            return finalResult.ToString();
        }
    }
}
