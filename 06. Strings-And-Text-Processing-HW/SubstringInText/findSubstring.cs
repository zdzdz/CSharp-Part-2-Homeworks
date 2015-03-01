//Problem 4. Sub-string in text

//    Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
//Example:
//The target sub-string is in
//The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//The result is: 9


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SubstringInText
{
    class findSubstring
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some text: ");
            string text = Console.ReadLine();
            Console.Write("Enter substring to search for: ");
            string substring = Console.ReadLine();
            Console.WriteLine(GetSubstringOccurenceCount(text, substring));
        }

        private static int GetSubstringOccurenceCount(string text, string substring)
        {
            return Regex.Matches(text, substring, RegexOptions.IgnoreCase).Count;
        }
    }
}
