using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing13
{
    public class ExtractText
    {
        private static string text = "We are living in a yellow submarine. We don't have anything else. "+
            "Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        private static string particularWord = " in ";

        public void Extract()
        {
            Console.WriteLine("\nWrite a program that extracts from a text all sentences that contain a particular word. "+
                "We accept that the sentences are separated from each other by the character \".\" and the words are "+
                "separated from one another by a character which is not a letter. ");
           List<string> result = new List<string>();

            string[] sentences = text.Split('.');
           foreach(var sentence in sentences)
            {
                if (sentence.Contains(particularWord))
                {
                    result.Add(sentence);
                }
            }
            Console.WriteLine(string.Join(".",result));
        }
    }
}
