using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Programing15
{
   public class DeleteAllTestWords
    {
        private string file = @"test.txt";
        private string pattern = "test";
        StringBuilder builder = new StringBuilder();

        public void ReadFile()
        {
            using (StreamReader reader = new StreamReader(file))
            {
                while(!reader.EndOfStream)
                {
                    string line = Regex.Replace(reader.ReadLine(), pattern, String.Empty);
                    Console.WriteLine(line);
                }
            }
        }
    }
}
