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

            // //2.
            CheckIfDivisible(numb1);

            // //3.
             CheckThirdDigit(numb1);

            // //4.
            CheckTheThirdBit(numb1);

            // //5.
            Console.WriteLine("\nInput side a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInput side b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInput side height h: ");
            int h = Convert.ToInt32(Console.ReadLine());
            FindArea(a, b, h);

            // //6.
            Console.WriteLine("\nInput the length(L): ");
            int L = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInput the width: ");
            int l = Convert.ToInt32(Console.ReadLine());
            FindPerimeterAndArea(L, l);

            // //7.
            Console.WriteLine("\ninput your weight: ");
            int yourWeight = Convert.ToInt32(Console.ReadLine());
            CalculateWeight(yourWeight);

            // //8.
            Console.WriteLine("\nInput the xp :");
            int xp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInput the yp :");
            int yp = Convert.ToInt32(Console.ReadLine());
           CheckGivenPoint(xp, yp);

            // //9.           
            CheckGivenPoint2(xp,yp);

            //10.
            Console.WriteLine("\nInput four digit number in format abcd (e.g. 2011): ");
            int number = Convert.ToInt32(Console.ReadLine());
            Calculate(number);


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
            int rectanglePerimeter = (2 * L) + (2 * l);
            int rectangleArea = L + l;
            Console.WriteLine("the perimeter of a rectangle is: {0} and the area of a rectangle is: {1}",rectanglePerimeter,rectanglePerimeter );
        }
        static void CalculateWeight(int yourWeight)
        {
            Console.WriteLine("\n The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates the weight of a man on the moon " +
                "by a given weight on the Earth.");

            var gravitationalField = 0.17;
            var weightOnTheMoon = gravitationalField * yourWeight;

            Console.WriteLine("\nYour weight on the moon is: {0}",weightOnTheMoon);
        }
        static void CheckGivenPoint(int xp, int yp)
        {
            Console.WriteLine("\nWrite an expression that checks for a given point {x, y} if it is within the circle K[{0, 0}, R=5]. " +
                "Explanation: the point {0, 0} is the center of the circle and 5 is the radius.\n");

            var xc = 0;
            var yc = 0;
            var r = 5;


            var result = (((xp - xc) * (xp - xc)) + ((yp - yc) * (yp - yc))) < (r * r);

            Console.WriteLine(result);

        }
        static void CheckGivenPoint2(int xp, int yp)
        {
            Console.WriteLine("\n Write an expression that checks for given point {x, y} if it is within the circle K[{0, 0}, R=5] and out of the rectangle [{-1, 1}, {5, 5}]. " +
               " Clarification: for the rectangle the lower left and the upper right corners are given.\n");

            var x1 = 1;
            var y1 = 1;
            var x2 = 5;
            var y2 = 5;
            var xc = 0;
            var yc = 0;
            var r = 5;

            var givenPoint1 = (((xp - xc) * (xp - xc)) + ((yp - yc) * (yp - yc))) < (r * r);

            var condition1 = (x1 <= xp) && (xp <= x2);
            var condition2 = (y1 <= yp) && (yp <= y2);

            var givenPoint2 = condition1 && condition2;

            var result = givenPoint2 && givenPoint1;

            Console.WriteLine(result);

        }
        static void Calculate(int number)
        {
            Console.WriteLine("Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following actions:" +
                                "- Calculates the sum of the digits(in our example 2 + 0 + 1 + 1 = 4)." +
                                "- Prints on the console the number in reversed order: dcba(in our example 1102)." +
                                "- Puts the last digit in the first position: dabc(in our example 1201)." +
                                "- Exchanges the second and the third digits: acbd(in our example 2101).);");
            var numberArray = new int[4];
            for (int i = 0; i < 4; i++)
            {
                numberArray[i] = number % 10;
                number = number / 10;
            }
            
            
            var sum = numberArray[0] + numberArray[1] + numberArray[2] + numberArray[3];
            Console.WriteLine("The Sum of numbers = {0}",sum);

            var reverseOrder = numberArray;
            Console.WriteLine("The number in reverse order is: {0}",string.Join(",",numberArray));

            var originalArray = numberArray.Reverse().ToArray();
            var arrayWithoutLastDigit = originalArray.Take(3).ToArray();
           
            var lastDigit = originalArray.Last();
            
            Console.WriteLine("\nThe new array after the first swiching is :{0}"+","+"{1}",lastDigit,string.Join(",",arrayWithoutLastDigit));
            

            Console.WriteLine("\nThe new array after the second swiching is : {0}"+","+"{1}"+","+"{2}"+","+"{3}",originalArray[0],originalArray[3],originalArray[1],originalArray[2]);
        }
      

    }
}
