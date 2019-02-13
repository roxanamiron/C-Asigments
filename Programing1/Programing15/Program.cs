using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing15
{
    class Program
    {
        static void Main(string[] args)
       {
            //1.
            Console.WriteLine("\nWrite a program that reads a text file and prints its odd lines on the console.");
            PrintOddLines oddLine = new PrintOddLines();
            oddLine.Print();

            //2.
            Console.WriteLine("\nWrite a program that joins two text files and records the results in a third file.");
            JoinAndRecordAFile joinRecord = new JoinAndRecordAFile();
            joinRecord.ReadWriteFiles();

            //3.
            Console.WriteLine("\n Write a program that reads the contents of a text file and inserts the " +
                "line numbers at the beginning of each line, then rewrites the file contents.");
            InsertLineNumbers numbers = new InsertLineNumbers();
            numbers.InsertNumbers();

            //4.
            Console.WriteLine("Write a program that compares two text files with the same number of rows " +
                "line by line and prints the number of equal and the number of different lines.");
            CompareTwoFiles compare = new CompareTwoFiles();
            compare.CompareFiles();

            //5.
            Console.WriteLine("\n  Write a program that reads a square matrix of integers from a file and finds the " +
                "sub-matrix with size 2 × 2 that has the maximal sum and writes this sum to a separate text file. The" +
                "first line of input file contains the size of the recorded matrix (N). The next N lines contain N " +
                "integers separated by spaces.");
            SquareMatrixOfIntegers result = new SquareMatrixOfIntegers();
            result.PrintSum();

            //6.
            Console.WriteLine("\nWrite a program that reads a list of names from a text file, arranges them in alphabetical order," +
                "and writes them to another file. The lines are written one per row.");
            ListOfNames sort = new ListOfNames();
            sort.WriteToAnotherFile();

            //7.
            Console.WriteLine("\nWrite a program that replaces every occurrence of the substring \"start\" with \"finish\" " +
                "in a text file. ");
            ReplaceOccurenceOfASubstring replece = new ReplaceOccurenceOfASubstring();
            replece.ReplaceWord();

            //9.
            Console.WriteLine("\nWrite a program that deletes all the odd lines of a text file.");
            Oddlines deleteOdd = new Oddlines();
            deleteOdd.WriteOdd();

            //10.
            Console.WriteLine("\nWrite a program that extracts from an XML file the text only (without the tags).");
            ExtractTextFromXmlFile extract = new ExtractTextFromXmlFile();
            extract.ExtractText();

            //11.
            Console.WriteLine("\n Write a program that deletes all words that begin with the word \"test\"." +
                "The words will contain only the following chars: 0…9, a…z, A…Z.");
            DeleteAllTestWords deleteWord = new DeleteAllTestWords();
            deleteWord.ReadFile();


            //12.
            Console.WriteLine("\nWrite a program that reads a list of words from a file called words.txt," +
                "counts how many times each of these words is found in another file text.txt, and records " +
                "the results in a third file – result.txt, but before that, sorts them by the number of " +
                "occurrences in descending order. Handle all possible exceptions.");
            OccurenceWords occurence = new OccurenceWords();
            occurence.GetWordOccur();


            Console.ReadLine();

        }
    }
}
