//Problem 5. Parse tags

//    You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//    The tags cannot be nested.

//Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ParseTags
{
    class parseTextInTags
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();     
            Console.WriteLine(Regex.Replace(text, @"<upcase>(.*?)</upcase>", word => word.Groups[1].Value.ToUpper()));
        }
    }
}
