using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Programing15
{
    public class ReplaceOccurenceOfASubstring
    {
        private string word = "start";
        private string replaceWord = "finish";
        private string orginalFile = @"Start.txt";
        private string resultFile = @"Finish.txt";

        public void ReplaceWord()
        {
            using (StreamReader reader = new StreamReader(orginalFile))
            {
                using (StreamWriter writer = new StreamWriter(resultFile))
                {
                    while (!reader.EndOfStream)
                    {
                        writer.WriteLine(reader.ReadLine().Replace(word, replaceWord));                      
                    }
                }
            }
        }
    }
}
