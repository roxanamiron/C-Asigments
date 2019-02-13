using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Programing15
{
    public class InsertLineNumbers
    {
        public void InsertNumbers()
        {
            string input = @"Sample.txt";
            string output = @"output.txt";
            int lineNr = 1;
            StreamReader reader = new StreamReader(input);
            StreamWriter writer = new StreamWriter(output);



            using (reader)
            {
                using (writer)
                {
                    string line = reader.ReadLine();
                    while(line != null)
                    {
                        writer.WriteLine("{0}-{1}", lineNr, line);
                        lineNr++;
                        line = reader.ReadLine();
                    }
                   
                }
            }
        }
    }
}
