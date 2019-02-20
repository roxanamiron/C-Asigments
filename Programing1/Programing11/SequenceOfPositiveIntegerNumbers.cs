using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing11
{
   public class SequenceOfPositiveIntegerNumbers
    {
        private string sequenceOfNumbers = "43 68 9 23 318";
        public List<int> listOfNumbers = new List<int>();

        private List<int> GetTheNumbers(string sequenceOfNumbers)
        {          
                var numb = sequenceOfNumbers.Split(' '); 
                foreach(var result in numb)
                {
                    var number = Convert.ToInt32(result);
                    listOfNumbers.Add(number);
                }   
            return listOfNumbers;           
        }

        public void CalculateSum()
        {
            var listOfNumbers = GetTheNumbers(sequenceOfNumbers);
            int sum = 0;
            foreach(var number in listOfNumbers)
            {
                sum += number;
            }
            Console.WriteLine("The sum of numbers : {0}" , sum);
        }
    }
}
