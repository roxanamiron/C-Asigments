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
                    if(noApperence != null)
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
            foreach(var n in bytes)
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
            return list;
        }

        public string stringList(List<WordsWithAppearences> list)
        {
            var newList = new List<string>();
            
             newList = string.Join(",", list.Select(w => new WordsWithAppearences
            {
                Word = w.Word,
                NrOfAppearences = w.NrOfAppearences,
                Positions = w.Positions
            }.ToString()));

            return newList;
        }

        public void writeAnotherFile(List<string> list)
        {

        }

    }
}
