using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing12
{
    public class FileClass
    {
        public void ReadFile(string fileName)
        {
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = reader.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read");
                Console.WriteLine(e.Message);
            }
        }
        public void ReturnTheFile(string fileName)
        {
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    List<byte> list = new List<byte>();
                    
                    String line = reader.ReadLine();
                   
                    byte[] array = Encoding.ASCII.GetBytes(line);
                    BinaryWriter newFile = new BinaryWriter(new FileStream("binaryFile", FileMode.Create));
                    newFile.Write(line);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("can not create the file");
                Console.WriteLine(e.Message);
            }

        }
    }
}
