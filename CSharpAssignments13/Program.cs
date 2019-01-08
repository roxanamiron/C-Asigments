using System;
using System.IO;
using System.Linq;
using System.Text;

namespace CSharpAssignments13
{
    class Program
    {
         
        private static string result;

        static void Main(string[] args)
        {
            //13.Create a program to create an HTML file containing the list of images (PNG and JPG) in the current directory.
            //For example, in the current directory there are images called.
            //1.png
            //2.jpg
            //The result should be:
            //< html >
            //< body >
            //< p > 1.png </ p >
            //< img src = "1.png" alt = "1.png" />
            //   < p > 2.jpg </ p >
            //   < img src = "2.jpg" alt = "2.jpg" />
            //      </ body >
            //      </ html >

            // Get the directories currently on the C drive.
            

        displayFile();
        Console.ReadLine();
        }

        private static void displayFile()
        {
            var display = getFiles();
            Console.WriteLine(display);
        }

        public static string getImagesPath()
        {
            string fileResult;
            string path = @"F:\file.html";
            string pathImage1 = "1.png";
            string pathImage2 = "2.jpg";
            string imageValue1 = "<img src = \"" + pathImage1 + "\" alt = \"" + pathImage1 + "\" />";
            string imageValue2 = "<p  " + pathImage1 + " </p>";
            string imageValue3 = "<img src = \"" + pathImage2 + "\" alt = \"" + pathImage2 + "\" />";
            string imageValue4 = "<p> " + pathImage2 + " </p>";

            //creaza fisierului
            FileStream file = new FileStream(path, FileMode.Create);
            
          //scrie toate liniile in fisier
                using (StreamWriter streamWriter = new StreamWriter(file))
                {
                    streamWriter.WriteLine("<html>");
                    streamWriter.WriteLine("<body>");
                    streamWriter.WriteLine(imageValue2);
                    streamWriter.WriteLine(imageValue1);
                    streamWriter.WriteLine(imageValue4);
                    streamWriter.WriteLine(imageValue3);
                    streamWriter.WriteLine("</body>");
                    streamWriter.WriteLine("</html>");                    
                }
                //returneaza fisierul
            fileResult = file.ToString();
            return fileResult;
        }

        public static string getFiles()
        {
            DirectoryInfo directory = new DirectoryInfo(@"F:\");
            FileInfo[] File = directory.GetFiles();

            
            foreach(FileInfo file in File.Where(x => x.Extension == ".png" || x.Extension == ".jpg"))
            {
                result = file.Name;
            }

            return result;
        }

    }
}
