//Problem 20. Palindromes

//    Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Text;

namespace Palindromes
{
    class Program
    {
        static void Main()
        {
            string sample = "Here are some palindromes: ABBA, exe, lamal. And here are some more - oohoo, SOS, lol. The following are not palindromes: cool, dot, tod, mike.";
            StringBuilder result = new StringBuilder();
            foreach (var match in Regex.Matches(sample, @"\w+"))
            {
                if (IsPalindrome(match.ToString()))
                {
                    result.AppendLine(match.ToString());
                }
            }
            if (result.Length == 0)
                result.AppendLine("No palindromes found!");
            Console.WriteLine(result);
        }
        private static bool IsPalindrome(string match)
        {
            for (int left = 0, right = match.Length - 1;
            left < match.Length / 2;
            left++, right--)
            {
                if (match[left] != match[right])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
