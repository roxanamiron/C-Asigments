using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments12
{
    public class Program
    {
         

        static void Main(string[] args)
        {
            // 12.Create a program to display the contents of a text file "inverted" : 
            //create a file containing the same lines as the original file but in reverse order 
            //(the first line will be the last one, the second will be the penultimate, and so on, until the last line 
            //of the original file, which should appear in the first position of the resulting file). Also, each line must 
            //be displayed reversed (it must start with the last letter and end with the first letter).
             string[] originalText = File.ReadAllLines(@"F:\originalFile.txt");
            // readFile();
            var invertedList = invertList(originalText);
            writeToFile(invertedList);
            Console.ReadLine();
        }
        

        public static List<string> invertList(string[] originalText)
        {
            //se inverseaza elementele listei
           // var reverseList = new List<string>();
            var reverseList = originalText.Reverse().ToList();
            var finalList = new List<string>();
            foreach (var element in reverseList)
            {
                // se inverseaza caracterele din lista inversata
                char[] chars = element.ToCharArray();
                Array.Reverse(chars);
                finalList.Add(new string (chars));
                //Console.WriteLine(chr);
            }
            return finalList;
        }

        public static void writeToFile(List<string> list)
        {
            
            //creaza fisierul
            FileStream invertedFile = new FileStream(@"F:\invertedFile.txt", FileMode.Create);

            //stocheaza in fisier lista inversata
            using (StreamWriter streamWriter = new StreamWriter(invertedFile))
            {
                //adauga in fisier fiecare element din lista inversata
                foreach(var line in list)
                {
                    streamWriter.WriteLine(line);
                }              
            }
            

        }

    }
}
