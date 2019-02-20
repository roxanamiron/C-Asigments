using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Programing15
{
    public class PrintOddLines
    {
        public void Print()
        {
            string path = @"odd.txt.txt";
            StreamReader reader = new StreamReader(path);
            try
            {
                using (reader)
                {
                    string line = reader.ReadLine();
                    int lineCount = 1;
                    while(line != null)
                    {
                        if(lineCount++ % 2 != 0)
                        {
                            Console.WriteLine(line);                           
                        }
                        line = reader.ReadLine();
                    }
                }
            }
            catch(IOException ex)
            {
                Console.Error.WriteLine("the file { 0} was not find", path);
            }
        }
    }
}
