using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Programing15
{
    public class OccurenceWords
    {
        private string wordsFile = @"words.txt";
        private string textFile = @"text.txt";
        private string result = @"result.txt";
        private string[] arrayOfWords = new string[] { };       
        private string value = "";
        private Dictionary<string, int> wordOccurs = new Dictionary<string, int>();

        private void ReadTextFile(string file)
        {
            using (StreamReader reader = new StreamReader(file))
            {
                while (!reader.EndOfStream)
                {
                    arrayOfWords = reader.ReadLine().Split(new char[] { ' ', '.', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < arrayOfWords.Length; i++)
                    {
                        if (!wordOccurs.ContainsKey(arrayOfWords[i]))
                        {
                            wordOccurs.Add(arrayOfWords[i], 0);
                        }
                    }
                }
            }
        }
        public void GetWordOccur()
        {
            ReadTextFile(wordsFile);
            using (StreamWriter writer = new StreamWriter(result))
            {
                using (StreamReader read = new StreamReader(textFile))
                {
                    while (!read.EndOfStream)
                    {
                        string line = read.ReadToEnd();

                        for (int i = 0; i < wordOccurs.Count; i++)
                        {
                            KeyValuePair<string, int> word = wordOccurs.ElementAt(i);
                            int index = value.IndexOf(word.Key);

                            while (index != -1)
                            {
                                wordOccurs[word.Key]++;
                                index = value.IndexOf(word.Key, index + 1);
                            }
                        }
                    }
                }
                WriteWordOccursToFile(writer);
            }                
        }

        private void WriteWordOccursToFile(StreamWriter writer)
        {
            foreach(KeyValuePair<string,int> word in wordOccurs.OrderByDescending(key => key.Value))
            {
                writer.WriteLine(word.Key + " -> " + word.Value + " times(s).");
            }
        }

       
    }
}
