using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordsWithAppearences;

namespace WordsWithAppearencesAplication
{
  public class Program
    {
      static void Main(string[] args)
        {
            Console.WriteLine("The List of words from the file are: ");

            var workingWithWords = new WorkingWithWords();
            //1.
           var firstMeth = workingWithWords.readTheWordsFromFile();


            Console.WriteLine("\nThe Position for every word is: \n");
          
           var secondMeth = workingWithWords.listsOfWordsAndPosition(firstMeth);

            Console.WriteLine("\nThe aplhabetic list is: \n");

            var thirdMeth = workingWithWords.alphabeticList(secondMeth);

            Console.WriteLine("\nThe UpperList is: \n");

           // var fourMeth = workingWithWords.upperList(secondMeth);

            Console.WriteLine("\nencrypt every word :");
            var fifthMeth = workingWithWords.encryptList(secondMeth);

            Console.WriteLine("\nThe string list :");
           var sixMeth = workingWithWords.stringList(secondMeth);

            Console.WriteLine("\n Write the result list at 6 to another file");            
            workingWithWords.writeAnotherFile(sixMeth);

            Console.WriteLine("\nDecrypt : ");
           // workingWithWords.readFile(secondMeth);

            Console.WriteLine("\nThe lowercase list:");
            workingWithWords.lowerList(secondMeth);

            Console.WriteLine("\nCreate the orginal List<string>");
            workingWithWords.originalList(sixMeth);


            Console.ReadLine();
        }
    }
}
