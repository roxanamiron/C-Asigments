using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing14
{
    public class TestFractional
    {
        public void TestFractionalOperations()
        {
            int num;
            int den;
            int divisor;
            int reducedNum;
            int reducedDen;
            Console.WriteLine("enter numerator: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("enter denumerator: ");
            den = int.Parse(Console.ReadLine());
            Frational fractional = new Frational(num,den);
            fractional.ToString();
            divisor = Gcd(num, den);

            if(divisor != 1)
            {
                reducedNum = Divisor(num, den);
                reducedDen = Divisor(den, num);
                Console.WriteLine("the reduced dumerator is {0} ",reducedNum);
                Console.WriteLine("the reduced denominator is: {0}", reducedDen);
                Console.WriteLine("if numerator is {0} and denominator is {1}, fractional to be canceled to {2}/{3}.",num,den,reducedNum,reducedDen);
            }
            else
            {
                Console.WriteLine("the fraction cannot be reduced");
            }
        }

        private int Gcd(int num, int den)
        {
            while(num != den)
            {
                if(num < den)
                {
                    den -= num;
                }
                else
                {
                    num -= den;
                }
            }
            return num;
        }
        private int Divisor(int num, int den)
        {
            int quation = 0;
            while(num >= den)
            {
                num -= den;
                quation++;
            }
            return num;
        }
    }
}
