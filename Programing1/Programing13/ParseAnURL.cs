using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing13
{
    public class ParseAnURL
    {
        private static string protocol;
        private static string server;
        private static string resource;
        private static string url;

        public void SplitUrl()
        {
            Console.WriteLine("Enter an URL");
            url = Console.ReadLine();

            protocol = url.Substring(0, url.IndexOf(':', 0));
            int firstIndex = url.IndexOf(':', 0) + 3;
            int secondIndex = url.IndexOf('/', firstIndex);
            server = url.Substring(firstIndex, secondIndex - firstIndex);
            resource = url.Substring(secondIndex);

            Console.WriteLine("[protocol]={0} \n[server]={1} \n[resource]={2}",protocol,server,resource);
        }
    }
}
