using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Programing15
{
   public class CompareTwoFiles
    {
        public void CompareFiles()
        {
            int equalLine = 0;
            int differentLine = 0;
            StreamReader r1 = new StreamReader(@"Sample.txt");
            StreamReader r2 = new StreamReader(@"Sample2.txt");

            using (r1)
            {
                using (r2)
                {
                    string line1 = r1.ReadLine();
                    string line2 = r2.ReadLine();
                    while((line1 != null) && (line2 != null))
                    {
                        if((line1 != line2) || (line2 != line1))
                        {
                            differentLine++;
                        }
                        else
                        {
                            equalLine++;
                        }
                         line1 = r1.ReadLine();
                         line2 = r2.ReadLine();
                    }
                    Console.WriteLine("equal line = {0} and diffrent lines = {1}",equalLine,differentLine);
                }
            }

        }
    }
}
