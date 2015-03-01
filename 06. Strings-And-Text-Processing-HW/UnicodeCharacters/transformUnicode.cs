//Problem 10. Unicode characters

//    Write a program that converts a string to a sequence of C# Unicode character literals.
//    Use format strings.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacters
{
    class transformUnicode
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string word = Console.ReadLine();
            Console.WriteLine("\nResult -> {0}\n", ConvertToUnicode(word));
        }
        static string ConvertToUnicode(string word)
        {
            return word.Aggregate(string.Empty, (current, t) => current + string.Format(@"\n{0:X4}", (int)t));
        }
    }
}
