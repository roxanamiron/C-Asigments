using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing11
{
    public class RandomAdvertisingMessage
    {
        private static List<string> LaudatoryPhrase = new List<string>{ "The product is excellent.", "This is a great product.", "I use this product constantly.",
            "This is the best product from this category." };
        private static List<string> LaudatoryStories = new List<string> { "Now I feel better.", "I managed to change.", "It made some miracle.",
            "I can’t believe it, but now I am feeling great.", "You should try it, too. I am very satisfied." };
        private static List<string> AuthorFirstName = new List<string> { "Dayan", "Stella", "Hellen", "Kate" };
        private static List<string> AuthorLastName = new List<string> { "Johnson", "Peterson", "Charls" };
        private static List<string> Cities = new List<string> { "London", "Paris", "Berlin", "New York", "Madrid" };


        Random rand = new Random();
        public List<string> message = new List<string>();

        public void GetStrings()
        {
            var cities = Generate(Cities);
            InsertString(message, cities);

            var lastName = Generate(AuthorLastName);
            InsertString(message, lastName);

            var firstName = Generate(AuthorFirstName);
            InsertString(message, firstName);

            var stories = Generate(LaudatoryStories);
            InsertString(message, stories);

            var phrase = Generate(LaudatoryPhrase);
            InsertString(message, phrase);


            Console.WriteLine("The new message is : {0}", string.Join(",",message.ToArray()));
        }

        private string Generate(List<string> stringmess)
        {
            var randomIndex = rand.Next(stringmess.Count);
            var randomText = stringmess[randomIndex];
            return randomText;
        }

        private void InsertString(List<string> message, string text)
        {
            for(int i = 0; i < 1; i++)
            {
                message.Insert(i, text);
            }
           
        }
    }
}
