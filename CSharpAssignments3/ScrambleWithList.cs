using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpAssignments3
{
    public class ScrambleWithList
    {
        private static OriginalLetters letter;

        public static bool scramble(string str1, string str2)
        {
            var list1 = getLetters(str1);
            var list2 = getLetters(str2);
            var result = compare(list1, list2);
            return result;
        }

        /// <summary>
        /// Extract letters from a string
        /// </summary>
        /// <param name = "str1" ></ param >
        /// < returns ></ returns >
        private static List<OriginalLetters> getLetters(string str1)
        {
            var lis1 = new List<OriginalLetters>();
            foreach (var letter in str1)
            {

                if (!lis1.Any(x => x.Letter == letter))
                {
                    var originalLetter = new OriginalLetters
                    {
                        Letter = letter,
                        NumberOfAppearences = 1
                    };
                    lis1.Add(originalLetter);
                }
                else
                {
                    //set
                    var element = lis1.FirstOrDefault(e => e.Letter == letter);
                    element.NumberOfAppearences++;
                }                
            }
            return lis1;
        }

        private static bool compare(List<OriginalLetters> list1, List<OriginalLetters> list2)
        {
            //parcurg prima lista  
            //si cautam elementul cu aceeasi litera din a 2 lista 
            //si apoi le comparam intre ele;
       foreach(var element1 in list1)
            {
                var element2 = list2.FirstOrDefault(e => e.Letter == element1.Letter);
                if(element2 == null)
                {
                    return false;
                }
                if(element2.NumberOfAppearences < element1.NumberOfAppearences)
                {
                    return false;
                }
                              
            }
            return true;
        }
    }
}
