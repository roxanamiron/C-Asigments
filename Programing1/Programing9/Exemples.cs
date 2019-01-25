using System;

namespace Programing9
{
    public class Exemples
    {
        public void CalculateTotalAmount(decimal[] prices)
        {
            decimal totalAmount = 0;
            foreach (decimal singlePriceOfABook in prices)
            {
                totalAmount += singlePriceOfABook;
            }
            System.Console.WriteLine("The total amount for all the books is: " + totalAmount);
        }

        public void ShowSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Zero");
            }
        }

        public void ShowTheMaximValue(int a, int b)
        {
            if (a < b)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(a);
            }
        }
        public void PrintNumber(int numberParam)
        {
            // Modifying the primitive-type parameter
            numberParam = 5;

            Console.WriteLine("in PrintNumber() method, after " +
                "modification, numberParam is: {0}", numberParam);
        }
        public void ModifyArray(int[] arrParam)
        {
            //modify yhe first element of an array that is passed as a parameter so it is reinitialized 
            //the first element with value 5 and then prints the elements of the array, 
            //surrounded by square brackets and separated by commas:

            arrParam[0] = 5;
            Console.WriteLine("In ModifyArray() the param is : ");
            PrintArrayParam(arrParam);
        }

        public void PrintArrayParam(int[] arrParam)
        {
            Console.WriteLine("[");
            int length = arrParam.Length;

            if (length > 0)
            {
                Console.WriteLine(arrParam[0].ToString());
                for (int i = 0; i < arrParam.Length; i++)
                {
                    Console.WriteLine(", {0}", arrParam[i]);
                }
            }
            Console.WriteLine("]");
        }

        public void PrintNameAndAge(string name, int age)
        {
            Console.WriteLine("I am {0}, {1} years old", name, age);
        }

        public long CalcSum(params int[] elements)
        {
            long sum = 0;
            foreach (int element in elements)
            {
                sum += element;
            }
            return sum;

        }
        public void CalculateTotalAmount2(params decimal[] prices)
        {
            decimal totalAmount = 0;
            foreach (decimal singlePriceOfABook in prices)
            {
                totalAmount += singlePriceOfABook;
            }
            System.Console.WriteLine("The total amount for all the books is: " + totalAmount);
        }
        public void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();
        }
        public void DisplayLine(int n)
        {
            // Entering the value of the variable n
            Console.Write("n = ");
             n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Printing the upper part of the triangle
            for (int line = 1; line <= n; line++)
            {
                PrintLine(1, line);
            }

            // Printing the bottom part of the triangle
            // that is under the longest line
            for (int line = n - 1; line >= 1; line--)
            {
                PrintLine(1, line);
            }
        }
        public int CompareTo(int n1, int n2)
        {
            if(n1 > n2)
            {
                return 1;
            }
            else if(n1 == n2)
            {
                return 0;
            }
            else 
            {
                return -1;
            }
        }
        public double ConvertFahrenheitToCelsius(double temperatureF)
        {
            double temperatureC = (temperatureF - 32) * 5 / 9;
            return temperatureC;
           
        }

        public string GetMonthsName(int month)
        {
            // To enter the months numbers that mark beginning and end of the period.
            string monthName;
            switch(month)
            {
                case 1:
                    monthName = "January";
                    break;
                case 2:
                    monthName = "February";
                    break;
                case 3:
                    monthName = "March";
                    break;
                case 4:
                    monthName = "April";
                    break;
                case 5:
                    monthName = "May";
                    break;
                case 6:
                    monthName = "June";
                    break;
                case 7:
                    monthName = "July";
                    break;
                case 8:
                    monthName = "August";
                    break;
                case 9:
                    monthName = "September";
                    break;
                case 10:
                    monthName = "Octomber";
                    break;
                case 11:
                    monthName = "November";
                    break;
                case 12:
                    monthName = "December";
                    break;
                default:
                    Console.WriteLine("Invalid month");
                    return null;
            }
            return monthName;
        }
        public void SayPeriod(int startMonth, int endMonth)
        {
            //To calculate the period between the input months.
            int period = startMonth - endMonth;
            if(period < 0)
            {
                //Fix negative distance
                period = period + 12;
            }
            //To print the message.
            Console.WriteLine("there is {0} months period from {1} and {2}",period,GetMonthsName(startMonth),GetMonthsName(endMonth));

        }
        public bool ValidateHour(int hours)
        {
            bool result = (hours >= 0) && (hours < 23);
            return result;
        }
        public bool ValidateMinutes(int minutes)
        {
            bool result = (minutes >= 0) && (minutes < 59);
            return result;
        }
        public int[] Sort(params int[] numbers)
        {
            //create a sort of that array and return it:
            // The sorting logic:
            for (int i = 0; i < numbers.Length-1; i++)
            {
                // Loop operating over the unsorted part of the array
                for (int j = i+1; j<numbers.Length;j++)
                // Swapping the values
                {
                    if(numbers[i] > numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }//end of the sorting logic
            
            return numbers;
        }
        public void PrintNumbers(params int[] numbers)
        {
            for(int i = 0; i< numbers.Length; i++)
            {
                Console.WriteLine("{0}",numbers[i]);
                if(i < numbers.Length -1)
                {
                    Console.WriteLine(", ");
                }
            }
        } 

    }
}