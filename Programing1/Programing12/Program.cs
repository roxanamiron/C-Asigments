using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing12
{
   public class Program
    {
        static void Main(string[] args)
        {
            //7.
            SquareRootOfInteger square = new SquareRootOfInteger();
            square.PrintSquare();

            //8.
            TakeTenIntegers tenintegers = new TakeTenIntegers();
            tenintegers.Print();

            //9.
            FileClass file = new FileClass();
            string fileName = "originalFile.txt";
            file.ReadFile(fileName);

            //10.
            FileClass file2 = new FileClass();
            string fileName2 = "originalFile.txt";
            file2.ReturnTheFile(fileName2);

            //11.
            FileParseException exception = new FileParseException("originalFile.txt", 3);
            exception.ReadFile("originalFile.txt");

            //12.
            IOFile readFile = new IOFile();
            Console.WriteLine("Enter the path for the existing file.");
            string path = Console.ReadLine();
            readFile.ReadTheFile(path);

            //13.
            DownloadAFileFromInternet download = new DownloadAFileFromInternet();
            download.DownloadFile();


            Console.ReadLine();
        }
    }
}
