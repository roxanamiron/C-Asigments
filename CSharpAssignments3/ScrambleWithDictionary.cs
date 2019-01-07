using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
            //Dictionary<string, int> dict1 = new Dictionary<string, int>();
            

            //for(int i = 0; i < str1.Length; i++)
            //{
            //     key =str1[i].ToString();
            //    for(int j = 0; j < str1.Length -1; j++)
            //    {
            //         val = str1[(j + 1)];
            //    }
            //    dict1.Add(key, val);
            //}
            //foreach( var letter in dict1)
            //{
            //    int count;
            //    if(dict1.TryGetValue(key, out count))
            //    {
            //        dict1[key] = count + 1;
            //    }                
            //}
namespace CSharpAssignments3
{
public static class ScrambleWithDictionary
    {
        public static bool scramble(string str1, string str2)
        {
            var dict1 =getLetters(str1);
           var dict2 = getLetters(str2);
           var result = compare(dict1, dict2);
            return result;
        }

        /// <summary>
        /// Extract letters from a string
        /// </summary>
        /// <param name="str1"></param>
        /// <returns></returns>
        private static Dictionary<char,int> getLetters(string str1)
        {
            var dict1 = new Dictionary<char, int>();
            foreach(var letter in str1)
            {
                if(!dict1.ContainsKey(letter))
                {
                    dict1.Add(letter, 1);
                }
                else
                {
                    //set
                    dict1[letter] = dict1[letter] + 1;
                }
            }
            return dict1;
        }

        private static bool compare(Dictionary<char, int> dict1, Dictionary<char, int> dict2)
        {
            foreach(var pair1 in dict1)
            {
                var letter = pair1.Key;
                if (!dict2.ContainsKey(letter))
                {
                    return false;
                }
                var numberOfAppearences1= pair1.Value;
                
                var numberOfAppearences2 = dict2[letter];

                if(numberOfAppearences1 > numberOfAppearences2)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
