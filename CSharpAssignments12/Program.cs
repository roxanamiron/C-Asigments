﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments12
{
   public class Program
    {
       

        static void Main(string[] args)
        {
            // 12.Create a program to display the contents of a text file "inverted" : 
            //create a file containing the same lines as the original file but in reverse order 
            //(the first line will be the last one, the second will be the penultimate, and so on, until the last line 
            //of the original file, which should appear in the first position of the resulting file). Also, each line must 
            //be displayed reversed (it must start with the last letter and end with the first letter).

            readFile();

            Console.ReadLine();
        }

        //public static void displayProgram()
        //{
           
        //}

        public static List<string> readFile()
        {
            List<string> newList = new List<string>();
            //citeste datele din fisier
            string[] originalText = File.ReadAllLines(@"F:\originalFile.txt");
                                  
            foreach(var lines in originalText)
            {
                Console.WriteLine(lines);
            }

            return newList;
        }

        public static string invertedFile()
        {

        }

    }
}
