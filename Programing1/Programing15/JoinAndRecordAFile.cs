using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Programing15
{
   public class JoinAndRecordAFile
    {
        public void ReadWriteFiles()
        {
            string inputFile1 = @"Sample.txt";
            string inputFile2 = @"Second.txt";
            string outputFile = @"third.txt";

            try
            {
                StreamReader reader1 = new StreamReader(inputFile1);
                StreamReader reader2 = new StreamReader(inputFile2);
                StreamWriter writer = new StreamWriter(outputFile);

                using (reader1)
                {
                    using (reader2)
                    {
                        using (writer)
                        {
                            string line = reader1.ReadLine();
                            string line2 = reader2.ReadLine();
                            while ((line != null) && (line2 != null))
                            {
                                writer.WriteLine(line);
                                writer.WriteLine(line2);
                            }
                        }
                    }
                }
            }
            catch(FileNotFoundException)
            {
                Console.Error.WriteLine("File not found");
            }           

        }
    }
}
