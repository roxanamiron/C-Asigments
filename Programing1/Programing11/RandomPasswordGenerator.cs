//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Programing11
//{
//    public class RandomPasswordGenerator
//    {
//        private const string CapitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
//        private const string SmallLetters = "abcdefghijklmnopqrstuvwxyz";
//        private const string Digits = "0123456789";
//        private const string SpecialChars = "~!@#$%^&*()_+=`{}[]\\|':;.,/?<>";
//        private const string AllChars = CapitalLetters + SmallLetters + Digits + SpecialChars;

//        //We start with an empty password. We create a generator of random numbers.
//        private static Random rand = new Random();

//        static void Main()
//        {
//            StringBuilder password = new StringBuilder();

//            //Generate 2 random capital letters
//            for (int i = 1; i <= 2; i++)
//            {
//                char capitalLetters = GenerateChar(CapitalLetters);
//                InsertAtRandomPosition(password, capitalLetters);
//            }

//            //Generate 2 random small letters
//            for (int i = 1; i <= 2; i++)
//            {
//                char smallLetters = GenerateChar(SmallLetters);
//                InsertAtRandomPosition(password, smallLetters);
//            }

//            //Generate 1 random digits
            
//                char digit = GenerateChar(Digits);
//                InsertAtRandomPosition(password, digit);
            

//            //genarate 3 special charcaters
//            for (int i = 1; i <= 3; i++)
//            {
//                char specialChars = GenerateChar(SpecialChars);
//                InsertAtRandomPosition(password, specialChars);
//            }

//            // Generate few random characters (between 0 and 7)
//            int count = rand.Next(8);
//            for(int i = 1; i <= count; i++)
//            {
//                char specialChar = GenerateChar(SpecialChars);
//                InsertAtRandomPosition(password, specialChar);
//            }

//            Console.WriteLine(password);

//            Console.ReadLine();
//        }

//        private static void InsertAtRandomPosition(StringBuilder password, char character)
//        {
//            int randPosition = rand.Next(password.Length + 1);
//            password.Insert(randPosition, character);
//        }

//        private static char GenerateChar(string availableChars)
//        {
//            int randomIndex = rand.Next(availableChars.Length);
//            char randomChars = availableChars[randomIndex];
//            return randomChars; 
//        }
//    }
//}
