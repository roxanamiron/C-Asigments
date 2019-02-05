using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing13
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.           
            //ReverseString reverse = new ReverseString();
            //reverse.Display();

            //3.
            //CheckIfItIsCorrect check = new CheckIfItIsCorrect();
            //check.Display();

            //4.
            //string text = "One two three";
            //UsingSplit split = new UsingSplit();
            //split.SplitMethod(text);

            //5.
            //string text2 = "We are living in a yellow submarine. We don't have anything else. " +
            //    "Inside the submarine is very tight. So we are drinking all the day. We will move " +
            //    "out of it in 5 days.";
            //UsingSubstring substr = new UsingSubstring();
            //substr.DetectHowManyTimes(text2);

            //6.
            //string text3 = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            //UpperCaseLetters upper = new UpperCaseLetters();
            //upper.ModifiesTheCasing(text3);

            //7.
            //UsingRegularExpression regex = new UsingRegularExpression();
            //regex.Display();

            //8.
            //TransformAString convert = new TransformAString();
            //convert.ConvertTheString();

            //9.
            //EcryptAString encrypt = new EcryptAString();
            //encrypt.Display();

            //10.
            //ExtractText extract = new ExtractText();
            //extract.Extract();

            //11.
            //ForbiddenWords words = new ForbiddenWords();
            //words.ReplaceTheForbidden();

            //12.
            //ReadANumber read = new ReadANumber();
            //read.ConvertNumber();

            //13.
            //ParseAnURL parse = new ParseAnURL();
            //parse.SplitUrl();

            //14.
            //ReverseTheWordsInASentence reverseWords = new ReverseTheWordsInASentence();
            //reverseWords.ReverseMethod();

            //15.
            WorkingWithDictionary explanation = new WorkingWithDictionary();
            Console.WriteLine("\nEnter a word: ");
            string word = Console.ReadLine();
            explanation.ReadWords(word);
            Console.ReadLine();
        }

    }
}
