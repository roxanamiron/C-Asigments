using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing11
{
   public class Calculator
    {
        private string expression;
        int result = 0;

        public void Calculate()
        {
            Console.WriteLine("Enter an expresion to compute: ");
            expression = Console.ReadLine();

            string[] sign = expression.Split(' ');

            switch (sign[1].ElementAtOrDefault(0))
            {
                case '+':
                    result = int.Parse(sign[0]) + int.Parse(sign[2]);
                    break;
                case '-':
                    result = int.Parse(sign[0]) - int.Parse(sign[2]);
                    break;
                case '*':
                    result = int.Parse(sign[0]) * int.Parse(sign[2]);
                    break;
                case '/':
                    result = int.Parse(sign[0]) / int.Parse(sign[2]);
                    break;
            }
            Console.WriteLine(sign[0] + ' ' + sign[1] + ' ' + sign[2] + ' ' + "=" + result);
        }
    }
}
