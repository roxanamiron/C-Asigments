using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|nPrimitive type & Variables");
            DeclareDatatypes();

            WhichOf();

            Initialize();

            FindHexadecimal();

            DeclareBoolVariable();

            DeclareObjectVariable();

            Usequots();

            PrintFigure();

            printIsoscel();

            DeclareAppropiateVariable();
        
            ExchangeValue();

            Console.ReadLine();
        }

        static void DeclareDatatypes()
        {
            Console.WriteLine("\nDeclare several variables by selecting for each one of them the most appropriate of the types sbyte, byte, short, ushort, int, uint, long and ulong in order to assign them the following values: 52,130; -115; 4825932; 97; -10000; 20000; 224; 970,700,000; 112; -44; -1,000,000; 1990; 123456789123456789.");

            float dec = 52.130f;
            Console.WriteLine("\nDecimal: {0}",dec);
            sbyte numb= -115;
            Console.WriteLine("\nNumber sbyte:{0}",numb);
            uint numb2 = 4825932;
            Console.WriteLine("\nNumber uint:{0}", numb2);
            byte numb3 = 97;
            Console.WriteLine("\nNumber byte:{0}", numb3);
            int numb4 = -10000;
            Console.WriteLine("\nNumber int:{0}", numb4);
            ulong numb5 = 20000;
            Console.WriteLine("\nNumber ulong:{0}", numb5);
            long numb6 = -1000000;
            Console.WriteLine("\nNumber long:{0}", numb6);
            long numb7 = 123456789123456789;
            Console.WriteLine("\nNumber long:{0}", numb7);
        }
        static void WhichOf()
        {
            Console.WriteLine("\nWhich of the following values can be assigned to variables of type float, double and decimal: 5, -5.01, 34.567839023; 12.345; 8923.1234857; 3456.091124875956542151256683467?");

            double n1 = -5.01;
            decimal n2 = 34.567839023m;
            float n3 = 8923.1234857f;
            decimal n4 = 3456.091124875956542151256683467m;
            Console.WriteLine("\nDoubel:{0},decimal:{1},float:{2},decimal:{3}",n1,n2,n3,n4);
        }
        static void Initialize()
        {
            Console.WriteLine("\nInitialize a variable of type int with a value of 256 in hexadecimal format(256 is 100 in a numeral system with base 16).");

            string hex = "256";
            int numb = Convert.ToInt32(hex, 16);
            Console.WriteLine("\nhexadecimal value = {0}, int value = {1}",hex,numb);
        }
        static void FindHexadecimal()
        {
            Console.WriteLine("\nDeclare a variable of type char and assign as a value the character, which has Unicode code, 72 (use the Windows calculator in order to find hexadecimal representation of 72).");

            char ch = 'r';
            int hex = Convert.ToInt32(ch);
            Console.WriteLine("\nchar character is :{0} and the hexemal representation is :{1}",ch,hex);
        }
        static void DeclareBoolVariable()
        {
            Console.WriteLine("\nDeclare a variable isMale of type bool and assign a value to it depending on your gender.");

            bool isMale = true;
            if(!isMale)
            {
                Console.WriteLine("you are a boy");
            }
            else
            {
                Console.WriteLine("you are a girl");
            }
        }
        static void DeclareObjectVariable()
        {
            Console.WriteLine("\nDeclare two variables of type string with values \"Hello\" and \"World\" Declare a variable of type object. Assign to this variable the value obtained of concatenation of the two string variables (add space if necessary). Print the variable of type object\n");

            string str1 = "Hello";
            string str2 = "world";
            object str3 = str1 +" "+ str2;
            Console.WriteLine(str3);
        }
        static void Usequots()
        {
            Console.WriteLine("\n Declare two variables of type string and assign them a value “The \"use\" of quotations causes difficulties.” (without the outer quotes). In one of the variables use quoted string and in the other do not use it.\n");

            string str1 = "The \"use\" of quotations causes difficulties.";
            string str2= "The use of quotations causes difficulties.";
            Console.WriteLine("{0} has became :{1} ",str2, str1);
        }
        static void PrintFigure()
        {
            Console.WriteLine("\nWrite a program to print a figure in the shape of a heart by the sign \"o\"");

            char o = 'o';
            Console.WriteLine("  " + o + o + o + "   " + o + o + o);
            Console.WriteLine(" " + o + "   " + o + " " + o + "   " + o);
            Console.WriteLine(o + "     " + o + "     " + o);
            Console.WriteLine(o + "     " + " " + "     " + o);
            Console.WriteLine(o + "     " + " " + "     " + o);
            Console.WriteLine(" " + o + "    " + "     " + o);
            Console.WriteLine("  " + o + "   " + "    " + o);
            Console.WriteLine("   " + o + "  " + "   " + o);
            Console.WriteLine("    " + o + "  " + " " + o);
            Console.WriteLine("     " + o + " " + o);
            Console.WriteLine("      " + o);
        }
        static void printIsoscel()
        {
            Console.WriteLine("\nWrite a program that prints on the console isosceles triangle which sides consist of the copyright character \"©\".");

            char ch = '\u00A9';
            Console.WriteLine("    " + ch + "    ");
            Console.WriteLine("   " + ch + "  " + ch + "   ");
            Console.WriteLine("  " + ch + "  " + "  "  + ch + "  ");
            Console.WriteLine(ch + "  " + ch + "  " + ch + "  "+ ch);
        }
        static void DeclareAppropiateVariable()
        {
            Console.WriteLine("\nA company dealing with marketing wants to keep a data record of its employees. Each record should have the following characteristic – first name, last name, age, gender (‘m’ or ‘f’) and unique employee number (27560000 to 27569999). Declare appropriate variables needed to maintain the information for an employee by using the appropriate data types and attribute names.");

            string firstName = "roxana";
            string lastName = "Miron";
            int age = 33;
            bool gender = true;
            long uniqueEmployeeNumber = 27560000;
            Console.WriteLine("\nfirstName {0} and lastName {1} is a string, age {2} is a int, gender {3} is a bool and the uniqueemployeeNumber {4} is a long",firstName,lastName,age,gender,uniqueEmployeeNumber);

        }
        static void ExchangeValue()
        {
            Console.WriteLine("\n Declare two variables of type int. Assign to them values 5 and 10 respectively. Exchange (swap) their values and print them");

            int val1 = 5;
            int val2 = 10;
            var random = new Random();
            int caseSwitch = random.Next(0, 3);
            switch(caseSwitch)
            {
                
                case 1: Console.WriteLine("Value1 = {0} and Value2 = {1}", val2,val1);
                    break;
                case 2: Console.WriteLine("Value2 = {0} and Value1 = {1}", val1,val2);
                    break;
                default:
                    Console.WriteLine("Value1 = {0} and Value2 = {1}", val1, val2);
                    break;
            }
        }

    }
}
