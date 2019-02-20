using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing4
{
   public class exemples
    {
       public void Exemples()
        {
            Console.WriteLine("{0:C2}", 123.46); //currency => $123.46
            Console.WriteLine("{0:D6}", -1234); //un nr intreg => -001234
            Console.WriteLine("{0:E2}", 134); //notatie exponentiala => 1.34E+002
            Console.WriteLine("{0:F2}", 12563.789); // rontujeste ultimele decimale => 12563.79
            Console.WriteLine("{0:N2}", 1245.8); // corespunde separatorului pentru mii, milioane, etc  =>1,245.8
            Console.WriteLine("{0:P}", 0.456); // reprezentarea din n% => 45.6%
            Console.WriteLine("{0:x}", 254); //printeaza nr in hexadecimal => FE


            Console.WriteLine("{0:0.00}",1); //=> 1.00
            Console.WriteLine("{0:#.###}",0.234); // daca nr incepe cu 0 nu il printeaza
            Console.WriteLine("{0:####}",123456.79);  // rotunjeste nr =>123457
            Console.WriteLine("{0:(0#) ### ## ##}",29342525);  // => (02) 934 25 25
            Console.WriteLine("{0:%##}",0.234); // => %23, multiplica rezultattul cu 100 si returneaza in procente

            DateTime t = new DateTime(2019, 01, 17, 02, 27, 45);

            Console.WriteLine("{0:dd/mm/yyyy HH:mm:ss}",t);
            Console.WriteLine("{0:d.MM.yy}",t);
            Console.WriteLine("{0:G}",DayOfWeek.Friday);  // => G/g reprezentarea string a zilei
            Console.WriteLine("{0:d}",DayOfWeek.Friday); // D/d reprezentarea numerica a zilei
            Console.WriteLine("{0:x}",DayOfWeek.Friday);  // reprezentarea hexadecimala a zilei
            Console.WriteLine("{0:d}",t); // reprezentarea numerica a var "t"

            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("caracter entered: " + key.KeyChar);
            Console.WriteLine("special keys: " + key.Modifiers);


            
        }
    }
}
