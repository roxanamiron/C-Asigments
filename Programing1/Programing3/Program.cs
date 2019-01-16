using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            Console.WriteLine("\nInput a integer number: ");
            int numb1 = Convert.ToInt32(Console.ReadLine());
            CheckEvenOrOdd(numb1);

            //2.
            CheckIfDivisible(numb1);

            //3.
            CheckThirdDigit(numb1);

            //4.
            CheckTheThirdBit(numb1);

            //5.
            Console.WriteLine("\nInput side a: ");
           int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInput side b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInput side c: ");
            int h = Convert.ToInt32(Console.ReadLine());
            FindArea(a,b,h);

            //6.
            Console.WriteLine("\nInput the length(L): ");
            int L = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInput the width: ");
            int l = Convert.ToInt32(Console.ReadLine());
            FindPerimeterAndArea(L,l);


            Console.ReadLine();

        }
        static void CheckEvenOrOdd(int numb)
        {
            Console.WriteLine("\n Write an expression that checks whether an integer is odd or even");

            if (numb % 2 == 0)
            {
                Console.WriteLine("the numb {0} is even",numb);
            }
            else
                Console.WriteLine("the numb {0} is odd", numb);
        }
        static void CheckIfDivisible(int numb)
        {
            Console.WriteLine("\nWrite a Boolean expression that checks whether a given integer is divisible by both 5 and 7, without a remainder.");

            if ((numb % 5 == 0) && (numb % 7 == 0))
            {
                Console.WriteLine("the number {0} is divisible by both 5 and 7",numb);
            }
            else
                Console.WriteLine("the number {0} is not divisible by both 5 and 7", numb);
        }
        static void CheckThirdDigit(int numb)
        {
            Console.WriteLine("\nWrite an expression that checks for a given integer if its third digit (right to left) is 7.");

            //impartim nr la 100,astfel incat thirDigit sa fie primul si apoi il dividem la 10
            int thirDigit = (numb / 100) % 10;
            int numberCheck = 7;

            if( thirDigit == numberCheck)
            {
                Console.WriteLine("the third digit is 7");
            }
            else
            {
                Console.WriteLine("the third digit is not 7");
            }
           
            
        }
        static void CheckTheThirdBit(int numb)
        {
            Console.WriteLine("\nWrite an expression that checks whether the third bit in a given integer is 1 or 0.");

            var bitNo = Convert.ToString(numb, 2);
            Console.WriteLine("{0} converted in bynary is :{1}", numb, bitNo);

            int stratIndex = 0;
            int endIndex = 4;
            //primele 4 caractere din string
            string chPos = bitNo.Substring(stratIndex, endIndex);
            var thirdBit = chPos.Substring(3);

            if(thirdBit == "1")
            {
                Console.WriteLine("the third bit is 1");
            }
           else if(thirdBit == "0")
            {
                Console.WriteLine("the third bit is 0");
            }
        }
        static void FindArea(int a, int b, int h)
        {
            Console.WriteLine("\nWrite an expression that calculates the area of a trapezoid by given sides a, b and height h.");

            int area = ((a + b) * h) / 2;
            Console.WriteLine("the area of a trapezoid is {0}",area);
        }
        static void FindPerimeterAndArea(int L, int l)
        {
            Console.WriteLine("\nWrite a program that prints on the console the perimeter and the area of a rectangle by given side and height entered by the user.");

        }

    }
}
