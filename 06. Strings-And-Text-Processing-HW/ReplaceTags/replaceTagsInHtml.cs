//Problem 15. Replace tags

//    Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReplaceTags
{
    class replaceTagsInHtml
    {
        static void Main()
        {
            Console.Write("Enter HTML code: ");
            string html = Console.ReadLine();
            
            Console.WriteLine(Regex.Replace(html, @"<a href=""(.*?)"">(.*?)</a>", @"[URL=$1]$2[/URL]"));
        }
    }
}
