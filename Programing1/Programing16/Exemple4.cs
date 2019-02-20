//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Programing16
//{
//    class Exemple4
//    {
//        static void Main()
//        {
//            //1.
//            //Stack<string> stack = new Stack<string>();
//            //stack.Push("1. John");
//            //stack.Push("2. nocholas");
//            //stack.Push("3. mary");
//            //stack.Push("4. George");
//            //Console.WriteLine("Top =" +stack.Peek());
//            //while(stack.Count > 0)
//            //{
//            //    string personName = stack.Pop();
//            //    Console.WriteLine(personName);
//            //}


//            //2.
//            string expression = "1 + (3 + 2 - (2+3)*4 - ((3+1)*(4-2)))";
//            Stack<int> stack = new Stack<int>();
//            bool correctBrakets = true;

//            for(int index = 0; index < expression.Length; index++)
//            {
//                char ch = expression[index];
//                if(ch == '(')
//                {
//                    stack.Push(index);
//                }
//                else if(ch == ')')
//                {
//                   if(stack.Count == 0)
//                    {
//                        correctBrakets = false;
//                        break;
//                    }
//                    stack.Pop();
//                }                
//            }

//            if(stack.Count != 0)
//            {
//                correctBrakets = false;
//            }
//            Console.WriteLine("are the brakets correct?" + correctBrakets);

//            Console.ReadLine();
//        }

//    }
//}
