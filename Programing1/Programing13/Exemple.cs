//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Programing13
//{
//   public class Exemple
//    {
//        static void Main()
//        {
//            //compare 2 strings when lexicographical order is needed
//            string score = "sCore";
//            string scary = "scary";
//            Console.WriteLine(score.CompareTo(scary)); // return 1 =>  the second string is lexicographically before the first
//            Console.WriteLine(scary.CompareTo(score)); // retur -1 => the first string is lexicographically before the second
//            Console.WriteLine(scary.CompareTo(scary)); //return 0 => the second string is lexicographically before the first


//            ////ignoreCase option for ignoring the casing of capital and small letters
//            string alpha = "alpha";
//            string score1 = "sCorE";
//            string score2 = "score";

//            Console.WriteLine(string.Compare(alpha, score1, false));
//            Console.WriteLine(string.Compare(score1, score2, false));
//            Console.WriteLine(string.Compare(score1, score2, true));
//            Console.WriteLine(string.Compare(score1, score2, StringComparison.CurrentCultureIgnoreCase));

//            //check if the values of 2 strings are equal or not
//            string str1 = "Hello";
//            string str2 = str1;

//            Console.WriteLine(str1 == str2);

//            //concatenation
//            string greet = "Hello";
//            string name = " reader!";
//            string result = greet + name;
//            Console.WriteLine(result);

//            //or
//            string result2 = string.Concat(greet, name);
//            Console.WriteLine(result2 + "How are you?");

//            string firstName = "John";
//            string lastName = " Smith";
//            string fullName = firstName + lastName;

//            int age = 33;
//            string nameAndAge = "Name: " + fullName + "\nAge: " + age;
//            Console.WriteLine(nameAndAge);

//            //searching into a string
//            string book = "Introduction to C# book";
//            int index = book.IndexOf("C#");
//            Console.WriteLine(index);

//            //finding all occurrences of the word "C#" in a given text:
//            string quote = "The main intent of the \"Intro C#\" book is to introduce the C# programming to newbies.";
//            string keyword = "C#";
//            int inde = quote.IndexOf(keyword);

//            while(index != -1)
//            {
//                Console.WriteLine("{0} found at index {1}", keyword, index);
//                index = quote.IndexOf(keyword, index + 1);
//            }

//            //concat in loop
//            Console.WriteLine(DateTime.Now);

//            StringBuilder builder = new StringBuilder();
//            builder.Append("Numbers: ");

//            for(int index3 = 1; index3 <= 200000; index3++)
//            {
//                builder.Append(index3);
//            }
//            Console.WriteLine(builder.ToString().Substring(0,1024));
//            Console.WriteLine(DateTime.Now);

//            //reversing a string
//            string s1 = "EM edit";
//            string reversed = ReversedText(s1);
//            Console.WriteLine(reversed);
//            reversed = ExtractCapital(s1);
//            Console.WriteLine(reversed);

//            //string.Format
//            DateTime date = DateTime.Now;
//            string name2 = "David";
//            string task = "Introducing to C# book";
//            string location = "his office";

//            string formattedTExt = String.Format("Today is {0:MM/dd/yyyy} and {1} is working on {2} in {3}.", date, name2, task, location);
//            Console.WriteLine(formattedTExt);

//            //parsing data


//            Console.ReadLine();
//        }   
//        static string ReversedText(string text)
//        {
//            StringBuilder builder = new StringBuilder();
//            for(int i = text.Length -1; i >= 0; i--)
//            {
//                builder.Append(text[i]);
//            }
//            return builder.ToString();
//        }
//       public static string ExtractCapital(string str4)
//        {
//            StringBuilder buid = new StringBuilder();

//            for(int i = 0; i < str4.Length; i++)
//            {
//                char ch = str4[i];
//                if(char.IsUpper(ch))
//                {
//                    buid.Append(ch);
//                }
//            }
//            return buid.ToString();
//        }
//    }
//}
