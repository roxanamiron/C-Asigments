using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing12
{
   public class FileParseException : Exception
    {
        private string fileName;
        private int numberOfRows;

        public string FileName { get; set; }
        public int NumberOfRows { get; set; }

        public FileParseException(string fileName, int numberOfRows) :base (string.Format("error in file {0} on row {1}.",fileName,numberOfRows))
        {
            FileName = fileName;
            NumberOfRows = numberOfRows;
        }

        public void ReadFile(string fileName)
        {
            Console.WriteLine("\nSearch for information in Internet and define your own class for exception FileParseException. "+
                "The exception has to contain the name of the processed file and the number of the row where the problem is occurred. "+
                "Add appropriate constructors in the exception. Write a program that reads integers from a text file. If the during "+
                "reading a row does not contain an integer throw FileParseException and pass it to the calling method.");

            try
            {
                TextReader reader = new StreamReader(fileName);
                string line = reader.ReadLine();
                Console.WriteLine(line);
                reader.Close();
            }
            catch(FileParseException fp)
            {
                Console.WriteLine("error while parsing file {0} on row {1}.",fp.FileName,fp.NumberOfRows);
            }
        }

        


    }
}
