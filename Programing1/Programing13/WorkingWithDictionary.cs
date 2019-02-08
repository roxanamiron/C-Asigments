using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing13
{
   public class WorkingWithDictionary
    {
        Dictionary<string, string> dict = new Dictionary<string, string>();
        private static string word;
     
        public void Create()
        {           
            dict.Add(".NET", "- platform for applications from Microsoft");
            dict.Add("CLR", "– managed execution environment for .NET");
            dict.Add("namespace", "– hierarchical organization of classes");
        }
        public void ReadWords(string word)
        {
           Create();
        foreach(var item in dict)
            {
                if (item.Key.Contains(word))
                {
                    Console.WriteLine("{0} {1}", word, item.Value);
                }
                else
                {
                    Console.WriteLine("Word not found");
                }
            }
           
        }
    }
}
