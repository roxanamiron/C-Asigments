using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Programing12
{
   public class DownloadAFileFromInternet
    {
        private string address;
        private string fileName;
        public string Address { get; set; }
        public string FileName { get; set; }
        public DownloadAFileFromInternet()
        {

        }
        public DownloadAFileFromInternet(string address, string fileName)
        {
            if(string.IsNullOrEmpty(address))
            {
                throw new ArgumentNullException("enter address");
            }
            if(string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException("error file name");
            }
        }

        public void DownloadFile()
        {
            Console.WriteLine("\nWrite a program that downloads a file from Internet by given URL, e.g. https://softuni.bg/forum.");
            try
            {
                using (WebClient myWebClient = new WebClient())
                {
                    myWebClient.DownloadFile(address, fileName);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Was not able to download file!");
                Console.WriteLine(e.Message);
            }             
        }
    }
}
