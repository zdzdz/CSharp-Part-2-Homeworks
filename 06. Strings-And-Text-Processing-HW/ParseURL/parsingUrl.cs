//Problem 12. Parse URL

//    Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ParseURL
{
    class parsingUrl
    {
        static void Main()
        {
            Console.Write("Enter URL: ");
            string url = Console.ReadLine();

            Uri uri = new Uri(url);
            string protocol = uri.Scheme;
            string server = uri.Host;
            string resource = uri.AbsolutePath;


            Console.WriteLine(@"
[protocol] = {0}
[server] = {1}
[resource] = {2} ", protocol, server, resource);

            //Another method

            var fragments = Regex.Match(url, "(.*)://(.*?)(/.*)").Groups;

            Console.WriteLine(@"
[protocol] = {0}
[server] = {1}
[resource] = {2} ", fragments[1], fragments[2], fragments[3]);
        }
    }
}

