using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing15
{
   public class Exemples
    {
        const double COEFFICIENT = 1.05;
        const int ADDITION = 5000;
        const string INPUT_FILE = @"GORA.sub";
        const string OUTPUT_FILE = @"StarWars.sub";


        static void UsingStream()
        {
            //create an instance of StreamReader to read from a file
            StreamReader reader = new StreamReader("Sample.txt");

            using (reader)
            {
                int lineNumber = 0;

                //read first line from a text file
                string line = reader.ReadLine();

                //read the other lines from the text file
                while (line != null)
                {
                    lineNumber++;
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                    line = reader.ReadLine();
                }
            }
            //close the resource after you've finished using it
            //reader.Close();
        }
        static void UsingStream2()
        {
            //printing the number [1...20]in a text file

            //create a StreamWriter instance
            StreamWriter writer = new StreamWriter("numbers.txt");

            //ensure the writer will be closed when no longer used
            using (writer)
            {
                //loop through the numbers from 1 to 20 and write them
                for(int i=0; i<= 20; i++)
                {
                    writer.WriteLine(i);
                }
            }
        }
        static void UsingStream3()
        {
            //catching an exception when Opening a file

            string fileName = @"somedir\somefile.txt";
            try
            {
                StreamReader reader = new StreamReader(fileName);
                Console.WriteLine("File {0} succesfully opened",fileName); ;
                Console.WriteLine("File content: ");
                using (reader)
                {
                    Console.WriteLine(reader.ReadToEnd());
                }
            }
            catch(FileNotFoundException)
            {
                Console.Error.WriteLine("Can not find the file {0}", fileName);
            }
            catch(DirectoryNotFoundException)
            {
                Console.Error.WriteLine("Invalid directory in the path name:");
            }catch(IOException)
            {
                Console.Error.WriteLine("can not open the file {0}", fileName);
            }
        }
        static void UsingStream4()
        {
            //occurence of a substring in a file
            string fileName = @"sample.txt";
            string word = "C#";
            try
            {
                StreamReader reader = new StreamReader(fileName);
                using (reader)
                {
                    int occurence = 0;
                    string line = reader.ReadLine();
                    while(line != null)
                    {
                        int index = line.IndexOf(word);
                        while(index != -1)
                        {
                            occurence++;
                            index = line.IndexOf(word, (index + 1));
                        }
                        line = reader.ReadLine();
                    }
                    Console.WriteLine("the word {0} occurs {1} times: ",word,occurence);
                }
            }
            catch(FileNotFoundException)
            {
                Console.Error.WriteLine("can not find the file {0}", fileName);
            }
            catch(IOException)
            {
                Console.Error.WriteLine("cannot read the file {0}", fileName);
            }
        }
        public void UsingStream5()
        {
            //fixing a subtitle
            //we nees to make an adjustment in the time for displaying the subtitles
            //by changing the speed by 1.05

           

            try
            {
                //create reader
                StreamReader reader = new StreamReader(INPUT_FILE);

                //create writer
                StreamWriter writer = new StreamWriter(OUTPUT_FILE, false);

                using (reader)
                {
                    using (writer)
                    {
                        string line;
                        while((line = reader.ReadLine()) !=null)
                        {
                            writer.WriteLine(FixLine(line));
                        }
                    }
                }
            }
            catch(IOException ex)
            {
                Console.Error.WriteLine("Error {0}", ex.Message);
            }
        }

        private static string FixLine(string line)
        {
            //find closing brace
            int braketFromindex = line.IndexOf('}');

            //extract 'from' time
            string fromTime = line.Substring(1, braketFromindex - 1);

            //calculate new 'from' time
            int newFromTime = (int)(Convert.ToInt32(fromTime)* COEFFICIENT + ADDITION);

            //find the following closing brace
            int braketToIndex = line.IndexOf('}', braketFromindex - 1);

            //extract 'to' time
            string toTime = line.Substring(braketFromindex + 2, braketToIndex - braketFromindex - 2);

            //calculate new 'to' time
            int newToTime = (int)(Convert.ToInt32(toTime) * COEFFICIENT + ADDITION);

            //create a new line using the new 'from' and 'to' times
            string fixedLine = "{" + newFromTime + "}" + "{" + newToTime + "}" + line.Substring(braketToIndex + 1);

            return fixedLine;
        }
    }
}
