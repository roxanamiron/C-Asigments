using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments
{
    class Program
    {
        static void Main(string[] args)
        {
           // 1.Scrie un program care printeaza numerele de la 1 la 200, cu urmatoarele reguli:
           // -Printeaza "Good" in loc de numar, cand e multiplu de 3
           //- Printeaza "Job" in loc de numar, cand e multiplu de 5
           //- Printeaza "GoodJob" in loc de numar, cand e multiplu atat de 3 cat si de 5


            for(int i = 1; i <= 200; i++)
            { 
                if(i % 3 == 0)
                {
                    Console.WriteLine("Good");
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine("Job");
                }
                else if((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("GoodJob");
                }
            }

            Console.ReadLine();
        }
    }
}
