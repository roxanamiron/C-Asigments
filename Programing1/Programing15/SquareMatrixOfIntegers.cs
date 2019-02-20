using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Programing15
{
    public class SquareMatrixOfIntegers
    {
        private int maxSum = 0;
        private int[,] matrix;
        private string matrixFile = @"matrix.txt";

        public void PrintSum()
        {
            matrix = ReadAndSeparatetheNumbers(matrixFile);

            maxSum = FindTheSum();

            //print the maximal sum to a separate text file
            using (StreamWriter writer = new StreamWriter(@"sum.txt"))
            {
                writer.WriteLine(maxSum);
                Console.WriteLine("Maximal sum {0}",maxSum);
            }
        }

        public int[,] ReadAndSeparatetheNumbers(string matrixFile)
        {
            StreamReader reader = new StreamReader(matrixFile);

            //read the first line and create a matrix length

            int length = int.Parse(reader.ReadLine());
            matrix = new int[length, length];
            using (reader)
            {
                int row = 0;
                while (!reader.EndOfStream)
                {
                    string[] separatedNr = reader.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < separatedNr.Length; i++)
                    {
                        matrix[row, i] = int.Parse(separatedNr[i]);
                    }
                    row++;
                }
            }
            return matrix;
        }
        public int FindTheSum()
        {
            //create a column and row to read each number and make the sum of them
            for (int row = 0; row < matrix.GetLongLength(0) - 1; row++)
            {
                int sum = 0;
                for (int colum = 0; colum < matrix.GetLongLength(1) - 1; colum++)
                {
                    sum = matrix[row, colum] + matrix[row, colum + 1] + matrix[row + 1, colum] + matrix[row + 1, colum + 1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }
                }               
            }
            return maxSum;
        }
        
    }
}
