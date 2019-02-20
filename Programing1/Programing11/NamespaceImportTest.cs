//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Programing11
//{
//   public class NamespaceImportTest
//    {
//        static void Main()
//        {
//            List<int> ints = new List<int>();
//            List<double> doubles = new List<double>();

//            while(true)
//            {
//                int intResult;
//                double doubleResult;
//                Console.WriteLine("enter an int or a double:");
//                string input = Console.ReadLine();

//                if(int.TryParse(input,out intResult))
//                {
//                    ints.Add(intResult);
//                }
//                else if(double.TryParse(input,out doubleResult))
//                {
//                    doubles.Add(doubleResult);
//                }
//                else
//                {
//                    break;
//                }
//            }
//            Console.WriteLine("You entered {0} ints:",ints.Count);
//            foreach(var i in ints)
//            {
//                Console.WriteLine(" " + i);
//            }
//            Console.WriteLine();

//            Console.WriteLine("You entered {0} doubles: ",doubles.Count);
//            foreach(var d in doubles)
//            {
//                Console.WriteLine(" " + d);
//            }
//            Console.WriteLine();

//            Console.ReadLine();
//        }
//    }
//}
