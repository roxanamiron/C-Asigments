using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsWithAppearences
{
    public class WorkingWithWords
    {
        //private static WordsWithAppearences wordsWithApperences;

        public List<string> readTheWordsFromFile()
        {
            string path = @"F:\WordsWithAppearences\words.in.txt";
            //citirea dintru-un fisier txt(cate un cuvant pe fiecare linie) 
            var originalWords = File.ReadAllLines(path);

            //stocarea intr-o lista
            var list1 = new List<string>();
            foreach (var word in originalWords)
            {
                list1.Add(word);
            }
            return list1;
        }

        public List<WordsWithAppearences> listsOfWordsAndPosition(List<string> list)
        {
            //Creaza o colectie din aceste cuvinte (poate fi lista, dictionar - ce preferi) de obiecte WordsWithAppearences,
            //in care sa apara cuvantul si numarul de aparitii

            //creaza o noua lista
            var listOfWords = new List<WordsWithAppearences>();

            //verifica daca cuvintele apar in lista si nr de aparitii

            int index = 0;

            foreach (var word in list)
            {
                if (!listOfWords.Any(w => w.Word == word))
                {
                    var wordWithApperence = new WordsWithAppearences
                    {
                        Word = word.ToString(),
                        NrOfAppearences = 1,
                        Positions = new List<int>()
                    };

                    wordWithApperence.Positions.Add(index);

                    listOfWords.Add(wordWithApperence);
                }
                else
                {
                    var noApperence = listOfWords.FirstOrDefault(n => n.Word == word.ToString());
                    if (noApperence != null)
                    {
                        noApperence.NrOfAppearences++;
                        noApperence.Positions.Add(index);
                    }
                }
                index++;
            }
            return listOfWords;

        }

        public List<WordsWithAppearences> alphabeticList(List<WordsWithAppearences> alphaList)
        {
            return alphaList.OrderBy(w => w.Word).ToList();
        }

        public List<WordsWithAppearences> upperList(List<WordsWithAppearences> list)
        {

            return list.Select(w =>
                new WordsWithAppearences
                {
                    Word = w.Word.ToUpper(),
                    NrOfAppearences = w.NrOfAppearences,
                    Positions = w.Positions
                }).ToList();

        }

        private string encryptToWord(string word)
        {

            byte[] bytes = Encoding.ASCII.GetBytes(word);
            foreach (var n in bytes)
            {
                var encrypt = n + 1;
                char character = (char)encrypt;
                word = character.ToString();
            }
            return word;
        }

        public List<WordsWithAppearences> encryptList(List<WordsWithAppearences> list)
        {
            return list.Select(w =>
           new WordsWithAppearences
           {
               Word = encryptToWord(w.Word),
               NrOfAppearences = w.NrOfAppearences,
               Positions = w.Positions

           }).ToList();

        }

        public List<string> stringList(List<WordsWithAppearences> list)
        {
            var newList = new List<string>();
            foreach (var element in list)
            {
                string result = string.Concat(element.Word, element.NrOfAppearences, element.Positions);
                var finalResult = string.Join(",", result);
                newList.Add(finalResult);
            }
            return newList;
        }

        public void writeAnotherFile(List<string> list)
        {
            string path = @"F:\WordsWithAppearences\words.out.txt";
            FileStream writeFile = new FileStream(path, FileMode.Create);

            using (StreamWriter streamWriter = new StreamWriter(writeFile))
            {
                foreach (var line in list)
                {
                    streamWriter.WriteLine(line);
                }
            }
        }

        //public List<string> readFile(List<WordsWithAppearences> list)
        //{
        //    string path = @"F:\WordsWithAppearences\words.in.txt";

        //    var listResult = new List<string>();
        //    using (StreamReader streamReader = new StreamReader(path))
        //    {
        //        foreach (var line in list)
        //        {

        //            var strLine = streamReader.ReadLine();
        //            while (strLine != null)
        //            {
        //                var workingWithApperences = new WordsWithAppearences();
        //                string[] linesValue = strLine.Split(' ');
        //                workingWithApperences.Word = linesValue[0];
        //                workingWithApperences.NrOfAppearences = int.Parse(linesValue[1]);
        //                workingWithApperences.Positions = linesValue[2]



        //                listResult.Add(workingWithApperences);
        //            }
        //            //var result = streamReader.ReadLine(line.Word, line.NrOfAppearences, line.Positions).ToString();
        //            //listResult.Add(result);

        //        }
        //    }

        //    return listResult;
        //}


        private string decryptToWord(string word)
        {

            byte[] bytes = Encoding.ASCII.GetBytes(word);
            foreach (var n in bytes)
            {
                var encrypt = n - 1;
                char character = (char)encrypt;
                word = character.ToString();
            }
            return word;
        }

        public List<WordsWithAppearences> decryptList(List<WordsWithAppearences> list)
        {
            return list.Select(w =>
           new WordsWithAppearences
           {
               Word = decryptToWord(w.Word),
               NrOfAppearences = w.NrOfAppearences,
               Positions = w.Positions

           }).ToList();

        }


        public List<WordsWithAppearences> lowerList(List<WordsWithAppearences> list)
        {
            return list.Select(x =>
           new WordsWithAppearences
           {
               Word = x.Word.ToLower(),
               NrOfAppearences = x.NrOfAppearences,
               Positions = x.Positions
           }).ToList();
        }

        public List<string> originalList(List<string> list)
        {
            var originalList = new List<string>();
            //originalList = list.Select(x => x.ToString()).ToList();

            int index = 0;
         foreach(var word in list)
            {
               
                originalList.Add(word);
            }

            return originalList;
        }



    }
}
