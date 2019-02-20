using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Programing15
{
    public class Oddlines
    {
        private string file = @"odd2.txt.txt";
        private List<string> odd = new List<string>();

        public void WriteOdd()
        {
            odd = ReadTheOdds();
            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach(var line in odd)
                {
                    writer.WriteLine(line);
                }
            }
        }

        public List<string> ReadTheOdds()
        {
            using (StreamReader reader = new StreamReader(file))
            {
                string line = reader.ReadLine();
                int count = 1;
                while (!reader.EndOfStream)
                {
                    if (count++ % 2 != 0)
                    {
                        odd.Add(line);                        
                    }
                    line = reader.ReadLine();
                }
                return odd;
            }
        }
    }
}
