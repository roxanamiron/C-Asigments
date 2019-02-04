using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing13
{
   public class CheckIfItIsCorrect
    {
        private char openParathese = '(';
        private char closeParanthese = ')';

        public void Display()
        {
            Console.WriteLine("\nWrite a program that checks whether the parentheses are placed correctly in "+
                "an arithmetic expression.Example of expression with correctly placed brackets: ((a + b) / 5 - d)."+
                "Example of an incorrect expression: )(a + b)).");

            Console.WriteLine("\nEnter an expression with parantheses: ");
            string expression = Console.ReadLine();
            var result = CheckIfArePlacedCorrectly(expression);            
            Console.WriteLine(result);
        }

        private bool CheckIfArePlacedCorrectly(string expression)
        {
           int count = 0;
           for(int i = 0; i < expression.Length; i++)
            {
                if(expression[i] == openParathese)
                {
                    count++;
                }
                if(expression[i] == closeParanthese)
                {
                    count--;
                }
                if(count < 0)
                {
                    return false;
                }
                if (count == 0)
                {
                    return true;
                }

            }
            return false;
        }
        
    }
}
