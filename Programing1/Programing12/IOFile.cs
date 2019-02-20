using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing12
{
   public class IOFile
    {
        private string path;

        public string Path { get; set; }
        public IOFile()
        {
            
        }

        public void ReadTheFile(string path)
        {
            Console.WriteLine("\nWrite a program that gets from the user the full path to a file (for example C:\\Windows\\win.ini), "+
                "reads the content of the file and prints it to the console. Find in MSDN how to us the System.IO.File.");

            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line = reader.ReadLine();
                    Console.WriteLine(line);
                    reader.Close();
                }
            }
            catch(FileNotFoundException f)
            {
                Console.WriteLine("the file was not found");
                Console.WriteLine(f.Message);
            }
            catch(DirectoryNotFoundException d)
            {
                Console.WriteLine("the directory was not found");
                Console.WriteLine(d.Message);
            }
            catch(UnauthorizedAccessException error)
            {
                Console.WriteLine("Error UnauthorizedAccessException");
                Console.WriteLine(error.Message);
            }
            catch(PathTooLongException p)
            {
                Console.WriteLine("tha path is too long");
                Console.WriteLine(p.Message);
            }
            catch(EndOfStreamException e)
            {
                Console.WriteLine("reading is attempted past the end of a stream.");
                Console.WriteLine(e.Message);
            }            
        }

    }
}
