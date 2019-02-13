using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Programing15
{
   public class ListOfNames
    {
        private string FileName = @"list of names.txt";
        private string resultFile = @"alphabetic list.txt";
        private List<string> listOfNames = new List<string>();
        private List<string> alphaList = new List<string>();


        public void WriteToAnotherFile()
        {
            alphaList = SortNames(FileName);
            using (StreamWriter writer = new StreamWriter(resultFile))
            {
                foreach(var name in alphaList)
                {
                    writer.WriteLine(name);
                }
            }
        }

        private List<string> SortNames(string fileName)
        {
            StreamReader reader = new StreamReader(fileName);
            //salveaza lista de nume intr-un list pentru ale putea sorta          
          
            using (reader)
            {
                while(!reader.EndOfStream)
                {
                    listOfNames.Add(reader.ReadLine());
                    alphaList = listOfNames.OrderBy(n => n).ToList();                   
                }
            }
            return alphaList;
        }

    }
}
